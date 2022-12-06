// 75. Написать программу вычисления функции Аккермана

		
		int FuncA(int m, int n)
		{
			if(m == 0) return n + 1;

			if(m > 0 && n == 0) return FuncA(m - 1, 1);

			return FuncA(m - 1, FuncA(m, n - 1));
		}
		
		Console.WriteLine(FuncA(3,3));
	