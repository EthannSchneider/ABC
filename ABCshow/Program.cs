namespace ABC
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            D d = new D();

            Console.WriteLine("A: " + a.OpenDay());
            Console.WriteLine("---------");
            Console.WriteLine("B: " + b.OpenDay());
            Console.WriteLine("---------");
            Console.WriteLine("C: " + c.OpenDay());
            Console.WriteLine("---------");
            Console.WriteLine("D: " + d.OpenDay());
            Console.WriteLine("---------");
        }
    }
}