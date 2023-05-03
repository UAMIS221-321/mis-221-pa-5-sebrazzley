namespace mis_221_pa_5_sebrazzley
{
    public class Report
    {
        private Booking[] bookings;

        public Report(Booking[] bookings)
        {
            this.bookings = bookings;
        }

    
        //prints a report that shows all bookings for a customer using their emial
        public void PrintAllByEmail()
        {
            int checking = 0;
            System.Console.WriteLine("Please enter enail");
            string userInput = System.Console.ReadLine();
            for(int i = 0; i < Booking.GetCount(); i++)
            {
                if(bookings[i].GetCustomerEmail().ToLower() == userInput)
                    System.Console.WriteLine(bookings[i].ToString());
                else
                    checking++;

            }

            if(checking == Booking.GetCount())
                System.Console.WriteLine("Couldn't Find this Email!");

        }

    }
}