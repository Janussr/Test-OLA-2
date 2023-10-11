# OLA-2 TEST COURSE

## Reflections

### Computer mouse:
- **RightClickTest**
- **LeftClickTest**
- **ScrollUpTest**
- **ScrollDownTest**
- **MouseBtnThreeTest**
- **SensorTest**
- **ChangeSensitivityTest**

### Catastrophic Failure:
- [Tesla recalls nearly 12,000 cars after technical fault](https://cardealermagazine.co.uk/publish/tesla-recalls-nearly-12000-cars-after-technical-fault-that-could-cause-unexpected-activation-of-the-emergency-brakes/240917)
  - Tesla recalled vehicles due to a technical fault causing emergency brakes to activate suddenly.
  - Risk of false forward-collision warning, increasing the risk of a rear-end shunt.
  
  #### Preventive Test:
  - **Scenario Testing: Forward Collision Scenarios**
    - Simulate various real-world scenarios where the vehicle might encounter potential forward collision situations. This includes different road conditions, speeds, and environmental factors.

### Load Testing:
- **Heavy Load Scenarios**
  - Simulate scenarios where the system is under heavy load, such as processing a large number of data inputs, to ensure accurate and safe functionality.

### Integration Testing:
- **Integration with AEB System**
  - Conduct thorough integration testing between the Full-Self Driving software and the Automatic Emergency Braking (AEB) system to ensure seamless communication and coordination.

## Two katas

### STRING UTILITY
Use BDD to create a string utility with the following methods:
- Reverse string (aBc -> cBa)
- Capitalize string (aBc -> ABC)
- Lowercase string (aBc -> abc)

### BOWLING GAME KATA
Complete the Bowling Game Kata using BDD. [Slides here](http://butunclebob.com/files/downloads/Bowling%20Game%20Kata.ppt)

# Investigation of Tools

## Junit 5

### @Tag:
@Tag allows you to categorize test methods or test classes with custom tags. Useful for grouping tests, which can be helpful for filtering and running specific subsets of tests. You can use tags to run tests for specific environments, features, or any other criteria.

### @Disabled:
@Disabled is used to disable a test method or test class temporarily. Useful when you want to skip certain tests without removing them from the codebase. Often used for tests that are currently failing or for tests that are not yet implemented.

### @RepeatedTest:
@RepeatedTest allows you to repeat the execution of a test method a specified number of times. Useful for testing scenarios that require multiple iterations or to ensure the stability of a test. You can set the repetition count using the value attribute.

### @BeforeEach and @AfterEach:
@BeforeEach and @AfterEach annotations are used to define methods that run before and after each test method within a test class. Useful for setting up and cleaning up test fixtures and resources. Helps in ensuring a clean and consistent state before and after each test method.

### @BeforeAll and @AfterAll:
@BeforeAll and @AfterAll annotations are used to define methods that run once before and after all the test methods in a test class. Useful for performing setup or teardown operations that are common to all test methods in a class. Typically used for expensive setup or cleanup tasks.

### @DisplayName:
@DisplayName allows you to specify a custom name for a test method or test class, making test reports more descriptive. Useful for providing meaningful and human-readable test names for better test documentation and reporting.

### @Nested:
@Nested allows you to define nested test classes within a parent test class. Useful for grouping related test methods and organizing tests in a hierarchical manner. Enhances test structure and readability.

### assumeFalse and assumeTrue:
assumeFalse and assumeTrue are conditional test execution methods. They allow you to conditionally skip a test based on a given condition. Useful when a test should only be executed if a certain condition holds, otherwise, it's assumed to pass or fail, depending on the condition.

## Mocking Frameworks

In this section, we will compare the two mocking frameworks for Mockito for Java and Moq for our preferred language, C#.

### Similarities:

- **Mocking:**
  Both Mockito and Moq allow you to create mock objects that simulate the behavior of real objects. This is essential for isolating the code under test and ensuring that it behaves as expected in isolation.
  
- **Syntax:**
  While the syntax differs because of the languages they are built for, both frameworks offer a similar fluent and intuitive syntax for defining mock behaviors and expectations.
  
- **Verification:**
  Both frameworks provide methods to verify that specific methods on mock objects were called with the expected arguments and a specified number of times.
  
- **Argument Matching:**
  Mockito and Moq both support argument matching, allowing you to specify expectations for method calls with various arguments, including wildcards and custom matchers.
  
- **Stubbing:**
  You can use both frameworks to specify how mock objects should behave when their methods are called, including returning specific values or throwing exceptions.
  
- **Annotations/Attributes:**
  Both frameworks support annotations (in Mockito for Java and attributes in Moq for C#) to simplify the creation and management of mocks.

### Differences:

- **Language:**
  The most significant difference is the programming language they are designed for. Mockito is primarily used with Java, while Moq is designed for C#.
  
- **Syntax:**
  Naturally, the syntax of the two frameworks is tailored to the respective languages. Mockito uses a more Java-centric syntax, while Moq uses C# idioms.
  
- **Type System:**
  Java and C# have different type systems and features. Mockito may require workarounds for some advanced scenarios due to limitations in the Java type system, while Moq can leverage some advanced features of C# more easily.
  
- **Features:**
  Moq may offer some features specific to C# and the .NET ecosystem, such as support for events and properties in a way that aligns with C# conventions.
  
- **Integration:**
  Mockito integrates well with popular Java testing frameworks like JUnit and TestNG. Moq integrates seamlessly with C# testing frameworks like MSTest, NUnit, and xUnit.
  
- **Async/Await:**
  Moq has built-in support for mocking asynchronous methods and handling asynchronous behavior, which aligns with the async/await pattern in C#. Mockito also has async support, but it may require additional configuration and is not as seamless as Moq in this regard.

