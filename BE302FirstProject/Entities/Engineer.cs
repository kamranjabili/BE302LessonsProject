using BE302FirstProject.Abstract;

namespace BE302FirstProject.Entities;

public class Engineer : Employee,ISum
{
    public Engineer()
    {
        Description = "Engineer value";
    }
    public string Description { get; set; }
    public override void GetSalary()
    {
        Console.WriteLine(5000);
    }

    public sealed override void InfoEntity()
    {
        Console.WriteLine("Engineer");
    }

    public decimal Sum(decimal n1, decimal n2)
    {
        throw new NotImplementedException();
    }
}

class Developer:Engineer
{
    public override void GetSalary()
    {
        base.GetSalary();
    }
}
