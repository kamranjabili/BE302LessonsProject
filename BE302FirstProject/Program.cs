//using BE302FirstProject.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Service;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Channels;
using BE302FirstProject;
using System.Text;
using BE302FirstProject.Entities;
using BE302FirstProject.Abstract;
using BE302FirstProject.Enums;
using BE302FirstProject.Dtos;
using BE302FirstProject.Delegates;
using BE302FirstProject.Generics;
using System.Collections;

Console.WriteLine("Salam BE302");


#region First Lesson
//int age = 255;


//float pi = 3.14f;
//pi = 3.14567f;
//decimal test = 3.14m;

//double a = 5.1234134;

//char letter = 'A';
//letter = '2';

//string word = "Salam World";

//bool isMaried = false;

//int num1 = 10;
//int num2 = 100;
//int num3 = 101;
//int num4 = 102;

//int num1=0, num2=2, num3=4, num4=6;

//int number = 6;
//Console.WriteLine(number);
//number = 100;
//Console.WriteLine(number);

//double pi = 3.14;

//pi = 2.5;

//string FirstWord = "sdfsd";
#endregion

#region Operators
#region Arithmetic
//int num = 5;
//num = num*2;
//Console.WriteLine(num);
//string word = "Hello";
//Console.WriteLine(word+5);

//int num = 10;
//Console.WriteLine(num%11);

//int num = 10;
//num++; //num = num + 1;
//num--; //num=num-1
//Console.WriteLine(++num + num++); //11+11  num=12
//Console.WriteLine(num);
//Console.WriteLine(num-- + ++num - num); //10 +10 - 10
#endregion

#region Comprison
//int num = 11;
//bool result = 10 < 10;
//bool result = 10 != 11;
//Console.WriteLine(result);
//bool result = "kamran" == "kamran";
//Console.WriteLine(result);

//string result = num == 10 ? "equal" : "not";
//string result = "not";
//if (num == 10) result = "equal";
//Console.WriteLine(result);
#endregion

#region Logical
//string username = "admin";
//string password = "admin123";

//if(!(username=="admi") || password == "admin12")
//{
//    Console.WriteLine("Welcome");
//}
//else
//{
//    Console.WriteLine("username or password is wrong");
//}
#endregion

#region Assignment
//int x = 10;
//x += 10; //x=x+10
//x *= 4; //x=x*4
//Console.WriteLine(x);

//x %= 7;
//Console.WriteLine(x);
#endregion

#region Bitwise
//Console.WriteLine(5^3); //101 ^ 011 =   110 = 6
#endregion

#region Task
//int a = 5;
//int b = 70;

//int c = a; //50
//a = b; //110
//b = c;

//a= a + b; // a=50+110=160;
//b = a - b; //b=160-110=50;
//a = a - b; //a=160-50=110

//a = a ^ b; //101^111 = 10 = 2(a) (b=7)
//b= b ^ a; // 111 ^ 010 =   101 = 5(b) a=2
//a= a ^ b; //010 ^ 101=111=7

//Console.WriteLine(a); //110
//Console.WriteLine(b); //50
#endregion

#region Var, Dynamic
//var number = 3.14;
//int a;

//dynamic x = 10;
//x = "asasf";
//x = true;
//x = 'a';
#endregion
#endregion

#region Loops

//int count = 0;

//do
//{
//    Console.WriteLine(count);
//    count++;
//}
//while (count > 1);

//while (count>1)
//{
//    Console.WriteLine(count);
//    count++;
//}
//int i = 0;
//while (i<=10)
//{
//    i++;
//    if (i == 5) continue;
//    Console.WriteLine(i);
//}

//for (int i = 1; i <= 10; i++)
//{
//    //if (i == 5) break;
//    Console.WriteLine(i);
//}

//for(; ; )
//{
//    Console.WriteLine("Salaaam");
//}

//for (int i = 10; i >= 0; i-=2)
//{
//    Console.WriteLine(i);
//}

//for (int i = -10; i <= 10; i++)
//{
//    if(i>0 && i%2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int n=int.Parse(Console.ReadLine());
//int m=int.Parse(Console.ReadLine());
//int sum = 0;
//for(int i=n; i<=m; i++)
//{
//    sum += i;

//}
//Console.WriteLine(sum);

#region Task

//int n = int.Parse(Console.ReadLine());
//int pow=int.Parse(Console.ReadLine());

