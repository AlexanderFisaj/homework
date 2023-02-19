/* Площадь треугольника

По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь.

Входные данные
Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. 
Все числа не превышают 106 по абсолютной величине.

Выходные данные
В выходной файл OUTPUT.TXT выведите точное значение площади заданного треугольника.

Примеры 
2 1 2 4 6 1 => 6
0 0 0 3 3 0 => 4.5*/
//------------------------------------------------------------------------------------------------------//

// функция расчета длины отрезка по координатам начальных точек X и Y
double SegmentLength (int xa, int ya, int xb, int yb)
{
    double l = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
    return l;
}

// функция расчета площади треугольника по длинам сторон A, B и C
double TriangleArea (double sideA, double sideB, double sideC)
{
    double halfMeter = (sideA + sideB + sideC) / 2;
    double area = Math.Round(Math.Sqrt(halfMeter * 
                                    (halfMeter - sideA) * 
                                    (halfMeter - sideB) * 
                                    (halfMeter - sideC)), 2);
    return area;
}


Console.Clear();

Console.WriteLine("Введите координаты вершин треугольника, разделив пробелом.");

Console.Write("Введите координаты 1-й вершины (X и Y): "); // запрос на ввод чисел через пробел
int[] topA = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray(); // формирование массива координат 1-й точки

Console.Write("Введите координаты 2-й вершины (X и Y): "); // запрос на ввод чисел через пробел
int[] topB = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray(); // формирование массива координат 2-й точки

Console.Write("Введите координаты 3-й вершины (X и Y): "); // запрос на ввод чисел через пробел
int[] topC = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray(); // формирование массива координат 3-й точки

// выделение координат в отдельные переменные
int x1 = topA[0];
int y1 = topA[1];
int x2 = topB[0];
int y2 = topB[1];
int x3 = topC[0];
int y3 = topC[1];

double a = SegmentLength(x1, y1, x2, y2); // расчет длины стороны А
double b = SegmentLength(x2, y2, x3, y3); // расчет длины стороны B
double c = SegmentLength(x1, y1, x3, y3); // расчет длины стороны C

double s = TriangleArea(a, b, c); // расчет площади треугольника

Console.Write($"Площадь треугольника: {s}"); // вывод результата на экран