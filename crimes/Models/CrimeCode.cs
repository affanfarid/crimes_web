//
// One movie
//

namespace crimes.Models
{

  public class CrimeCode
	{
	
		// data members with auto-generated getters and setters:
	    public string crimeCode { get; set; }
        public string PrimaryDescription { get; set; }
        public string SecondaryDescription { get; set; }
		public int Occurence { get; set; }

		// default constructor:
		public CrimeCode()
		{ }
		
		// constructor:
		public CrimeCode(string crimecode, string primDesc, string secDesc, int occurence)
		{
            PrimaryDescription = primDesc;
            SecondaryDescription = secDesc;
			crimeCode = crimecode;
			Occurence = occurence;
	
            
            
            
            
            
            
		}
		
	}//class

}//namespace