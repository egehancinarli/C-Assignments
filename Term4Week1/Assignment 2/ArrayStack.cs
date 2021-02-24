using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_2
{
    public class ArrayStack : IStack

    {

        private int[] myStackArray;
        // we don't have to use new keyword right away. In this way we can 
        // assign a limit to our array a user wants.
        public ArrayStack(int limit)
        {
            myStackArray = new int[limit];
            //Since we are creating a stack right now  it's empty and count is 0
            Count = 0;
           
        }
        public int Count { get; private set; }

        public bool IsEmpty { get { return Count == 0; } }

        public bool Contains(int value)
        {

            foreach (int i in myStackArray)
            {
                if (i == value)
                {
                    return true;
                }
            }
            //if there is a value in the stack that equals to  'i' it
            //will return true before compiler reaches 'return false' line
            return false;
        }

        public int Pop()
        {

            //I have to check whether the stack is empty or not to get one number.
            if (!IsEmpty)
            {
                Count--;
                return myStackArray[Count];
            }
            else
            {
                throw new Exception("The Stack is empty!!");
            }

        }

        public void Push(int value)
        {
            // I have to check whether the stack is full or not.
            if (Count < myStackArray.Length)
            {
                myStackArray[Count] = value;
                Count++;
                //Since we add a value into stack it's not empty anymore.
            }
            else
            {
                throw new Exception("The stack is full.");
            }

        }
    }
}
