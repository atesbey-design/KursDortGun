using System;

namespace OOP1
{
    class Program
    {
        //İnt,boole,double,float..... değer tipleridir.
        //Diziler,classlar,abstract class,interface,,, referans tipleridir.
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CatagoryId = 2;//buradaki 2 mobilyaya karşılık gelsin diye
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product { Id = 2, CatagoryId = 5, UnitsInStock = 4,ProductName="kalem",UnitPrice=35 }; //bu şekilde de yapılabilir.


            ProductManager productManager = new ProductManager();//stack--->heap
            productManager.Add(product1);
            // classlarda pascal case (kelime başı büyük) diğer tiplerde camel case(baş kelimenin harfi küçük diğeri büyük
            //c# case sensitive
        }
    }
}
