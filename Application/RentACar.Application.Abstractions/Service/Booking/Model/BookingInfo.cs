using RentACar.Application.Abstractions.Service.ViewModel;

namespace RentACar.Application.Abstractions.Service.Model
{
    public class BookingInfo
    {
        public BookingDto BookingDto { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public VehicleView VehicleView { get; set; }
        public ExchangeRateView ExchangeRateView { get; set; }
        public OfficeInfo DeliveryOfficeInfo { get; set; }
        public OfficeInfo ReceiveOfficeInfo { get; set; }
    }
}
