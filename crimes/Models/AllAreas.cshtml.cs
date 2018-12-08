using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class AllAreasModel : PageModel  
    {  
        public List<Models.ChicagoArea> CrimesList { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<Models.ChicagoArea> crimes = new List<Models.ChicagoArea>();
					
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
                       DECLARE @total as FLOAT
SET @total = (SELECT COUNT(*) From Crimes) 
SELECT Areas.Area, Areas.AreaName, COUNT(*) TotalNumCrimes, Convert(Decimal(10,2),Count(*)/@total * 100.0) PercentageTotal
FROM Areas
LEFT JOIN Crimes 
ON Areas.Area = Crimes.Area 
GROUP BY Areas.Area, Areas.AreaName
ORDER BY Areas.AreaName ASC
	");

						DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

						foreach (DataRow row in ds.Tables["TABLE"].Rows)
						{
							Models.ChicagoArea c = new Models.ChicagoArea();
							c.AreaNum = Convert.ToInt32(row["Area"]);
							c.AreaName = Convert.ToString(row["AreaName"]);
                            c.TotalNumCrimes = Convert.ToInt32(row["TotalNumCrimes"]);
							c.PercentageTotal = Convert.ToDouble(row["PercentageTotal"]);

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