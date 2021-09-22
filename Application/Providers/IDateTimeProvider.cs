using System;

namespace Application.Providers
{
    // Pros:
    // 1) The IDateTimeProvider dependency is an explicit one.
    // To understand whether a particular class works with the IDateTimeProvider,
    // developers just need to look at the class constructor.
    // There is no need to analyze the rest of the class logic.
    public interface IDateTimeProvider
    {
        DateTime GetNow();
    }
}