using AvatradeTests.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AvatradeTests.Utils
{
    class TestDataParametr<T>
    {
        public static T GetParametrs(string path = "../../../Resources/User.json")
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(path));
        }
    }
}
