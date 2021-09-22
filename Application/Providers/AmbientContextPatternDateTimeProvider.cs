using System;

namespace Application.Providers
{
    /// <summary>
    /// There is no need to do DI registration.
    /// </summary>
    public class AmbientContextPatternDateTimeProvider
    {
        private static Func<DateTime> _dateTimeNowFunc = () => DateTime.Now;
        public static DateTime Now => _dateTimeNowFunc();

        public static void Set(Func<DateTime> dateTimeNowFunc)
        {
            _dateTimeNowFunc = dateTimeNowFunc;
        }
    }
}