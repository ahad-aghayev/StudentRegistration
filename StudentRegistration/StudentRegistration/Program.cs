using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(1, "Deniz", "Yılmaz", 56, 35, 26, "İstanbul Teknik Unı");
            bool b = true;

            while (b)
            {
                Console.WriteLine(" ");
                islemler();
                Console.WriteLine(" ");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        st.student_Info();
                        break;
                    case "2":
                        Console.WriteLine(st.ortalama_Bul());
                        break;
                    case "3":
                        st.okul_Getir();
                        break;
                    case "4":
                        Console.WriteLine("Çıkış yapıldı");
                        b = false;
                        break;
                }
            }
        }

        static void islemler()
        {
            Console.WriteLine("1.Öğrenci Bilgilerini Göster\n" +
                "2.Öğrenci Not ortalaması göster\n" +
                "3.Öğrenci Okulunu göster\n" +
                "4.Çıkış yap\n");
        }
    }
}
