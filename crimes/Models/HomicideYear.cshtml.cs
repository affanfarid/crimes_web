using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class HomicideYearModel : PageModel  
    {  
				public List<Models.Crime> CrimesList { get; set; }
				public string Input { get; set; }
				//public int NumCrimes { get; set; }
				public Exception EX { get; set; }
  
        public void OnGet(string input)  
        {  
				  List<Models.Crime> crimes = new List<Models.Crime>();
					
					// make input available to web page:
					Input = input;
					
					// clear exception:
					EX = null;
					
					try
					{
						//
						// Do we have an input argument?  If so, we do a lookup:
						//
						if (input == null)
						{
							//
							// there's no page argument, perhaps user surfed to the page directly?  
							// In this case, nothing to do.
							//
						}
						else  
						{
							// 
							// Lookup movie(s) based on input, which could be id or a partial name:
							// 
							
							int year ;
							string sql = " ";

							if (System.Int32.TryParse(input, out year))
							{
								// lookup movie by movie id:
								sql = string.Format(@"
                                SELECT Year, AreaName, SecondaryDesc, Count(PrimaryDesc) as TotalHomicides
From Crimes
Left Join Areas
ON Crimes.Area = Areas.Area
Left Join Codes 
ON Crimes.IUCR = Codes.IUCR
Where PrimaryDesc ='Homicide' and Year = {0} 
Group by Year, AreaName, SecondaryDesc
Order BY TotalHomicides DESC, SecondaryDesc ASC

	", year);
							}
							

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables["TABLE"].Rows)
							{
								Models.Crime c = new Models.Crime();
                            c.Year = Convert.ToInt32(row["Year"]);
							c.AreaName = Convert.ToString(row["AreaName"]); 
							c.SecondaryDescription = Convert.ToString(row["SecondaryDesc"]);
							c.TotalHomicides = Convert.ToInt32(row["TotalHomicides"]);
							

					

								// avg rating could be null if there are no reviews:
							//	if (row["AvgRating"] == System.DBNull.Value)
							//		m.AvgRating = 0.0;
							//	else
							//		m.AvgRating = Convert.ToDouble(row["AvgRating"]);

								crimes.Add(c);
							}
						}//else
					}
					catch(Exception ex)
					{
					  EX = ex;
					}
					finally
					{
					  CrimesList = crimes;
					  //NumMovies = movies.Count;
				  }
				}
			
    }//class  
}//namespace