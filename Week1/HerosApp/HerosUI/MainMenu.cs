using System;
using HerosDB;
using Heroslib;
namespace HerosUI
{
    public class MainMenu : IMenu
    {
        private string userInput;
        private HeroMenu heroMenu = new HeroMenu(new DBRepo(new HerosContext()), new MessagingService());
        private VillainMenu villainMenu= new VillainMenu(new FileRepo(), new MessagingService());
        public void Start()
        {
            do{
                Console.WriteLine("Welcome Friend! Are you a hero or a villain?");
                Console.WriteLine("[0] Hero?");
                Console.WriteLine("[1] Villain?");
                Console.WriteLine("[2] Exit?");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //call the hero menu;
                        heroMenu.Start();
                        break;
                    case "1":
                        //call the villain menu;
                        villainMenu.Start();
                        break;
                    case "2":
                        Console.WriteLine("Goodbye Friend");
                        break;
                    default:
                    //call the invalid message
                    break;
                }
                
            }while(!(userInput.Equals("2")));
        }
    }
}