namespace mis_221_pa_5_sebrazzley
{
    public class ListingUtility
    {
        private Listing[] listings;

        public ListingUtility(Listing[] listings)
        {
            this.listings = listings;
        }

        public void GetAllListings()
        {
            //open
            StreamReader inFile = new StreamReader("listing.txt");
            
            //process
            Listing.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split('#');
                listings[Listing.GetCount()] = new Listing(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]);
                Listing.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();

      
        }

        public void PrintAllListings()
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                System.Console.WriteLine(listings[i].ToString());
            }
        }

        public void AddListing()
        {
            System.Console.WriteLine("Please enter name of Listing ID");
            Listing myListing = new Listing();
            myListing.SetListingID(System.Console.ReadLine());

            System.Console.WriteLine("Please enter trainer name");
            myListing.SetTrainerName(System.Console.ReadLine());

            System.Console.WriteLine("Please enter Session Date");
            myListing.SetSessionDate(System.Console.ReadLine());

            System.Console.WriteLine("Please enter session time");
            myListing.SetSessionTime(System.Console.ReadLine());

            System.Console.WriteLine("Please enter session Cost");
            myListing.SetSessionCost(System.Console.ReadLine());

            myListing.SetSessionStatus("available");

            listings[Listing.GetCount()] = myListing;
            Listing.IncCount();
        }

        public void Save()
        {
            StreamWriter outFile = new StreamWriter("listing.txt");

            for(int i = 0; i < Listing.GetCount(); i++)
            {
                outFile.WriteLine(listings[i].ToFile());
            }

            outFile.Close();
        }

        public void DeleteListing(string listingID)
        {
            StreamWriter outFile = new StreamWriter("listing.txt");
            
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                if(listings[i].GetListingID() != listingID)
                {
                    outFile.WriteLine(listings[i].ToFile());
                }
            }

            Listing.DecCount();
            outFile.Close();
        }

        public void UpdateListing()
        {
            System.Console.WriteLine("What is the ID of the listing you want to update");

            string searchVal = System.Console.ReadLine();
            int foundIndex = Find(searchVal);

            if(foundIndex != -1)
            {
                System.Console.WriteLine("Please enter the Listing ID:");
                Listing myListing = new Listing();

                myListing.SetListingID(System.Console.ReadLine());
                
                System.Console.WriteLine("Please enter the trainer name");
                myListing.SetTrainerName(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the session date");
                myListing.SetSessionDate(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the session time");
                myListing.SetSessionTime(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the session cost");
                myListing.SetSessionCost(System.Console.ReadLine());

                System.Console.WriteLine("Please enter the session status");
                myListing.SetSessionStatus(System.Console.ReadLine());


                listings[foundIndex] = myListing;


            }
            else if(foundIndex == -1)
                System.Console.WriteLine("Error Finding");

        }


        public int Find(string searchVal)
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                string id = listings[i].GetTrainerName();
                System.Console.WriteLine("You are editing a listing for : " + id);
                
                if(listings[i].GetListingID() == searchVal)
                    return i;
            }
            return -1;
        }

    }
}