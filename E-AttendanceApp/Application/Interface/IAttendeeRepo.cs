using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IAttendeeRepo
    {
        Task<bool> CreateAttendee(Attendee model);
        Task<bool> UpdateAttendee(Attendee model);
        Task DeleteAttendee(string id);
        Task<Attendee> GetAttendeeById(string id);
        Task<List<Attendee>> GetAllAttendees();
        Task<List<Attendee>> GetAttendeesByDateTime(string DateTime);
    }
}
