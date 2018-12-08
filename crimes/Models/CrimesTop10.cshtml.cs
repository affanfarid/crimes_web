using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class CrimesTop10Model : PageModel  
    {  
        public List<Models.Crime> CrimesList { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<Models.Crime> crimes = new List<Models.Crime>();
					
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
DECLARE @total as FLOAT
SET @total = (SELECT COUNT(*) From Crimes)
SELECT TOP 10 A.IUCR, A.PrimaryDesc + ' ' +   A.SecondaryDesc Description, A.Occurence, A.PercentageTotal, B.PercentageArrested
FROM 
(SELECT CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, COUNT(*) Occurence, Convert(Decimal(10,2),Count(*)/@total * 100.0) PercentageTotal
From dbo.Codes CO
RIGHT JOIN dbo.Crimes CR
ON CO.IUCR = CR.IUCR
GROUP BY CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc ) A
JOIN
(SELECT CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, Convert(Decimal(10,2),COUNT (*)/@total * 100.0) PercentageArrested
FROM dbo.Codes CO
RIGHT JOIN dbo.Crimes CR
ON CO.IUCR = CR.IUCR
Where Arrested = 1
Group BY CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc) B
ON B.IUCR = A.IUCR
ORDER BY A.Occurence DESC
	");

						DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

						foreach (DataRow row in ds.Tables["TABLE"].Rows)
						{
							Models.Crime c = new Models.Crime();
							c.CrimeCode = Convert.ToString(row["IUCR"]);
							c.Description = Convert.ToString(row["Description"]);
							c.Occurence = Convert.ToInt32(row["Occurence"]);
							c.PercentageTotal = Convert.ToDouble(row["PercentageTotal"]);
                            c.PercentageArrested = Convert.ToDouble(row["PercentageArrested"]);

							crimes.Add(c);
						}
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
            CrimesList = crimes;  
				  }
        }  
				
    }//class
}//namespace