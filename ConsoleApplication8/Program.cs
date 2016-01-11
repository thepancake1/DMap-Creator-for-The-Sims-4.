using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Program Files\Blender Foundation\Blender\peteriscute3.txt";
            var pathTxtBytes = File.ReadAllText(path);

            Dictionary<int, Vector2> DictionaryOfUVCoords = new Dictionary<int, Vector2>();
            string Index = System.String.Empty;
            string UVCoordsX = System.String.Empty, UVCoordsY = System.String.Empty;


            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                var values = line.Split(',');
                if (DictionaryOfUVCoords.ContainsKey(int.Parse(values[0])) == false)
                {
                    DictionaryOfUVCoords.Add(int.Parse(values[0]), new Vector2(double.Parse(values[1]), double.Parse(values[2])));
                }
                counter++;
            }

            file.Close();

            // Suspend the screen.
            foreach (var x in DictionaryOfUVCoords)
            {
                Console.WriteLine(x.Key);

            }
            Console.ReadLine();
            var path2 = @"C:\Program Files\Blender Foundation\Blender\peteriscute2.txt";

        }

        public class Vector2
        {
            double x;
            double y;
           public Vector2(double _x, double _y)
            {
                x = _x;
                y = _y;

            }

        }
    }
}
