namespace Assignment1;

public class Person
{
    private string _name;
    private int _age;

    public Person(int age, string name)
    {
        _age = age;
        _name = name;
    }

    
    public int Age
    {
        get { return _age; }
        set { _age = value;  }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value;  }
    }
}
