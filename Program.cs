using System;



namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 2;
            for (int i = 0; i < 5; i += 1)
            {
                total = total * 2;
            }
            Console.Write("O	total	é:	" + total);
            
        }
    }
}
