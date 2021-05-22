﻿using AutoMapper;
using DentistBookingSystem.ApplicationServices.API.Domain;
using DentistBookingSystem.DataAccess.CQRS;
using DentistBookingSystem.DataAccess.CQRS.Commands;
using DentistBookingSystem.DataAccess.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Handlers
{
    class AddAppointmentsHandler : IRequestHandler<AddAppointmentRequest, AddAppointmentResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor; 

        public AddAppointmentsHandler(IMapper mapper, ICommandExecutor commandExecutor)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
        }

        public async Task<AddAppointmentResponse> Handle(AddAppointmentRequest request, CancellationToken cancellationToken)
        {
            var appointment = this.mapper.Map<Appointment>(request);
            var command = new AddAppointmentCommand() { Parameter = appointment };

            var userFromDB = await this.commandExecutor.Execute(command);

            return new AddAppointmentResponse()
            {
                Data = this.mapper.Map<Domain.Models.Appointment>(userFromDB)
            };
        }
    }
}