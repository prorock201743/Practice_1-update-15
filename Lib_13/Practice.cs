using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_13
{
    public class Practice
    {
        /// <summary>
        /// Генерировать случайные числа Х, распределенные в диапазоне от -5 до 5 и
        /// и вычислять для чисел > 0 корень из X, а для чисел < 0 Х в степени 2
        /// </summary>
        /// <returns>Вычисление корня из Х или возведение во Х во 2 степень и вывод сгенерированные чисел</returns>
        public static (string allNumbers, string calculations) GetSqrtOrSquare()
        {
            Random random = new Random();

            string numbers = string.Empty;

            string calculation = string.Empty;

            int temporaryValue = -6;
            int currentValue = random.Next(-5, 5);

            do
            {
                numbers += currentValue.ToString() + ", ";

                if (currentValue > 0)
                {
                    calculation += Math.Sqrt(currentValue).ToString() + ", ";
                }
                else 
                {
                    calculation += (currentValue * currentValue).ToString() + ", ";
                }
                temporaryValue = currentValue;
                currentValue = random.Next(-5, 5);

            } while (currentValue != temporaryValue);
            numbers = numbers.Remove(numbers.Length - 2) + ".";

            calculation = calculation.Remove(calculation.Length - 2) + ".";

            var result = (numbers, calculation);

            return result;
        }
    }
}
