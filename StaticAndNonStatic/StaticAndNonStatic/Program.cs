using System;
namespace StaticAndNonStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer S1 = new Customer(101, "Waseem");
            S1.Details();

            Customer S2 = new Customer();
            S2.Id = 102;
            S2.Name = "Waqar";
            S2.Details();

            Customer S3 = new Customer()
            {
                Id = 103,
                Name = "Shahzad",
            };
            S3.Details();
            Console.ReadLine();



            var r = new Random();
            int n = r.Next(-5, 5);

            Console.WriteLine(n);

            if (n > 0)
            {
                Console.WriteLine("The n variable is positive");
            }

            string[] names = { "Jane", "Frank", "Alice", "Tom" };
            string[] girls = new string[5];

            names.SetValue("Beky", 1);
            names.SetValue("Erzebeth", 3);

            Console.WriteLine(names.GetValue(1));
            Console.WriteLine(names.GetValue(3));

            Console.WriteLine(Array.IndexOf(names, "Erzebeth"));

            Array.Copy(names, girls, names.Length);

            foreach (string girl in girls)
            {
                Console.Write(girl + " ");
            }

            Console.Write('\n');

            Array.Clear(names, 0, 2);

            foreach (string name in names)
            {
                Console.Write(name + " ");
            }

            Console.Write('\n');

            int[] array = new int[10];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;
            array[5] = 6;
            array[6] = 7;
            array[7] = 8;
            array[8] = 9;
            array[9] = 10;

            for (int i = 0; i < array.Length; i=i+3)
            {
                Console.WriteLine(array[i]);
                

            }

            int[] marks = new int[11] { 1, 2, 3, 4, 5, 6,7, 8, 9, 10, 11};

            int[] arr1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int dm3 = marks.GetLength(0);
            foreach (int arr in arr1)
            {
                Console.WriteLine(arr);
  
            }
            Console.ReadLine();

            int[,] arrytwodm = new int[,] { { 1 ,2, 3 }, { 5, 6, 7 } };
            

            int dm1 = arrytwodm.GetLength(0);
            int dm2 = arrytwodm.GetLength(1); 

            for(int i = 0; i < dm1; i++)
            {
                for (int j = 0; j < dm2; j++)
                {
                    Console.WriteLine(arrytwodm[i, j]);              
                    Console.ReadLine();
                }
            }
            

            int[] arr6 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int arrVal = arr6.GetLength(0);

            foreach (int arr7 in arr6)
            {
                Console.WriteLine("Thisis last arry" + arr7);
                for (int u = 0; u <= arr7; u = u + 3)
                {
                    Console.WriteLine("Thisis last arryu" + arr7);
                }
            }

            int[,] arr8 = new int[,] { { 12, 13, 14 }, { 16, 18, 19 } };

            int dem4 = arr8.GetLength(0);
            int dem5 = arr8.GetLength(1);

            for(int t1 =0; t1 < dem4; t1++)
            {
                for(int t2 = 0; t2 < dem5; t2++)
                {
                    Console.WriteLine("This is value of t1 and t2" + arr8[t1, t2]);

                }
            }

            int[] a11 = { 1, 2 };
            int[,] a21 = { { 1 }, { 2 } };
            int[,,] a31 = { { { 1, 2 }, { 2, 1 } } };

            Console.WriteLine("-------A1"+a11.Rank);
            Console.WriteLine("-------A2" + a21.Rank);
            Console.WriteLine("-------A3" + a31.Rank);











            int[] name1 = new int[] { 1, 4, 7, 3, 11 };

            Array.Sort(name1);

            foreach(int n1 in name1)
            {
                Console.Write("_" + n1);
            }
            Console.Write("--------------------------------------");
            Array.Reverse(name1);

            foreach (int n1 in name1)
            {
                Console.Write("_" + n1);
            }























            string[] names1 = { "Jane", "Frank", "Alice", "Tom" };

            Array.Sort(names1);

            foreach (string el in names1)
            {
                Console.Write(el + " ");
            }

            Console.Write('\n');

            Array.Reverse(names1);

            foreach (string el in names1)
            {
                Console.Write(el + " ");
            }

            Console.Write('\n');
            Console.ReadLine();


        }
    
    }
}

public struct Customer
{
    private int _Id;
    private string _Name;

    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }

    public string Name
    {
        get => _Name;
        set => _Name = value;
    }

    public Customer(int Id, string Name)
    {
        this._Id = Id;
        this._Name = Name;
    }

    public void Details()
    {
        Console.WriteLine("Id = {0} && Name = {1}", this._Id, this._Name);
    }
}





