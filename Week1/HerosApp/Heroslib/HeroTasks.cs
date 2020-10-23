using System.Threading.Tasks;
namespace Heroslib

{
    public delegate void HeroDel();
    public class HeroTasks : IHeroOperation, IHeroSuperPowers
    {
        string path = @"C:\Users\shale\Desktop\UiPath_Batch\KumarShalei-Code\Week1\SuperPower.txt";
        public event HeroDel workDone;
        public async void DoWork()
        {
            System.Console.WriteLine("Work Started..........");
            await Task.Run(new System.Action(GetPowers));
            System.Console.WriteLine("Saving humanity is my passion");
            System.Console.WriteLine("Work finished");
            OnWorkDone();
        }
        public void OnWorkDone(){
            //workDone?.Invoke();
            if(workDone!=null){
                workDone();// raising the event
            }
        }
        public void GetPowers()
        {
            System.Console.WriteLine("Getting Powers");
            System.Threading.Thread.Sleep(2000);
            string superPower = System.IO.File.ReadAllText(path);
            System.Console.WriteLine($"Power obtained {superPower}");
        }

        public void ManageLife()
        {
            System.Console.Write("I have a cranky partner to manage");
        }
    }
}