using System;
using System.Collections.Generic;
using System.Text;
//snippet-->Kullanılan kalıbın hazır kodunu götserir(2.TAB)
namespace OOP1
{
    class Product//entity tarzı isimler verilir.
    {
        public int Id { get; set; }//idesi
        public int CatagoryId { get; set; }//katagori idesi
        public int  UnitsInStock { get; set; }//stok adedi
        public string ProductName { get; set; }//ürün ismi
        public double UnitPrice { get; set; }//ürün fiyatı
        //CRUD-->create,read,update,delete
        
    }
}
