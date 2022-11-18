using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Events
//{
//    public delegate void MyDelegate();
//    public class Stud
//    {
//        public event MyDelegate Pass; // declare an event
//        public event MyDelegate Fail;
//        public void AcceptMarks(int marks)
//        {
//            if (marks < 40)
//            {
//                Fail(); // raise an event
//            }
//            else
//            {
//                Pass(); // raise an event
//            }
//        }
//    }
//    public class Program
//    {
//        static void PassMsg()
//        {
//            Console.WriteLine("You are pass");
//        }
//        static void FailMsg()
//        {
//            Console.WriteLine("You are Fail");
//        }
//        static void Main(string[] args)
//        {
//            Stud s = new Stud();
//            s.Pass += new MyDelegate(PassMsg);
//            s.Fail += new MyDelegate(FailMsg);
//            s.AcceptMarks(65);
//        }
//    }
//}

