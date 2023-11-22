using Проводник;



namespace проводник
{
    public class Program
    {

        public static void Main()
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"{"Компьютер",10}");
                    Console.WriteLine("".PadRight(120, '~'));

                    Console.SetCursorPosition(0, 2);

                    string[] array;
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo driv in drives)
                    {
                        Console.Write("\t" + driv.Name);
                        Console.WriteLine("  " + driv.TotalSize / 1073741824 + " Гб   Cвободно: " + driv.TotalFreeSpace / 1073741824 + " ГБ "); //перевод в гб 
                    }

                    int pos = Arrow.Arrows(1, drives.Length + 2);

                    Papki.Papku(drives[pos - 2].Name);

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

