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
            var path = @"C:\Program Files\Blender Foundation\Blender\peteriscute.txt";
            var pathTxtBytes = File.ReadAllText(path);

            Dictionary<int, Vector2> DictionaryOfUVCoords = new Dictionary<int, Vector2>;
            int currentPos = 0;
            for (int i = 0; i < pathTxtBytes.Length; i++)
            {
                int Index = 0;
                string UVCoordsX = System.String.Empty, UVCoordsY = System.String.Empty;

                if(pathTxtBytes[i] == ',')
                {
                    currentPos++;
                    if(DictionaryOfUVCoords[Index] == null)
                    {
                        DictionaryOfUVCoords.Add(Index, new Vector2(Convert.ToDouble(UVCoordsX), Convert.ToDouble(UVCoordsY)));
                    }
                }
                if (currentPos == 0 || currentPos % 3 == 1)
                {
                    Index = (Convert.ToInt16(pathTxtBytes[i]));
                }
                else if(currentPos == 1 || currentPos % 3 == 2)
                {
                    UVCoordsX += pathTxtBytes[i];

                }

                else if (currentPos == 2 || currentPos % 3 == 3)
                {
                    UVCoordsY += pathTxtBytes[i];

                }
     

            }
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
