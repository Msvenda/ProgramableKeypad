using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeypadProgrammer
{
    class SettingsManager
    {
        private static string SAVE_DIR = @"C:\Users\Public\KeypadProgrammer";
        private static string SAVE_FILE = @"C:\Users\Public\KeypadProgrammer\keyMaps.kpd";

        public static KeyData[][] getMaps()
        {
            if (!System.IO.File.Exists(SAVE_FILE))
            {
                KeyData[][] d = new KeyData[4][];
                for(int i = 0; i < 4; i++)
                {
                    d[i] = new KeyData[21];
                }
                return d;
            }

            string data = System.IO.File.ReadAllText(SAVE_FILE); 

            var serializer = new JavaScriptSerializer();
            var deserializedResult = serializer.Deserialize<KeyData[][]>(data);
            return deserializedResult;
        }
        public static KeyData[][] getMaps(String loc)
        {
            KeyData[][] d = new KeyData[4][];
            for (int i = 0; i < 4; i++)
            {
                d[i] = new KeyData[21];
            }
            if (!System.IO.File.Exists(loc))
            {
                return d;
            }
            string data = System.IO.File.ReadAllText(SAVE_FILE);
            try
            {
                var serializer = new JavaScriptSerializer();
                d = serializer.Deserialize<KeyData[][]>(data);
            }
            catch(Exception e)
            {

            }
            
            return d;
        }

        public static void saveMaps(KeyData[][] keyMaps)
        {
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(keyMaps);

            if (!System.IO.Directory.Exists(SAVE_DIR))
            {
                System.IO.Directory.CreateDirectory(SAVE_DIR);
            }
            if (System.IO.File.Exists(SAVE_FILE))
            {
                System.IO.File.Delete(SAVE_FILE);
            }
            System.IO.File.WriteAllText(SAVE_FILE, serializedResult);
        }
        public static void saveMaps(KeyData[][] keyMaps, String loc)
        {
            var serializer = new JavaScriptSerializer();
            var serializedResult = serializer.Serialize(keyMaps);

            if (System.IO.File.Exists(loc))
            {
                System.IO.File.Delete(loc);
            }
            System.IO.File.WriteAllText(loc, serializedResult);
        }
    }
}
