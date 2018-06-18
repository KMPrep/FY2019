using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib {
    public class SingleCircularLinkedList<T> : ISingleLinkedList<T> {
        public SingleLinkedListNode<T> Head { get; private set; }

        public bool AddNewNode(SingleLinkedListNode<T> node, uint posIndex, out string errorMessage) {
            errorMessage = "";

            if(node == null) {
                errorMessage = "Node can't be null";
                return false;
            }

            try {

                if (posIndex == 0) {

                    if (Head == null) {
                        Head = node;
                        node.Next = Head;
                    } else {
                        var temp = Head;
                        //Traverse to the end of Head, to get Head's previous node
                        while (temp.Next != Head) {
                            temp = temp.Next;
                        }

                        temp.Next = node;
                        node.Next = Head;
                        Head = node;
                    }
                } else {
                    int count = 0;
                    var temp = Head;

                    while (temp.Next != Head && count < posIndex - 1) {
                        temp = temp.Next;
                        count++;
                    }
                    //Updating the head node
                    if (temp.Next == Head) {
                        temp.Next = node;
                        node.Next = Head;
                        Head = node;
                    } else {
                        node.Next = temp.Next;
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
                    var temp = Head;

                    while(temp.Next != Head) {
                        temp = temp.Next;
                    }
                    temp.Next = Head.Next;
                    Head = temp;
                } else {
                   
                    int count = 0;
                    var temp = Head;

                    while (temp.Next != Head && count < posIndex - 1) {
                        temp = temp.Next;
                        count++;
                    }
                
                    if(temp.Next == Head) {
                        temp.Next = Head.Next;
                        Head = temp;
                    } else {
                        temp.Next = temp.Next.Next;
                    }
                }
                return true;
            }catch(Exception ex) {
                errorMessage = ex.ToString();
                return false;
            }
        }

        public int GetLength() {
            var temp = Head;
            int count = 1;
            //Traverse to the end of Head, to get Head's previous node
            while (temp.Next != Head) {
                temp = temp.Next;
                count++;
            }

            return count;
        }
    }
}
