namespace mis_221_pa_5_sebrazzley
{
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers)
        {
            this.trainers = trainers;
        }

        public void GetAllTrainers()
        {
            //open
            StreamReader inFile = new StreamReader("trainers.txt");
            
            //process
            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split('#');
                trainers[Trainer.GetCount()] = new Trainer(temp[0], temp[1], temp[2], temp[3]);
                Trainer.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();

      
        }

        public void PrintAllTrainers()
        {
            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                System.Console.WriteLine(trainers[i].ToString());
            }
        }

        public void AddTrainer()
        {
            System.Console.WriteLine("Please enter name of trainer");
            Trainer myTrainer = new Trainer();

            myTrainer.SetTrainerName(System.Console.ReadLine());
            System.Console.WriteLine("Please enter trainer ID");
            myTrainer.SetTrainerID(System.Console.ReadLine());

            System.Console.WriteLine("Please enter trainer email");
            myTrainer.SetTrainerEmail(System.Console.ReadLine());

            System.Console.WriteLine("Please enter trainer mailing address");
            myTrainer.SetTrainerMail(System.Console.ReadLine());

            trainers[Trainer.GetCount()] = myTrainer;
            Trainer.IncCount();
        }

        public void Save()
        {
            StreamWriter outFile = new StreamWriter("trainers.txt");

            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                outFile.WriteLine(trainers[i].ToFile());
            }

            outFile.Close();
        }

        public void DeleteTrainer(string trainerID)
        {
            StreamWriter outFile = new StreamWriter("trainers.txt");
            
            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                if(trainers[i].GetTrainerID() != trainerID)
                {
                    outFile.WriteLine(trainers[i].ToFile());
                }
            }

            Trainer.DecCount();
            outFile.Close();
        }

        public void UpdateTrainer()
        {
            System.Console.WriteLine("What is the ID of the trainer you want to update");

            string searchVal = System.Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1)
            {
                System.Console.WriteLine("Please enter the trainer ID:");
                Trainer myTrainer = new Trainer();

                myTrainer.SetTrainerID(System.Console.ReadLine());
                
                System.Console.WriteLine("Please enter the trainer name");
                myTrainer.SetTrainerName(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the trainer email");
                myTrainer.SetTrainerEmail(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the trainer mailing address");
                myTrainer.SetTrainerMail(System.Console.ReadLine());

                trainers[foundIndex] = myTrainer;


            }
            else if(foundIndex == -1)
                System.Console.WriteLine("Error Finding");

        }


        public int Find(string searchVal)
        {
            for(int i = 0; i < Trainer.GetCount(); i++)
            {
                string id = trainers[i].GetTrainerName();
                System.Console.WriteLine("You are editing: " + id);
                
                //System.Console.WriteLine("trainer id currently is: " + trainers[i].GetTrainerID);
                if(trainers[i].GetTrainerID() == searchVal)
                    return i;
            }
            return -1;
        }



    }
}