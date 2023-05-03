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



        //retrieves trainer id
        public string GetTrainerID()
        {
            return trainerID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retrievs trainer name
        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetTrainerEmail(string trainerEmail)
        {
            this.trainerEmail = trainerEmail; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retrieves trainer email
        public string GetTrainerEmail()
        {
            return trainerEmail;
        }

        public void SetTrainerMail(string trainerMailingAddress)
        {
            this.trainerMailingAddress = trainerMailingAddress; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retreieves trainer mailing address
        public string GetTrainerMail()
        {
            return trainerMailingAddress;
        }

        static public void SetCount(int count)
        {
            Trainer.count = count; //sets specific instance of the object to its correct title **known as data shadowing
        }

        //retrieves total number of trainers
        static public int GetCount()
        {
            return count;
        }

        //increase total number of trainer
         static public void IncCount()
        {
            Trainer.count++; 
        }

        //decreases total number of trainers
        static public void DecCount()
        {
            Trainer.count--; 
        }
        
        //makes text print out in nice format
        
        public override string ToString()
        {
            return $"Trainer name:{this.trainerName}. Trainer ID: {this.trainerID}. Trainer Email: {this.trainerEmail}. Trainer Mailing Address: {this.trainerMailingAddress}";
        }

        //prints trainers to file with proper # delimination
        public string ToFile()
        {
            return $"{trainerName}#{trainerID}#{trainerEmail}#{trainerMailingAddress}";
        }



    }

}