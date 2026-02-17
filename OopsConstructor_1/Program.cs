namespace OopsConstructor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Constructor:
             It is a special type of function; it is member of a class.
             Constructor is used to initialize the instance variables at the time of creating object.*/

            Console.WriteLine("before object is creating");
            myclass mc = new myclass();
            Console.WriteLine("After object is creating");
            mc.display();
            int gt = mc.GetHashCode();
            Console.WriteLine("the address of object mc is : "+gt);
            Console.ReadLine();

        }
    }
}
