using System;
using System.IO;
using mis_221_pa_5_sebrazzley;

string userInput = GetMenuChoice();

//reuns while program is not exited out of
while (userInput != "3")
{
    Route(userInput);
    userInput = GetMenuChoice();
}


//END MAIN
//Menu

//retrieves menu choice and error checks for valid menu choice selection
static string GetMenuChoice()
{
    DisplayMenu();
    string userInput = Console.ReadLine();

    while (!ValidMenuChoice(userInput))
    {
        Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();

        DisplayMenu();
        userInput = Console.ReadLine();
    }

    return userInput;
}
//retrieves menu choice for client option and error checks for valid menu choice selection
static string GetMenuChoiceClient()
{
    DisplayClientMenu();
    string userInputClient = Console.ReadLine();

    while (!ValidMenuChoiceClient(userInputClient))
    {
        Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();

        DisplayClientMenu();
        userInputClient = Console.ReadLine();
    }

    return userInputClient;
}
//retrieves menu choice for admin and error checks for valid menu choice selection
static string GetMenuChoiceAdmin()
{
    DisplayAdminMenu();
    string userInputAdmin = Console.ReadLine();

    while (!ValidMenuChoiceAdmin(userInputAdmin))
    {
        Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();

        DisplayAdminMenu();
        userInputAdmin = Console.ReadLine();
    }

    return userInputAdmin;
}
//retrieves menu choice for trainer option and error checks for valid menu choice selection
static string GetMenuChoiceTrainer()
{
    DisplayTrainerMenu();
    string userInputTrainer = Console.ReadLine();

    while (!ValidMenuChoiceTrainer(userInputTrainer))
    {
        Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();

        DisplayTrainerMenu();
        userInputTrainer = Console.ReadLine();
    }

    return userInputTrainer;
}
//retrieves menu choice for listing and error checks for valid menu choice selection
static string GetMenuChoiceListing()
{
    DisplayListingMenu();
    string userInputListing = Console.ReadLine();

    while (!ValidMenuChoiceListing(userInputListing))
    {
        Console.WriteLine("Invalid menu choice.  Please Enter a Valid Menu Choice");
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();

        DisplayListingMenu();
        userInputListing = Console.ReadLine();
    }

    return userInputListing;
}

//displays the menu
static void DisplayMenu()
{
     Console.Clear();
    System.Console.WriteLine(" ____   ___  ____    _____  ___   ____    ____  _          ______  ____    ____  ____  ____     ___  ____  ");
    System.Console.WriteLine("|    \\ /  _]|    \\  / ___/ /   \\ |    \\  /    || |        |      ||    \\  /    ||    ||    \\   /  _]|    \\ ");
    System.Console.WriteLine("|  o  )  [_ |  D  )(   \\_ |     ||  _  ||  o  || |        |      ||  D  )|  o  | |  | |  _  | /  [_ |  D  )");
    System.Console.WriteLine("|   _/    _]|    /  \\__  ||  O  ||  |  ||     || |___     |_|  |_||    / |     | |  | |  |  ||    _]|    / ");
    System.Console.WriteLine("|  | |   [_ |    \\  /  \\ ||     ||  |  ||  _  ||     |      |  |  |    \\ |  _  | |  | |  |  ||   [_ |    \\ ");
    System.Console.WriteLine("|  | |     ||  .  \\ \\    ||     ||  |  ||  |  ||     |      |  |  |  .  \\|  |  | |  | |  |  ||     ||  .  \\");
    System.Console.WriteLine("|__| |_____||__|\\_|  \\___| \\___/ |__|__||__|__||_____|      |__|  |__|\\_||__|__||____||__|__||_____||__|\\_|");
     

    System.Console.WriteLine("");
    System.Console.WriteLine("");

    DateTime dateTime = DateTime.UtcNow.Date;
    System.Console.Write("Today's Date:");
    Console.WriteLine(dateTime.ToString("d"));
    System.Console.WriteLine("");
    System.Console.WriteLine("");

     System.Console.WriteLine("      Portal Menu");
     System.Console.WriteLine("   ------------------");
     Console.WriteLine("1:   Client Portal");
     Console.WriteLine("2:   Admin Portal");
     Console.WriteLine("3:   Exit");
}
//displays the client menu
static void DisplayClientMenu()
{
     Console.Clear();
     System.Console.WriteLine("      Client Menu");
     System.Console.WriteLine("   ------------------");
     System.Console.WriteLine("1:    Show Available Sessions");
     System.Console.WriteLine("2:    Book a session");
     System.Console.WriteLine("3:    Cancel a session");
}
//displays the admin menu
static void DisplayAdminMenu()
{
     Console.Clear();
     System.Console.WriteLine("      Admin Menu");
     System.Console.WriteLine("   ------------------");
     System.Console.WriteLine("1:    Trainers");
     System.Console.WriteLine("2:    Listing");
     System.Console.WriteLine("3:    Reports");
     System.Console.WriteLine("4:    Update Status");
}
//displays the trainer menu
static void DisplayTrainerMenu()
{
     Console.Clear();
     System.Console.WriteLine("      Trainer Menu");
     System.Console.WriteLine("   ------------------");
     System.Console.WriteLine("1:    Show");
     System.Console.WriteLine("2:    Add");
     System.Console.WriteLine("3:    Edit");
     System.Console.WriteLine("4:    Delete");
}
//displays the listing menu
static void DisplayListingMenu()
{
     Console.Clear();
     System.Console.WriteLine("      Listing Menu");
     System.Console.WriteLine("   ------------------");
     System.Console.WriteLine("1:    Show");
     System.Console.WriteLine("2:    Add");
     System.Console.WriteLine("3:    Edit");
     System.Console.WriteLine("4:    Delete");
}

