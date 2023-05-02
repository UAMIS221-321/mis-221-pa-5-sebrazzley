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
                bookings[Booking.GetCount()] = new Booking(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
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

        public void BookSession()
        {
            Booking mybooking = new Booking();

            System.Console.WriteLine("Enter the session ID you would like to book for");
            string userInput = System.Console.ReadLine();
            mybooking.SetListingID(userInput);

            System.Console.WriteLine("Please enter your name");
            mybooking.SetCustomerName(System.Console.ReadLine());

            System.Console.WriteLine("Please enter your email address");
            mybooking.SetCustomerEmail(System.Console.ReadLine());

            bookings[Booking.GetCount()] = mybooking;
            Booking.IncCount();

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

     

    }
}