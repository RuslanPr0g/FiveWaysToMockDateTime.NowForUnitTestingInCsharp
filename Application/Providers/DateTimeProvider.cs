using System;

namespace Application.Providers
{
    /// <summary>
    /// The solution is simple because it has a single class
    /// </summary>
    public class DateTimeProvider
    {
        private readonly DateTime? _dateTime = null;

        public DateTimeProvider(DateTime fixedDateTime)
            => _dateTime = fixedDateTime;

        public DateTime Now => _dateTime ?? DateTime.Now;
    }
}