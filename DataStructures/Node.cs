public abstract class Node<T>
{
    public Node(T element){
        this.Element = element;
    }
    public T Element { get;set; }
    public Node<T> Next { get;set; }
}