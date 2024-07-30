public class View
{
	public void DisplayRiskLevel(string riskLevel)
	{
		Console.WriteLine($"Transaction risk level: {riskLevel}");
	}

	public void DisplayError(string errorMessage)
	{
		Console.WriteLine($"Error: {errorMessage}");
	}
}
