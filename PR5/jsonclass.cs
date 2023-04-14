using Newtonsoft.Json;
using System.IO;

namespace PR5
{
    class jsonclass
    {
        private static string rootFolder = Path.GetFullPath(@"..\..\..\");

        public static void JsonSer<T>(T type)
        {
            string JsonWrite = JsonConvert.SerializeObject(type);
            File.WriteAllText(rootFolder + "\\save.json", JsonWrite);
        }
        public static T JsonDeser<T>()
        {
            string JsonRead = File.ReadAllText(rootFolder + "\\save.json");
            T Mytype = JsonConvert.DeserializeObject<T>(JsonRead);
            return Mytype;
        }
    }
}

