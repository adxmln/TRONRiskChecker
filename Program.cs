using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRONRiskChecker
{
	public class Program
	{
		private static readonly string API_ENDPOINT = "https://apilist.tronscanapi.com/api/transaction-info";
		private static readonly string TRANSACTION_HASH = "853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2";

		public static async Task Main(string[] args)
		{
			using (var httpClient = new HttpClient())
			{
				var model = new Model(httpClient, API_ENDPOINT);
				var view = new View();
				var controller = new Controller(model, view);

				await controller.CheckAndReportRiskLevelAsync(TRANSACTION_HASH);
			}
		}
	}

}
