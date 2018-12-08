using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class CrimeCodesModel : PageModel  
    {  
        public List<Models.CrimeCode> CrimesList { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet()  
        {  
				  List<Models.CrimeCode> crimes = new List<Models.CrimeCode>();
					
					// clear exception:
					EX = null;
					
					try
					{
						string sql = string.Format(@"
                        SELECT Codes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc, COUNT(*) Occurence
FROM Codes
LEFT JOIN Crimes 
ON Crimes.IUCR = Codes.IUCR 
GROUP BY Codes.IUCR, Codes.PrimaryDesc, Codes.SecondaryDesc
ORDER BY Codes.PrimaryDesc ASC ,  Codes.SecondaryDesc ASC
	");

						DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

						foreach (DataRow row in ds.Tables["TABLE"].Rows)
						{
							Models.CrimeCode c = new Models.CrimeCode();
							c.crimeCode = Convert.ToString(row["IUCR"]);
							c.PrimaryDescription = Convert.ToString(row["PrimaryDesc"]);
                            c.SecondaryDescription = Convert.ToString(row["SecondaryDesc"]);
							c.Occurence = Convert.ToInt32(row["Occurence"]);
							

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