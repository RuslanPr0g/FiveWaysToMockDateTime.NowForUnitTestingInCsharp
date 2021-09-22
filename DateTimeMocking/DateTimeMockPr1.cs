using System;
using Application.Providers;
using Application.Services;
using Xunit;

namespace DateTimeMocking
{
    public class DateTimeMockPr1
    {
        [Fact]
        public void UserCreated()
        {
            var user = new UserService(new FixedDateTimeProvider(new DateTime(2021, 07, 20)));

            Assert.Equal(new DateTime(2021, 07, 20), user.CreatedAt);
        }
    }
}