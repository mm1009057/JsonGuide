using json;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Person> people = [];
            Person person = new Person
            {
                Name = "John Doe",
                Age = 30,
                Email = "JoneDoe@orc.edu",
                IsStudent = true
            };
            people.Add(person);

            string json = JsonConvert.SerializeObject(person);
            string jsonList = JsonConvert.SerializeObject(people); //serialized list
            Console.WriteLine("Serialized JSON: " + json);

            //Deserialize 
            Person deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
            Console.WriteLine($"Deserialized Person: Name - {deserializedPerson.Name} Age - {deserializedPerson.Age} Email - {deserializedPerson.Email} Is a student - {deserializedPerson.IsStudent}");

            //Deserialize List
            var deserializedPersonList = JsonConvert.DeserializeObject<List<Person>>(jsonList);
            Console.WriteLine($"Deserialized Json List : {String.Join("", deserializedPersonList)}");
        }
        catch (JsonReaderException e)
        {
            Console.WriteLine($"Invalid Json Error: {e}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Json file not found");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error occured: {e}");
        }
    }
}