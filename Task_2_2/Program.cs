namespace Task_2_2
{
	class Programm
	{
		static void Main(string[] agrs)
		{
			try
			{
				int month = 1;
				int m;

				while (true)
				{
					Console.WriteLine("Введите m месяцев: ");
					m = Convert.ToInt32(Console.ReadLine());

					if (m >= 0) break;
					Console.WriteLine("Кол-во месяцев не может быть отрицательным");
				}

				month += m;
				month %= 12;

				month = month == 0 ? 12 : month;

				if (month == 1) Console.WriteLine("Текущий месяц: январь");
				else if (month == 2) Console.WriteLine("Текущий месяц: февраль");
				else if (month == 3) Console.WriteLine("Текущий месяц: март");
				else if (month == 4) Console.WriteLine("Текущий месяц: апрель");
				else if (month == 5) Console.WriteLine("Текущий месяц: май");
				else if (month == 6) Console.WriteLine("Текущий месяц: июнь");
				else if (month == 7) Console.WriteLine("Текущий месяц: июль");
				else if (month == 8) Console.WriteLine("Текущий месяц: август");
				else if (month == 9) Console.WriteLine("Текущий месяц: сентябрь");
				else if (month == 10) Console.WriteLine("Текущий месяц: октябрь");
				else if (month == 11) Console.WriteLine("Текущий месяц: ноябрь");
				else if (month == 12) Console.WriteLine("Текущий месяц: декабрь");
			}
			catch
			{
				Console.WriteLine("Кол-во месяцев должно быть целым числом");
			}
		}
	}
}