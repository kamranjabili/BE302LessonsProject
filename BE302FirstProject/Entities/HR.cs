namespace BE302FirstProject.Entities;

internal sealed class HR : Employee
{
    public string Level { get; set; }
    public override void GetSalary()
    {
        Console.WriteLine(3000);
    }
    public override void InfoEntity()
    {
        Console.WriteLine("HR");
    }

}
