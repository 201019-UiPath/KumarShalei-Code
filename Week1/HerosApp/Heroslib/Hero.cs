using System;
using System.Collections.Generic;

namespace Heroslib
{
    #region old way of creating class members
    /*
    public class Hero// default modifier for class -> internal
    {
        // default modifier of members of a class is private
        */
        /*int id;// value type -> System.int32
        public int Id{
            get{
                if (id>0)
                    return id;
            }
            set{
                id = value;
            }
        }
        */
        /*
        public int Id{get;set;}// autonomous 
        string name;// reference type
        // Constructor - default
        public Hero(){
            //id = 1;
            name = "Ironman";
        }
        //snippet - ctor
        public Hero(int id, string name)
        {
            //this.id = id;
            this.name = name;
        }
    }
    */
    #endregion
    public class Hero{
        public int Id{get;set;}
        public string Name{get;set;}
        #region Arrays
        /*public string[] superPowers = new string[10]; // 1D
        //jagged array
        public int[][] ja = new int[3][]; */
        #endregion
        //public static List<string> superPowers = new List<string>();
        public static Stack<string> superPowers = new Stack<string>();// LIFO
        // look into double linked lists
        public static Dictionary<string, string> hideOuts = new Dictionary<string,string>();
        ///Method
        

        public Hero()
        {
            superPowers.Push("Strength");
            superPowers.Push("Speed");
            superPowers.Push("Invisibility");
            superPowers.Push("Fly");

            // hideOuts.Add("Thor", "Asgard");
            // hideOuts.Add("Batman", "Bat Cave");
            // hideOuts.Add("Superman", "Fortress of Solitude");

        }

        public static IEnumerable<string> GetSuperPowers(){
            return superPowers;
        }
        public void RemoveSuperPower(){//string superPower){
            //if(superPowers.Contains(superPower)){
                //superPowers.Remove(superPower);

            //}
            superPowers.Pop();
        }

        public void AddSuperPower(string superPower){
            if(superPower != null && superPower != ""){
                superPowers.Push(superPower);
            } else throw new ArgumentException("Super power shouldn't be null");
        }
    }

}
