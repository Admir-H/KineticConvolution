using System.Linq;

using FluentAssertions;

using NUnit.Framework;

namespace Hilke.KineticConvolution.Tests
{
    [TestFixture]
    public class ConvolutionHelperTests
    {
        [Test]
        public void When_Direction_Ranges_Are_Included_Then_Intersection_Should_Be_The_Innermost_Range()
        {
            const double radius1 = 2.0;
            const double radius2 = 2.0;

            var convolutionFactory = new ConvolutionFactory<double>(new DoubleAlgebraicNumberCalculator());

            var arc1 = convolutionFactory.CreateArc(
                1,
                1.0,
                2.0,
                1.0,
                0.0,
                0.0,
                1.0,
                Orientation.CounterClockwise,
                radius1);

            var arc2 = convolutionFactory.CreateArc(
                1,
                2.0,
                1.0,
                1.0,
                0.5,
                0.5,
                1.0,
                Orientation.CounterClockwise,
                radius2);

            var convolution = convolutionFactory.Convolve(arc1, arc2).ToList();

            convolution.Should().HaveCount(1);

            convolution[0].Convolution.Should().BeOfType(typeof(Arc<double>));

            var convolutionAsArc = (Arc<double>)convolution[0].Convolution;

            convolutionAsArc.Center.Should().BeEquivalentTo(convolutionFactory.CreatePoint(3.0, 3.0));
        }
    }
}
