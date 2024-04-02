namespace Linked_Lists;

class Program
{
    static void Main(string[] args)
    {
        SinglyLinkedList<int> myList = new SinglyLinkedList<int>();
        myList.Add(12);
        myList.Add(19);
        myList.Add(1);
        Console.WriteLine("Before the deletion: ");
        foreach(int i in myList){
            Console.WriteLine(i);
        }
        myList.DeleteLast();
        myList.DeleteLast();
        myList.DeleteLast();
        Console.WriteLine("After the deletion: ");
        foreach(int i in myList){
            Console.WriteLine(i);
        }
    }
}
