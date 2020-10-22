using Heroslib;
using System.Text.RegularExpressions;
using HerosBL;
using System.Collections.Generic;
namespace HerosUI.Menus

{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>
    public class MainMenu:IMenu
    {
        HeroBL heroBL = new HeroBL();
        public void Start(){
            string userInput;
            do{
            System.Console.WriteLine("Welcome fam! What do you wanna do today?");
            // options
            System.Console.WriteLine("[0] Create a hero");
            userInput = System.Console.ReadLine();
            switch(userInput){
                case "0":
                    Hero newHero = GetHeroDetails();
                    heroBL.AddHero(newHero);
                    System.Console.WriteLine($"Hero {newHero.Name} was created with a super power of {Hero.superPowers.Pop()}");
                    break;
                case "1":
                    List<Hero> allheros = heroBL.GetAllHeros();
                    foreach(var hero in allheros){
                        System.Console.WriteLine($"Hero {hero.Name}");
                    }
                    break;
            }
            } while(!userInput.Equals("0")||!userInput.Equals("0"));
            
        }

        public Hero GetHeroDetails(){
            Hero hero = new Hero();
            do{
                System.Console.WriteLine("Enter Hero name: ");
                hero.Name = System.Console.ReadLine();
            } while(Regex.IsMatch(hero.Name, "[\\d]"));
            
            System.Console.WriteLine("Enter to add a super power: ");
            hero.AddSuperPower(System.Console.ReadLine());
            System.Console.WriteLine("Hero created!"); // use logging software to log this
            // add step that pushes this heros details to BL
            return hero;

        }
    }
}