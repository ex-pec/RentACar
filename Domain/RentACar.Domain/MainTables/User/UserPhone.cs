using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class UserPhone : IEntity
    {
        public Guid PHONE_ID { get; set; }

        public Guid USER_ID { get; set; }
    }
}