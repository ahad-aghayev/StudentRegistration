using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Students
    {
        private int St_No;
        private string name;
        private string surname;
        private int vize1;
        private int vize2;
        private double final;
        private string schoolName;



        public void student_Info()
        {
            Console.WriteLine("Student No: " + St_No);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Surname: " + surname);
            Console.WriteLine("Student Vize1: " + vize1);
            Console.WriteLine("Student Vize2: " + vize2);
            Console.WriteLine("Student Final Notu: " + final;
            Console.WriteLine("Student School Name: " + schoolName);
        }

        public double ortalama_Bul
        {
            return (vize1+vize2)*02+final*0,6;
        }

    public void okul_Getir()
    {
        Console.WriteLine("Student School Name: " + schoolName);
    }
}
}
