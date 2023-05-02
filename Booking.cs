namespace mis_221_pa_5_sebrazzley
{
    public class Booking
    {
       private string listingID;
       private string trainerName;
       private string sessionDate;
       private string customerName;
       private string customerEmail;

       private string sessionStatus; 
       
       private string trainerID;
       static int count;

       public Booking()
       {

       }

        public Booking(string listingID, string customerName, string customerEmail, string sessionDate, string trainerName, string sessionStatus)
        {
            this.listingID = listingID;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
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

        public void SetSessionStatus(string sessionStatus)
        {
            this.sessionStatus = sessionStatus;
        }

        public string GetSessionStatus()
        {
            return sessionStatus;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail()
        {
            return customerEmail;
        }

        static public void SetCount(int count)
        {
            Booking.count = count; //sets specific instance of the object to its correct title **known as data shadowing
        }

        static public int GetCount()
        {
            return count;
        }

         static public void IncCount()
        {
            Booking.count++; 
        }

        static public void DecCount()
        {
            Booking.count--; 
        }

            public string ToFile()
        {
            return $"{listingID}#{customerName}#{customerEmail}#{sessionDate}#{trainerName}#{sessionStatus}";
        }
        
        
        


    }


}