using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.IO;

namespace High_Score
{
    internal class Utility
    {
        public static bool IsDirty { get; set; }
        private static JsonSerializer serializer = new JsonSerializer();

        public static void WriteToFile(High_Score[] stacks, string fileName)
        {
            StreamWriter streamWriter = new StreamWriter(fileName);
            serializer.Formatting = Formatting.Indented;

            serializer.Serialize(streamWriter, stacks, typeof(High_Score[]));
            streamWriter.Flush();
            streamWriter.Close();
        }

        public static High_Score[] ReadFromFile(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            var obj = serializer.Deserialize(streamReader, typeof(High_Score[]));
            streamReader.Close();
            if (obj == null)
            {
                return new High_Score[10];
            }

            High_Score[] High_Scores = (High_Score[])obj;
            return High_Scores;
        }
    }
}