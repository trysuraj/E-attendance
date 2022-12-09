using Application.Interface;
using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class Services:IServices
    {
        private readonly IAttendeeRepo _Repo;

        public Services(IAttendeeRepo Repo)
        {
            _Repo = Repo;
        }
        public async Task<bool> CreateAttendee(AttendeesVM model)
        {
            var NewModel = new Attendee()
            {
                FirstName = model.FirstName,
                lastName = model.lastName,
                Gender = model.Gender,
                Stack = model.Stack,
                Arival = model.Arival,
                Departure = model.Departure,
                Phone = model.Phone,
                Email = model.Email,
            };
               if  (await _Repo.CreateAttendee(NewModel)) return true;
               return false;

        }

    }
}