//Checks for valid menu choice
static bool ValidMenuChoice(string userInput)
{

    if (userInput == "1" || userInput == "2" || userInput == "3")
    {
        return true;
    }
    else
        return false;
}
//Checks for valid menu choice
static bool ValidMenuChoiceClient(string userInput)
{

    if (userInput == "1" || userInput == "2"||userInput == "3")
    {
        return true;
    }
    else
        return false;
}
//Checks for valid menu choice
static bool ValidMenuChoiceAdmin(string userInputAdmin)
{

    if (userInputAdmin == "1" || userInputAdmin == "2" || userInputAdmin == "3"||userInputAdmin == "4")
    {
        return true;
    }
    else
        return false;
}
//Checks for valid menu choice
static bool ValidMenuChoiceTrainer(string userInputTrainer)
{

    if (userInputTrainer == "1" || userInputTrainer == "2" || userInputTrainer == "3" || userInputTrainer == "4")
    {
        return true;
    }
    else
        return false;
}
//Checks for valid menu choice
static bool ValidMenuChoiceListing(string userInputListing)
{

    if (userInputListing == "1" || userInputListing == "2" || userInputListing == "3" || userInputListing == "4")
    {
        return true;
    }
    else
        return false;
}

//runs menu options

static void Route(string userInput)
{
    if (userInput == "1")
    {
          string userInputClient = GetMenuChoiceClient();
          RouteClient(userInputClient);

    }
    else if (userInput == "2")
    {
          

          System.Console.WriteLine("Please enter the secret password (password is 0000)");
          string password = System.Console.ReadLine();
          if(password == "0000")
          {
           
            string userInputAdmin = GetMenuChoiceAdmin();
             RouteAdmin(userInputAdmin);
          }
        else
        {
            System.Console.WriteLine("Sorry! Incorrect Password. You are not authorized");
            Console.WriteLine("PRESS ANY KEY TO BEGIN");
            Console.ReadKey();
        }
    }
    else if(userInput == "3")
    {

        Booking[] bookings = new Booking[100];
        Listing[] listings = new Listing[100];
        BookingUtility bookingUtility = new BookingUtility(bookings,listings);
        bookingUtility.GetAllBookings();

        Report reports = new Report(bookings);
        reports.PrintAllByEmail();

        Console.WriteLine("PRESS ANY KEY TO BEGIN");
        Console.ReadKey();
    }
}
//runs Client menu options
static void RouteClient(string userInputClient)
{
    if (userInputClient == "1")
    {
        
          System.Console.WriteLine("showing listings");

          Listing[] listings = new Listing[100];
          Booking[] bookings = new Booking[100];
          BookingUtility bookingUtility = new BookingUtility(bookings,listings);


          

          bookingUtility.GetAllListings();
          bookingUtility.PrintAllListings();


          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();

    }
    else if (userInputClient == "2")
    {
          System.Console.WriteLine("book a session");
          Listing[] listings = new Listing[100];
          Booking[] bookings = new Booking[100];
          int pos = 0;

          BookingUtility bookingUtility = new BookingUtility(bookings,listings);
          ListingUtility listingUtility = new ListingUtility(listings);
          bookingUtility.GetAllBookings();
          bookingUtility.GetAllListings();
          pos = bookingUtility.BookSession();
          bookingUtility.Save();
          listingUtility.UpdateAvailable(pos);
          listingUtility.Save();

          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
    }
    else if (userInputClient == "3")
    {
          //System.Console.WriteLine("cancel a session");
         
        System.Console.WriteLine("Cancelling");
        Listing[] listings = new Listing[100];
        Booking[] bookings = new Booking[100];

        BookingUtility bookingUtility = new BookingUtility(bookings,listings);
        bookingUtility.GetAllBookings();
        bookingUtility.CancelBooking();
        bookingUtility.Save();

          
          

          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
    }
}
//runs Admin menu options
static void RouteAdmin(string userInputAdmin)
{
    if (userInputAdmin == "1")
    {
        
          string userInputTrainer = GetMenuChoiceTrainer();
          RouteTrainer(userInputTrainer);


    }
    else if (userInputAdmin == "2")
    {
          string userInputListing = GetMenuChoiceListing();
          RouteListing(userInputListing);
          
    }

    else if(userInputAdmin=="3")
    {
        Booking[] bookings = new Booking[100];
        Listing[] listings = new Listing[100];
        BookingUtility bookingUtility = new BookingUtility(bookings,listings);
        bookingUtility.GetAllBookings();

        Report reports = new Report(bookings);
        reports.PrintAllByEmail();

        Console.WriteLine("PRESS ANY KEY TO BEGIN");
        Console.ReadKey();
    }
    else if(userInputAdmin=="4")
    {
        Booking[] bookings = new Booking[100];
        Listing[] listings = new Listing[100];
        BookingUtility bookingUtility = new BookingUtility(bookings,listings);
        bookingUtility.GetAllBookings();
        bookingUtility.UpdateBooking();
        bookingUtility.Save();

        Console.WriteLine("PRESS ANY KEY TO BEGIN");
        Console.ReadKey();
    }
    
}
//runs trainer menu options
static void RouteTrainer(string userInputTrainer)
{
     if (userInputTrainer == "1")
     {
        
          Trainer[] trainers = new Trainer[100];
          TrainerUtility trainerUtility = new TrainerUtility(trainers);

          trainerUtility.GetAllTrainers();
          trainerUtility.PrintAllTrainers();

          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();

     }
     else if (userInputTrainer == "2")
     {
          System.Console.WriteLine("add a trainer");
          
          Trainer[] trainers = new Trainer[100];
          TrainerUtility trainerUtility = new TrainerUtility(trainers);

          trainerUtility.GetAllTrainers();
          trainerUtility.AddTrainer();
          trainerUtility.Save();
          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
     }
     else if (userInputTrainer == "3")
     {     
          System.Console.WriteLine("edit a trainer");
          
          Trainer[] trainers = new Trainer[100];
          TrainerUtility trainerUtility = new TrainerUtility(trainers);

          trainerUtility.GetAllTrainers();
          trainerUtility.UpdateTrainer();
          trainerUtility.Save();
          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
     }
     else
     {
          Trainer[] trainers = new Trainer[100];
          TrainerUtility trainerUtility = new TrainerUtility(trainers);
          trainerUtility.GetAllTrainers();

          System.Console.WriteLine("Please enter the ID of the trainer you would like to delete");
          string trainerIDDelete = System.Console.ReadLine();
          trainerUtility.DeleteTrainer(trainerIDDelete);
          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
     }
}
//runs listings menu options
static void RouteListing(string userInputListing)
{
     if (userInputListing == "1")
     {
        

          Listing[] listings = new Listing[100];
          ListingUtility listingUtility = new ListingUtility(listings);

          listingUtility.GetAllListings();
          listingUtility.PrintAllListings();

          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();

     }
     else if (userInputListing == "2")
     {

          
           Listing[] listings = new Listing[100];
          ListingUtility listingUtility = new ListingUtility(listings);

          listingUtility.GetAllListings();
          listingUtility.AddListing();
          listingUtility.Save();

          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
     }
     else if (userInputListing == "3")
     {     

          
          Listing[] listings = new Listing[100];
          ListingUtility listingUtility = new ListingUtility(listings);

          listingUtility.GetAllListings();
          listingUtility.UpdateListing();
          listingUtility.Save();

          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
     }
     else
     {
          Listing[] listings = new Listing[100];
          ListingUtility listingUtility = new ListingUtility(listings);

          listingUtility.GetAllListings();

          System.Console.WriteLine("Please enter the ID of the trainer you would like to delete");
          string listingIDDelete = System.Console.ReadLine();
          listingUtility.DeleteListing(listingIDDelete);
          Console.WriteLine("PRESS ANY KEY TO BEGIN");
          Console.ReadKey();
     }
}