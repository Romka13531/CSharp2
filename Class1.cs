using System;
using System.Threading;

internal class Program
{
    public static void Main(string[] args)
    {
        MyString.MyString str3 = new MyString.MyString("Hello ");
        MyString.MyString str = new MyString.MyString("Hello ");
        MyString.MyString str1 = new MyString.MyString("World");
        MyString.MyString str2 = new MyString.MyString("!");
        //str = str.Concat(str1);
        //str = str.Concat(str2);
        Console.WriteLine(str1.IndexOf('r'));
        str = str + str1 + str2;
        Console.WriteLine(str);
        Console.ReadLine();
    }
}