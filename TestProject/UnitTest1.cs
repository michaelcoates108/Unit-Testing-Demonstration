using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoublyLinkedListWithErrors;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0() // testing addToHead, when list is empty
        {
            //create node and empty list
            DLLNode p = new DLLNode(5);
            DLList list = new DLList();
            // add node to head of list
            list.addToHead(p);
            // check value of head.num
            Assert.AreEqual(list.head.num, 5);
        }

        [TestMethod]
        public void TestMethod1() // testing addToHead, when list is not empty
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add the two nodes to head of list 
            list.addToHead(p);
            list.addToHead(q);
            // check the value of head.num
            Assert.AreEqual(list.head.num, 10);
        }

        [TestMethod]
        public void TestMethod2() // testing addToTail, when list is empty
        {
            //create node and empty list
            DLLNode p = new DLLNode(5);
            DLList list = new DLList();
            // add node to tail of list
            list.addToTail(p);
            // check value of tail.num
            Assert.AreEqual(list.tail.num, 5);
        }

        [TestMethod]
        public void TestMethod3() // testing addToTail, when list is not empty
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add the two nodes to tail of list 
            list.addToTail(p);
            list.addToTail(q);
            // check value of tail.num
            Assert.AreEqual(list.tail.num, 10);
        }

        [TestMethod]
        public void TestMethod4() // testing removeHead, when list is already empty
        {
            // create empty list
            DLList list = new DLList();
            // try to remove head of list
            list.removeHead();
            // ensure list.head still empty/unchanged 
            Assert.AreEqual(list.head, null);
        }
        [TestMethod]
        public void TestMethod5() // testing removeHead, when list has one node
        {
            //create node and empty list
            DLLNode p = new DLLNode(5);
            DLList list = new DLList();
            // add node to list and then remove it 
            list.addToHead(p);
            list.removeHead();
            // check list is empty
            Assert.AreEqual(list.head, null);
        }

        [TestMethod]
        public void TestMethod6() // testing removeHead, when list has two nodes
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add nodes to head of list, then remove head 
            list.addToHead(p);
            list.addToHead(q);
            list.removeHead();
            // check value of head
            Assert.AreEqual(list.head.num, 5);
        }

        [TestMethod]
        public void TestMethod7() // testing removeTail, when list is already empty
        {
            // create empty list
            DLList list = new DLList();
            // try to remove tail
            list.removeTail();
            // ensure list is empty/unchanged
            Assert.IsTrue(list.tail == null);
        }

        [TestMethod]
        public void TestMethod8() // testing removeTail, when list has one node
        {
            // create node and empty list
            DLLNode p = new DLLNode(5);
            DLList list = new DLList();
            // add node to tail, then remove it 
            list.addToTail(p);
            list.removeTail();
            // check list is empty 
            Assert.AreEqual(list.tail, null);
        }

        [TestMethod]
        public void TestMethod9() // testing removeTail, when list has two nodes
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add nodes to tail, then remove tail
            list.addToTail(p);
            list.addToTail(q);
            list.removeTail();
            // check value of tail
            Assert.AreEqual(list.tail.num, 5);
        }

        [TestMethod]
        public void TestMethod10() // testing search on an empty list
        {
            // create empty list
            DLList list = new DLList();
            // attempt to find node in list
            DLLNode p = list.search(5);
            // check result is null
            Assert.AreEqual(p, null);
        }

        [TestMethod]
        public void TestMethod11() // testing search on non-empty list, where the number IS in the list 
        {
            // create nodes and empty list
            DLList list = new DLList();
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(7);
            DLLNode r = new DLLNode(10);
            // add nodes to list 
            list.addToTail(p);
            list.addToTail(q);
            list.addToTail(r);
            // search for node in list, check result is not null
            Assert.IsNotNull(list.search(7));
        }

        [TestMethod]
        public void TestMethod12() // testing search on non-empty list, where the number is NOT in the list 
        {
            // create nodes and empty list
            DLList list = new DLList();
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(7);
            DLLNode r = new DLLNode(10);
            // add nodes to list 
            list.addToTail(p);
            list.addToTail(q);
            list.addToTail(r);
            // search for node that isnt in list, check result is null
            Assert.IsNull(list.search(3));
        }

        [TestMethod]
        public void TestMethod13() // testing isPrime on the number 2 (boundary case)
        {
            //create node with num = 2
            DLLNode p = new DLLNode(2);
            // check prime is true
            Assert.IsTrue(p.isPrime(p.num));
        }
        [TestMethod]
        public void TestMethod14() // testing isPrime on the number -5 (negative case)
        {
            // create node with num = -5
            DLLNode p = new DLLNode(-5);
            // check prime is false
            Assert.IsFalse(p.isPrime(p.num));
        }

        [TestMethod]
        public void TestMethod15() // testing isPrime on the number 7 (prime) 
        {
            // create node with num = 7
            DLLNode p = new DLLNode(7);
            // check prime is true
            Assert.IsTrue(p.isPrime(p.num));
        }
        [TestMethod]
        public void TestMethod16() // testing isPrime on the number 9 (non-prime, sq number) 
        {
            // create node with num = 9
            DLLNode p = new DLLNode(9);
            // check prime is false
            Assert.IsFalse(p.isPrime(p.num));
        }

        [TestMethod]
        public void TestMethod17() // testing removeNode, where the node is NOT in the list
        {
            // create nodes and empty list
            DLList list = new DLList();
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLLNode r = new DLLNode(15);
            // add nodes to list
            list.addToTail(p);
            list.addToTail(q);
            // try to remove node that isnt in list
            list.removeNode(r);
            // ensure list is unchanged 
            Assert.IsTrue((p.next == q) && (q.prev == p));
            
        }

        [TestMethod]
        public void TestMethod18() // testing removeNode, where the node is at the head
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add nodes to list
            list.addToTail(p);
            list.addToTail(q);
            // remove node that is the current head
            list.removeNode(p);
            // check value of new head
            Assert.AreEqual(list.head.num, 10);
        }

        [TestMethod]
        public void TestMethod19() // testing removeNode, where the node is at the tail
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add nodes to list
            list.addToTail(p);
            list.addToTail(q);
            // remove node that is the current tail
            list.removeNode(q);
            // check value of new tail
            Assert.AreEqual(list.tail, p);
        }

        [TestMethod]
        public void TestMethod20() // testing removeNode, where the node is in the middle of the list
        {
            // create 3 nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLLNode r = new DLLNode(15);
            DLList list = new DLList();
            // add nodes to list
            list.addToTail(p);
            list.addToTail(q);
            list.addToTail(r);
            // remove middle node
            list.removeNode(q);
            // check middle node removed
            Assert.AreEqual(p.next, r);
        }
       
        [TestMethod]
        public void TestMethod21() // testing removeNode, where the list is empty
        {
            // create node and empty list
            DLList list = new DLList();
            DLLNode p = new DLLNode(5);
            // try to remove node from empty list
            list.removeNode(p);
            // check list is still empty/unchanged 
            Assert.AreEqual(list.head, null);
        }

        [TestMethod]
        public void TestMethod22() // testing total(), where the list is empty
        {
            // create empty list
            DLList list = new DLList();
            // check total sum is 0
            Assert.IsTrue(list.total() == 0);
        }

        [TestMethod]
        public void TestMethod23() // testing total(), where the list is not empty
        {
            // create two nodes and empty list
            DLLNode p = new DLLNode(5);
            DLLNode q = new DLLNode(10);
            DLList list = new DLList();
            // add nodes to list
            list.addToTail(p);
            list.addToTail(q);
            // check total is 15 (5 + 10)
            Assert.AreEqual(list.total(), 15);

        }

        [TestMethod]
        public void TestMethod24() // testing total(), where the list has only one node
        {
            // create node and empty list
            DLLNode p = new DLLNode(5);
            DLList list = new DLList();
            // add node to list
            list.addToTail(p);
            // check total is same as p.num
            Assert.AreEqual(list.total(), p.num);
        }

    }
}
