# 5 Ways to Mock DateTime.Now for Unit Testing in C#
### With pros and cons of each.
### Abstracting the application logic from DateTime.Now property is a common task for developers to enable unit testing. When DateTime is hard-coded into logic, unit tests will not be reliable.

## IDateTimeProvider Interface
One of the most common approaches is to introduce an interface that the application logic will use instead of the direct use of DateTime.Now property. <br />
### Pros:
The IDateTimeProvider dependency is an explicit one. To understand whether a particular class works with the IDateTimeProvider, developers just need to look at the class constructor. There is no need to analyze the rest of the class logic.<br />
It is more natural to have a method that returns the current DateTime than a property. Typically, when C# developers call the same property multiple times, they expect to get the same value.
### Cons:
Many class constructors across all codebase will have an additional IDateTimeProvider parameter in the list that pollutes the code.
It is necessary to register the interface and implementation in the DI- container.<br />
Nothing prevents developers from using the DateTime type directly, bypassing the IDateTimeProvider implementation.
<br />

## Single DateTimeProvider Class
The previous example can be simplified. The IDateTimeProvider interface and its two implementations can be combined into one DateTimeProvider class. <br />
### Pros:
DateTimeProvider is an explicit dependency, because it’s injected into constructor.<br />
The solution is simple because it has a single class.
### Cons:
Again, nothing prevents developers from using the DateTime type directly.<br />
Additional registration in the DI-container is required.
<br />

## Ambient Context Pattern
There is a way to provide a global access point to DateTime using the Ambient Context pattern implementation. <br />
### Pros:
Using the DateTimeProvider is very similar to using the DateTime class.<br />
There is no need to do DI registration.
### Cons:
Since the implementation of DateTimeProvider is based on a shared static property, tests cannot run in parallel.<br />
The dependency of the DateTimeProvider is implicit because there is no need to inject it into the constructor to use it. Developers should review the entire implementation of the class to see if it is used there.<br />
Again, nothing prevents developers from using the DateTime type directly.
<br />

## One-line Wrapper
The following implementation provides a trivial wrapper for the DateTime.Now property. <br />
### Pros:
The DateTimeProvider is a one-line implementation. <br />
The DateTimeProvider dependency is an explicit one.
### Cons:
The property Now must be virtual. Otherwise, the Moq framework will not be able to create the wrapper over the mocked type. We pollute the application logic with what is needed only for unit testing purposes.<br />
DI registration for DateTimeProvider is needed.<br />
Again, nothing prevents developers from using the DateTime type directly.
<br />

## Pose Library
The final approach is to leave the application logic as is and use the Pose library, which allows you to replace any property or method with your own delegate. <br />
### Pros:
No need to change application logic.<br />
The only choice for developers is the DateTime type.
### Cons:
Mocking types you don’t own is often a bad practice.<br />
Third party libraries may contain bugs, require additional maintenance efforts, etc.<br />
The DateTime type will be used implicitly in the application logic.
<br />

# We’ve looked at 5 different approaches to achieving the same goal, with the pros and cons.
