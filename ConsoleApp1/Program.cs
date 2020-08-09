using System;

namespace ConsoleApp1
{
    class Program
    {
        //public readonly override string ToString() =>
        //$"({X}, {Y}) is {Distance} from the origin";

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //var person = new Person("He", "World");
            //var length = GetApplicationLength(person);
            //Console.WriteLine(length);
            //Console.WriteLine(person.Name.ToString());


            ILogger log = new Logger();
            log.Log("测试");

            try
            {
                throw new Exception(message: "invalid value");
            }
            catch (Exception ex)
            {
                log.Log(ex);
            }


            Console.ReadKey();
        }



        static int GetApplicationLength(Person? person)
        {
            //return person?.Application is { Length: var length } ? length : 0;

            //var application = person?.Application;
            //return (application!).Length;

            return person?.Application?.Length ?? 0;

            //if (person != null && !string.IsNullOrEmpty(person.Application))
            //{
            //    return person.Application.Length;
            //}
            //return 0;

            //return person?.Application == null ? 0 : person.Application.Length;
        }
    }

}
