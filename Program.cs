using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace OOP._101.Draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tanımlanmış Class'tan bir nesne yaratma
            //<Sınıf Adı> <Nesne Adı> =new <Sınıf Adı> **nesne yaratma

            CarGallery carGallery = new CarGallery(); //Yaratılan nesne tanımlanmış olan sınıftan instance aldı (kendini örnekledi)

            carGallery.Brands = "Mercedes"; //Yaratılan nesneye ulaşma ve tanımlama
            carGallery.Model = "C200";
            carGallery.ColourType = "Black";

            Console.WriteLine("Arabanın Markası: " + carGallery.Brands + " - " + "\nArabanın Modeli: " + carGallery.Model + " - " + "\nArabanın rengi: " + carGallery.ColourType);
            Console.WriteLine("Arabanın Fiyatı: " + carGallery.Price.ToString());

            Console.ReadKey();
        }
    }
    public class CarGallery //Car Gallery isminde bir class tanımlandı
    {
        public string Brands { get; set; } //Marka
        public string Model { get; set; } //Model
        public string Mclass { get; set; } //Sınıf (B,C,SUV)
        public int Mpower { get; set; } //Motor gücü (90,140 Beygir)
        public int MVolume { get; set; } //1400,2000 cc
        public string Mserial { get; set; } //Motor Seri no XSDRRTU5W342167890
        public char GasType { get; set; } //Yakıt Türü
        public char GearType { get; set; } //Vites Türü (Manuel Otomatik)
        public string CaseType { get; set; } //Kasa Tipi
        public int ProducedYear { get; set; } //Üretim yılı
        public int Price = 1000000000; //Fiyat, farklı gösterim örneği

        public string ColourType { get; set; } //Renk
    }
}
