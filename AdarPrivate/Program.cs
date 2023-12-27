using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdarPrivate
{
    internal class Program
    {
        // לכתוב פעולה המקבלת שני מספרים שלמים ומחזירה את הממוצע
        public static double Avg(int num1, int num2)
        {
            return (double)(num1 + num2) / 2;
        }

        // לכתוב פעולה המקבלת מערך של שלמים ומחזירה את סכום איברי המערך

        public static int SumArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

        // לכתוב פעולה המקבלת מערך ומחזירה ממוצע של אבריו
        public static double AvgArr(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            return (double)(sum / arr.Length);
        }

        // יש לכתוב פעולה המקבלת מערך ומחזירה אמת אם כל המספרים זוגיים


        public static bool IsAllEven(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    return false;
                }
            }
            return true;

        }
        // יש לכתוב פעולה המקבלת מערך ומחזירה אם הסכום זוגי

        public static bool IsSumEven(int[] arr)
        {
            /*
            int sumOfArr=SumArr(arr);
            if (sumOfArr %2==0)
            {
                return true;

            }
            return false;
            */
            return (SumArr(arr) % 2 == 0);
        }

        // פעולה המקבלת מערך ומחזירה מערך חדש מוסיפה 1 לכל איבר

        public static int[] AddOneToArr(int[] arr)
        {
            int[] arrToReturn = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arrToReturn[i] = arr[i] + 1;
            }
            return arrToReturn;
        }

        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine();
        }

        public static void TestArr(int[] arrTemp)
        {

            int[] arrTemp2 = new int[3];
            for (int i = 0;i< arrTemp.Length;i++)
            {
                arrTemp2[i] = arrTemp[i];
            }
            PrintArr(arrTemp2);
            Console.WriteLine(arrTemp[0]);
            arrTemp2[0] = 100;
            PrintArr(arrTemp2);
            Console.WriteLine(arrTemp[0]);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Console.WriteLine("on Main" + arr[0]);
            //  int[] newArr = AddOneToArr(arr);
         
            TestArr(arr);
            PrintArr(arr);
        }
    }
}
