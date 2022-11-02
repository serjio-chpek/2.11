//сериализация десериализация

//сохраненние объектов в постоянную память
//вывод из постоянно памяти в оперативку

using ConsoleApp6;
using System.IO;
using System.Xml.Linq;

Cats Cat1 = new Cats();
Cat1.name = "Барсик";
Cat1.poroda = "Дворняга";
Cat1.year = "3";


Cats Cat2 = new Cats();
Cat2.name = "Рыжик";
Cat2.poroda = "Чеширский";
Cat2.year = "4";

Cats Cat3 = new Cats();
Cat3.name = "Симба";
Cat3.poroda = "Британец";
Cat3.year = "5";


Cats[] cats = new Cats[3];
cats[0] = Cat1;
cats[1] = Cat2;
cats[2] = Cat3;

Controller controller = new Controller();

controller.Save(cats);
string path = "cats.json";


var t = controller.Load(path);


//for (int i = 0; i<cats.Length; i++)
//{
//    var l = cats;
//    foreach (var item in l)
//    {
//        Console.WriteLine(item);
//    }
//}

if (t == null)
    return;

foreach (var item in t)
{
    Console.WriteLine("{0} {1} {2}", item.name, item.poroda, item.year);
}


























//using ConsoleApp6;
//using System.Text.Json;

//Sudent stud = new Sudent();
//stud.Group = "IS-22-07";
//stud.Name = "Student";
//stud.NumTelephone = "89270262725";

//var json = JsonSerializer.Serialize<Sudent>(stud);
//Console.WriteLine(json);

//File.WriteAllText("file.json", json);

//using ConsoleApp6;
//using System.Text.Json;

//var json =  File.ReadAllText("file.json"); //файла может не быть

//Sudent stud = JsonSerializer.Deserialize<Sudent>(json); //может произойти на ошибка при сериализации и десеарилазации

//Console.WriteLine($"{stud.Name}, {stud.Group}");


