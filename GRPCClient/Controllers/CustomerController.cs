using GetCustomer;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;

namespace GRPCClient.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly Customer.CustomerClient _customerBase;

		public CustomerController(Customer.CustomerClient customerBase)
		{
			this._customerBase = customerBase;
		}
		[HttpPost]
		public async Task<IActionResult> GetCus(CustomerRequest model)
		{
			//GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:7044");
			////var client = new SMSClient(channel);
			var res =  _customerBase.GetCustomer(new CustomerRequest { Id="1"},null);


			return Ok("Send sms succ...");

		}
	}
}
