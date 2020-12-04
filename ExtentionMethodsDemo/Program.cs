using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethodsDemo
{
    class Program
    {
        public void m1()
        {
            Console.WriteLine("M1");
        }

        public void m2()
        {
            Console.WriteLine("M2");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.extention();  // now we can call the extention method using Program class Reference 

            int i = 14;   // i am going to find the 14th Fibonacci term

            Console.WriteLine(i.fibo());  // calling the extention fibo method using int type reference

            string str = "Arunava Banerjee ";   // I will add a method to string that would prtint the number of vowels

            Console.WriteLine(str.countvowels());
        }
    }


    static class ExtendProgramMethods
    {

       public  static void extention(this Program p)    // extention method of program class
        {
            Console.WriteLine(" EXTENTION ");
        }

        // Using Extention methods with Structures --> I am going to add a function 
        // which will return me the nth Fibonacci  term


       public static int fibo(this Int32 x)
        {
            if(x==0)
            {
                return 0;
            }

            if(x<3)
            {
                return 1;
            }

            return fibo(x - 1) + fibo(x - 2);

        }


        public static int countvowels(this string s)  // this method now belongs to string class
        {
            int count = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'   )
                {
                    count++;
                }

            }

            return count;
        }         




    }








}
