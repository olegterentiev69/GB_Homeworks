Console.Clear();
 
 Console.Write("Введите x точки A: ");
 double x1 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите x точки B: ");
 double x2 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите y точки A: ");
 double y1 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите y точки B: ");
 double y2 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите z точки A: ");
 double z1 = double.Parse(Console.ReadLine() ?? "");
 Console.Write("Введите z точки B: ");
 double z2 = double.Parse(Console.ReadLine() ?? "");

double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y1-y2)*(y2-y1)+(z2 - z1)*(z2-z1));
Console.WriteLine($"Расстояние между двумя точками в 3-D пространстве равно {distance:f2}");