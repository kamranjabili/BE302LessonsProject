namespace BE302FirstProject.Abstract;

//public interface ICalculate
//{
//    decimal Sum(decimal n1, decimal n2);
//    decimal Difference(decimal n1, decimal n2);
//    decimal Multiple(decimal n1, decimal n2);
//    decimal Divide(decimal n1, decimal n2);
//}

public interface ISum
{
    decimal Sum(decimal n1, decimal n2);
}

public interface IDifference
{
    decimal Difference(decimal n1, decimal n2);
}

public interface IMultiple
{
    decimal Multiple(decimal n1, decimal n2);
}

public interface IDivide
{
    decimal Divide(decimal n1, decimal n2);
}


