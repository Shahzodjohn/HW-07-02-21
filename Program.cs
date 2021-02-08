using System;

namespace ConsoleApp15
{
    class ArrayHelper<T>
    {
        public static T Pop(ref T[] arr)
        {
            T mas = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return mas;
        }
        public static int Push(ref T[] mass, T rar)
        {
            Array.Resize(ref mass, mass.Length + 1);
            mass[mass.Length - 1] = rar;
            return mass.Length;
        }
        public static T Shift(ref T[] arr5)
        {
            T arr = arr5[0];
            for (int i = 0; i < arr5.Length - 1; i++)
            {
                arr5[i] = arr5[i + 1];
            }
            Array.Resize(ref arr5, arr5.Length - 1);
            return arr;
        }
        public static int UnShift(ref T[] newaddelement, T element)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length - 1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = element;
            return newaddelement.Length - 1;
        }
        
        public static T[] Slice(ref T[] array, int? Begin_Index = null, int? End_Index = null)
        {
            int arrLen = array.Length;
            Begin_Index = Begin_Index ?? 0;
            End_Index = End_Index ?? arrLen;
            if (End_Index < 0) End_Index = arrLen + End_Index;
            if (Begin_Index < 0) Begin_Index = End_Index + Begin_Index;
            int new_len = (End_Index - Begin_Index > 0) ? (int)(End_Index - Begin_Index) : 0;
            Console.WriteLine($"New arrLen = {new_len}");
            T[] newArr = new T[new_len];
            for (int i = 0; i < new_len; i++)
            newArr[i] = array[i + (int)Begin_Index];
            return newArr;

        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] mas = new string[] { "Car", "Bus", "Train" };
            string massive = ArrayHelper<string>.Pop(ref mas);
            Console.WriteLine($" POP = { massive}");

            int[] mas1 = new int[] { 1, 2, 3 };
            int massive1 = ArrayHelper<int>.Pop(ref mas1);
            Console.WriteLine($" POP = { massive1}");

            double[] mas2 = new double[] { 1.1, 1.2, 1.3 };
            double massive2 = ArrayHelper<double>.Pop(ref mas2);
            Console.WriteLine($" POP = { massive2}");

            decimal[] mas3 = new decimal[] { 1.0m, 2.1m, 3.2m };
            decimal massive3 = ArrayHelper<decimal>.Pop(ref mas3);
            Console.WriteLine($" POP = { massive3}");

            float[] mas4 = new float[] { 1.1f, 2.2f, 3.3f };
            float massive4 = ArrayHelper<float>.Pop(ref mas4);
            Console.WriteLine($" POP = { massive4}");

            string[] arr = new string[] { "me", "brother", "sister" };
            int rar = ArrayHelper<string>.Push(ref arr, "Mother");
            Console.WriteLine("String Push MEARRAY = " + rar);

            int[] arr122 = new int[] { 1, 2, 3 };
            int rar1 = ArrayHelper<int>.Push(ref arr122, 4);
            Console.WriteLine("Int Push = " + rar1);

            double[] arr123 = new double[] { 1.1, 1.2, 1.3 };
            double rar2 = ArrayHelper<double>.Push(ref arr123, 1.4);
            Console.WriteLine("Double Push = " + rar2);

            decimal[] arr1234 = new decimal[] { 1.1m, 1.2m, 1.3m, 1.4m };
            decimal rar3 = ArrayHelper<decimal>.Push(ref arr1234, 1.5m);
            Console.WriteLine("Decimal Push = " + rar3);

            float[] arr12345 = new float[] { 5.1f, 5.2f, 5.3f };
            float rar4 = ArrayHelper<float>.Push(ref arr12345, 5.4f);
            Console.WriteLine("Float Push = " + rar4);

            string[] marr = new string[] { "dog", "cat", "cow" };
            Console.WriteLine($"String Shift = {ArrayHelper<string>.Shift(ref marr)}");


            int[] marrr = new int[] { 4, 5, 6 };
            Console.WriteLine($"Int Shift = { ArrayHelper<int>.Shift(ref marrr)}");


            double[] marrrr = new double[] { 7.1, 7.2, 7.3 };
            Console.WriteLine($"Double Shift = {ArrayHelper<double>.Shift(ref marrrr)}");

            decimal[] marrrrr = new decimal[] { 8.1m, 8.2m, 8.3m };
            Console.WriteLine($"Decimal Shift = {ArrayHelper<decimal>.Shift(ref marrrrr)}");

            float[] marrrrrr = new float[] { 9.1f, 9.2f, 9.3f };
            Console.WriteLine($"Float Shift = {ArrayHelper<float>.Shift(ref marrrrrr)}");

            string[] newarray = new string[] { "C++", "C#", "C" };
            int newelemstr = ArrayHelper<string>.UnShift(ref newarray, "C");
            Console.WriteLine($"Unshift string: {newelemstr}");

            int[] arrayint = new int[] { 1, 2, 3, 4, 5 };
            int newelemint = ArrayHelper<int>.UnShift(ref arrayint, 6);
            Console.WriteLine($"Unshift int: {newelemint}");


            double[] arraydouble = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double newelemdbl = ArrayHelper<double>.UnShift(ref arraydouble, 6.6);
            Console.WriteLine($"Unshift double {newelemdbl}");


            decimal[] arraydecimal = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            decimal newelembl = ArrayHelper<decimal>.UnShift(ref arraydecimal, 0.101m);
            Console.WriteLine($"Unshift decimal: {newelembl}");

            float[] arrayfloat = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            float newelemfloat = ArrayHelper<float>.UnShift(ref arrayfloat, 0.1f);
            Console.WriteLine($"Unshift float: {newelemfloat}");

            string[] array = new string[] { "Mersedes","AUDI","BMW","TOYOTA","OPEL" };
            
            int? begin = null, end = null;
            Console.WriteLine(@"Begin index:
            1. Нужно указывать   -> 1
            2. Не указывать      -> 2");
            int enterNumber = int.Parse(Console.ReadLine());
            if (enterNumber == 1)
            {
                Console.Write("BeginIndex = ");
                begin = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(@"End index:
            1. Нужно указывать -> 1
            2. Не указывать    -> 2");
            enterNumber = int.Parse(Console.ReadLine());
            if (enterNumber == 1)
            {
                Console.Write("EndIndex = ");
                end = int.Parse(Console.ReadLine());
            }
            string[] new_array = ArrayHelper<string>.Slice(ref array, begin, end);
            Console.WriteLine("Mассив: ");
            for (int i = 0; i < new_array.Length; i++)
            {
                Console.Write($"{new_array[i]} ");
            }
            












        }
    }
}