//int count = 0;
//int temp = n;

//while (temp % pow == 0) //10
//{
//    temp = temp / pow; //n=5
//    count++;
//}

//if (temp == 1)
//{
//    //Console.WriteLine(n+" "+pow+" ededinin ustu "+count+"-dur");
//    Console.WriteLine($"{n} {pow} ededinin ustu {count}-dir");
//}
//else
//{
//    Console.WriteLine(false);
//}

//Console.WriteLine(n == 1 ? true : false);

//if ((n & (n - 1)) == 0) 
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}

//123815 - 6
//int n = int.Parse(Console.ReadLine());
//int count = 0;
//if (n < 0) 
//{
//    n = -n;
//}

//if (n == 0)
//{
//    count++;
//}

//while (n > 0) 
//{
//    n = n / 10;
//    count ++;
//}


//Console.WriteLine(count);

#endregion

#endregion

#region Task
//Console.Write("Ədəd daxil edin: ");
//string input = Console.ReadLine();
//if (!int.TryParse(input, out int number))
//{
//    Console.WriteLine("duzgun eded daxil etttt: ");
//    return;
//}
//if (number <= 1)
//{
//    Console.WriteLine($"{number} nə sadədir, nə də mürəkkəbdir.");
//    return;
//}

//bool sade = true;
//for (int i = 2; i*i <= number; i++)
//{
//    if (number % i == 0)
//    {
//        sade = false;
//        break;
//    }
//}

//if (sade)
//    Console.WriteLine($"{number} sadə ədəddir.");
//else
//    Console.WriteLine($"{number} mürəkkəb ədəddir.");


#endregion

#region Array & String
//string[] words =  { "Ilkin","Riad","Aysun","Sabir","Yaqub","Turgut","Ferhad"};
//string[] words2 = { "Ruslan", "Yaqub" };

//int[] numbers = { 1, 2 };

//numbers[0] = 3;

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//int[,] massive = { 
//                    {1,2 ,3},
//                    {6,4 , 5 }
//                  };

//Console.WriteLine(massive[1,2]);
//Console.WriteLine(words.Length);

//for (int i = 0; i < words.Length; i++)
//{
//    Console.WriteLine(words[i]);
//}

//foreach(string item in words)
//{
//    Console.WriteLine(item);
//}

//for (int i = words.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(words[i]);
//}

//string text = "Salam";

//text[0] = "s";

//Console.WriteLine(text[0]);
//foreach (string item in text)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Function
//Console.WriteLine(Sum(5, 6));

////DRY - do not repeat yourself
//int Sum(int num1,int num2) //num1,num2 - parameters
//{
//    int result=num1 + num2;
//    return result;
//}

//Console.WriteLine(Sum(3,-9));  //5 & 6 - argument
//Console.WriteLine(Sum(333,-9));  //5 & 6 - argument

//decimal Average(int a,params int[] arr)
//{
//    Console.WriteLine(a);
//    decimal result = 0;
//    foreach (var item in arr)
//    {
//        result += item;
//    }
//    result /= arr.Length;
//    return result;
//}

////int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

//Console.WriteLine(Average(1, 2, 3, 4, 5, 6, 7, 8, 9));

//string GetMaxLengthStr(string s1, string s2)
//{
//    if (s1.Length > s2.Length)
//    {
//        return s1;
//    }
//    return s2;
//}

//Console.WriteLine(GetMaxLengthStr("Riad", "Nesib"));

//void Print(string name,string surname)
//{
//    Console.WriteLine($"name: {name}; surname: {surname}");
//}


//Print("Eli", "Huseynov");

//void PrintMaxNumber(int n1, int n2)
//{
//    if(n1 > n2)
//    {
//        Console.WriteLine(n1);
//        return;
//    }
//    Console.WriteLine(n2);
//}

//PrintMaxNumber(1,2);

//bool IsExist(string word="Salam",char letter='a')
//{
//    foreach (char c in word)
//    {
//        if (c == letter) return true; 
//    }
//    return false;
//}

//Console.WriteLine(IsExist());
//Console.WriteLine(IsExist("Sagol"));
//Console.WriteLine(IsExist("Sagol",'b'));
//kamran //kaanrm
#region Task

//string word = "kamran"; //['a','a','m','r','k','n'] char[]

