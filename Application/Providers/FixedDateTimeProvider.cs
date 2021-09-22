using System;

namespace Application.Providers
{
    //FixedDateTimeProvider implementation for unit tests
    public class FixedDateTimeProvider : IDateTimeProvider
    {
        private DateTime _fixedDateTime;

        public FixedDateTimeProvider(DateTime fixedDateTime)
            => _fixedDateTime = fixedDateTime;

        public DateTime GetNow() => _fixedDateTime;
    }
}