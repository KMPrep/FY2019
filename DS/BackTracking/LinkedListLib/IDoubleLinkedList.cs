namespace LinkedListLib {
    public interface IDoubleLinkedList<T> {
        DoubleLinkedListNode<T> Head { get; }

        bool AddNewNode(DoubleLinkedListNode<T> node, uint posIndex, out string errorMessage);
        bool DeleteNode(uint posIndex, out string errorMessage);
        int GetLength();
    }
}