﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain
{
    public class AddUsersRequest : IRequest<AddUsersResponse>
    {
        
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }

        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public string Gender { get; set; }
        
    }
}
