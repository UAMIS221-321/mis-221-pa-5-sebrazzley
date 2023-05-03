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

        //retrieves listing ID
        public string GetListingID()
        {
            return listingID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retrieves trainer name

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetSessionDate(string sessionDate)
        {
            this.sessionDate = sessionDate; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retrieves session date
        public string GetSessionDate()
        {
            return sessionDate;
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

        //sets customer name for that instance
        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }

        //retrieves customer name
        public string GetCustomerName()
        {
            return customerName;
        }

        //sets customer email for that specific instance
        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }

        //retrieves customer email
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

        //incremement num of bookings
         static public void IncCount()
        {
            Booking.count++; 
        }

        //decrease number of bookings
        static public void DecCount()
        {
            Booking.count--; 
        }

        //prints to user in a nice format
        public override string ToString()
        {
            return $"Session ID:{this.listingID}. CustomerName: {this.customerName}. Customer Email: {this.customerEmail}. Date of Session: {this.sessionDate}. Trainer Name {this.trainerName}. SessionStatus: {this.sessionStatus} ";
        }

        //prints to file in correct # deliminated way
            public string ToFile()
        {
            return $"{listingID}#{customerName}#{customerEmail}#{sessionDate}#{trainerName}#{sessionStatus}";
        }
        
        
        


    }


}