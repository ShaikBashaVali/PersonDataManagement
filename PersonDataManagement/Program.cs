namespace PersonDataManagement
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Person Data Management!!!");
            List<Person> list = new List<Person>();
            AddPerson(list);

        }
        /// <summary>
        /// UC1-Adding Person details and display it. 
        /// </summary>
        /// <param name="list"></param>
        public static void AddPerson(List<Person> list)
        {
            try
            {
                if (list.Count >= 0)
                {
                    list.Add(new Person() { SSN = 1, name = "Shaik", address = "Chennai", age = 21 });
                    list.Add(new Person() { SSN = 2, name = "Basha", address = "Bangalore", age = 27 });
                    list.Add(new Person() { SSN = 3, name = "Vali", address = "Pondicherry", age = 35 });
                    list.Add(new Person() { SSN = 4, name = "Allu", address = "Madurai", age = 37 });
                    list.Add(new Person() { SSN = 5, name = "Arjun", address = "Hyderabad", age = 41 });
                }
                else if (list.Count == 0)
                {
                    Console.WriteLine("No details are added");
                }

                foreach (Person person in list)
                {
                    Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}