using System;
using LinkedListNamespace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLinkedList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(2, false);
            Assert.IsTrue(myList1.GetNodeCount() == 1);
            myList1.Add(7, false);
            Assert.IsTrue(myList1.GetNodeCount() == 2);

            Assert.AreEqual(2, myList1.head.data);
            Assert.AreEqual(7, myList1.tail.data);
        }

        [TestMethod]
        public void TestAdd2()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(9, false);
            Assert.IsTrue(myList1.GetNodeCount() == 1);
            myList1.Add(5, true);
            Assert.IsTrue(myList1.GetNodeCount() == 2);
            Assert.AreEqual(5, myList1.head.data);
            Assert.AreEqual(9, myList1.tail.data);
        }


        [TestMethod]
        public void TestDelete1()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(1, true);
            myList1.Add(23, true);
            myList1.Add(27, true);
            myList1.Add(29, true);
            Assert.AreEqual(29, myList1.head.data);
            Assert.AreEqual(1, myList1.tail.data);
            Assert.IsTrue(myList1.GetNodeCount() == 4);
            myList1.Delete(1);
            Assert.IsTrue(myList1.GetNodeCount() == 3);
            Assert.AreEqual(29, myList1.head.data);
            Assert.AreEqual(1, myList1.tail.data);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestDelete2()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Delete(23);
        }

        [TestMethod]
        public void TestDelete3()
        {
            LinkedList<string> myList1 = new LinkedList<string>();
            myList1.Add("1", true);
            myList1.Delete("1");
            Assert.IsTrue(myList1.GetNodeCount() == 0);
        }

        [TestMethod]
        public void TestDelete4()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(1, true);
            Assert.IsTrue(myList1.GetNodeCount() == 1);
            Assert.AreEqual(1, myList1.head.data);
            Assert.AreEqual(1, myList1.tail.data);
            myList1.Delete(1);
            Assert.IsTrue(myList1.GetNodeCount() == 0);


        }

        [TestMethod]
        public void TestDelete5()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(1, true);
            myList1.Add(5, false);
            myList1.Delete(1);
            Assert.IsTrue(myList1.GetNodeCount() == 1);
        }
    



        [TestMethod]
        public void TestClone1()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(1, true);
            myList1.Add(23, true);
            myList1.Add(27, true);
            myList1.Add(29, true);
            Assert.AreEqual(29, myList1.head.data);
            Assert.AreEqual(1, myList1.tail.data);
            Assert.IsTrue(myList1.GetNodeCount() == 4);
            var clonedList = myList1.Clone();
            Assert.AreEqual(29, clonedList.head.data);
            Assert.AreEqual(1, clonedList.tail.data);
        }        

        [TestMethod]
        public void TestClone2()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(1, true);
            var clonedList = myList1.Clone();
            Assert.IsTrue(clonedList.GetNodeCount() == 1);
            Assert.AreEqual(1, clonedList.head.data);
            Assert.AreEqual(1, clonedList.tail.data);
        }

        [TestMethod]
        public void IteratorTest()
        {
            LinkedList<int> myList1 = new LinkedList<int>();
            myList1.Add(1, true);
            myList1.Add(23, true);
            //myList1.Add(27, true);
            //myList1.Add(29, true);
            //myList1.Add(30, true);
            //myList1.Add(31, true);
            //myList1.Add(32, true);
            //myList1.Add(33, true);

            int count = 0;
            foreach(Node<int> node in myList1)
            {
                int value = node.data;
                count++;
            }
            Assert.AreEqual(2, count);

            count = 0;

            foreach (Node<int> node in myList1)
            {
                int value = node.data;
                count++;
            }

            Assert.AreEqual(2, count);
        }
    }
}