//Console.WriteLine(string.Join(',',SortForAToZ(word)));

//string word1 = "kaamrn";
//string word2 = "kamran";
//Console.WriteLine(IsEqualStr(word1,word2));
//bool IsEqualStr(string str1, string str2)
//{
//    if (str1.Length != str2.Length)
//    {
//        return false;
//    }

//    char[] arr1=SortForAToZ(str1); //['a','m','r','k','k','n']
//    char[] arr2=SortForAToZ(str2); //['a','a','m','r','k','n'] 

//    for (int i = 0; i < arr1.Length; i++)
//    {
//        if(arr1[i] != arr2[i])
//        {
//            return false;
//        }
//    }
//    return true;
//}

//char[] SortForAToZ(string str)
//{
//    char[] arr = ConvertToCharMassiv(str);

//    for (int i = 0; i < arr.Length; i++) //i=0 
//    {
//        char temp=arr[i]; //k
//        for(int j=i+1; j < arr.Length; j++) //j=1
//        {
//            if (arr[i] > arr[j]) //k>a
//            {
//                arr[i] = arr[j];
//                arr[j] = temp;
//                temp = arr[i];
//            }
//        }   
//    }

//    return arr;
//}


//char[] ConvertToCharMassiv(string str)
//{
//    char[] result = new char[str.Length];
//    for (int i = 0; i < str.Length; i++)
//    {
//        result[i] = str[i];
//    }
//    return result;
//}
//PrintNumbers(4);

//int PrintNumbers(int n)
//{
//    if (n == 0)
//    {
//        Console.WriteLine(n);
//        return n;
//    }
//    Console.WriteLine(n);
//    return PrintNumbers(n-1);   
//}

//4 PrintNumbers(3)
//3 PrintNumbers(2)
//2 PrintNumbers(1)
//1 PrintNumbers(0)
//0
#endregion
#endregion

#region Class
//string name = "Riad";
//string surname = "Eliyev";
//int age = 18;

//string name1 = "Eli";
//string surname1 = "Huseynov";
//int age1 = 13;

//string name2 = "Aysun";
//string surname2 = "Shirelizade";
//int age2 = 19;

#region Anonimous object
//var stu1 = new
//{
//    name= "Riad",
//    surname="Eliyev",
//    age=18
//};

//var stu2 = new
//{
//    name = "Aysun",
//    surname = "Shirelizade",
//    age = 19
//};

//Console.WriteLine($"{stu1.name} {stu1.surname} {stu1.age}");
//Console.WriteLine($"{stu2.name} {stu2.surname} {stu2.age}");
#endregion

//Student stu1 = new("Riad", "Eliyev",18);
//Console.WriteLine(stu1.GetFullInfo());

//Student stu2= new();
//stu2.Name = "Aysun";
//stu2.Surname = "Shirelizade";
//stu2.Age = 19;
//Console.WriteLine(stu2.GetFullInfo());

//Student s1 = new Student();
//Teacher t1 = new Teacher();

//Person[] people = {s1,t1};

//foreach (Person person in people)
//{
//    person.Info();
//}
#endregion

#region Reference&value
//int a = 5;
//int b = a; //b=5
//a = 10;

//Console.WriteLine($"a={a}");
//Console.WriteLine($"b={b}");



//arr1[0] = 100;

//Console.WriteLine($"arr1[0]={arr1[0]}");
//Console.WriteLine($"arr2[0]={arr2[0]}");

//Person p1=new Person("Nesib","Esgerbeyli",18);
//Person p3=new Person("Nesib","Esgerbeyli",18);
//Person p2 = p1;

//p1.Name = "Riad";

//Console.WriteLine(p1==p2);
//Console.WriteLine(p1==p3);

//Console.WriteLine($"p1={p1.Name}");
//Console.WriteLine($"p2={p2.Name}");
//Console.WriteLine($"p3={p3.Name}");

//int num = 10;
//ChangeNumber(num);
//Console.WriteLine($"num: {num}");

//void ChangeNumber(int number)
//{
//    number = 100;
//    Console.WriteLine($"function: {number}");
//}

//int[] arr = { 1, 2, 3 };
//ChangeArr(arr);
//Console.WriteLine(arr[0]);

//void ChangeArr(int[] arr)
//{
//    arr[0] = 1000;
//    Console.WriteLine($"function: {arr[0]}");
//}

