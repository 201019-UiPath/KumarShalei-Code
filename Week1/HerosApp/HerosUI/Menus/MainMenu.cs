using Heroslib;
using System.Text.RegularExpressions;
namespace HerosUI.Menus
{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>
    public class MainMenu:IMenu
    {
        public void Start(){
            do{
            System.Console.WriteLine("Welcome fam! What do you wanna do today?");
            // options
            System.Console.WriteLine("[0] Create a hero");
            } while(!System.Console.ReadLine().Equals("0"));
            Hero newHero = GetHeroDetails();
            System.Console.WriteLine($"Hero {newHero.Name} was created with a super power of {Hero.superPowers.Pop()}");
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