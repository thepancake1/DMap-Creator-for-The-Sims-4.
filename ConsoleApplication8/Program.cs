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
        public static Dictionary<int, Vector2> DictionaryOfUVCoords = new Dictionary<int, Vector2>();
       public static Dictionary<int, Vector3> DictionaryOfVertexLocations = new Dictionary<int, Vector3>();
        public static Dictionary<int, UVLocationsWithVertexLocs> CombinedDictionaries = new Dictionary<int, UVLocationsWithVertexLocs>();
        public static Dictionary<int, UVLocationsWithVertexLocs> CombinedDictionaries2 = new Dictionary<int, UVLocationsWithVertexLocs>();

        static void Main(string[] args)
        {
            var path = @"C:\Program Files\Blender Foundation\Blender\peteriscute3.txt";
            var pathTxtBytes = File.ReadAllText(path);


            string Index = System.String.Empty;
            string UVCoordsX = System.String.Empty, UVCoordsY = System.String.Empty;

            int currentFile = 0;
            ReadUVCoords(path);

            // Suspend the screen.
            foreach (var x in DictionaryOfVertexLocations)
            {
                //Console.WriteLine(x.Key);

            }
            var path2 = @"C:\Program Files\Blender Foundation\Blender\peteriscute4.txt";

            //Console.ReadLine();

            ReadVertices(path2);

            foreach (var x in DictionaryOfVertexLocations)
            {

                CombinedDictionaries.Add(x.Key, new UVLocationsWithVertexLocs(x.Value.x, x.Value.y, x.Value.z, DictionaryOfUVCoords[x.Key].x, DictionaryOfUVCoords[x.Key].y));

                //Console.WriteLine(x.Key);

            }
            DictionaryOfUVCoords.Clear();
            DictionaryOfVertexLocations.Clear();
            var path3 = @"C:\Program Files\Blender Foundation\Blender\peteriscute5.txt";
            var path4 = @"C:\Program Files\Blender Foundation\Blender\peteriscute6.txt";
            ReadUVCoords(path3);
            ReadVertices(path4);
            foreach (var x in DictionaryOfVertexLocations)
            {

                CombinedDictionaries2.Add(x.Key, new UVLocationsWithVertexLocs(x.Value.x, x.Value.y, x.Value.z, DictionaryOfUVCoords[x.Key].x, DictionaryOfUVCoords[x.Key].y));

                Console.WriteLine(x.Key);

            }

            Console.ReadLine();

        }

        private static void ReadVertices(string path2)
        {
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
        }

        private static void ReadUVCoords(string path)
        {
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
        }

        public class Vector2
        {
            public double x;
            public double y;
           public Vector2(double _x, double _y)
            {
                x = _x;
                y = _y;

            }

        }

        public class Vector3
        {
            public double x;
            public double y;
            public double z;
            public Vector3(double _x, double _y, double _z)
            {
                x = _x;
                y = _y;
                z = _z;

            }

        }
        public class UVLocationsWithVertexLocs
        {
            public double V3x;
            public double V3y;
            public double V3z;
            public double V2x;
            public double V2y;
            public UVLocationsWithVertexLocs(double _x, double _y, double _z, double V2X, double V2Y)
            {
                V3x = _x;
                V3y = _y;
                V3z = _z;
                V2x = V2X;
                V2y = V2Y;

            }

        }
    }
}
