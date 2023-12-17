namespace DZ.codeFolder
{
    public class Calc
    {
        public static int Calculate(string[] example)
        {
            int a;
            int b;

            if (example.Length > 3 || example.Length < 3)
            {
                throw new ArgumentException("Некорректное количество аргументов. Допускаются три аргумента: Число > арифметический знак > число");
            }

            if (int.TryParse(example[0], out int result) && int.TryParse(example[2], out int result2))
            {
                a = result;
                b = result2;
            }
            else
            {
                throw new FormatException("Вместо цифр указано, что-то другое. Укажите пример в формате: Число > арифметический знак > число");
            }

            if (example[1] == "+")
            {
                return a + b;
            }
            else if (example[1] == "-")
            {
                return a - b;
            }
            else if (example[1] == "*")
            {
                return a * b;
            }
            else if (example[1] == "/")
            {
                return a / b;
            }
            else
            {
                throw new ArgumentException("Некорректное значнение второго аргумента. Досукаются значения '-', '+', '*', '/'");
            }
        }
    }
}
