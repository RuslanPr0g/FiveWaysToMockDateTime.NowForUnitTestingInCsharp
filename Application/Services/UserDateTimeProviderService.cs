using System;
using Application.Providers;

namespace Application.Services
{
    public class UserDateTimeProviderService
    {
        public UserDateTimeProviderService(SingleProviderDateTimeProvider singleProviderDateTimeProvider)
        {
            CreatedAt = singleProviderDateTimeProvider.Now;
        }

        public DateTime CreatedAt { get; }
    }
}