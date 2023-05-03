namespace mis_221_pa_5_sebrazzley
{
    public class Listing
    {
        private string listingID;
       private string trainerName;

       private string sessionDate;

       private string sessionTime;

       private string sessionCost;

       private string sessionStatus; 
       
       static int count;

        public Listing()
        {

        }
        public Listing(string listingID, string trainerName, string sessionDate, string sessionTime, string sessionCost, string sessionStatus)
        {
            this.listingID=listingID;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.sessionStatus = sessionStatus;
        }
        public void SetListingID(string listingID)
        {
            this.listingID = listingID; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retreives listing id
        public string GetListingID()
        {
            return listingID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retreives trainer name
        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetSessionDate(string sessionDate)
        {
            this.sessionDate = sessionDate; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retreives session date
        public string GetSessionDate()
        {
            return sessionDate;
        }


        public void SetSessionTime(string sessionTime)
        {
            this.sessionTime = sessionTime; //sets specific instance of the object to its correct title **known as data shadowing
        }


        //retreives session time
        public string GetSessionTime()
        {
            return sessionTime;
        }


        //sets session costs for that specfic instance
        public void SetSessionCost(string sessionCost)
        {
            this.sessionCost = sessionCost;
        }

        //retreives session cost
        public string GetSessionCost()
        {
            return sessionCost;
        }

        //sets session status for that specific instance
        public void SetSessionStatus(string sessionStatus)
        {
            this.sessionStatus = sessionStatus;
        }

        //retrieves session status
        public string GetSessionStatus()
        {
            return sessionStatus;
        }


      
        static public void SetCount(int count)
        {
            Listing.count = count; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retrieves total number of sessions
        static public int GetCount()
        {
            return count;
        }

        //increase number of sessions
         static public void IncCount()
        {
            Listing.count++; 
        }


        //decreases number of sessions
        static public void DecCount()
        {
            Listing.count--; 
        }
        
        //prints sessions to user in nice format
        public override string ToString()
        {
            return $"Session ID:{this.listingID}. Trainer name: {this.trainerName}. Date of Session: {this.sessionDate}. Time of Session: {this.sessionTime}. Cost of session: {this.sessionCost}. SessionStatus: {this.sessionStatus} ";
        }

        //prints sessions to file with proper # delimination
        public string ToFile()
        {
            return $"{listingID}#{trainerName}#{sessionDate}#{sessionTime}#{sessionCost}#{sessionStatus}";
        }



    }


}
