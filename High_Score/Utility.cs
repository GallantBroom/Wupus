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
        private static JsonSerializer serializer = new JsonSerializer();

        public static void WriteToFile(List<PlayerScore> scores, string fileName)
        {
            StreamWriter streamWriter = new StreamWriter(fileName);
            serializer.Formatting = Formatting.Indented;
            serializer.Serialize(streamWriter, scores, typeof(List<PlayerScore>));
            streamWriter.Flush();
            streamWriter.Close();
        }
        /// <summary>
        /// Getting Player score from read file
        /// </summary>
        /// <param name="fileName">Get player score</param>
        /// <returns></returns>
        public static List<PlayerScore> ReadFromFile(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            List<PlayerScore> list = (List<PlayerScore>)serializer.Deserialize(streamReader, typeof(List<PlayerScore>));
            streamReader.Close();
            return list;
        }
    }
}