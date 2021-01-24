using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OligertCrroj

{     public class Task  :  IEquatable<Task>
    {
        //Creating the items which are commonly used/
        //variables
        string name;             
        string dificulty;        
        Task next;              //This item will keep the connction for the chain
        
       
        public string Name { get { return name; } }
        public string Dificultys { get { return dificulty; } }
    
        public Task Next
        {
            get { return next; }
            set{next = value;   }
            
        }
        /****************************************************
         * Constructor- to create new items for the taskList
        *****************************************************/
        public Task(string n, string dificult)
        {
            name = n;
            dificulty = dificult;
            next = null;
        }

        public override string ToString()
        {
         return $" Task:{Name}   Level: {Dificultys}";
        }


        public bool Equals(Task other)
        {
            return this.Name == other.Name;
        }

     
    }
}
