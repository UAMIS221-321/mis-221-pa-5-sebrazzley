namespace mis_221_pa_5_sebrazzley
{
    public class Report
    {
        private Booking[] bookings;

        private Listing[] listings;

        public Report(Booking[] bookings, Listing[] listings)
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

        public void PrintAllListings()
        {
            for(int i = 0; i < Listing.GetCount(); i++)
            {
                System.Console.WriteLine(listings[i].ToString());
            }
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

        public void PrintAllCustomerEmail()
        {
            System.Console.WriteLine("Please give email");
            string userInput=System.Console.ReadLine();
            for(int i = 0; i < Booking.GetCount(); i++)
            {
                if(bookings[i].GetCustomerEmail() == userInput)
                    System.Console.WriteLine(bookings[i].ToString());
            }
        }

    }
}