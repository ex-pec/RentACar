using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class RentACarOfficePhone : IEntity
    {
        public Guid PHONE_ID { get; set; }

        public Guid RENT_A_CAR_OFFICE_ID { get; set; }
    }
}