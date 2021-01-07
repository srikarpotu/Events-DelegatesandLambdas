using System;
namespace Hotel
{
    public delegate void MyAction<T>(T a,T b);
    public class Room
    {
        public static void CheckIn(String s1,String s2)
        {
            Console.WriteLine($"Check in Name of Two Persons-{s1} And {s2}");
        }
        public static void CheckOut(String s1,String s2)
        {
            Console.WriteLine($"Check Out Name of Two Persons-{s1} And {s2}");
        }
        public static void Welcome(String s1, String s2)
        {
            Console.WriteLine($"Welcome {s1} And {s2}  To AIR Hotels");
        }
        public static void Great(String s1, String s2)
        {
            Console.WriteLine($"Great to have {s1} And {s2}  In AIR Hotels");
        }

    }
    public class Program
    {
        public static void Main(String []args)
        {
            Room r = new Room();
            MyAction<String> A1 = Room.CheckIn;
            A1("varun", "srikar");
            MyAction<String> A2 = Room.CheckOut;
            A2("santhu", "naresh");
            MyAction<String> A3 = Room.Welcome;
            A3("sai", "kumar");
            MyAction<String> A4 = Room.Great;
            A4("Mallesh", "rohith");
            Console.WriteLine("-----------------------");
            Console.WriteLine("A4 += A1 + A2 + A3\n");
            A4 += A1 + A2 + A3;
            A4("Mallesh", "rohith");
            Console.WriteLine("-----------------------");
            Console.WriteLine("A4 -=A1\n");
            A4 -= A1;
            A4("mallesh", "rohith");


        }

    }
}
