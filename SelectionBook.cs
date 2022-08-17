namespace AddressBook
{
    public class SelectionBook : ViewBook
    {
        public void Choose()
        {
            Console.Write("\n 1. Add New Member \n 2. View Names in the Book \n 3. View Details \n 4. Modify Details \n 5. Delete a Member \n 6. EXIT \nEnter number corresponding to desired action :  "); var input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    {
                        Add();
                        Console.Write("\nPress Enter To Continue .. "); Console.ReadLine();
                        Choose();
                        break;
                    }
                case "2":
                    {
                        ViewNames();
                        Console.Write("\nPress Enter To Continue .. "); Console.ReadLine();
                        Choose();
                        break;
                    }
                case "3":
                    {
                        ViewNames();
                        ViewDetails();
                        Console.Write("\nPress Enter To Continue .. "); Console.ReadLine();
                        Choose();
                        break;
                    }
                case "4":
                    {
                        ViewNames();
                        Modify();
                        Console.Write("\nPress Enter To Continue .. "); Console.ReadLine();
                        Choose();
                        break;
                    }
                case "5":
                    {
                        ViewNames();
                        Delete();
                        Console.Write("\nPress Enter To Continue .. "); Console.ReadLine();
                        Choose();
                        break;
                    }
                case "6":
                    {
                        break;
                    }
                default: Console.WriteLine("Try Again"); Console.Write("\nPress Enter To Continue .. "); Console.ReadLine(); Choose(); break;
                    
            }
        }
    }

}