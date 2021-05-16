using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class CustomerEmail : IEntity
    {
        public Guid EMAIL_ID { get; set; }

        public Guid CUSTOMER_ID { get; set; }
    }
}