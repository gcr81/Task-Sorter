using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OligertCrroj
{
    public class PrimaryQueue :  ICollection<Task>

    {
        private Task first;

        #region Count Function
        //Count the item of how many element are in the list.
        public new int Count
        {
            get
            {
                Task current = first;
                int c = 0;
                while (current != null)
                {
                    c++;
                    current = current.Next;
                }
                return c;
            }
        }

        #endregion
     
        #region Eneueue funtion
        /**********************************************************************************
         * Eneque - a function that will add a new item to the list IN THE CORRECT PLACE
         * i have modified , so it depends on the categorie that have been choosen from ddl
         **********************************************************************************/
        public void Enqueue(int key, string name, string dificulties)
        {
            Task current = first;

            if (current.Dificultys == null )
            {
                throw new System.InvalidOperationException("Check you dropdownList");
            }
            /**********************************************************************************
             * Loop idea taken from week6Tutorial
             * When we want to add an item in the middle of the list but keep the connection
             * with the other item in the list
             * Function uses a key to detemine which categorie has been selected
             **********************************************************************************/

            if (key == 1)
            {
                while (current != null)
                {
                    if (current.Dificultys == "Low") break;
                    current = current.Next;
                }
            }
            if (key == 2)
            {
                while (current != null)
                {
                    if (current.Dificultys == "Normal") break;
                    current = current.Next;
                }
            }
            if (key == 3)
            {
                while (current != null)
                {
                    if (current.Dificultys == "Important") break;
                    current = current.Next;
                }
            }
            if (key == 4)
            {
                while (current != null)
                {
                    if (current.Dificultys == "Critical") break;
                    current = current.Next;
                }
            }
            //creating that connection we need to keep both and 
            //after we done we move with the item we need
            Task b2 = new Task(name, dificulties);
            b2.Next = current.Next;     
            current.Next = b2;          

        }
        #endregion

        #region Dequeuee funtion
        /**********************************************************************************
         * Dequeuee-a function that returns and removes the first Task in the list.
         * i have modified ,so everytime you would click the first element of the list wor
         * be removed from the list
         **********************************************************************************/
        public bool Dequeuee()
        {
            Task item = first;
            //a -> b -> c -> d
            //remove a, by making b first
            if (item.Name == first.Name)
            {
                first = first.Next;
                return true;
            }

            Task current = first;
            while (current != null)
            {
                if (current.Next == null) return false; //end of list, didn't remove anything
                if (current.Next.Name == item.Name) //the next element is the one to remove
                {
                    current.Next = current.Next.Next;   //if current is A, this makes A.Next -> C
                    return true;    //successfully skipped over B
                }
                current = current.Next;
            }
            return false;

        }
        #endregion

        #region Peek function
        /**********************************************************************************
         * Peek--a function that lets you view the first Task in the list but does not remove
         * it from the list.
         **********************************************************************************/
        public new string Peek()
        {
            Task current = first;
            if (current == null)
            {
              throw new InvalidOperationException("List is empty.");
            }

            return $"Name: {current.Name} Dificulties:  {current.Dificultys}";
        }

        #endregion
         
        #region ICollection Functions
        public bool IsReadOnly => false;

        //Have used this method to add the main items in the list
        //This method hepls me with the program
        public void Add(Task z)
        {
            z.Next = first;     //z.Next points to A
            first = z;
        }

        //Clearing the list by making the first item null

        public void Clear()
        {
            first = null;
        }

       
        public bool Contains(Task item)
        {
          
            Task current = first;
            while (current != null)
            {
                if (current.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(Task[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }


  
        public IEnumerator<Task> GetEnumerator()
        {
            return new PrimaryListEnumerator(this);
        }

        public bool Remove(Task item)
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Primary List Enumerator 
        class PrimaryListEnumerator :  IEnumerator<Task>
        {
            private PrimaryQueue enumList;
            private int index;
            private Task current;      

            public PrimaryListEnumerator(PrimaryQueue list)
            {
                enumList = list;
                index = -1;         //before the iteration begins
                current = null;
            }
            public Task Current { get { return current; } }     
            object IEnumerator.Current { get { return current; } }  //readonly
            public void Dispose(){}

            public bool MoveNext()
            {
               index++;
                if (index >= enumList.Count) return false;

                Task c = enumList.first;
                for (int i = 0; i < index; i++)
                    c = c.Next;

                current = c;
                return true;
            }


            public void Reset()
            {
                index = -1;
            }
            #endregion

        }
    }
  }

