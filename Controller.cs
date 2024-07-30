public class Controller
{
	private readonly Model _model;
	private readonly View _view;

	public Controller(Model model, View view)
	{
		_model = model;
		_view = view;
	}

	public async Task CheckAndReportRiskLevelAsync(string transactionHash)
	{
		try
		{
			var riskLevel = await _model.GetTransactionRiskLevelAsync(transactionHash);
			_view.DisplayRiskLevel(riskLevel);
		}
		catch (Exception ex)
		{
			_view.DisplayError(ex.Message);
		}
	}
}
