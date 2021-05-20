﻿using DentistBookingSystem.DataAccess.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentistBookingSystem.DataAccess.CQRS
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly AppointmentStorageContext context;

        public CommandExecutor(AppointmentStorageContext context)
        {
            this.context = context;
        }
        public Task<TResult> Execute<TParameters, TResult>(CommandBase<TParameters, TResult> command)
        {
            return command.Execute(this.context);
        }
    }
}
