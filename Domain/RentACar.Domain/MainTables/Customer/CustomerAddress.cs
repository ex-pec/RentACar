using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class CustomerAddress : IEntity
    {
        public Guid ADDRESS_ID { get; set; }

        public Guid CUSTOMER_ID { get; set; }
    }
}