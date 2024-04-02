using System.Collections;

namespace Linked_Lists;

/// <summary>
///     Represents the doubly linked list of the specified type.
/// </summary>
/// <remarks>
///     A doubly linked list is one in which each cell is connected to the following cell, and to the previous cell.
/// </remarks>
/// <typeparam name="T">
///     The type that is being stored.
/// </typeparam>
public class DoublyLinkedList<T> : IEnumerable<T>, ILinkedList<T>
{
    /// <summary>
    ///     Gets the top cell (the first cell) of the doubly linked list. Or <c>null</c> if the doubly linked list is empty.
    /// </summary>
    public DoublyCell<T>? Top { get; private set; } = null;

    /// <summary>
    ///     Gets the bottom cell (the last added item) of the doubly linked list. Or <c>null</c> if the doubly linked list is empty.
    /// </summary>
    public DoublyCell<T>? Bottom { get; private set; } = null;

    /// <summary>
    ///     Gets the number of cells (<c>Cell</c>) that are contained in the doubly linked list.
    /// </summary>
    public int Length { get; private set; } = 0;

    public void Add(T data)
    {
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        DoublyCell<T> cell = new DoublyCell<T>(){
            Data = data
        };

        if(Top is null){
            Top = cell;
            Bottom = Top;
        }
        else{
            Bottom!.Next = cell;
            cell.Previous = Bottom;
            Bottom = cell;
        }

        Length ++;
    }

    public void Clear()
    {
        // Runtime O(1).

        Top = null;
        Bottom = null;

        Length = 0;
    }

    public void DeleteLast()
    {
        // Runtime O(1).

        if(Top is null){
            throw new InvalidOperationException("The doubly linked list is empty.");
        }

        if(Bottom == Top){
            Clear();
        }
        else{
            Bottom = Bottom!.Previous;

            Length --;
        }
    }

    public bool Exists(T value){
        // Runtime O(N).

        ArgumentNullException.ThrowIfNull(value);

        foreach(T data in this){
            if(data!.Equals(value)){
                return true;
            }
        }

        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        // Runtime O(N).

        DoublyCell<T>? temp = Top;

        while(temp is not null){
            yield return temp.Data;
            temp = temp.Next;
        }
    }

    public void Prepend(T data)
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}