using System;

using FluentAssertions;

using Hilke.KineticConvolution.DoubleAlgebraicNumber;

using NUnit.Framework;

namespace Hilke.KineticConvolution.Tests
{
    [TestFixture]
    public class AlgebraicNumberCalculatorExtensionsTests
    {
        private IAlgebraicNumberCalculator<double> _calculator;

        [SetUp]
        public void SetUp() => _calculator = new DoubleAlgebraicNumberCalculator();

        [Test]
        public void When_calling_IsZero_On_null_calculator_Then_an_ArgumentNullException_Should_be_thrown()
        {
            // Arrange
            IAlgebraicNumberCalculator<double> calculator = null!;

            // Act
            Action action = () => calculator.IsZero(3.25);

            // Assert
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        [TestCase(-0.5, false)]
        [TestCase(0.0, true)]
        [TestCase(0.5, false)]
        public void When_calling_IsZero_With_valid_parameter_Then_the_correct_result_should_be_returned(
            double value,
            bool expected)
        {
            // Act
            var actual = _calculator.IsZero(value);

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void When_calling_IsStrictlyPositive_On_null_calculator_Then_an_ArgumentNullException_Should_be_thrown()
        {
            // Arrange
            IAlgebraicNumberCalculator<double> calculator = null!;

            // Act
            Action action = () => calculator.IsStrictlyPositive(3.25);

            // Assert
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        [TestCase(-0.5, false)]
        [TestCase(0.0, false)]
        [TestCase(0.5, true)]
        [TestCase(1e-15, true)]
        public void When_calling_IsStrictlyPositive_With_valid_parameter_Then_the_correct_result_should_be_returned(
            double value,
            bool expected)
        {
            // Act
            var actual = _calculator.IsStrictlyPositive(value);

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void When_calling_IsPositive_On_null_calculator_Then_an_ArgumentNullException_Should_be_thrown()
        {
            // Arrange
            IAlgebraicNumberCalculator<double> calculator = null!;

            // Act
            Action action = () => calculator.IsPositive(3.25);

            // Assert
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        [TestCase(-0.5, false)]
        [TestCase(0.0, true)]
        [TestCase(0.5, true)]
        [TestCase(1e-15, true)]
        public void When_calling_IsPositive_With_valid_parameter_Then_the_correct_result_should_be_returned(
            double value,
            bool expected)
        {
            // Act
            var actual = _calculator.IsPositive(value);

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void When_calling_IsStrictlyNegative_On_null_calculator_Then_an_ArgumentNullException_Should_be_thrown()
        {
            // Arrange
            IAlgebraicNumberCalculator<double> calculator = null!;

            // Act
            Action action = () => calculator.IsStrictlyNegative(3.25);

            // Assert
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        [TestCase(-0.5, true)]
        [TestCase(0.0, false)]
        [TestCase(0.5, false)]
        [TestCase(1e-15, false)]
        [TestCase(-1e-15, true)]
        public void When_calling_IsStrictlyNegative_With_valid_parameter_Then_the_correct_result_should_be_returned(
            double value,
            bool expected)
        {
            // Act
            var actual = _calculator.IsStrictlyNegative(value);

            // Assert
            actual.Should().Be(expected);
        }

        [Test]
        public void When_calling_IsNegative_On_null_calculator_Then_an_ArgumentNullException_Should_be_thrown()
        {
            // Arrange
            IAlgebraicNumberCalculator<double> calculator = null!;

            // Act
            Action action = () => calculator.IsNegative(3.25);

            // Assert
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Test]
        [TestCase(-0.5, true)]
        [TestCase(0.0, true)]
        [TestCase(0.5, false)]
        [TestCase(1e-15, false)]
        [TestCase(-1e-15, true)]
        public void When_calling_IsNegative_With_valid_parameter_Then_the_correct_result_should_be_returned(
            double value,
            bool expected)
        {
            // Act
            var actual = _calculator.IsNegative(value);

            // Assert
            actual.Should().Be(expected);
        }
    }
}
