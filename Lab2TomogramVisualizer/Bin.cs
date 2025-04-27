﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2TomogramVisualizer
{
    internal class Bin
    {
        public static int X, Y, Z;
        public static short[] array;

        public Bin() { }

        public void ReadBIN(string path)
        {
            BinaryReader reader = new BinaryReader(new FileStream(path, FileMode.Open));
            X = reader.ReadInt32();
            Y = reader.ReadInt32();
            Z = reader.ReadInt32();

            int arraySize = X * Y * Z;
            array = new short[arraySize];
            for(int i = 0; i < arraySize; i++)
            {
                array[i] = reader.ReadInt16();
            }
        }
    }
}
