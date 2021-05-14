using RentACar.Domain.Abstractions;
using System;

namespace RentACar.Domain
{
    public class BaseSchema<T> : IEntity<T>
    {
        public T ID { get; set; }

        public Guid CREATED_BY { get; set; }

        public Guid MODIFIED_BY { get; set; }

        public DateTime CREATED_ON { get; set; }

        public DateTime MODIFIED_ON { get; set; }

        public bool IS_ACTIVE { get; set; }

        public bool IS_DELETE { get; set; }
    }
}
