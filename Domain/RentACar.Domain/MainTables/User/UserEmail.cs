using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class UserEmail : IEntity
    {
        public Guid EMAIL_ID { get; set; }

        public Guid USER_ID { get; set; }
    }
}