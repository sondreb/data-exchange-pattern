using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Autofac;
using Tyrell.Heart.Models;
using DataSegmentExchangePattern;

namespace Tyrell.Heart.Tests
{
    public class AortaTests : TestBase
    {
        [Fact]
        public void Aorta_CheckAmount_ShouldSucceed()
        {
            // Arrange
            var aorta = Container.Resolve<Aorta>();

            var segments = new Dictionary<Data, object>();
            segments.Add(Data.ReplicantVersion, new Version(2, 0, 0, 0));
            segments.Add(Data.OperationalState, OperationalState.Panic);

            // Act
            var oxygen = aorta.Run(segments);

            // Assert
            Assert.Equal(100, oxygen.Amount);
        }
    }
}
