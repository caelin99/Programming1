namespace Opgave5;

public class GymMember
{
    public string Name { get; }
    public int Age { get; set; }

    public int Visits
    {
        get;
        set
        {
            if (value >= 0)
            {
                field = value;
            }
        }
    }

    public GymMember(string name, int age, int visits)
    {
        Name = name;
        Age = age;
        Visits = visits;
    }

    public bool IsRegularVisitor()
    {
        return Visits >= 8;
    }
}