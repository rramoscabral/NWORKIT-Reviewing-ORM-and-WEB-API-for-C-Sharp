internal class Coffee
{
	int stock;

	public Coffee(int initialStock)
	{
		stock = initialStock;
	}

	public bool MakeCoffees(int coffeesRequired)
	{
		if (stock < 0)
		{
			throw new Exception("Stock cannot be negative!");
		}
		if (stock >= coffeesRequired)
		{
			Thread.Sleep(500);

			Console.WriteLine(String.Format("Stock level before making coffee: {0}", stock));
			Console.WriteLine("Making coffee...");
			stock = stock - coffeesRequired;
			Console.WriteLine(String.Format("Stock level after making coffee: {0}", stock));
			return true;
		}
		else
		{
			Console.WriteLine("Insufficient stock to make coffee");
			return false;
		}
	}
}

