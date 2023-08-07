using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SchoolManagment.Console
{
   
    // fName =Ahmed, sName=Mohammed, faName= Gubran => fName+" "+sName+" "+faName Ahmed Mohammed Gubran
    class Program
    {
        static void MyMethod(string fname , int age)
        {
            System.Console.WriteLine(fname + " is " + age);
        }
        static int MySecondMethod(int x)
        {
            return x + 18;
        }
        static int MyThirdMethod(int x , int y)
        {
            return x + y;
        }

        static void MakingChild(string child1 , string child2 , string child3)
        {
            System.Console.WriteLine("The adult child is: " + child1);
        }

        static int MultipleTwoNum(int x, int y)
        {
            return x * y;
        }
        static double PlusTwoNum(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // C# Comments    ctrl+c 
            //    UnComments  ctrl+u
            // /*   */
            //System.Console.WriteLine("Hello World!");
            //System.Console.WriteLine("I am Learning C#");
            //System.Console.WriteLine("It is awesome!");
            //System.Console.WriteLine(3 + 3);
            //System.Console.WriteLine("Enter X value : ");
            //int x = Convert.ToInt32(System.Console.ReadLine());

            //System.Console.WriteLine("Enter Y value : ");
            //int y = Convert.ToInt32(System.Console.ReadLine());
            //System.Console.WriteLine("X+Y=" + (x + y));  //string.Concat("X+Y =", (x + y)));

            //variables : 
            //int myVar;
            //myVar = 5;
            //double myDoubleNum = 5.99;
            //char myLetter = 'A';
            //bool myBool = true;
            //string myText = "Hello";
            //System.Console.Write("value : " + myVar + "\n");
            //System.Console.Write("value : " + myDoubleNum + "\n");
            //System.Console.Write("value : " + myLetter + "\n");
            //System.Console.Write("value : " + myBool + "\n");
            //System.Console.Write("value : " + myText + "\n");

            //Constant 
            //const int myNum=15 ; // the value must be write in development mode and can not change in runtime mode 
            //myNum = 20; // error
            //Implicit Casting -> from small number to large number - no nead will do it automatically
            //Explicit Casting -> from large to small - need to specify 
            //double x = 214;

            //int y = (int)x;


            //string status = "false";
            //bool statusInBool =Convert.ToBoolean(status);

            // i++ => i=i+1
            // i-- => i=i-1
            //for (int i = 0; i < 10; i++)
            //{
            //    System.Console.Write("when use i ++  : " + i + "\n");
            //}
            //for (int i = 10; i > 0; i--)
            //{
            //    System.Console.Write("when use i -- : " + i + "\n");
            //}

            //int x = 10;
            ////x += 5; // x = x+5
            ////&& and 
            ////|| or 
            //if (x==5 || y==3)
            //{

            //}


            //int x = 10;
            //System.Console.WriteLine("Math.Pow(x, 2)  : " + Math.Pow(x, 2));

            //int x = 3;
            //switch (x)
            //{
            //    case 0:
            //        System.Console.WriteLine($"X is equal 0"); 
            //        break;
            //    case 1:
            //        System.Console.WriteLine($"X is equal 1");
            //        break;
            //    case 2:
            //        System.Console.WriteLine($"X is equal 2");
            //        break;

            //    default:
            //        System.Console.WriteLine($"X not in my ranage");
            //        break;
            //}

            //string fName = "Ziad";
            //string sName = "Mubarak";
            //int age = 21;
            // System.Console.WriteLine($"Full Name\\{fName[3]} {sName} and his age is {age} ");
             

            //Start with Array

            //string[] cars = { "Toyota", "Ford", "BMW", "Mazda", "Volvo" };
            //for(int i = 0; i < cars.Length; i++)
            //{
            //if(i == 1 || i == 3)
            //{
            // continue;
            //}
            //System.Console.WriteLine(cars[i]);
            //}

            //int[] myNumbers = { 4, 6, 2, 9, 3, 2, 1 };

            //Array.Sort(myNumbers);
            //foreach(int i in myNumbers)
            //{
            //if(i ==3)
            //{
            //   continue;
            //}
            //else if (i == 6)
            //{
            //   break;   
            // }


            //   System.Console.WriteLine(i);
            // }

            // int[] tringNum = { 3, 5, 1, 6, 29, 26, 29, 83, 0, 99 };
            // System.Console.WriteLine(tringNum.Max());
            // System.Console.WriteLine(tringNum.Min());
            // System.Console.WriteLine(tringNum.Sum());
            // System.Console.WriteLine(tringNum.Average());
           

            // start with Method
            MyMethod("Zeyad", 23);
            
            System.Console.WriteLine(MySecondMethod(22));

            int z = MyThirdMethod(6, 29);
            System.Console.WriteLine(z);

            MakingChild(child1: "Ahmed", child2: "Nasser", child3: "Fahad");

            int numOne = MultipleTwoNum(33, 3);
            double numTwo = PlusTwoNum(28, 22);
            System.Console.WriteLine("Int: ", +numOne);
            System.Console.WriteLine("Double: ", +numTwo);
                                                                            
        }
    }
}


// Database -> SqlClient
// Network  -> Socket TCP UDP 