using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class CustomerPhone : IEntity
    {
        public Guid PHONE_ID { get; set; }

        public Guid CUSTOMER_ID { get; set; }
    }
}