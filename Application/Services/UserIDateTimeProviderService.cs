using System;
using Application.Providers;

namespace Application.Services
{
    public class UserIDateTimeProviderService
    {
        public UserIDateTimeProviderService(IDateTimeProvider dateTimeProvider)
        { 
            CreatedAt = dateTimeProvider.GetNow();
        }

        public DateTime CreatedAt { get; }
    }
}