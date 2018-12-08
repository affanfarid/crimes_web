//
// One movie
//

namespace crimes.Models
{

  public class ChicagoArea
	{
	
		// data members with auto-generated getters and setters:
	    
		public double PercentageTotal { get; set; }
        public int AreaNum { get; set; }
        public string AreaName { get; set; }
        public int TotalNumCrimes { get; set; }
		// default constructor:
		public ChicagoArea()
		{ }
		
		// constructor:
		public ChicagoArea( double percentage, int areaNum, string areaName, int totalNumCrimes)
		{
            
			
			PercentageTotal = percentage;
            AreaNum = areaNum;
            AreaName = areaName;
            TotalNumCrimes = totalNumCrimes;
            
            
            
            
            
            
		}
		
	}//class

}//namespace