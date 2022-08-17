namespace AddressBook
{
    public class ViewBook : DeleteBook
    {
        public void ViewNames()
        {
            Console.WriteLine("\nAddress Book Contains following members : ");

            foreach (var item in BookDictionary.Keys)
            {
                Console.WriteLine(" [+] Name : {0}", item);
            }
        }

        public void ViewDetails()
        {
            Console.Write("\n  Enter the name of member to view details : "); var dictionaryKey = Console.ReadLine().ToUpper();

            foreach (var item in BookDictionary[dictionaryKey])
            {
                Console.WriteLine(" >> {0}", item);
            }
        }
    }
    
}