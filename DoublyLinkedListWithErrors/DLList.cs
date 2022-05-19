using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */


        public void addToTail(DLLNode p)
        {
            // if the list is empty
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.prev = this.tail;
                this.tail.next = p;
                tail = p;
            }
        } // end of addToTail

        public void addToHead(DLLNode p)
        {
            // if the list is empty
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = this.head;
                this.head.prev = p;
                head = p;
            }
        } // end of addToHead

        public void removeHead()
        {
            // if the list is empty
            if (this.head == null) return;
            // if the list has one node
            if(this.head == this.tail)
            {
                head = null;
                tail = null;
                return;
            }
            this.head = this.head.next;
            this.head.prev = null;
        } // removeHead

        public void removeTail()
        {
            // if the list is empty
            if (this.tail == null) return;
            // if the list has one node
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
                return;
            }
            this.tail.prev.next = null;
            this.tail = this.tail.prev; 
        } // remove tail

        /*-------------------------------------------------
         * Return null if the string does not exist.
         * ----------------------------------------------*/
        public DLLNode search(int num)
        {
            // loop through list, find matching number, return corresponding node
            DLLNode p = head;
            while (p != null)
            {
                if (p.num == num) break;
                p = p.next;
            }
            return (p);
        } // end of search (return pionter to the node);

        public void removeNode(DLLNode p)
        { // removing the node p.
            //if list is empty
            if (head == null) return;

            // if node is not in list
            if (search(p.num) == null) return;
            // if p is the tail
            if (p.next == null)
            {
                this.tail = this.tail.prev;
                this.tail.next = null;
                p.prev = null;
                return;
            }
            // if p is the head
            if (p.prev == null)
            {
                this.head = this.head.next;
                p.next = null;
                this.head.prev = null;
                return;
            }
            // if p is in the middle
            p.next.prev = p.prev;
            p.prev.next = p.next;
            p.next = null;
            p.prev = null;
            return;
        }  // end of remove a node

        public int total()
        {
            // loop through list, add all num values together
            // if list is empty return 0
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next;         //changed from p = p.next.next;
            }
            return (tot);
        } // end of total
    } // end of DLList class
}
