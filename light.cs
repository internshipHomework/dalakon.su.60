using System;

interface LightBulb
{
    void checkLight(string[] opend,string[] check);
}


class Light : LightBulb
{
    public void checkLight(string[] opend,string[] check)
    {
           int x = 1;
            while(x <= 50){
                string ledno = Console.ReadLine();
                for (int i = 0; i < 10; i++)
                {
                    if (opend[i] == ledno & check[i] == "[]")
                    {
                        check[i] = "[!]";
                    }
                    else if (opend[i] == ledno & check[i] == "[!]")
                    {
                        check[i] = "[]";
                    }
                    
                }
                 Console.WriteLine(string.Join(" ", check));
                x++;
            }
        
    }
}

class Program
{    //[]=close , [!]=open
    static void Main(string[] args)
    {
        Light Light = new Light();
        string[] opend = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A" };
        string[] check = { "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]", "[]"};
        Light.checkLight(opend,check);
       
    }
}