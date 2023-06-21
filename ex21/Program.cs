Console.Clear();
 
 Console.Write("Введите x1: ");
 double x1 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите x2: ");
 double x2 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите y1: ");
 double y1 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите y2: ");
 double y2 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите z1: ");
 double z1 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите z2: ");
 double z2 = double.Parse(Console.ReadLine() ?? "");

double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y1-y2)*(y2-y1)+(z2 - z1)*(z2-z1));
Console.WriteLine($"Расстояние между двумя точками в 3-D пространстве равно {distance}");