using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal<string> myInt = new Animal<string>();
            myInt.Value = "1";
            myInt.Name = "Human";
            myInt.Eats = "Daal Chawal";
            myInt.breed();
            myInt.eats();
            Console.WriteLine(myInt.Value);
            Console.WriteLine();

            Animal<animal> myAni = new Animal<animal>();
            myAni.Value = new animal() { Value = 1, Name = "COW", Eats = "Grass" };
            myAni.breed();
            myAni.eats();
            Console.WriteLine(myAni.Value.Name);
            Console.WriteLine();

            MyAnimalCollections<string> myCollection = new MyAnimalCollections<string>();
            myCollection.Add("Cow");
            myCollection.Add("Goat");
            myCollection.Add("Dear");
            myCollection.Add("Lion");
            Console.WriteLine("Items in the Animal Collection:");
            foreach (string i in myCollection)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Second element in the Integer Collection: {0}", myCollection[1]);


            foreach (string i in myCollection)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine();


            MyAnimalCollections<animal> AnimalCollection = new MyAnimalCollections<animal>();
            AnimalCollection.Add(new animal { Value = 1, Name = "Goat" , Eats = "Grass"});
            AnimalCollection.Add(new animal { Value = 2, Name = "Elephant" , Eats = "Banana"});
            AnimalCollection.Add(new animal { Value = 3, Name = "Dear" , Eats = "Leaves"});
            AnimalCollection.Add(new animal { Value = 4, Name = "PeaCock" , Eats = "Insects"});
            AnimalCollection.Add(new animal { Value = 5, Name = "Hen" , Eats = "Insects"});
            Console.WriteLine("Animals in the Collection");
            foreach (animal ani in AnimalCollection)
            {
                Console.WriteLine(ani);
            }
        }

            class animal
            {
            public int Value { get; set; }
            public string Name { get; set; }
            public string Eats { get; set; }

            public override string ToString()
            {
                return $"Value: {this.Value}, Name: {this.Name}, Eats: {this.Eats}";
            }
        }
        }
    }
