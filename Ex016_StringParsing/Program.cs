using System.Linq;

string text = "(1,2) (2,3) (4,5) (6,7)"
              .Replace("(","")
              .Replace(")","");

var data = text.Split(" ")  // Распарсить строку в пары координат
               .Select(item => item.Split(','))  // Распарсить координаты в структуру
               .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1]))) // Превратить координаты в коллекцию x, y
               .Where(e => e.x % 2 == 0) // Отсеевает выборку по условию
               .Select(point => (point.x*10, point.y)) // Умножить первую координату на 10
               .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}