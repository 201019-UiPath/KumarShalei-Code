using System;
using Heroslib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Hero obj2 = new Hero();
            /*Console.Write("Please enter Heros id: ");
            obj2.Id=Int32.Parse(Console.ReadLine());
            Console.Write("Please enter Heros name: ");
            obj2.Name=Console.ReadLine();
            Console.Write("Please enter Heros first power: ");
            obj2.superPowers[0]=Console.ReadLine();
            Console.Write($"{obj2.Id} {obj2.Name} {obj2.superPowers[0]}");*/
            // Jagged Arrays rows initialization
            obj2.ja[0] = new int[2]; // first column
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
            #endregion
        }
    }
}
