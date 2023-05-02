namespace mis_221_pa_5_sebrazzley
{
    public class Booking
    {
        private string ID;

        private string trainerName;

        private string sessionDate;
        private string sessionTime;
        private string sessionCost;
        static int count;

        public Booking(string ID,string trainerName, string sessionDate, string sessionTime, string sessionCost)
        {
            this.ID=ID;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
    
        }
         public void SetID(string ID)
        {
            this.ID = ID; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetID()
        {
            return ID;
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
        static public void SetCount(int count)
        {
            Booking.count = count; //sets specific instance of the object to its correct title **known as data shadowing
        }


         public void SetSessionTime(string sessionTime)
        {
            this.sessionTime = sessionTime; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetSessionTime()
        {
            return sessionTime;
        }
        static public int GetCount()
        {
            return count;
        }

        public void SetSessionCost(string sessionCost)
        {
            this.sessionCost = sessionCost; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetSessionCost()
        {
            return sessionCost;
        }
         static public void IncCount()
        {
            Booking.count++; 
        }

        static public void DecCount()
        {
            Booking.count--; 
        }
        
        public override string ToString()
        {
            return $"Booking ID:{this.ID}. Trainer Name: {this.trainerName}. Session Date: {this.sessionDate}.  Session Time: {this.sessionTime}.  Session Cost: {this.sessionCost} ";
        }

    }
}