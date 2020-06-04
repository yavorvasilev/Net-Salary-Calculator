namespace NetSalaryCalculator
{
	using System;

	public static class Print
	{
		public static void Info(string text) 
		{
			Console.Write(text);
		}

		public static void Error(string text) 
		{
			SetErrorColors();
			Console.Write(text);
			Console.ResetColor();
		}

		private static void SetErrorColors() 
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
	}
}
