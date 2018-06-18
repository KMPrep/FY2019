namespace LinkedListLib {
    public interface ISingleLinkedList<T> {
        SingleLinkedListNode<T> Head { get; }

        bool AddNewNode(SingleLinkedListNode<T> node, uint posIndex, out string errorMessage);
        bool DeleteNode(uint posIndex, out string errorMessage);
        int GetLength();
    }
}