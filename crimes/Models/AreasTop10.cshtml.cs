using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using Microsoft.AspNetCore.Mvc;  
using Microsoft.AspNetCore.Mvc.RazorPages;  
using System.Data;
  
namespace crimes.Pages  
{  
    public class AreasTop10Model : PageModel  
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
							int areaNum;
							string sql;

							if (System.Int32.TryParse(input, out areaNum))
							{
								// lookup movie by movie id:
								sql = string.Format(@"
DECLARE @total as FLOAT
SET @total = (SELECT COUNT(*) From Crimes Where Area = {0} )
SELECT TOP 10 A.IUCR, A.Area, A.AreaName, A.PrimaryDesc + ' ' +   A.SecondaryDesc Description, A.Occurence, A.PercentageTotal, B.PercentageArrested
FROM 
(SELECT CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, COUNT(*) Occurence, Convert(Decimal(10,2),Count(*)/@total * 100.0) PercentageTotal,AR.Area, AR.AreaName
From dbo.Codes CO
RIGHT JOIN dbo.Crimes CR
ON CO.IUCR = CR.IUCR
RIGHT JOIN dbo.Areas AR
ON AR.Area = Cr.Area
WHERE AR.Area = {0}
GROUP BY CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, AR.AreaName, AR.Area) A
JOIN
(SELECT CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, Convert(Decimal(10,2),COUNT (*)/@total * 100.0) PercentageArrested, AR.AreaName, AR.Area
FROM dbo.Codes CO
RIGHT JOIN dbo.Crimes CR
ON CO.IUCR = CR.IUCR
RIGHT JOIN dbo.Areas AR
ON AR.Area = CR.Area
WHERE AR.Area = {0}
AND Arrested = 1
Group BY CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, AR.AreaName, AR.Area) B
ON B.IUCR = A.IUCR
ORDER BY A.Occurence DESC
	", areaNum);
							}
							else
							{
								// lookup movie(s) by partial name match:
								input = input.Replace("'", "''");

								sql = string.Format(@"
	DECLARE @total as FLOAT
SET @total = (SELECT COUNT(*) From Crimes LEFT JOIN Areas ON Crimes.Area = Areas.Area Where AreaName = '{0}')
SELECT TOP 10 A.IUCR, A.Area, A.AreaName, A.PrimaryDesc + ' ' +   A.SecondaryDesc Description, A.Occurence, A.PercentageTotal, B.PercentageArrested
FROM 
(SELECT CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, COUNT(*) Occurence, Convert(Decimal(10,2),Count(*)/@total * 100.0) PercentageTotal, AR.Area,AR.AreaName
From dbo.Codes CO
RIGHT JOIN dbo.Crimes CR
ON CO.IUCR = CR.IUCR
RIGHT JOIN dbo.Areas AR
ON AR.Area = Cr.Area
WHERE AR.AreaName = '{0}'
GROUP BY CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, AR.AreaName, AR.Area) A
JOIN
(SELECT CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, Convert(Decimal(10,2),COUNT (*)/@total * 100.0) PercentageArrested, AR.Area,AR.AreaName
FROM dbo.Codes CO
RIGHT JOIN dbo.Crimes CR
ON CO.IUCR = CR.IUCR
RIGHT JOIN dbo.Areas AR
ON AR.Area = CR.Area
WHERE AR.AreaName = '{0}'
AND Arrested = 1
Group BY CO.IUCR, CO.PrimaryDesc, CO.SecondaryDesc, AR.AreaName, AR.Area) B
ON B.IUCR = A.IUCR
ORDER BY A.Occurence DESC
	", input);
							}

							DataSet ds = DataAccessTier.DB.ExecuteNonScalarQuery(sql);

							foreach (DataRow row in ds.Tables["TABLE"].Rows)
							{
								Models.Crime c = new Models.Crime();
                            c.AreaNum = Convert.ToInt32(row["Area"]);
							c.AreaName = Convert.ToString(row["AreaName"]);   
							c.CrimeCode = Convert.ToString(row["IUCR"]);
							c.Description = Convert.ToString(row["Description"]);
							c.Occurence = Convert.ToInt32(row["Occurence"]);
							c.PercentageTotal = Convert.ToDouble(row["PercentageTotal"]);
                            c.PercentageArrested = Convert.ToDouble(row["PercentageArrested"]);

					

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