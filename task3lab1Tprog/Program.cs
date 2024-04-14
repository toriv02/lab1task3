using System;
public class Logic {
    //логика программы в которой происходит поиск ответа на поставленную задачу с текущими данными
    public static double findsum(string vvod) {
        double sum = 0; //счётчик суммы
        double save = 0; //вспомогательная переменная для хранения числа, при его переводе из текста
        int j = 0;//счётчик разрядности, предназначенный для корректного перевода числа
        int countlet = 0; //счётчик цифр
        try //обработка ошибки, при неверно введённом формате данных
        {
            for (int i = vvod.Length; i > 0; i--) //прохолдим строку в обратном порядке
            {
                if (vvod[i - 1] == '+') { sum += save; save = 0; j = 0; } //при виде символа "+" добавляем к значениу переменной sum значение из переменной save
                else if (vvod[i - 1] == '-') { sum -= save; save = 0; j = 0; }//при виде символа "-" добавляем к значениу переменной sum значение из переменной save
                else if (vvod[i - 1] == '.' || vvod[i - 1] == ',') { save /= Math.Pow(10, j); j = 0; }//при виде символа "." или "," делим значение переменной save на разрядность для перехода к вещественному числу
                else
                {
                    save += Math.Pow(10, j) * double.Parse(vvod[i - 1].ToString()); //переводимтекущий символ в число домнажая его на разрядность и сохраняем в переменной save
                    j++;
                    countlet++;
                }
            }
        }catch (FormatException) { Console.WriteLine("формат введённых данных некоректен, попробуйте ещё раз");Program.flag = false; return -1; }
        sum += save;
        if (countlet == 0)
        { Console.WriteLine("формат введённых данных некоректен, попробуйте ещё раз"); Program.flag = false; }

        return sum;
    }
}
class Program
{
    static public bool flag = true;//вспомогательная переменная, необходимая для обработки ошибки, при неверно введённом формате данных
    static void Main()
    {
        //основная часть программы в которой происходит ввод данных и вывод ответа.
        Console.WriteLine("Введите строку:");
        var vvod = Console.ReadLine();
        var ans = Logic.findsum(vvod);
        if (flag)
        {
            Console.WriteLine("Cумма чисел:");
            Console.WriteLine(ans);
        }
    }
}