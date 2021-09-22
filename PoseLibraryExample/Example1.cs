using System;
using Application.Services;
using Xunit;

namespace PoseLibraryExample
{
    /// <summary>
    /// Mocking types you don’t own is often a bad practice.
    /// </summary>
    public class Example1
    {
        [Fact]
        public void UserCreated()
        {
            PoseUserService user = null;

            Shim shim = Shim.Replace(() => DateTime.Now).With(() => new DateTime(2021, 07, 20));

            PoseContext.Isolate(() =>
            {
                user = new PoseUserService();
            }, shim);

            Assert.Equal(new DateTime(2021, 07, 20), user.CreatedAt);
        }
    }
}