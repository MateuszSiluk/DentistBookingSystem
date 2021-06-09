﻿using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS.Queries
{
    public class GetUsersQuery : QueryBase<List<User>>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthDate { get; set; }

        public override Task<List<User>> Execute(AppointmentStorageContext context)
        {
            if (Name != "" || Surname != "" || BirthDate != "")
            {
                return context.Users.Where(x => x.Name.StartsWith(this.Name) &&
                                                x.Surname.StartsWith(this.Surname) &&
                                                x.BirthDate.ToString().StartsWith(this.BirthDate))
                                                .ToListAsync();
            }
            return context.Users
                .Include(x => x.Appointments)
                .ToListAsync();
            
        }
    }
}
