﻿using DentistBookingSystem.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class AddEmergencyListRequest : IRequest<AddEmergencyListResponse>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }


        public int AlertId { get; set; }
        public Alert Alert { get; set; }
    }
}