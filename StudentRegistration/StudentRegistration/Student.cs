using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class Student
    {
        private int St_No;
        private string name;
        private string surname;
        private int vize1;
        private int vize2;
        private double final;
        private string schoolName;

        public Student(int _St_No, string _name, string _surname, int _vize1, int _vize2, double _final, string _schoolName)
        {
            St_No = _St_No;
            name = _name;
            surname = _surname;
            vize1 = _vize1;
            vize2 = _vize2;
            final = _final;
            schoolName = _schoolName;

        }

        public void student_Info()
        {
            Console.WriteLine("Student No: " + St_No);
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Surname: " + surname);
            Console.WriteLine("Student Vize1: " + vize1);
            Console.WriteLine("Student Vize2: " + vize2);
            Console.WriteLine("Student Final Notu: " + final);
            Console.WriteLine("Student School Name: " + schoolName);
        }
        public double ortalama_Bul()
        {
            return (vize1+vize2)*0.2+final*0.6;
        }

    public void okul_Getir()
    {
        Console.WriteLine("Student School Name: " + schoolName);
    }

}
}
