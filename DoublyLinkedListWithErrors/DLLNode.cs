using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLLNode
    {
        public int num;   // field of the node
        public DLLNode next; // pointer to the next node
        public DLLNode prev; // pointer to the previous node
        public DLLNode (int num)
        {
            this.num = num;
            next = null;
            prev = null;
        } // end of constructor

        public Boolean isPrime(int n)
        {
            if (n < 2)
            {
                return (false);
            }
            else
            {
                var root = Math.Sqrt(n);
                for (int i = 2; i <= root; i++)
                {
                    if ((root % i) == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        } // end of isPrime

    } // end of class DLLNode
}
