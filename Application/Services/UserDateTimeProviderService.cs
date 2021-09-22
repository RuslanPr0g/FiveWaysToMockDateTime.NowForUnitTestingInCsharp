using System;
using Application.Providers;

namespace Application.Services
{
    public class UserDateTimeProviderService
    {
        public UserDateTimeProviderService(DateTimeProvider dateTimeProvider)
        {
            CreatedAt = dateTimeProvider.Now;
        }

        public DateTime CreatedAt { get; }
    }
}