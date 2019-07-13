using System;


namespace directives
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            Console.WriteLine("Hello World!");
#if MAVAR

            Console.WriteLine("Hello World!");
#endif
            #endregion 
        }
    }
}
