namespace Insertion_Sort;

public class Person : IComparable<Person>{
    public string Name { get; private set; }
    public byte Age { get; private set; }

    public Person(string name, byte age){
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Hello my name is {Name}, I am {Age} years old.";
    }

    public int CompareTo(Person? other)
    {
        if(other is null || this.Age > other.Age){
            return 1;
        }
        if(other.Age > this.Age){
            return -1;
        }
        else{
            return 0;
        }
    }
}