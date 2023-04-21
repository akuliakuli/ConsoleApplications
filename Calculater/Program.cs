namespace Calculater
{
	internal class Program
	{
		//დავალება მესამე
		static void Main(string[] args)
		{
			Console.WriteLine($"Result of method with two parameters { Calculate(20, 45)}");
			Console.WriteLine($"Result of method with three parameters { Calculate(20, 45,35)}");
			
		}
		static int Calculate(int length, int width)
		{
			return length * width;
		}
		static int Calculate(int length,int width,int height)
		{
			return length * width * height;
		}
	}
}