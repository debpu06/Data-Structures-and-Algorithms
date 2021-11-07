// public class LinkedList<T, K>
// {
//     Node head;

//     public LinkedList()
//     {

//     }

//     //-O(n)
//     public void Delete(K key)
//     {
//         var node = Search(key);

//         Delete(node);
//     }

//     //O(1)
//     public void Delete(Node element)
//     {
//         if (element.previous != null)
//             element.previous.next = element.next;
//         else
//             head = element.next;
//         if (element.next != null)
//             element.next.previous = element.previous;
//     }

//     //O(1)
//     public void Insert(T element)
//     {
//         var node = new Node()
//         element.next = head;
//         if (head != null)
//             head.previous = element;
//         head = element;
//         element.previous = null;
//     }

//     //Θ(n)
//     public Node Search(K key)
//     {
//         Node current = head;
//         while (current != null && current.key != key)
//         {
//             current = head.next;
//         }

//         return current;
//     }

//     public Node Successor(Node node)
//     {
//         return node.next;
//     }

//     //only implement if doubly linked list
//     public Node Predecessor(Node node)
//     {
//         return node.previous;
//     }

//     public class Node
//     {
//         public Node next;
//         //only implement previous if its a doubly linked list
//         public Node previous;
//         K key;
//         T element;
//     }
// }