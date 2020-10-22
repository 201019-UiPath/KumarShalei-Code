namespace Heroslib
{
    public delegate void HeroDel();
    public class HeroTasks : IHeroOperation, IHeroSuperPowers
    {
        string path = "../SuperPower.txt";
        public void DoWork()
        {
            System.Console.WriteLine("Saving humanity is my passion");
        }

        public void GetPowers()
        {
            string superPower = System.IO.File.ReadAllText(path);
            System.Console.WriteLine(superPower);
        }

        public void ManageLife()
        {
            System.Console.WriteLine("I have a cranky partner to manage");
        }
    }
}