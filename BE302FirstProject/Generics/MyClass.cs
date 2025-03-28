namespace BE302FirstProject.Generics;

//class MyNonGenericList
//{
//    private object[] _arr;

//    public void Add(object item)
//    {
//        Array.Resize(ref _arr, _arr.Length+1);
//        _arr[^1]=item;
//    }

//    public void GetAll()
//    {
//        foreach(object item in _arr)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

class MyGenericList<T,K>
    //where T:K
    //where T : struct,ITest
    //where T : class,ITest,new()
    //where T : ITest
    //where T : class, new()
    //where T : struct
    //where T : class
{
    private T[] _arr;

    public void Add(T item)
    {
        Array.Resize(ref _arr, _arr.Length + 1);
        _arr[^1] = item;
    }

    public void GetAll()
    {
        foreach (T item in _arr)
        {
            Console.WriteLine(item);
        }
    }
}


class Person:ITest
{
    public Person()
    {
        
    }
}

interface ITest
{

}