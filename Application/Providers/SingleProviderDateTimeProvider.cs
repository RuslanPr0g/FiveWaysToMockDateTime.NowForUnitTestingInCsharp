using System;

namespace Application.Providers
{
    /// <summary>
    /// The solution is simple because it has a single class
    /// </summary>
    public class SingleProviderDateTimeProvider
    {
        private readonly DateTime? _dateTime = null;

        public SingleProviderDateTimeProvider(DateTime fixedDateTime)
            => _dateTime = fixedDateTime;

        public DateTime Now => _dateTime ?? DateTime.Now;
    }
}