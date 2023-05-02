namespace mis_221_pa_5_sebrazzley
{
    public class Trainer
    {
       private string trainerID;
       private string trainerName;

       private string trainerEmail;

       private string trainerMailingAddress; 
       
       static int count;

        public Trainer()
        {

        }
        public Trainer(string trainerName, string trainerID, string trainerEmail, string trainerMailingAddress)
        {
            this.trainerID=trainerID;
            this.trainerName = trainerName;
            this.trainerEmail = trainerEmail;
            this.trainerMailingAddress = trainerMailingAddress;
        }
        public void SetTrainerID(string trainerID)
        {
            this.trainerID = trainerID; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetTrainerID()
        {
            return trainerID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetTrainerEmail(string trainerEmail)
        {
            this.trainerEmail = trainerEmail; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetTrainerEmail()
        {
            return trainerEmail;
        }

        public void SetTrainerMail(string trainerMailingAddress)
        {
            this.trainerMailingAddress = trainerMailingAddress; //sets specific instance of the object to its correct title **known as data shadowing
        }

        public string GetTrainerMail()
        {
            return trainerMailingAddress;
        }

        static public void SetCount(int count)
        {
            Trainer.count = count; //sets specific instance of the object to its correct title **known as data shadowing
        }

        static public int GetCount()
        {
            return count;
        }

         static public void IncCount()
        {
            Trainer.count++; 
        }

        static public void DecCount()
        {
            Trainer.count--; 
        }
        
        
        public override string ToString()
        {
            return $"Trainer name:{this.trainerName}. Trainer ID: {this.trainerID}. Trainer Email: {this.trainerEmail}. Trainer Mailing Address: {this.trainerMailingAddress}";
        }

        public string ToFile()
        {
            return $"{trainerName}#{trainerID}#{trainerEmail}#{trainerMailingAddress}";
        }



    }

}