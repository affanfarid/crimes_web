//
// One movie
//

namespace crimes.Models
{

  public class Crime
	{
	
		// data members with auto-generated getters and setters:
	    public string CrimeCode { get; set; }
		public string Description { get; set; }
        //public string PrimaryDescription { get; set; }
        public string SecondaryDescription { get; set; }
		public int Occurence { get; set; }
		public double PercentageTotal { get; set; }
		public double PercentageArrested { get; set; }
        public int AreaNum{get;set;}
        public string AreaName{get;set;}
        public int TotalHomicides {get;set;}
        public int Year {get;set;}
      
		// default constructor:
		public Crime()
		{ }
		
		// constructor:
		public Crime(string crimeCode, string desc, int occurence, double percentage, double percentageArrested,
                    int areaNum, string areaName, string secDesc, int totalHomicides, int year)
		{
            //PrimaryDescription = primDesc;
            SecondaryDescription = secDesc;
			CrimeCode = crimeCode;
			Description = desc;
			Occurence = occurence;
			PercentageTotal = percentage;
			PercentageArrested = percentageArrested;
            AreaNum = areaNum;
            AreaName = areaName;
            TotalHomicides = totalHomicides;
            Year = year;
           // TotalNumCrimes = totalNumCrimes;
            
            
            
            
            
            
		}
		
	}//class

}//namespace