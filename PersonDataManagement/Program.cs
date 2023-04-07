namespace PersonDataManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            PersonData person = new PersonData();
            Console.WriteLine("Welcome to Person Data Management!!!");
            List<Person> list = new List<Person>();
            Console.WriteLine("Enter 1. Adding to person details to list");
            Console.WriteLine("Enter 2. Retrieve top two records which age is less than 60");
            Console.WriteLine("Enter 3 Retrieve Records which is Age between 13 to 18");
            Console.WriteLine("Enter 4. Calculating average age");
            Console.WriteLine("Enter 5.Search Specific name in list");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PersonData.AddPerson(list);
                    break;
                case 2:
                    PersonData.AddPerson(list);
                    PersonData.RetrieveTopTwoLessThan60(list);
                    break;
                case 3:
                    PersonData.AddPerson(list);
                    PersonData.RetrieveTeenageRecords(list);
                    break;
                case 4:
                    PersonData.AddPerson(list);
                    PersonData.CalculateAverageAge(list);
                    break;
                case 5:
                    PersonData.SearchingSpecificName(list, "Arun");
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }
    }
}