using Animals;
using Employer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using extensionMethods;
using System.Reflection;
using static IteratorTraining.Iterators;
using System.Xml;
using System.Data;

namespace Training
{
    class Program
    {
        public static event EventHandler<Person> Process;
        public static (int row, int column) position() => (1,3);
        static void Main(string[] args)
        {
            //Menager menager = new Menager();
            //menager.name = "Dawid";

            //Process += Program_Process;
            //List<Person> people = GetPeople();
            //people = people.OrderByDescending(x => x._name).ThenBy(x => x._lastName).ToList<Person>();
            //foreach (var q in people)
            //{
            //    OnProcess(q);
            //}
            ////people.ForEach(x => Process?.Invoke(x, x));
            //Parallel.ForEach(people, x => Process?.Invoke(x, x));

            //var bob = (Name: "Bob", Age: 23);
            //Console.WriteLine(bob.Age);
            //(int row, int column) = position();
            //Console.WriteLine(row);

            //DateTime birth = new DateTime(2001, 4, 22);
            //DateTime birth2 = new DateTime(2011, 10, 21);
            //DateTime birth3 = new DateTime(2005, 8, 20);

            //Elephant elephant = new Elephant(birth);
            //Elephant elephant2 = new Elephant(birth2);
            //Elephant elephant3 = new Elephant(birth3);

            //Elephant.ElephantPresentation(elephant);
            //Elephant.ElephantPresentation(elephant2);
            //Elephant.ElephantPresentation(elephant3);

            //Elephant.ElephantsPopulationPresentation();


            //Console.WriteLine(1 << 5);
            //metodax(null);

            //Bee bee = Bee.NewBee("Maja");
            //Console.WriteLine(bee?.name);
            //Bee bee2 = Bee.NewBee("Gucio");
            //Console.WriteLine(bee2?.name ?? "Nic");

            //Elephant p = new Elephant(new DateTime(2012, 2, 3));
            //Console.WriteLine(p.birthDate);
            //var (_, d) = p;
            //Console.WriteLine(d);


            //Elephant r = new Elephant(new DateTime(2012, 2, 3));
            //Animal.Presentation(r);
            //Bee bee = Bee.NewBee("maja", new DateTime(2012, 2, 3));
            //Animal.Presentation(bee);
            //Bee bee1 = Bee.NewBee("maja", new DateTime(2012, 2, 3));
            //Console.WriteLine(bee1?.name ?? "Brak");

            //Console.WriteLine("".FirstChar());


            //var dude = new { name = "Dawid", Lastname = "Król" };
            //var dude = (Name:"Dawid", Lastname:"Król");

            //foreach (var item in "dawid".OtherWay())
            //{
            //    Console.WriteLine(item);
            //}

            //string key = string.Join("", Assembly.GetExecutingAssembly().GetName().GetPublicKeyToken().Select(b => b.ToString("x2")));

            //Menager menager = new Menager();
            //menager.name = "Dawid";
            //menager.surName = "Król";

            //(string imie, string nazwisko) = menager;
            //Console.WriteLine(imie);

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid.ToString());
            
        }
        protected static void OnProcess(Person e)
        {
            Process?.Invoke(e, e);
        }
        private static void Program_Process(object sender, Person e)
        {
            Console.WriteLine($"{e._name} {e._lastName}");
        }

        static List<Person> GetPeople()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person("Dawid", "Król"));
            output.Add(new Person("Al"));
            output.Add(new Person("John", "Lenon"));
            output.Add(new Person("Michał", "MOrawiecki"));

            return output;
        }
        static void metodax(object x)
        {
            switch (x)
            {
                case int i:
                    Console.WriteLine("int");
                    break;
                case string j:
                    Console.WriteLine("string");
                    break;
                case null:
                    Console.WriteLine("Null");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }
        static int multiplay(params int[] vs)
        {
            int output = 1;
            foreach (var item in vs)
            {
                output *= item;
            }
            return output;
        }
        static int NewtonSign(int a)
        {
            int output = 1;
            for (int i = 1; i <= a; i++)
            {
                output *= i;
            }
            return output;
        }
    }
}
