using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class UserAddress : IEntity
    {
        public Guid ADDRESS_ID { get; set; }

        public Guid USER_ID { get; set; }
    }
}