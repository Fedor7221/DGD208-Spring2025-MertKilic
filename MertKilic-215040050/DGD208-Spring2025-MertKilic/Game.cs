using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGD208_Spring2025_MertKilic
{
    public class Game
    {
        private List<Pet> pets = new List<Pet>();

        public void Start()
        {
            bool running = true;

            while (running)
            {
                MainMenu.ShowMainMenu();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AdoptPet();
                        break;
                    case "2":
                        Stats();
                        break;
                    case "3":
                        Item();
                        break;
                    case "4":
                        Console.WriteLine("Mert Kılıç - ISU DGD208");
                        Console.ReadKey();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("please valid choice");
                        break;
                }
            }
        }

        private void AdoptPet()
        {
            Console.Write("Pet name please: ");
            string petname = Console.ReadLine();

            Console.WriteLine("Choose pet: 0=Tiger, 1=Dog, 2=Cat, 3=Hamster");
            //int choice = int.Parse(Console.ReadLine()); --bunu da deneycem--
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                Pet newPet = new Pet
                {
                    name = petname,
                    type = (PetType)choice
                };

                pets.Add(newPet);
                Console.WriteLine($"{newPet.name} is your pet");
                Console.WriteLine("press key");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("please enter valid number");
            }


        }

        private void Stats()
        {
            if (pets.Count == 0)
            {
                Console.WriteLine("No pet");
            }
            else
            {
                for (int i = 0; i < pets.Count; i++)
                    {
                        Pet pet = pets[i];
                        Console.WriteLine($"{pet.name} ({pet.type}) = Food:{pet.food}, Sleep:{pet.sleep}, Smile:{pet.smile}");
                    }
            }
        }

        private void Item()
        {
            if (pets.Count == 0)
                {
                    Console.WriteLine("Please choose a pet.");
                    return;
                }

                
                Console.WriteLine("Choose your pet: ");
                for (int i = 0 ; i < pets.Count ; i++)
                    Console.WriteLine( $" {i + 1}. {pets[i].name} ");

                
                int petIndex = int.Parse( Console.ReadLine() ) - 1;
                Pet pet = pets[petIndex];

                
                Console.WriteLine("Choose the item: ");
                for (int i = 0; i < ItemDatabase.items.Count; i++)
                    Console.WriteLine($"{i + 1}. {ItemDatabase.items[i].name}");

                
                int itemIndex = int.Parse(Console.ReadLine() ) - 1;
                Item item = ItemDatabase.items[itemIndex];

                
                await Task.Delay(item.duration * 1000);

                
                if (item.type == ItemType.Food )
                    pet.food += item.effect;
                else if (item.type == ItemType.Toy)
                    pet.smile += item.effect;
                else if ( item.type == ItemType.Sleep)
                    pet.sleep += item.effect;

                Console.WriteLine( "Item used. ");
        }
    }
}
