/* Перестановки

Дана строка, состоящая из N попарно различных символов. 
Требуется вывести все перестановки символов данной строки.

Входные данные
Входной файл INPUT.TXT содержит строку, состоящую из N символов (1 ≤ N ≤ 8), 
символы - буквы английского алфавита и цифры.

Выходные данные
В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке. 
Перестановки можно выводить в любом порядке. Повторений и строк, 
не являющихся перестановками исходной, быть не должно.

Пример:
AB       AB
         BA

IOX     XOI
        OIX
        IXO
        XIO
        OXI
        IOX
 */

 
void Perestanovka(string slovo)
{
  string[] = result[slovo.Length];
  if (slovo.Length == 1) return slovo;

  foreach (string element in slovo)
  {
    string tmp = slovo.Select()
  }
  
}


Console.Clear();

Console.Write("Введите строку символов: ");
string slovo = ?Console.ReadLine();
Perestanovka(slovo);




//Console.Write("Введите строку: ");
//string slovo = Console.ReadLine(); // формирование массива из слова
