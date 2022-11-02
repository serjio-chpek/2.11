using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6
{
    internal class Controller
    {
        public void Save(Cats[] cats)
        {

                var json = JsonSerializer.Serialize<Cats[]>(cats);
                File.WriteAllText("cats.json", json);

        }
        public Cats[] Load(string path)
        {
            path = "cats.json";
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                var json = File.ReadAllText(path);
                Cats[] cats = JsonSerializer.Deserialize<Cats[]>(json);
                return cats;
            }

        }
    }
}
