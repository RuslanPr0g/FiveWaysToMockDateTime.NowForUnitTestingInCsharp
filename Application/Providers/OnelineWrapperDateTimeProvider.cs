using System;

namespace Application.Providers
{
    public class OnelineWrapperDateTimeProvider
    {
        /// <summary>
        /// The property Now must be virtual.
        /// Otherwise, the Moq framework will not be able to create the wrapper over the mocked type.
        /// We pollute the application logic with what is needed only for unit testing purposes.
        /// </summary>
        public virtual DateTime Now { get; } = DateTime.Now;
    }
}