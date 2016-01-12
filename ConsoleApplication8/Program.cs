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
            Dictionary<int, Vector3> DictionaryOfVertexLocations = new Dictionary<int, Vector3>();
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
            foreach (var x in DictionaryOfVertexLocations)
            {
                //Console.WriteLine(x.Key);

            }
            var path2 = @"C:\Program Files\Blender Foundation\Blender\peteriscute4.txt";

            //Console.ReadLine();

            int counter1 = 0;
            string line1;

            // Read the file and display it line by line.
            System.IO.StreamReader file1 =
               new System.IO.StreamReader(path2);
            while ((line1 = file1.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                var values = line1.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }
                if (DictionaryOfVertexLocations.ContainsKey(int.Parse(values[0])) == false)
                {
                    DictionaryOfVertexLocations.Add(int.Parse(values[0]), new Vector3(double.Parse(values[1]), double.Parse(values[2]), double.Parse(values[3])));
                }
                counter1++;
            }
            file1.Close();


            foreach (var x in DictionaryOfVertexLocations)
            {
                Console.WriteLine(x.Key);

            }
            Console.ReadLine();

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

        public class Vector3
        {
            double x;
            double y;
            double z;
            public Vector3(double _x, double _y, double _z)
            {
                x = _x;
                y = _y;
                z = _z;

            }

        }
    }
}
