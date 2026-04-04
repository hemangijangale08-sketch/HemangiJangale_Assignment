// ------------------------------------------------------------
// Class: Employee
// Description: Demonstrates Encapsulation using properties
// ------------------------------------------------------------

public class Employee
{
    // Private fields (data hiding)
    private int id;
    private string name;
    private double salary;

    // Public property for Id
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    // Public property for Name
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // Public property for Salary with validation
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0) // Validation logic
            {
                salary = value;
            }
        }
    }
}
