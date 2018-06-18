using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib
{
     /// <summary>
     /// Single Linked List Implementation
     /// </summary>
     /// <typeparam name="T"></typeparam>
    public class SingleLinkedList<T> : ISingleLinkedList<T> {
        /// <summary>
        /// Head pointer of the Linked List
        /// </summary>
        public SingleLinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// Get the Length of the Linked List
        /// </summary>
        /// <returns></returns>
        public int GetLength() {

            var head = Head;
            int count = 0;

            while(head != null) {
                count++;
                head = head.Next;
            }
            return count;
        }

        /// <summary>
        /// Adding new node to the single linked list. 
        /// </summary>
        /// <param name="node">Node to be added to the linked list</param>
        /// <param name="posIndex">If inserted as head, use 0, else the position of the Linked list</param>
        /// <param name="errorMessage">Placeholder for error message</param>
        /// <returns></returns>
        public bool AddNewNode(SingleLinkedListNode<T> node, uint posIndex, out string errorMessage) {

            errorMessage = "";

            try {
                if(node == null) {
                    errorMessage = "Node is not initialized with data";
                    return false;
                }

                if(posIndex == 0) {
                    if (Head == null) {
                        Head = node;
                        return true;
                    } else {                        
                        node.Next = Head;
                        Head = node;
                    }
                    return true;
                } else {
                    int count = 0;
                    var head = Head;
                    while(head.Next != null && count < posIndex - 1) {
                        count++;
                        head = head.Next;
                    }
                    //Adding node at the tail.
                    if(head.Next == null) {
                        head.Next = node;
                        node.Next = null;
                    } else {
                        var temp = head.Next;
                        head.Next = node;
                        node.Next = temp;
                    }
                    return true;
                }

            }catch(Exception ex) {
                return false;
            }

            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="posIndex"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public bool DeleteNode(uint posIndex, out string errorMessage) {

            errorMessage = "";

            try {
                if (Head == null) {
                    errorMessage = "No node to delete";
                    return true;
                }

                //delete Head node;
                if (posIndex == 0) {
                    var temp = Head;
                    Head = Head.Next;
                } else {
                    int count = 0;
                    var head = Head;
                    while (head.Next != null  && count < posIndex - 1) {
                        count++;
                        head = head.Next;
                    }
                    var temp = head.Next.Next;
                    head.Next = temp;
                }
                return true;
            }catch(Exception ex) {
                errorMessage = "Error occurred while deleting node";
                return false;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SingleLinkedListNode <T> {
        public SingleLinkedListNode<T> Next { get; set; }
        public T Data { get; set; }
    }
}
