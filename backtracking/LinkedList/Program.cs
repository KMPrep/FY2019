using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLib;

namespace LinkedList {
    class Program {
        static void Main(string[] args) {

            var singleLL = new SingleLinkedList<int>();
            string errorMessage = "";
            foreach (var i in Enumerable.Range(0, 10)) {                
                singleLL.AddNewNode(new SingleLinkedListNode<int>() { Data = i, Next = null }, (uint)0, out errorMessage);
            }

            singleLL.AddNewNode(new SingleLinkedListNode<int>() { Data = 16, Next = null }, (uint)5, out errorMessage);
            singleLL.AddNewNode(new SingleLinkedListNode<int>() { Data = 18, Next = null }, (uint)16, out errorMessage);

            foreach(var i in Enumerable.Range(0, 12)) {
                singleLL.DeleteNode((uint)11, out errorMessage);
            }
        }
    }
}
