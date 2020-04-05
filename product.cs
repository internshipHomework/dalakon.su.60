using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
interface productTo
{
    string getSKU(string [] idArray,int i);
    string getPRICE(string [] priceArray,int i);
    string getNAME(string [] nameArray,int i);
    
}
class product : productTo
{

    public string getSKU(string [] idArray,int i)
    {
            string getsku = idArray[i];
            return getsku;
    }
     private void setSKU(){}
    public string getNAME(string [] nameArray,int i)
    {
            string getname = nameArray[i];
            return getname;
    }
     private void setNMAE(){}

    public string getPRICE(string [] priceArray,int i)
    {       string getprice = priceArray[i];
            return getprice;
    }
    private void setPRICE(){}
   
   

}
class Program
{
    static void Main(string[] args)
    {
        
        product pro = new product();
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
                string[] nameArray = name.ToArray();
                string[] idArray = id.ToArray();
                string[] priceArray = price.ToArray();
                List<string> productlist = new List<string>();
                int sumPrice = 0;
                int count = 1;
                while ( count <= 100 ) {
                Console.WriteLine("Please input a product key : ");
                string inputid = Console.ReadLine();
                for (int i = 0; i < 10; i++) {  
                   string  SKU = pro.getSKU(idArray,i);
                    if ( SKU == inputid ){
                            string strprice = pro.getPRICE(priceArray,i);
                            int priceToint = Convert.ToInt32(strprice);
                            sumPrice = sumPrice + priceToint;
                            productlist.Add(count+"."+ pro.getNAME(nameArray,i)+" : "+strprice+".00 baht");
                            
                    }
                }
                count = count + 1 ;
                Console.WriteLine("Products in your cart are");
                Console.WriteLine("{0}", string.Join("\n", productlist));   
                Console.WriteLine("---");
                Console.WriteLine("Total : ");
                Console.WriteLine(sumPrice +".00 baht");
            }
    }
}
}
