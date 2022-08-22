namespace AddressBook
{
    public class EditBook : Book
    {
        public void Modify()
        {
            Console.Write("\nEnter the name of person for which modification is required : "); var dictionaryKey = Console.ReadLine().ToUpper();

            if (!dictionaryKey.Contains(dictionaryKey))
                Console.WriteLine("User Not Found. Try Again"); Modify();

            Console.Write("\n [+] 1. Modify Address \n [+] 2. Modify City \n [+] 3. Modify State \n [+] 4. Modify Zip \n [+] 5. Modify Phone Number \n [+] 6. Modify E-Mail \n   Enter number corresponding to the parameter : "); var modifyIndex = Convert.ToByte(Console.ReadLine());

            switch (modifyIndex)
            {
                case 1:
                    {
                        Console.WriteLine("\nCurrent Address : {0}", BookDictionary[dictionaryKey][modifyIndex - 1]);
                        Console.Write("New Address : "); BookDictionary[dictionaryKey][modifyIndex - 1] = Console.ReadLine();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nCurrent City : {0}", BookDictionary[dictionaryKey][modifyIndex - 1]);
                        Console.Write("New City : "); BookDictionary[dictionaryKey][modifyIndex - 1] = Console.ReadLine();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\nCurrent State : {0}", BookDictionary[dictionaryKey][modifyIndex - 1]);
                        Console.Write("New State : "); BookDictionary[dictionaryKey][modifyIndex - 1] = Console.ReadLine();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("\nCurrent Zip : {0}", BookDictionary[dictionaryKey][modifyIndex - 1]);
                        Console.Write("New Zip : "); BookDictionary[dictionaryKey][modifyIndex - 1] = Console.ReadLine();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("\nCurrent Phone Number : {0}", BookDictionary[dictionaryKey][modifyIndex - 1]);
                        Console.Write("New Phone Number : "); BookDictionary[dictionaryKey][modifyIndex - 1] = Console.ReadLine();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("\nCurrent E-Mail : {0}", BookDictionary[dictionaryKey][modifyIndex - 1]);
                        Console.Write("New E-Mail : "); BookDictionary[dictionaryKey][modifyIndex - 1] = Console.ReadLine();
                        break;
                    }
            }
        }

    }

}