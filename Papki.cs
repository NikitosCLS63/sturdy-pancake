
using System.Diagnostics;


namespace Проводник
{
    public class Papki
    {
        public static void Papku(string b)
        {
           
            if (Directory.Exists(b))
            {

                while (true)
                {

                    Console.Clear();
                   
                    Console.SetCursorPosition(0, 1);


                    
                    
                    Console.WriteLine("".PadRight(120, '~'));
                    Console.SetCursorPosition(0, 2);
                    Console.WriteLine($"{"Escape  вернуться назад",111}");


                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine($"{"F1  добавить файл",111}");
                    
                    
                    
                    Console.SetCursorPosition(0, 6);
                    Console.WriteLine($"{"F2  добавить директории",111}");
                    
                    
                    
                    Console.SetCursorPosition(0, 8);
                    Console.WriteLine($"{"F3 удалить файл",111}");
                    
                    
                    Console.SetCursorPosition(0, 10);
                    Console.WriteLine($"{"F4 удаление директории",111}");
                    
                    
                    Console.SetCursorPosition(2, 2);
                    Console.WriteLine($"{"~Название~",20} {"~Дата создания~",36} {"~Тип~",17}");

                    string[] Directories = Directory.GetDirectories(b);

                    for (int i1 = 0; i1 < Directories.Length; i1++)
                    {
                        string Direct = Directories[i1];
                        string name = Path.GetFileName(Direct);
                        if (name.Length >= 24)
                        {
                            name = name.Substring(0, 24);
                        }
                        Console.Write("  " + name);
                        Console.SetCursorPosition(30, i1 + 3);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(Direct));
                    }

                    string[] files = Directory.GetFiles(b);
                    for (int i2 = 0; i2 < files.Length; i2++)
                    {
                        string file = files[i2];
                        string fileName = Path.GetFileName(file); 

                        Console.Write("  " + fileName);

                        Console.SetCursorPosition(30, i2 + 3 + Directories.Length);
                        string fileExtension = Path.GetExtension(file);
                        Console.WriteLine("\t\t" + Directory.GetCreationTime(file) + "\t\t" + fileExtension);
                    }



                    int position = Arrow.Arrows(2, Directories.Length + files.Length + 3);

                    if (position == -99)
                        return;

                    else if (position == -111)
                    {
                        Console.Clear();
                        Console.WriteLine("~введите название файла,который хотите создать~");
                        class1.D1(b);
                    }

                    else if (position == -222)
                    {
                        Console.Clear();
                        Console.WriteLine("~введите название папки,которую хотите создать~");
                        class1.D2(b);
                    }

                    else if (position == -333)
                    {
                        Console.Clear();
                        Console.WriteLine("~введите название файла,который надо удалить~");
                        class1.D4(b);
                    }
                    else if (position == -444)
                    {
                        Console.Clear();
                        Console.WriteLine("~введите название папки,который хотите удалить~");
                        class1.D3(b);
                    }

                    else if (position - 3 < Directories.Length)
                        Papku(Directories[position - 3]);



                    else
                        Papku(files[position - 3 - Directories.Length]);
              
                }
            }
            else
            {
                Process.Start(new ProcessStartInfo { FileName = b, UseShellExecute = true });
            }
            
        }
    }
}
    

