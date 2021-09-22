using System;
using Application.Providers;

namespace Application.Services
{
    public class OnelineWrapperUserService
    {
        public OnelineWrapperUserService(OnelineWrapperDateTimeProvider dateTimeProvider)
        {
            CreatedAt = dateTimeProvider.Now;
        }

        public DateTime CreatedAt { get; }
    }
}