using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLib {
    public class DoubleLinkedList {


    }

    public class DoubleLinkedListNode<T> {
        public T Data { get; private set; }
        public DoubleLinkedListNode<T> Prev { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }

        public DoubleLinkedListNode(T data, DoubleLinkedListNode<T> prev, DoubleLinkedListNode<T> next ) {
            Data = data;
        }
    }
         
}
