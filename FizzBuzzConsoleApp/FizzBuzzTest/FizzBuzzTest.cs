using MathsTask;
using FluentAssertions;

namespace FizzBuzzTest;

public class Tests
{
    FizzBuzz fizzBuzz = new FizzBuzz();

    [Test]
    public void Given2IsPassedItReturnsANonEmptyListContaining1And2()
    {
        var output = fizzBuzz.execute(2);

        output.Count.Should().Be(2);
        output[0].Should().Be("1");
        output[1].Should().Be("2");
    }

    [Test]
    public void Given15IsPassedItReturnsAListWith15EntriesAndCorrectEntries()
    {
        var output = fizzBuzz.execute(15);

        output.Count.Should().Be(15);
        output[2].Should().Be("Fizz");
        output[3].Should().Be("4");
        output[4].Should().Be("Buzz");
        output[5].Should().Be("Fizz");
        output[6].Should().Be("7");
        output[7].Should().Be("8");
        output[8].Should().Be("Fizz");
        output[9].Should().Be("Buzz");
        output[10].Should().Be("11");
        output[11].Should().Be("Fizz");
        output[12].Should().Be("13");
        output[13].Should().Be("14");
        output[14].Should().Be("FizzBuzz");
    }

    [Test]
    public void Given100IsPassedItReturnsAListWith100EntriesAndCorrectEntries()
    {
        var output = fizzBuzz.execute(100);

        output.Count.Should().Be(100);
        output[29].Should().Be("FizzBuzz");
        output[49].Should().Be("Buzz");
        output[44].Should().Be("FizzBuzz");
        output[32].Should().Be("Fizz");
        output[59].Should().Be("FizzBuzz");
        output[74].Should().Be("FizzBuzz");
        output[89].Should().Be("FizzBuzz");
        output[91].Should().Be("92");
    }
}
