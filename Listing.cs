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

        public string GetListingID()
        {
            return listingID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetSessionDate(string sessionDate)
        {
            this.sessionDate = sessionDate; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetSessionDate()
        {
            return sessionDate;
        }

        public void SetSessionTime(string sessionTime)
        {
            this.sessionTime = sessionTime; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetSessionTime()
        {
            return sessionTime;
        }


        public void SetSessionCost(string sessionCost)
        {
            this.sessionCost = sessionCost;
        }

        public string GetSessionCost()
        {
            return sessionCost;
        }
        public void SetSessionStatus(string sessionStatus)
        {
            this.sessionStatus = sessionStatus;
        }

        public string GetSessionStatus()
        {
            return sessionStatus;
        }


      
        static public void SetCount(int count)
        {
            Listing.count = count; //sets specific instance of the object to its correct title **known as data shadowing
        }

        static public int GetCount()
        {
            return count;
        }

         static public void IncCount()
        {
            Listing.count++; 
        }

        static public void DecCount()
        {
            Listing.count--; 
        }
        
        
        public override string ToString()
        {
            return $"Session ID:{this.listingID}. Trainer name: {this.trainerName}. Date of Session: {this.sessionDate}. Time of Session: {this.sessionTime}. Cost of session: {this.sessionCost}. SessionStatus: {this.sessionStatus} ";
        }

        public string ToFile()
        {
            return $"{listingID}#{trainerName}#{sessionDate}#{sessionTime}#{sessionCost}#{sessionStatus}";
        }



    }


}
