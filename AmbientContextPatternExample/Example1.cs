using System;
using Application.Providers;
using Application.Services;
using Xunit;

namespace AmbientContextPatternExample
{
    /// <summary>
    /// Since the implementation of DateTimeProvider is based on a shared static property, tests cannot run in parallel.
    /// </summary>
    public class Example1
    {
        /// <summary>
        /// The dependency of the AmbientContextPatternDateTimeProvider is implicit because
        /// there is no need to inject it into the constructor to use it.
        /// Developers should review the entire implementation of the class to see if it is used there.
        /// </summary>
        public Example1()
        {
            
        }
        
        [Fact]
        public void UserCreated()
        {
            AmbientContextPatternDateTimeProvider.Set(() => new DateTime(2021, 07, 20));

            var user = new AmbientContextPatternUserService();

            Assert.Equal(new DateTime(2021, 07, 20), user.CreatedAt);
        }
    }
}