namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Welcome to Address Book !!");

            // Dummy DATA
            var check = new SelectionBook();
            check.BookDictionary.Add("ABC", new List<string> { "Koregoan Park", "Pune", "Maharashtra", "400000", "0122456789", "abc@email.com" });
            check.BookDictionary.Add("XYZ", new List<string> { "Shivaji Nagar", "Pune", "Maharashtra", "411111", "0456789123", "xyz@email.com" });
            check.Choose();
        }
    }

}