using System;

namespace Application.Providers
{
    // The IDateTimeProvider dependency is an explicit one.
    // To understand whether a particular class works with the IDateTimeProvider,
    // developers just need to look at the class constructor.
    // There is no need to analyze the rest of the class logic.
    public interface IDateTimeProvider
    {
        /// <summary>
        /// It is more natural to have a method that returns the current DateTime than a property.
        /// Typically, when C# developers call the same property multiple times,
        /// they expect to get the same value.
        /// </summary>
        /// <returns></returns>
        DateTime GetNow();
    }
}