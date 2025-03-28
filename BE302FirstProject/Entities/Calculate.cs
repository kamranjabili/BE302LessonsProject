using BE302FirstProject.Abstract;

namespace BE302FirstProject.Entities;

public class Calculate : ISum,IDivide,IMultiple,IDifference
{
    public decimal Difference(decimal n1, decimal n2)
    {
        return n1 - n2;
    }

    public decimal Divide(decimal n1, decimal n2)
    {
        return n1/ n2;
    }

    public decimal Multiple(decimal n1, decimal n2)
    {
        return n1 * n2;
    }

    public decimal Sum(decimal n1, decimal n2)
    {
        return n1+n2;
    }
}
