using System;


public class Program
{
	public static void Main()
	{
		DateTime saveNow = DateTime.Now;

		DateTime saveEarlier = saveNow.AddHours(-20);

		//DateTime saveLater = new DateTime();
		//saveLater = saveNow.AddHours(20);

		TimeSpan elapsedTime = saveNow.Subtract(saveEarlier);
		Console.WriteLine("The datetime now: " + saveNow.ToString());
		//Console.WriteLine("Add 20 hours to the datetime now: " + saveLater.ToString());
		Console.WriteLine("The datetime 20 hours earlier: " + saveEarlier.ToString());
		Console.WriteLine("The difference between the two timestamps: " + elapsedTime.ToString());

		TimeSpan maxElapsedTime = new TimeSpan(0, 10, 0);
		Console.WriteLine("The max elapsed time: " + maxElapsedTime.ToString());

		if (elapsedTime > maxElapsedTime)
		{
			Console.WriteLine("The elapsed time: " + elapsedTime.ToString() + " is greater than the maxElapsedTime: " + maxElapsedTime.ToString());
		}
		else
		{
			Console.WriteLine("The elapsed time: " + elapsedTime.ToString() + " is less than the maxElapsedTime: " + maxElapsedTime.ToString());
		}


	}
}
