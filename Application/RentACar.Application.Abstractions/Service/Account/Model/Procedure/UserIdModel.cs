using RentACar.Application.Abstractions.Service.Model;
using System;

namespace RentACar.Application.Abstractions.Service.Account.Model.Procedure
{
    public class UserIdModel
    {
        public UserIdModel(UserDto req)
        {
            this.UserId = req.ID;
        }
        public Guid UserId { get; set; }
    }
}
