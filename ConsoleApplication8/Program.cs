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

            Dictionary<int, Vector2> DictionaryOfUVCoords = new Dictionary<int, Vector2>();
            int currentPos;
            currentPos = 1;
            string Index = System.String.Empty;
            string UVCoordsX = System.String.Empty, UVCoordsY = System.String.Empty;
            int lastByteIndex = 90000;
            for (int i = 0; i < pathTxtBytes.Length; i++)
            {

                //Console.WriteLine(pathTxtBytes[i]);
                if(pathTxtBytes[i].ToString() == ",")
                {
                    
                    currentPos++;
                    if(DictionaryOfUVCoords.ContainsKey(int.Parse(Index)) == false)
                    {
                        //Console.WriteLine(i - lastByteIndex);
                       
                        if (currentPos % 3 == 0 && (i - lastByteIndex) == 10)
                        {
                            //Console.WriteLine("Index for Dictionary is " + Index);
                            //DictionaryOfUVCoords.Add(Index, new Vector2(Convert.ToDouble(UVCoordsX), Convert.ToDouble(UVCoordsY)));
                            //Console.WriteLine("Adding numbers");
                        }
                    }
                }
                else if (currentPos == 1 || currentPos % 3 == 1)
                {
                    Console.WriteLine(currentPos);
                    Index += pathTxtBytes[i];
                    //Console.WriteLine("Vertex index is " + Index);
                    //Console.WriteLine("Index is " + i);

                }
                else if(currentPos == 2 || currentPos % 3 == 2)
                {
                    UVCoordsX += pathTxtBytes[i];
                    //Console.WriteLine(UVCoordsX);

                    lastByteIndex = i;
                   // Console.WriteLine("Index is " + i);


                }

                else if (currentPos % 3 == 0)
                {
                    UVCoordsY += pathTxtBytes[i];
                    //Console.WriteLine(i - lastByteIndex);

                    //Console.WriteLine(UVCoordsY);

                   // Console.WriteLine("Index is " + i);


                }


            }

           foreach(var x in DictionaryOfUVCoords)
            {
                //Console.WriteLine(x.Key);
                //Console.WriteLine(x.Value);

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
