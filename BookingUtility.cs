namespace mis_221_pa_5_sebrazzley
{
    public class BookingUtility
    {
        private Booking[] bookings;

        private Listing[] listings;

        public BookingUtility(Booking[] bookings, Listing[] listings)
        {
            this.bookings = bookings;
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
        public void GetAllBookings()
        {
            //open
            StreamReader inFile = new StreamReader("transactions.txt");
            
            //process
            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split('#');
                bookings[Booking.GetCount()] = new Booking(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5]);
                Booking.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();

      
        }

        public void PrintAllBookings()
        {
            for(int i = 0; i < Booking.GetCount(); i++)
            {
                System.Console.WriteLine(bookings[i].ToString());
            }
        }

        public void PrintAllListings()
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                if(listings[i].GetSessionStatus() == "available")
                    System.Console.WriteLine(listings[i].ToString());
            }
        }

    

        public int BookSession()
        {
            Booking mybooking = new Booking();
            Listing myListing = new Listing();
            Trainer myTrainers = new Trainer();

            System.Console.WriteLine("Enter the session ID you would like to book for");
            
            string searchVal = System.Console.ReadLine();
            int foundIndex = Find(searchVal);
           

            
           if(foundIndex != -1)
            {
                string searchValName = (listings[foundIndex].GetTrainerName());

                System.Console.WriteLine("Please enter your name");
                mybooking.SetCustomerName(System.Console.ReadLine());

                System.Console.WriteLine("Please enter your email address");
                mybooking.SetCustomerEmail(System.Console.ReadLine());
                
                mybooking.SetListingID((listings[foundIndex].GetListingID()));
                mybooking.SetSessionDate((listings[foundIndex].GetSessionDate()));
                mybooking.SetSessionStatus("Booked");
                //mybooking.SetTrainerID((trainers[foundTrainerIndex].GetTrainerID()));
                

                bookings[Booking.GetCount()] = mybooking;


            

            bookings[Booking.GetCount()] = mybooking;
            Booking.IncCount();




            


            }
            else if(foundIndex == -1)
                System.Console.WriteLine("Error Finding");

        
        return foundIndex;

        }


        public void CancelBooking()
        {
            System.Console.WriteLine("What is the ID of the listing you want to cancel");

            string searchVal = System.Console.ReadLine();
            int foundIndex = FindBooking(searchVal);

            if(foundIndex != -1)
            {

                Booking mybooking = new Booking();

                mybooking.SetListingID(searchVal);
                mybooking.SetCustomerName(bookings[foundIndex].GetCustomerName());
                mybooking.SetCustomerEmail(bookings[foundIndex].GetCustomerEmail());
                mybooking.SetSessionDate(bookings[foundIndex].GetSessionDate());
                mybooking.SetTrainerName(bookings[foundIndex].GetTrainerName());
                mybooking.SetSessionStatus("Cancelled");
                
                bookings[foundIndex] = mybooking;


            }
            else if(foundIndex == -1)
                System.Console.WriteLine("Error Finding");

        }


        public void UpdateBooking()
        {
            System.Console.WriteLine("What is the ID of the listing you want to cancel");

            string searchVal = System.Console.ReadLine();
            int foundIndex = FindBooking(searchVal);

            if(foundIndex != -1)
            {

                Booking mybooking = new Booking();

                mybooking.SetListingID(searchVal);
                mybooking.SetCustomerName(bookings[foundIndex].GetCustomerName());
                mybooking.SetCustomerEmail(bookings[foundIndex].GetCustomerEmail());
                mybooking.SetSessionDate(bookings[foundIndex].GetSessionDate());
                mybooking.SetTrainerName(bookings[foundIndex].GetTrainerName());
                
                System.Console.WriteLine("Was this booking cancelled or completed?");
                string userInput = System.Console.ReadLine();
                
                if(userInput.ToLower() == "cancelled")
                    mybooking.SetSessionStatus("Cancelled");
                else if(userInput.ToLower() == "completed");
                    mybooking.SetSessionStatus("Completed");
                
                bookings[foundIndex] = mybooking;


            }
            else if(foundIndex == -1)
                System.Console.WriteLine("Error Finding");

        }

        public void Save()
        {
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < Booking.GetCount(); i++)
            {
                outFile.WriteLine(bookings[i].ToFile());
            }

            outFile.Close();
        }

        public int Find(string searchVal)
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                string id = listings[i].GetTrainerName();
                ;
                
                if(listings[i].GetListingID() == searchVal)
                {
                    System.Console.WriteLine("You are booking a session for : " + id);
                    return i;
                }
            }
            return -1;
        }
        public int FindBooking(string searchVal)
        {
            for(int i = 0; i < Booking.GetCount(); i++)
            {
                
                if(bookings[i].GetListingID() == searchVal)
                {
                    return i;
                }
            }
            return -1;
        }

       

     

    }
}