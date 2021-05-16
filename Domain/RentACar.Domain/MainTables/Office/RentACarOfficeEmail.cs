using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class RentACarOfficeEmail : IEntity
    {
        public Guid EMAIL_ID { get; set; }

        public Guid RENT_A_CAR_OFFICE_ID { get; set; }
    }
}