using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataManagement
{
    public class PersonData
    {

        /// <summary>
        /// UC1-Adding Person details and display it. 
        /// </summary>
        /// <param name="list"></param>
        public static void AddPerson(List<Person> list)
        {
            Console.WriteLine("\n-----------Adding person details to list----------\n");
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

                IterateThroughList(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UC2-Retrieve Top two records which is less tahn 60
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool RetrieveTopTwoLessThan60(List<Person> list)
        {
            Console.WriteLine("\n----------Retrieve top two records in list-----------\n");
            try
            {
                AddPerson(list);
                if (list.Count > 0)
                {
                    var ageResult1 = list.FindAll(a => a.age < 60).OrderBy(b => b.age).Take(2).ToList();
                    IterateThroughList(ageResult1);
                    return true;
                }
                else if (list.Count < 0)
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
        /// <summary>
        /// UC3-Retrieve teenage records
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static bool RetrieveTeenageRecords(List<Person> list)
        {
            Console.WriteLine("\n----------Retrieve Records which is Age between 13 to 18-----------\n");
            try
            {
                AddPerson(list);

                if (list.Count > 0)
                {
                    var ageResult2 = list.FindAll(a => a.age > 13 && a.age < 18);


                    IterateThroughList(ageResult2);
                    return true;

                }
                else
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool CalculateAverageAge(List<Person> list)
        {
            Console.WriteLine("\n----------Average age in list-----------\n");
            try
            {
                AddPerson(list);
                if (list.Count > 0)
                {
                    double avgAge = list.Average(a => a.age);
                    Console.WriteLine("Average age value is : {0} ", avgAge);
                    return true;
                }
                else
                {
                    Console.WriteLine("No data present in list");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public static bool SearchingSpecificName(List<Person> list, string Name)
        {
            try
            {
                AddPerson(list);
                var person = list.Find(a => a.name.Equals(Name));
                if (person != null)
                {
                    Console.WriteLine("\n-----Found the person--------\n");
                    Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool SkipRecordLessThan60(List<Person> list)
        {
            try
            {
                AddPerson(list);
                var skipRecord = list.FindAll(a => a.age > 60);
                if (skipRecord != null)
                {
                    Console.WriteLine("\n-----Record which age is greater than 60-----");
                    IterateThroughList(skipRecord);
                    return true;
                }
                else
                {
                    Console.WriteLine("No data available ");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static void IterateThroughList(List<Person> list)
        {
            foreach (Person person in list)
            {
                Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3}  ", person.SSN, person.name, person.address, person.age);
            }
        }
    }
}