using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class UserRole : IEntity
    {
        public Guid USER_ID { get; set; }

        public Guid ROLE_ID { get; set; }
    }
}
