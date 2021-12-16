using System;

namespace lab_1
{
	using System;
	using System.IO;
	using System.Collections.Generic;
	using System.Linq;
	
	class Calculator
	{
			string[] nums;
			string sign;

			public void Run()
			{
				while(Console.ReadLine() != "~")
			{
				Input();
				Console.WriteLine("Number 1 = " + Convert.ToInt32(nums[0], 2));
				Console.WriteLine("Number 2 = " + Convert.ToInt32(nums[1], 2));
				int result = Calculate(0, Convert.ToInt32(nums[0], 2), Convert.ToInt32(nums[1], 2));
				Console.WriteLine("Output: " + Convert.ToString(result, 2));
				Console.WriteLine("Output(10): " + Convert.ToString(result));
			}
			}

			void Input()
			{
				Console.WriteLine("Input num1: ");
				nums[0] = Console.ReadLine();

				Console.WriteLine("Input num2: ");
				nums[1] = Console.ReadLine();

				Console.WriteLine("Выберете операцию: \n 1) +\n 2) - \n 3) * \n 4) /");
				sign = Console.ReadLine();
			}

			int Calculate(int signIndex, int a, int b)
			{
				int result = 0;
				switch (sign)
				{
					case "+": result = a + b; break;
					case "-": result = a - b; break;
					case "*": result = a * b; break;
					case "/": result = a / b; break;
				}
				signIndex++;
				return Calculate(signIndex, result, Convert.ToInt32(nums[signIndex + 1], 2));
			}
	}
		// ПОПРОБОВАТЬ СОЕДИНИТЬ КЛАССЫ !!!!!

		// class Bi
		// {
		// 	int sign;
		// 	int num;
		// 	public Bi(int n)
		// 	{
		// 		if (n < 0)
		// 		{
		// 			sign = -1;
		// 			num = n * (-1);
		// 		}
		// 		else
		// 		{
		// 			sign = 1;
		// 			num = n;
		// 		}
		// 		GetString(num, sign);
		// 	}

		// static string GetString(int num, int sign)
		// {
		// 	string res;

		// 	res = ConvertTo2(Convert.ToString(num));
		// 	if (sign == -1)
		// 		res.Insert(0, "-");
		// 	return (res);
		// }

		// 	public static string ConvertTo2(string num, int round = 5)
		// 		{
		// 			string result = ""; //Результат
		// 			int left = 0; //Целая часть
		// 			int right = 0; //Дробная часть
		// 			string[] temp1 = num.Split(new char[] { '.', ',' }); //Нужна для разделения целой и дробной частей
		// 			left = Convert.ToInt32(temp1[0]);
		// 			//Проверяем имеется ли у нас дробная часть
		// 			if (temp1.Count() > 1)
		// 			{
		// 				right = Convert.ToInt32(num.Split(new char[] { '.', ',' })[1]); //Дробная часть
		// 			}
		// 			//Алгоритм перевода целой части в двоичную систему
		// 			while (true)
		// 			{
		// 				result += left % 2; //В ответ помещаем остаток от деления. В конце программы мы перевернём строку, так как в обратном порядке записываются остатки
		// 				left = left / 2; //Так как Left целое число, то при делении например числа 2359 на 2, мы получим не 1179,5 а 1179
		// 				if (left == 0)
		// 					break;
		// 			}
		// 			result = new string(result.ToCharArray().Reverse().ToArray()); //Реверсирование строки
		// 			/*Не углублялся в ситуацию, но вдруг при реверсе появятся первые символы нули, а ведь их мы не пишем!
		// 			Не знаю есть ли необходимость в этом цикле */
		// 			while (true)
		// 			{
		// 				int i = 0;
		// 				if (result[i] == '0')
		// 					result = result.Remove(i, 1);
		// 				else break;
		// 			}
		// 			//Прокеряем есть ли у нас дробная часть, можно было бы проверить и так if(temp1.count()>1)
		// 			if (right == 0)
		// 				return result;

		// 			//Добавляем разделить целой части от дробной
		// 			result += '.';

		// 			int count = right.ToString().Count(); // Нам нужно знать кол-во цифр, при превышении которого дописывается единичка

		// 			for (int i = 0; i < round; i++)
		// 			{
		// 				/*Умножаем число на 2 и проверяем, стало ли оно больше по количеству цифр, если да,
		// 				то в результат идёт "1" и первая цифра у right удаляется */
		// 				right = right * 2;
		// 				if (right.ToString().Count() > count)
		// 				{
		// 					string buf = right.ToString();
		// 					buf = buf.Remove(0, 1);
		// 					right = Convert.ToInt32(buf);

		// 					result += '1';
		// 				}
		// 				else
		// 				{
		// 					result += '0';
		// 				}
		// 			}
		// 		return result;
		// 	}

		// }

		class Program
		{
			static void Main(string[] args)
			{
				Calculator calc = new Calculator();
				calc.Run();
				Console.ReadKey();
			}
		}
}

