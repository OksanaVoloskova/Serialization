using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Serialisation
{
    interface ISerializer
    {
        T Deserialize<T>(string serialisedStr);
        string Serialize<T>(T obj);
    }
}
