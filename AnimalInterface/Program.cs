using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    interface IIBird
    {
        string DoAction();
    }

    interface IAnimal
    {
        string Name { get; set; }
        string MakeSound();
    }

    class Bear : IAnimal
    {
        public string Name { get; set; }
        public string MakeSound()
        {
            return "Grrrrr!";
        }
    }

    class Chicken : IAnimal, IIBird
    {
        public string Name { get; set; }
        public string MakeSound()
        {
            return "Cluck cluck!";
        }
        public string DoAction()
        {
            return "flap flap flap";
        }
    }

    class Eagle : IAnimal, IIBird
    {
        public string Name { get; set; }
        public string MakeSound()
        {
            return "Shreeeeekkkkkk!";
        }
        public string DoAction()
        {
            return "flap flap flap";
        }
    }

    class AnimalUtility
    {

        public static string DoSomething(IAnimal Animal)
        {
            if (Animal is IIBird)
            {
                return Animal.MakeSound() + " flap flap flap";
            }
            else
            {
                return Animal.MakeSound();
            }
        }
        //public string DoSomething(string Animal)
        //{
        //    var strReturn = "Houston, we have a problem.";
        //    var MyBear = new Bear();
        //    var MyChicken = new Chicken();
        //    var MyEagle = new Eagle();

        //    switch (Animal)
        //    {
        //        case "Bear":
        //            strReturn = "The bear goes ";
        //            strReturn = strReturn + MyBear.MakeSound();
        //            break;

        //        case "Chicken":
        //            strReturn = "The chicken goes ";
        //            strReturn = strReturn + MyChicken.MakeSound();
        //            strReturn = strReturn + "\n" + MyChicken.DoAction();
        //            break;

        //        case "Eagle":
        //            strReturn = "The eagle goes ";
        //            strReturn = strReturn + MyEagle.MakeSound();
        //            strReturn = strReturn + "\n" + MyChicken.DoAction();
        //            break;

        //        default:
        //            break;
        //    }
        //    return strReturn;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var MyAnimal = new AnimalUtility();
            var eagle = new Eagle { Name = "Eagle" };

            Console.WriteLine(AnimalUtility.DoSomething(eagle));
            Console.ReadLine();

            //Console.WriteLine(MyAnimal.DoSomething("Bear"));
            //Console.ReadLine();

            //Console.WriteLine(MyAnimal.DoSomething("Chicken"));
            //Console.ReadLine();

            //Console.WriteLine(MyAnimal.DoSomething("Eagle"));
            //Console.ReadLine();

            File.Create(@"C:\temp\test.txt");
        }
    }
}
