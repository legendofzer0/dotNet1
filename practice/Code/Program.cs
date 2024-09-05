using System;
using System.Collections;
using System.Collections.Generic;
/*//Dog dog1 = new Dog("Rex");
//Cat cat1 = new Cat("Whiskers");
Jenish jenish = new Jenish("test", 15);
//dog1.Speak();
//cat1.Speak();
jenish.DisplayNameAge();
jenish.DisplayNameAge("colle");*/

//!Encapsulation
/*Encap encap = new Encap();
encap.setName("Help",10);

name=encap.getName();
age=encap.getAge();

Console.Writeline(name+" "+age);*/

using Code;
using Code.Chapter_2;
using static Code.DeligateTest;
using static Code.tested;

/*MultiClass classes = new MultiClass();
classes.add();
classes.sub();
classes.mul();
classes.div();*//*
TestMain test = new TestMain();
test.Main();*/
//String
/*string test = "Test String";
string test2 = "Test  test         ";
Console.WriteLine("Test Concat" + test);
Console.WriteLine(test.Length);
char A = test[5];
Console.WriteLine(A);   
string B = test.Substring(1,3);
Console.WriteLine(B);
Console.WriteLine(test.Replace(

"T","B"));
Console.WriteLine(test);
Console.WriteLine(test.ToUpper());
Console.WriteLine(test.ToLower());
Console.WriteLine(test2);
Console.WriteLine(test2.Trim());

//Array



int [] numArray = new int[10];
numArray[0] = 5;

int[] nubArray = { 1,2,3,4,5,6,7,8,9,10};
Console.WriteLine(nubArray[5]);
Console.WriteLine(numArray[0]);


int searchValue = 9;
int index= Array.IndexOf(nubArray, searchValue);
Console.WriteLine("5 in "+index);
//loop

for (int i = 0; i < nubArray.Length; i++)
{
    Console.WriteLine(nubArray[i]);
}
Console.WriteLine("------");
foreach (int i in nubArray)
{
    Console.WriteLine(i);
}
Console.WriteLine("------");
int j = 0;
while (j != numArray.Length)
{
    Console.WriteLine(nubArray[j]);
    j=j+1;
}
Console.WriteLine("------");
j=0;
do
{
    Console.WriteLine(numArray[j]);
    j=j+1;
}while (j != numArray.Length);

*/

//methods
/*int one = 1;
int two = 2;

paramsClass testParam= new paramsClass();
testParam.Value(one,two);
testParam.Reference(ref one, ref two);
*/

//boxing and unboxing


//boxing
/*int num = 123;
Object obj = num;
Console.WriteLine(obj);
//unboxing
Object obj3 = 1234;
int num2 = Convert.ToInt32(obj3);
Console.WriteLine(num2);
*/

//Optional Params
/*optionalParams param = new optionalParams();
param.Jenish("Jenish",20,"Maharjan");*/

//internal  acess
//ShieldClass shi = new ShieldClass();
//shi.run();

//Static CLass
//StaticClass.Hello();
//static Count
/*CountClass count1= new CountClass();
CountClass count2 = new CountClass();
CountClass count3 = new CountClass();
CountClass.Counted();*/

//Abstract
/*newAbbs abs= new newAbbs(); 
abs.run();*/

//finallier
/*for (int i = 0; i < 10; i++)
{
    Finalizer finalizer = new Finalizer();
}


Finalizer2 finalizer2 = new Finalizer2();
finalizer2.finaler();

GC.Collect();
GC.WaitForPendingFinalizers();

Console.WriteLine("End of Main method");*/


//multilevel
public delegate void Print();
public delegate TResult Func<in T, out TResult>(T arg);
internal class Good
{

    static void Main(string[] args)
    {
		/*GenericClass<string, string, int> gen = new GenericClass<string, string, int>("BMW", "MS52", 2022);
		gen.getData();*/

		/*       Dictionary<int,String> keyValuePairs = new Dictionary<int,String>();
               keyValuePairs.Add(1, "New");
               keyValuePairs.Add(2, "good");
               keyValuePairs.Add(3, "Test");

               foreach(KeyValuePair<int,String> pair in keyValuePairs)
               {
                   System.Console.WriteLine("Key={0},Value={1}",pair.Key,pair.Value);
               }*/
		//queue
		/*Queue<string> queue = new Queue<string>();
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
*/
		//stack
		/*Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }*/
		//List
		/*List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        list.Remove(2);
        list.RemoveAt(0);
        foreach (int i in list) { 
            Console.WriteLine(i);
        }*/

		//ArrayList
		/* ArrayList array = new ArrayList();
         array.Add(1);
         array.Add(2);
         array.Add(3);
         array.Add(4);
         //array.Add("Test");

         ArrayList array1 = new ArrayList();
         array1.Add("test");
         foreach (int i in array) { 
             Console.WriteLine(i);
         }*/

		//delegate
		/* DeligateTest obj = new DeligateTest();
         addnum del_obj1 = new addnum(obj.sum);
         subnum del_obj2 = new subnum(obj.subtract);

         // pass the values to the methods by delegate object
         del_obj1(100, 40);
         del_obj2(100, 60);*/

		//Multicast Delegate
		/*MultiDeligate mul = new MultiDeligate();
        Print mu=  mul.Method1;
        mu += mul.Method2;
        mu();
        mu -= mul.Method1;
		mu();*/
		/*//Function Delegate
		Func<int, int, int> add = Sum;

		int result = add(10, 10);

		Console.WriteLine(result);

		Console.ReadKey();*/

        //Action Deligate
	/*	ActionDeligate ac = new ActionDeligate();
		Action printActionDel = ac.ActionDEl; 
        printActionDel();

        //Predicate Deligate
        PredigateDeligate pre = new PredigateDeligate();
        Predicate<int> boo = pre.Bo;
        Console.WriteLine(boo(-5));*/

        //Ananomus Deligate
		/*Func<int, int, int> sum = delegate (int a, int b) { return a + b; };
        Console.WriteLine(sum(1,3));*/

        //Lambda Expresstion
        /*Func<int,int,int> sub= (x,y)=>{return x-y;};
        Console.WriteLine(sub(1,2));*/

        //Exception
        /*ArthExp ar = new ArthExp();
        ar.exe();*/
       /* NestedExp nested = new NestedExp();
        nested.Nest();
*/
	
    //CustomException
    NewExp news = new NewExp();
        news.exp();
    }
}

