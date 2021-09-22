using System;
using Application.Providers;

namespace Application.Services
{
    public class AmbientContextPatternUserService
    {
        public DateTime CreatedAt { get; } = AmbientContextPatternDateTimeProvider.Now;
    }
}