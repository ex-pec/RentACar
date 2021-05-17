using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
	public class UserRoleView
	{
		public Guid USER_ID { get; set; }
		public Guid ROLE_ID { get; set; }
		public string ROLE_NAME { get; set; }
	}
}
