using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika
{
    class Program
    {
        static void Main(string[] args)
        {

            int deger = 2;

            string degisken = "null";
            string Degisken = "null";

            string degisken2 = "";

            byte a = 5;     //1
            sbyte b = 5;    //1
            short c = 5;    //2
            ushort d = 5;   //2

            Int16 i16 = 2;  //2
            int i = 2;      //4
            Int32 i32 = 2;  //4
            Int64 i64 = 2;  //8

            uint u = 2;     //4
            long l = 2;     //8
            ulong r = 2;    //8

            //reel sayılar
            float f = 2;    //4
            double g = 2;   //8
            decimal h = 2;  //16

            char j = '2';   //2
            string str = "Hakan";   //sınırsız

            bool b1= true;
            bool b2 = false;

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 23;
            object o4 = 8.3456;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Hakan Ulusöver";
            string ad = "Hakan";
            string soyad = "Ulusöver";
            string tamIsim = ad + " " + soyad;

            //int tanımlama
            int int1 = 3;
            int int2 = 4;
            int int3 = int1 * int2;

            //boolean
            bool b3 = 34 < 1;

            //değişken dönüşümleri
            string str4 = "4";
            int int5 = 5;

            string yeniDeger = str4+int5.ToString();
            Console.WriteLine(yeniDeger);

            int int6 = int5 + Convert.ToInt32(str4);
            Console.WriteLine(int6);

            int int7 = int5 + int.Parse(str4);

            //DateTime
            string dateTime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/mm/yyyy");
            Console.WriteLine(dateTime2);

            //hour
            string hour = DateTime.Now.ToString("hh:mm");
            Console.WriteLine(hour);
            





        }
    }
}
