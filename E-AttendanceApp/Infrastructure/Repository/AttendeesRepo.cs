using Application.Interface;
using Domain.Entities;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AttendeesRepo :IAttendeeRepo
    {
        private MyDbContext _context;

        public AttendeesRepo(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAttendee(Attendee model)
        {
            var addAttendee = _context.Attendees.Add(model);
            if (await _context.SaveChangesAsync() > 0) return true;
            return false;
        }

        public Task DeleteAttendee(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Attendee>> GetAllAttendees()
        {
            var attendees = await _context.Attendees.ToListAsync();
            return attendees;
        }

        public async Task<Attendee> GetAttendeeById(string id)
        {
             var attendees = await _context.Attendees.FindAsync();
            return attendees;
        }

        public async Task<List<Attendee>> GetAttendeesByDateTime(string DateTime)
        {
            var attendees = await _context.Attendees.Where(x => x.Arival.Equals(DateTime)).ToListAsync(); 
            return (attendees);
        }

        public Task<bool> UpdateAttendee(Attendee model)
        {
            throw new NotImplementedException();
        }
    }
}
