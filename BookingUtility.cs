namespace mis_221_pa_5_sebrazzley
{
    public class BookingUtility
    {
        private Booking[] bookings;

        public BookingUtility(Booking[] bookings)
        {
            this.bookings = bookings;
        }

        public void GetAllBookings()
        {
            //open
            StreamReader inFile = new StreamReader("listing.txt");
            
            //process
            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split('#');
                bookings[Booking.GetCount()] = new Booking(temp[0], temp[1], temp[2], temp[3], temp[4]);
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
    }
}