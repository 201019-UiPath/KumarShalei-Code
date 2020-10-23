using System;
using Heroslib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hero obj2 = new Hero();
            #region default constructor
            //Hero obj=new Hero();
            //Console.WriteLine($"{obj.Id} {obj.name}");
            #endregion
            #region parameterized constructor
            //Hero obj1 = new Hero(2, "Captain America");
            //Console.WriteLine($"{obj1.Id}");// cannot access variables if they are not public
            #endregion
            #region Access via Properties
            /*Console.WriteLine(obj1.Id);// read property value
            obj1.Id = 3;
            Console.Write($"New Id = {obj1.Id}");*/
            #endregion
            #region Accessing 1-D Arrays            
            
            /*Console.Write("Please enter Heros id: ");
            obj2.Id=Int32.Parse(Console.ReadLine());
            Console.Write("Please enter Heros name: ");
            obj2.Name=Console.ReadLine();
            Console.Write("Please enter Heros first power: ");
            obj2.superPowers[0]=Console.ReadLine();
            Console.Write($"{obj2.Id} {obj2.Name} {obj2.superPowers[0]}");*/
            // Jagged Arrays rows initialization
            /*obj2.ja[0] = new int[2]; // first column
            obj2.ja[1] = new int[3]; // second column
            obj2.ja[2] = new int[1]; // third column
            obj2.ja[0][0]=10;
            obj2.ja[1][2]=30;
            int[,,] td = new int[2,4,3];
            Console.WriteLine($"Dimension of Array: {td.Rank}");
            Console.WriteLine($"Number if elements in Array: {td.Length}");
            //Console.WriteLine(obj2.ja.Rank); // dimension of array
            //Console.WriteLine(obj2.ja.Length); // elements of array

            // loop through the jagged array
            foreach(var rows in obj2.ja){
                //looping through all columns of every rows
                for(int i=0;i<rows.Length; i++){
                    Console.Write($"{rows[i]} ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region List<T>, Stack<T>
            /*Console.WriteLine("Please enter power to be removed ");
            string sp = Console.ReadLine();
            obj2.RemoveSuperPower();
            foreach(var superPowers in Hero.GetSuperPowers()){
                Console.WriteLine(superPowers);               
            }*/
            #endregion
            #region Dictionary<key,value>
            // Console.WriteLine("Hero     Hideout");
            // foreach(var superhero in Hero.hideOuts){
            //     //Console.WriteLine($"{superhero.Key} {Hero.hideOuts[superhero.Key]}"); old way
            //     Console.WriteLine($"{superhero.Key} {superhero.Value}"); // new way
            // }
            #endregion
            #region Calling HeroMenu
            // Menus.IMenu startMenu = new Menus.MainMenu();
            // startMenu.Start();
            #endregion
            
            HeroTasks heroTasks = new HeroTasks();
            #region Delegate, Anonymous, methods, Lambda
            

            //HeroDel del = new HeroDel(heroTasks.GetPowers);
            // Action del = new Action(heroTasks.GetPowers);
            // //Func<string, string> fd = new Func<string, string>(some method);
            // //Predicate<string> predicate = new Predicate<string>(some method);
            // del += heroTasks.DoWork; // += subscribe to a method
            // del += heroTasks.ManageLife; // -= unsubsribe
            // del();

            // //Anonymous method
            // Action<string> am=delegate(string name){
            //     System.Console.WriteLine("Hello anon");
            // };
            // am("Peggy");
            //lambda expressions - shorthand notation to anon methods
            //Action result = ()=>System.Console.WriteLine("Hello Lambda");
            //result();
            #endregion
            #region Asynchronous vs Synchronous programming, Delegates (cont.)
            // Subscribing to publisher
            heroTasks.workDone += EmailService.SendEmail;
            heroTasks.workDone += TextMessageService.SendText;
            heroTasks.workDone += PushNotification.SendPush;
            heroTasks.DoWork();
            heroTasks.ManageLife();
            Console.Read(); //Holds the screen until a key pressed
            #endregion
        }
    }
}
