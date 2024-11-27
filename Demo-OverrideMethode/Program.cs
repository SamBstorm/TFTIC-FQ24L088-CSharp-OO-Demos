﻿namespace Demo_OverrideMethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal("Félix");
            Console.WriteLine(a);
            a.Manger();
            if (a is Chat)
            {
                ((Chat)a).Ronroner();
            }
            a.SeDeplacer();

            Animal b = new Chat("Wiskass");
            Console.WriteLine(b);
            b.Manger();
            if (b is Chat)
            {
                ((Chat)b).Ronroner();
            }
            b.SeDeplacer();
        }
    }
}
