using System;
using Application.Providers;

namespace Application.Services
{
    public class UserService
    {
        public UserService(IDateTimeProvider dateTimeProvider)
        { 
            CreatedAt = dateTimeProvider.GetNow();
        }

        public DateTime CreatedAt { get; }
    }
}