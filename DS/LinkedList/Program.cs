using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLib;

namespace LinkedList {
    class Program {
        static void Main(string[] args) {
            //TestSingleLinkedList();
            //TestDoubleLinkedList();
            string errorMessage = "";
            var singleCircularLL = new SingleCircularLinkedList<int>();
            foreach (var i in Enumerable.Range(0, 10)) {
                singleCircularLL.AddNewNode(new SingleLinkedListNode<int>() { Data = i, Next = null }, (uint)0, out errorMessage);
            }

            singleCircularLL.AddNewNode(new SingleLinkedListNode<int>() { Data = 16, Next = null }, (uint)5, out errorMessage);
            singleCircularLL.AddNewNode(new SingleLinkedListNode<int>() { Data = 18, Next = null }, (uint)16, out errorMessage);

            singleCircularLL.DeleteNode(0, out errorMessage);
            singleCircularLL.DeleteNode(0, out errorMessage);
        }

        private static void TestDoubleLinkedList() {
            var doubleLinkedList = new DoubleLinkedList<int>();
            string errorMessage = "";
            foreach (var i in Enumerable.Range(0, 10)) {
                doubleLinkedList.AddNewNode(new DoubleLinkedListNode<int>(i, null, null), (uint)0, out errorMessage);
            }

            doubleLinkedList.AddNewNode(new DoubleLinkedListNode<int>(16, null, null), (uint)5, out errorMessage);
            doubleLinkedList.AddNewNode(new DoubleLinkedListNode<int>(18, null, null), (uint)16, out errorMessage);

            doubleLinkedList.DeleteNode(0, out errorMessage);
            doubleLinkedList.DeleteNode(12, out errorMessage);
            doubleLinkedList.DeleteNode(4, out errorMessage);
        }

        private static void TestSingleLinkedList() {
            var singleLL = new SingleLinkedList<int>();
            string errorMessage = "";
            foreach (var i in Enumerable.Range(0, 10)) {
                singleLL.AddNewNode(new SingleLinkedListNode<int>() { Data = i, Next = null }, (uint)0, out errorMessage);
            }

            singleLL.AddNewNode(new SingleLinkedListNode<int>() { Data = 16, Next = null }, (uint)5, out errorMessage);
            singleLL.AddNewNode(new SingleLinkedListNode<int>() { Data = 18, Next = null }, (uint)16, out errorMessage);

            foreach (var i in Enumerable.Range(0, 12)) {
                singleLL.DeleteNode((uint)11, out errorMessage);
            }
        }
    }
}
