using System;

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
        public string[] superPowers = new string[10]; // 1D
        //jagged array
        public int[][] ja = new int[3][]; 
    }

}
