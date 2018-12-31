using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FB_Logic
{
    public static class CloneMachine
    {
        public static T DeepClone<T>(this T i_ToClone)
            where T : class
        {
            using (Stream stream = new MemoryStream())
            {
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(stream, i_ToClone);
                stream.Flush();
                stream.Seek(0, SeekOrigin.Begin);
                T theClone = serializer.Deserialize(stream) as T;
                return theClone;
            }
        }
    }
}
