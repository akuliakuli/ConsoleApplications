namespace ConvertToBinary
{
	internal class Program
	{
		// დავალება მეორე
		static void Main(string[] args)
		{
			Console.Write("Write A number : ");
			try
			{
				int number = Convert.ToInt32(Console.ReadLine().Trim());
				string binary = Convert.ToString(number, 2);
				Console.WriteLine($"the binary value of {number} is {binary}");
			}
			catch (Exception ex)
			{
				Console.WriteLine (ex.Message);
			}

		}
	}
}