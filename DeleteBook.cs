namespace AddressBook
{
    public class DeleteBook : EditBook
    {
        public void Delete()
        {
            Console.Write("\nEnter the name of person to delete : "); var dictionaryKey = Console.ReadLine().ToUpper();
            BookDictionary.Remove(dictionaryKey);
        }
    }
    
}