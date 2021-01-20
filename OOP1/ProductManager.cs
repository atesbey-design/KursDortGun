using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)//string ad ile aynı muhabbet.Çünkü prdouct classından product isimle şeyi ver diyoruz...
        {
            Console.WriteLine(product.ProductName+"   eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "   güncellendi.");
        }
        //public int Topla(int sayı1, int sayı2)
        //{
        //    return sayı1 + sayı2;
        //}
        //public void Topla2(int sayı1, int sayı2)
        //{
        //    Console.WriteLine( sayı1 + sayı2 ); 
        //}
        //VOİD GERİYE DEĞER DÖNDERMEZ.GEREKLİ OLAN İŞLEMDEN SONRA ELİMDE BİRŞEY KALMAZ.İNT RETURN KOMUTU İLE SANA TOPLAMINI DÖNDERDİ VE ELİNDE BİR DEĞER OLUŞTU.
    }
}
