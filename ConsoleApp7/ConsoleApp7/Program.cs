using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float flimBackWidth = float.Parse(Console.ReadLine());
            
            if (flimBackWidth > 0)
            {
                for (int i = 1; flimBackWidth < 0; i++)
                {
                    flimBackWidth = float.Parse(Console.ReadLine());
                }
            }
            else
            {
                double fLength, fov;
                if(mode == "fLength")
                {
                    fLength = float.Parse(Console.ReadLine());
                    if (fLength > 0)
                    {
                        for(int j = 1; fLength < 0; j++)
                        {
                            Console.WriteLine("Invalid Flength Please input again");
                            fLength = float.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        fov = 2 * Math.Atan(flimBackWidth / (2 * fLength));
                        Console.WriteLine("fLegnth = {0},fov= {1}", fLength, fov);
                    }
                }
                else
                {
                    fov = float.Parse(Console.ReadLine());
                    if (fov < 0.1 && fov > 6.28)
                    {
                        Console.WriteLine("Invalid fov Please input again");
                        fov = float.Parse(Console.ReadLine());
                    }
                    else
                    {
                        fLength = flimBackWidth / (2 * Math.Tan(fov / 2));
                        Console.WriteLine("fLength ={0},fov = {1}",fLength,fov);
                    }
                }
            }
            
        }
    }
}
