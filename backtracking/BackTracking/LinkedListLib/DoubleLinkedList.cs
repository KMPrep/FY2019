using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib {
    public class DoubleLinkedList<T> : IDoubleLinkedList<T> {
        public DoubleLinkedListNode<T> Head { get; set; }

        public bool AddNewNode(DoubleLinkedListNode<T> node, uint posIndex, out string errorMessage) {
            errorMessage = "";

            if(node == null) {
                errorMessage = "Node can't be null";
                return false;
            }

            try {
                if (posIndex == 0) {
                    if (Head == null) {
                        Head = node;
                        return true;
                    } else {
                        Head.Prev = node;
                        node.Next = Head;
                        node.Prev = null;
                        Head = node;
                    }
                } else {
                    int count = 0;
                    var temp = Head;
                    while (temp.Next != null && count < posIndex - 1) {
                        count++;
                        temp = temp.Next;
                    }

                    //Inserting node at the end;
                    if (temp.Next == null) {
                        temp.Next = node;
                        node.Prev = temp;
                        node.Next = null;
                    } else { //Inserting in the middle.
                        temp.Next.Prev = node;
                        node.Next = temp.Next;
                        node.Prev = temp;
                        temp.Next = node;

                    }
                }

                return true;
            }catch(Exception ex) {
                errorMessage = ex.ToString();
                return false;
            }
        }

        public bool DeleteNode(uint posIndex, out string errorMessage) {

            errorMessage = "";

            try {
                if (posIndex == 0) {
                    if (Head == null || Head.Next == null) {
                        Head = null;
                    } else {
                        var temp = Head;
                        temp.Next.Prev = null;                        
                        Head = temp.Next;
                        temp.Next = null;

                    }
                } else {
                    int count = 0;
                    var temp = Head;
                    while (temp.Next != null && count < posIndex - 1) {
                        count++;
                        temp = temp.Next;
                    }

                    if(temp.Next == null) {
                        temp.Prev.Next = null;
                    } else {
                        temp.Prev.Next = temp.Next;
                        temp.Next.Prev = temp.Prev;
                        temp.Prev = null;
                        temp.Next = null;
                    }
                }

                return true;
            }catch(Exception ex) {
                errorMessage = ex.ToString();
                return false;
            }

        }

        public int GetLength() {
            int count = 1;
            var temp = Head;
            while(temp.Next != null) {
                count++;
            }
            return count;
        }
    }

    public class DoubleLinkedListNode<T> {
        public T Data { get; private set; }
        public DoubleLinkedListNode<T> Prev { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }

        public DoubleLinkedListNode(T data, DoubleLinkedListNode<T> prev, DoubleLinkedListNode<T> next ) {
            Data = data;
            Prev = prev;
            Next = next;
        }
    }
         
}
