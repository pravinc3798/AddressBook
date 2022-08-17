namespace AddressBook
{
    public class Book
    {
        public Dictionary<string, List<string>> BookDictionary = new Dictionary<string, List<string>>();

        public void Add()
        {
            Console.Write("\n [+] Enter Full Name : "); var name = Console.ReadLine();
            Console.Write(" [+] Enter Address : "); var address = Console.ReadLine();
            Console.Write(" [+] Enter City : "); var city = Console.ReadLine();
            Console.Write(" [+] Enter State : "); var state = Console.ReadLine();
            Console.Write(" [+] Enter Zip : "); var zip = Console.ReadLine();
            Console.Write(" [+] Enter Phone Number : "); var phoneNumber = Console.ReadLine();
            Console.Write(" [+] Enter Email : "); var email = Console.ReadLine();

            var detailList = new List<string> { address, city, state, zip, phoneNumber, email };

            BookDictionary.Add(name.ToUpper(), detailList);
        }
    }
    
}