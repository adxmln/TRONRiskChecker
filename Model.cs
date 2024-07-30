using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

public class Model
{
	private readonly HttpClient _httpClient;
	private readonly string _apiEndpoint;

	public Model(HttpClient httpClient, string apiEndpoint)
	{
		_httpClient = httpClient;
		_apiEndpoint = apiEndpoint;
	}

	public async Task<string> GetTransactionRiskLevelAsync(string transactionHash)
	{
		var response = await _httpClient.GetAsync($"{_apiEndpoint}?hash={transactionHash}");
		response.EnsureSuccessStatusCode();

		var json = await response.Content.ReadAsStringAsync();
		var data = JObject.Parse(json);

		return data["riskTransaction"].ToString();
	}
}