//int num=10;
//ChangeNumber(ref num);
//Console.WriteLine($"num: {num}");

//void ChangeNumber(ref int number)
//{
//    number = 100;
//    Console.WriteLine($"function: {number}");
//}
#endregion

#region Access modifiers
#region Public - class & class members. Referenced Assemblies, Instance, Inheretance
//Product p1 = new();
//p1.Name = "IPhone 16";
//Console.WriteLine(p1.Name);
#endregion

#region Protected - class members. Can be used in drived Class(inheretance)
//Product product = new();
//product.Test();
#endregion

#region Private - class members. Only in own class
//Product product = new();
//product._price = 10M;
#endregion

#region Encapsulation
//Product p1 = new();
//p1.SetPrice(-100);
//Console.WriteLine(p1.GetPrice());
//p1.Price = -100;
//Console.WriteLine(p1.Price);
#endregion

#region Internal - class and all class members. Accecibility only in own assembly.
//MailAddress mail = new();
//mail.Title = "asddf";
#endregion

#region Protected Internal
//MailAddress mail = new();
#endregion

#region Private Protected

#endregion
#endregion

#region Namespace
//Test test = new();
//BE302FirstProject.Product product = new();
#endregion

#region Static
//Product.count = 10;
//Console.WriteLine(Product.count);

//Product product = new Product();
//product.Id = 0;

//Product p1 = new Product();
//Console.WriteLine("count: "+Product.count);
//Console.WriteLine("p1 id: "+p1.Id);
//Product p2 = new Product();
//Console.WriteLine("count: " + Product.count);
//Console.WriteLine("p2 id: " + p2.Id);
//Product p3 = new Product();
//Console.WriteLine("count: " + Product.count);
//Console.WriteLine("p3 id: " + p3.Id);

//Product.count = 1;
//Product p1 = new();
//Product p2 = new();
//Product p3 = new();
//Product.GetInfo();
//Console.WriteLine(Product.MyProperty);

#endregion

#region Extensions
//MyMath math = new MyMath();
//MyMath.Power(5,3);

//int a = 5;
//a.ToString();
//a.Power(3);

//string word = "Hello World";
//word.StrToArray();
#endregion

#region String

//string str = "ads asfsha";

//string[] arr=str.Split("sf");
//foreach(string s in arr)
//{
//    Console.WriteLine(s);
//}
//Console.WriteLine(str.IndexOf('a'));
//Console.WriteLine(str.LastIndexOf('a'));
//Console.WriteLine(str.StartsWith(" "));
//Console.WriteLine(str.MyTrim());
//Console.WriteLine(string.IsNullOrWhiteSpace(str));
//Console.WriteLine(str.Trim().Length);

//var result = str.Reverse();
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}
//MyString myString = new MyString();
//var res=myString.Reverse(str);
//Console.WriteLine(res);
//Console.WriteLine(str.ReverseWithStrBuilder());
#endregion

#region StringBuilder
//StringBuilder sb = new();
//sb.Append("aaaaaaaaaaaa");
//sb.AppendLine("test");
//sb.AppendLine("test");
//sb.Replace("t","a");
//sb.Insert(5, 'b');
//Console.WriteLine(sb);
//Console.WriteLine(sb.Capacity);
//Console.WriteLine(sb.Length);
#endregion

#region Array
//int[] arr = { 10,2,-3,40,15};
//Console.WriteLine(arr.Average());
//string[] strArr = { "Nesib", "Anar", "Riyyyyyad", "Aysun" };
//Array.Sort(strArr);
//Array.Sort(arr);
//var reverseArr=arr.Reverse();
//foreach (var i in strArr)
//{
//    Console.WriteLine(i);
//}
#endregion

#region Abstract - don't get object instance, abstract method contains
//BaseEntity entity=new();

//BaseEntity -> Employee -> Engineer
//                       -> HR

//HR hR = new HR();
//Engineer engineer = new Engineer();
//Employee[] employees = { engineer,hR };

//foreach (Employee employee in employees)
//{
//    #region First - is operator
//    //if(employee is Engineer e)
//    //{
//    //    Console.WriteLine(e.Description);
//    //}
//    #endregion

//    #region Second - as
//    //Engineer? e = employee as Engineer;
//    //if(e is not null)
//    //{
//    //    Console.WriteLine(e.Description);
//    //}
//    #endregion

