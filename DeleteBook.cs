namespace AddressBook
{
    public class DeleteBook : EditBook
    {
        public void Delete()
        {
            Console.Write("\nEnter the name of person to delete : "); var dictionaryKey = Console.ReadLine().ToUpper();
            if (dictionaryKey.Contains(dictionaryKey))
                BookDictionary.Remove(dictionaryKey);
            else
                Console.WriteLine("User Not Found. Try Again"); Delete();
        }
    }
    
}