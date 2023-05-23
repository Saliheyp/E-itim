namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            byte b = 5; // 1 byte yer kaplar
            sbyte c = 5; // 1 byte yer kaplar
            
            short s = 5; // 2 byte yer kaplar
            ushort us = 5; // 2 byte yer kaplar

            Int16 i16 = 5; // 2 byte yer kaplar
            int i =5; // 4 byte yer kaplar
            Int32 i32 = 5; // 4 byte yer kaplar
            Int64 i64 = 5; // 8 byte yer kaplar

            uint ui =5 ; // 4 byte yer kaplar
            ulong ul = 5; // 8 byte yer kaplar
            long l=5 ; // 8 byte yer kaplar

            // Reel Sayılar
            float f = 1; // 4 byte yer kaplar
            double d =5; // 8 byte yer kaplar
            decimal de = 5;  // 16 byte yer kaplar

            char ch = '5'; // 2 byte yer kaplar
            string st = "null"; // sınırsız
            
            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt);       

            object o1 ="x";
            object o2 ='y';
            object o3 =4;
            object o4 =4.3;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "salih";
            string ad ="salih";
            string soyad ="eyupoğlu";
            string tamad = ad +" "+soyad;

            int integer1 = 5; 
            int integer2 = 3;
            int integer3 = integer1 + integer2;

            //boolean
            bool bool1 = 10>2;

            // Değişken dönüşümleri
            string str20 ="20";
            int int20 =20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // çıktı 40

            int int22 = int20+ int.Parse(str20);

            //datetime

            string datetime = DateTime.Now.ToString("dd.mm.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
