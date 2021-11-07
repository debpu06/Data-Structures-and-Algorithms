public interface IStack<T>
{
    bool IsEmpty();
    T Pop();
    void Push(T element);
}