using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static List<ShopItems> shopItemsList = new List<ShopItems>();
        static void Main(string[] args)
        {
            List<Person> peoples = new List<Person>();
            
           

            
            Person person = new Person();
            Console.WriteLine("Tere, mis on su nimi?");

            person.name = Console.ReadLine();

            Console.WriteLine("Tere," + person.name + " kui vana sa oled?");

            person.age = int.Parse(Console.ReadLine());


            Console.WriteLine("Meeldiv tutvuda, " + person.name + " sa oled " + person.age + " aastane!");

            peoples.Add(person);
            //peoples.Add(person.name);
            //peoples.Add(person.age.ToString());


            Console.WriteLine("Peoples:");
            foreach (Person item in peoples)
            {
                Console.WriteLine(string.Format("{0} {1}", item.name, item.age));

            }
            sayHello();
            //objekt
            Program program = new Program();

            program.sayGreetings();

            addCart("Tomato", 20);
            addCart("Cucumber", 25);
            addCart("Pasta", 10);
            addCart("Cheese", 50);
            Console.WriteLine("Meil on pakkuda:");

            foreach (ShopItems shopItem in shopItemsList)
            {
                Console.WriteLine(string.Format("Name:{0}, Price:{1} + euros", shopItem.itemName, shopItem.price));
            }
            string ost = Console.ReadLine();
            //if(ost == )



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

            shopItemsList.Add(shopItems);
            //shopItemsList.Add(shopItems.itemName);
            //shopItemsList.Add(shopItems.price.ToString());
            

        }
            
        
        
    }
}
