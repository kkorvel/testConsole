using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static List<string> shopItemsList = new List<string>();
        static void Main(string[] args)
        {
            List<string> peoples = new List<string>();
            
           

            
            Person person = new Person();
            Console.WriteLine("Tere, mis on su nimi?");

            person.name = Console.ReadLine();

            Console.WriteLine("Tere," + person.name + " kui vana sa oled?");

            person.age = int.Parse(Console.ReadLine());


            Console.WriteLine("Meeldiv tutvuda, " + person.name + " sa oled " + person.age + " aastane!");


            peoples.Add(person.name);
            peoples.Add(person.age.ToString());


            Console.WriteLine("Peoples:");
            foreach (string item in peoples)
            {
                Console.WriteLine(item);
            }
            sayHello();
            //objekt
            Program program = new Program();

            program.sayGreetings();

            addCart("Tomato", 20);
            addCart("Cucumber", 25);
            addCart("Pasta", 10);
            addCart("Cheese", 50);

            foreach (var shopItem in shopItemsList)
            {
                Console.WriteLine(shopItem);
            }



        }
        //static kutsub niisama välja
        private static void sayHello()
        {
            Console.WriteLine("Tere!");
        }

        //nonstatic kutsuma välja objekti abil
        private void sayGreetings()
        {
            Console.WriteLine("Greetings!");
        }
   
        private static void addCart( string name, int itemPrice)
        {
           
            ShopItems shopItems = new ShopItems();
            shopItems.itemName = name;
            shopItems.price = itemPrice;

            shopItemsList.Add(shopItems.itemName);
            shopItemsList.Add(shopItems.price.ToString());

        }
            
        
        
    }
}
