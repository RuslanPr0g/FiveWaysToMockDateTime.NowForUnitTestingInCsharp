using System;

namespace Application.Providers
{
    public class OnelineWrapperDateTimeProvider
    {
        public virtual DateTime Now { get; } = DateTime.Now;
    }
}