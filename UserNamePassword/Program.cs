namespace UserNamePassword
{


	// დავალება პირველი
	internal class Program
	{
		static void Main(string[] args)
		{
			string name = "BarackObama";
			string password = "pA$$w0rd";
			int count = 0;
			while (true)
			{
				Console.Write("Write user name ");
				string uName = Console.ReadLine();
				Console.Write("Write password ");
				string uPass = Console.ReadLine();
				if (name == uName && password == uPass)
				{

					Console.WriteLine("Congratulations, you've guessed it right");
					break;
				}
				count++;

				if (count == 5)
				{
					Console.WriteLine("You have reached the limit of tries");
					break;
				}
			}
		}
	}
}