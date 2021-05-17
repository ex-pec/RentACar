using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
	public class VehicleModelView
	{
		public Guid MODEL_ID { get; set; }
		public Guid BRAND_ID { get; set; }
		public string MODEL_NAME { get; set; }
		public string BRAND_NAME { get; set; }
	}
}
