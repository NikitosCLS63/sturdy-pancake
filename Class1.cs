using System;


namespace Проводник
{
    public class class1 
    {
        
        public static void D1(string path)
        {

            string name = Console.ReadLine();
            File.Create(path + "\\" + name).Close();
        }
        public static void D2(string path)
        {

            string name = Console.ReadLine();
            Directory.CreateDirectory(path + "\\" + name);

        }
        public static void D3(string path)
        {

            string name = Console.ReadLine();
            Directory.Delete(path + "\\" + name, true);

        }
        public static void D4(string path)
        {

            string name = Console.ReadLine();
            File.Delete(path + "\\" + name);

        }
    }
}

