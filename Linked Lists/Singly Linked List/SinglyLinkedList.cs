using System.Collections;

namespace Linked_Lists;

/// <summary>
///     Represents the singly linked list of the specified type.
/// </summary>
/// <remarks>
///     A singly linked list is one in which each cell is connected to the following cell by a reference.
/// </remarks>
/// <typeparam name="T">
///     The type that is being stored.
/// </typeparam>
public class SinglyLinkedList<T> : IEnumerable<T>, ILinkedList<T>
{
    /// <summary>
    ///     Gets the top cell (the first cell) of the singly linked list. Or <c>null</c> if the singly linked list is empty.
    /// </summary>
    public Cell<T>? Top { get; private set; } = null;

    /// <summary>
    ///     Gets the bottom cell (the last added item) of the singly linked list. Or <c>null</c> if the singly linked list is empty.
    /// </summary>
    public Cell<T>? Bottom { get; private set; } = null;
    
    /// <summary>
    ///     Gets the number of cells (<c>Cell</c>) that are contained in the singly linked list.
    /// </summary>
    public int Length { get; private set; } = 0;
    public void Add(T data){
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        Cell<T> newCell = new Cell<T>(){
            Data = data
        };

        if(Top is null){
            Top = newCell;
            Bottom = Top;
        }
        else{
            Bottom!.Next = newCell;
            Bottom = newCell;
        }

        Length ++;
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

    public void Prepend(T data){
        // Runtime O(1).

        ArgumentNullException.ThrowIfNull(data);

        if(Top is null){
            Add(data);
        }
        else{
            Cell<T> newCell = new Cell<T>(){
                Data = data
            };

            newCell.Next = Top;
            Top = newCell;
            
            Length ++;
        }
    }

    public void DeleteLast(){
        // Runtime O(N).

        if(Top is null){
            throw new InvalidOperationException("The singly linked list is empty.");
        }

        if(Bottom == Top){
            Clear();
        }
        else{
            Cell<T>? temp = Top;
            while(temp is not null){
                if(temp.Next == Bottom){
                    Bottom = temp;
                    Bottom.Next = null;
                    break;
                }

                temp = temp.Next;
            }
            Length --;
        }
    }

    public void Clear(){
        // Runtime O(1).

        Top = null;
        Bottom = null;

        Length = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        // Runtime O(N).

        Cell<T>? temp = Top;

        while(temp is not null){
            yield return temp.Data;
            temp = temp.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}