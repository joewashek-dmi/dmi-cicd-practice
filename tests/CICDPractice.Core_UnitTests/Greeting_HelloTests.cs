using CICDPractice.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CICDPractice.Core_UnitTests;
public class Greeting_HelloTests
{
    private readonly string TEST_NAME = "Joe";

    [Test]
    public void ShouldGetHelloWithName()
    {
        var greeting = Greeting.Hello(TEST_NAME);


        Assert.That(greeting, Is.EqualTo($"Hello, {TEST_NAME}!"));
    }
    [Test]
    public void ShouldAskForName()
    {
        var greeting = Greeting.Hello("");


        Assert.That(greeting, Is.EqualTo("What is your name?"));
    }
}
