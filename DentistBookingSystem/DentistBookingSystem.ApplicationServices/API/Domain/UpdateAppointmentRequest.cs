﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class UpdateAppointmentRequest : IRequest<UpdateAppointmentResponse>
    {
        public int Id { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateStop { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }
    }
}
