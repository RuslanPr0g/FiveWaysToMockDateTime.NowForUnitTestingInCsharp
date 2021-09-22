using System;

namespace Application.Providers
{
    public class RealDateTimeProvider : IDateTimeProvider
    {
        public DateTime GetNow() => DateTime.Now;
    }
}