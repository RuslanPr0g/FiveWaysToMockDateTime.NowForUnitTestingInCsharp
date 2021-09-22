using System;
using Application.Providers;
using Application.Services;
using Xunit;

namespace SingleDateTimeProviderClassExample
{
    public class Example1
    {
        [Fact]
        public void UserCreated()
        {
            var user = new UserDateTimeProviderService(new SingleProviderDateTimeProvider(new DateTime(2021, 07, 20)));
            Assert.Equal(new DateTime(2021, 07, 20), user.CreatedAt);
        }
    }
}