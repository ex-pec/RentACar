﻿using System;

namespace RentACar.Application.Abstractions.Service.ViewModel
{
    public class EmailView
    {
        public Guid EMAIL_ID { get; set; }

        public Guid EMAIL_TYPE_ID { get; set; }

        public string EMAIL_TYPE { get; set; }

        public string EMAIL_ADDRESS { get; set; }
    }
}