//    #region try catch
//    //try
//    //{
//    //    Console.WriteLine(((Engineer)employee).Description);
//    //}
//    //catch (Exception ex)
//    //{
//    //    Console.WriteLine(ex.Message);
//    //}
//    //finally 
//    //{
//    //    Console.WriteLine("finally");
//    //}
//    #endregion

//}
#endregion

#region Sealed
//HR hR = new HR();
#endregion

#region Casting
//string data = "123";
//try
//{
//    int a = int.Parse(data);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//int result;
//int.TryParse(data, out result);
//Console.WriteLine(result);


//double num2=123.43;
//int number = (int)num2;
//Console.WriteLine(number);

//Manat manat = new(340);

//Dollar dollar = (Dollar)manat;
//Console.WriteLine(dollar.Usd);
#endregion

#region Interface
//ISum sum = new Calculate();
#endregion

#region Indexer
//string word = "Hello World";
//Console.WriteLine(word[3]);

//Library library = new("Libraff", 100);
//library[0] = "Xemse";
//Console.WriteLine(library[0]);
//library[200] = "Ali ve Nino";
#endregion

#region Nullable value type
//char? x = 'a';
//x = null;
#endregion

#region Enum
//int day = 2;
//switch (day)
//{
//    case (int)Weekdays.Monday:
//    case (int)Weekdays.Tuesday:
//    case (int)Weekdays.Wednesday:
//    case (int)Weekdays.Thursday:
//    case (int)Weekdays.Friday:
//        Console.WriteLine("Weekday");
//        break;
//    case (int)Weekdays.Saturday:
//    case (int)Weekdays.Sunday:
//        Console.WriteLine("Weekend");
//        break;
//    default:
//        Console.WriteLine("Duzgun format daxil edin");
//        break;
//}
#endregion

#region Record
//Car car1 = new("BMW", "x7");
//Car car2 = new("BMW", "x7");

//Car car3 = car1 with { Model = "F30" };
//Console.WriteLine(car3);
#endregion

#region Struct
Area area = new();
#endregion

#region Delegate

//int[] arr = { -1, 0, 30 };

//int Sum(int[] arr,Check func)
//{
//    int result = 0;
//    foreach (int num in arr)
//    {
//        if(func(num))
//        {
//            result += num;
//        }
//    }
//    return result;
//}

//Console.WriteLine(Sum(arr,isNegative));
//Console.WriteLine(Sum(arr,isPositive));
//Console.WriteLine(Sum(arr,IsEven));

//bool isNegative(int num) => num < 0;
//bool isPositive(int num) => num > 0;
//bool IsEven(int num) => num % 2 == 0;



//int a = 5;
//Check check = isNegative;
//Console.WriteLine(check.Invoke(5));

//Print print = PrintLastChar;
//print("Nesib");

//Print p = delegate (string s)
//{
//    Console.WriteLine(s[0]);
//};

//void PrintLastChar(string str)
//{
//    Console.WriteLine(str[^1]);
//}

//Print p = s => Console.WriteLine(s[0]);
//p += PrintLastChar;
//p += s => Console.WriteLine(s.Length);
//p("Nesib");
#endregion

#region Generic
//MyNonGenericList strList = new();

//strList.Add("Nesib");
//strList.Add("Riad");
//strList.Add(10);

//MyGenericList<string> myStrList = new();
//myStrList.Add("Nesib");

//MyGenericList<Person,object> myList = new();

//MyGenericList<int> myIntList = new();
//myIntList.Add(1);

//Action<int> action = s => { Console.WriteLine(s); };
//Func<string,int> func=

//ArrayList arrayList = new ArrayList();
//arrayList.Add("afasf");
//arrayList.Add('a');
//arrayList.Add(10);
//arrayList.Remove(10);
//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}

List<string> sList = new();
sList.Add("Nesib");
sList.Add("Aysun");
sList.Add("Riad");

Console.WriteLine(sList.Contains("Aysun"));
sList.Append("Mustafa");
sList.Add("Nesib");
sList.Add("Aysun");
sList.Add("Riad");
Console.WriteLine(sList.All(s => s.StartsWith('A')));
Console.WriteLine(sList.Count);
Console.WriteLine(sList.Capacity);

foreach (string s in sList)
{
    Console.WriteLine(s);
}
#endregion