using System.Collections.Generic;
using System.IO;
using System.Collections;
using System;
namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var reader = new StreamReader(@"product.csv"))
            {
                List<string> id = new List<string>();
                List<string> name = new List<string>();
                List<string> price = new List<string>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    id.Add(values[0]);
                    name.Add(values[1]);
                    price.Add(values[2]);

                }
                string[] array1 = new string[10];
                ArrayList myAL = new ArrayList();
                int sum = 0;
                int count = 1;
                while ( count <= 100 ) {
                Console.WriteLine("input :");
                string inputid = Console.ReadLine();
                for (int i = 0; i < 10; i++) {
                    if ( id[i] == inputid ){
                            string v = price[i];
                            int x = Convert.ToInt32(v);
                            sum = sum + x;
                            array1[i-1] = name[i];
                            
                    }
                }
                Console.WriteLine("Products");
                Console.WriteLine("{0}", string.Join(" ", array1));            
                Console.WriteLine("----------");
                Console.WriteLine("Total : ");
                Console.WriteLine(sum + " Bath");
            }
        }
    }
}
}