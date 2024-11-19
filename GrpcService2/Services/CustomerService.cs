using GetCustomer;
using Grpc.Core;
using GrpcService2;

namespace GrpcService2.Services
{
	public class CustomerService:Customer.CustomerBase
	{
		private readonly ILogger<CustomerService> _logger;
		public CustomerService(ILogger<CustomerService> logger)
		{
			_logger = logger;
		}

		public override Task<CustomerResponce> GetCustomer(CustomerRequest customerRequest, ServerCallContext context)
		{
			try
			{
				if (string.IsNullOrEmpty(customerRequest.Id)) throw new RpcException(new Status(StatusCode.InvalidArgument,"Customer Id is null"));

				return  Task.FromResult(new CustomerResponce { Family="as",Name="a"});
			}
			catch (Exception ex)
			{

				throw new RpcException(new Status(StatusCode.Internal,"Erroe in server"));
			}

		}
	}
}
