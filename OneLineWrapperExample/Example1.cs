using System;
using Application.Providers;
using Application.Services;
using Moq;
using Xunit;

namespace OneLineWrapperExample
{
    public class Example1
    {
        [Fact]
        public void UserCreated()
        {
            var mock = new Mock<OnelineWrapperDateTimeProvider>();
            mock.Setup(x => x.Now)
                .Returns(new DateTime(2021, 07, 20));
        
            var user = new OnelineWrapperUserService(mock.Object);
        
            Assert.Equal(new DateTime(2021, 07, 20), user.CreatedAt);
        }
    }
}