using NUnit.Framework;
using Calculator.src.model;

namespace Calculator.test.model
{
    [TestFixture]
    class ArithmeticOperationTest
    {
        private ArithmeticOperation operations;

        public ArithmeticOperationTest()
        {
            this.operations = new ArithmeticOperation();
        }

        [Test]
        public void chekingInstance() 
        {
            Assert.That(this.operations, Is.InstanceOf(typeof(ArithmeticOperation)));
        }

        [Test]
        public void AdditionOperation() 
        {
            Assert.AreEqual(this.operations.addition(4, 5), 9);
            Assert.AreEqual(this.operations.addition(3,-6.5), -3.5);
            Assert.AreEqual(this.operations.addition(5.5, 10), 15.5);
        }

        [Test]
        public void SubstractionOperatio() 
        {
            Assert.AreEqual(this.operations.substraction(-5,-10), 5);
            Assert.AreEqual(this.operations.substraction(15, 5), 10);
            Assert.AreEqual(this.operations.substraction(-8.5, 2.5), -11);
        }

        [Test]
        public void Multiplication() 
        {
            Assert.AreEqual(this.operations.multiplication(1, 5), 5);
            Assert.AreEqual(this.operations.multiplication(5, 5), 25);
            Assert.AreEqual(this.operations.multiplication(7, 9), 63);
        }
    }
}