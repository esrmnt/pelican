namespace esrmnt.pelican.tests
{
    using System;
    using System.Linq;
    using System.Text;
    using NUnit.Framework;
    using System.Collections.Generic;
    using esrmnt.pelican.common.abstracts;
    using esrmnt.pelican.common.patterns;
    using esrmnt.pelican.common.interfaces;   

    [TestFixture]
    public class ChainOfResponsibility
    {
        MonkeyHandler? monkeyHandler;
        SquirrelHandler? squirrelHandler;
        DogHandler? dogHandler;

        [SetUp]
        public void Setup()
        {
            monkeyHandler = new MonkeyHandler();
            squirrelHandler = new SquirrelHandler();
            dogHandler = new DogHandler();

            monkeyHandler.SetNext(squirrelHandler);
            squirrelHandler.SetNext(dogHandler);
        }

        [Test]
        [TestCase("Nut")]
        [TestCase("Banana")]
        [TestCase("MeatBall")]
        public void ChainOfResponsibility_OK_Result(string food)
        {
            var result = monkeyHandler.Handle(food);

            Assert.That(result, Is.Not.Null);
        }

        [Test]
        [TestCase("Coffee")]
        [TestCase("Ice Cream")]
        public void ChainOfResponsibility_Not_OK_Result(string food)
        {
            var result = monkeyHandler.Handle(food);

            Assert.That(result, Is.Null);
        }

        [TearDown]
        public void Teardwon()
        {

        }
    }
     
}