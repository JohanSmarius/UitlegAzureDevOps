namespace Domain.Tests
{
    public class MetingTesten
    {
        [Fact]
        public void PositieveMeting()
        {
            var meting = new Meting(2);
            Assert.True(meting.IsPositive);

        }

        [Fact]
        public void NegatieveMeting()
        {
            var meting = new Meting(-2);
            Assert.False(meting.IsPositive);
        }
        
        [Fact]
        public void MetingIsZero()
        {
            var meting = new Meting(0);
            Assert.False(meting.IsPositive);
        }

    }
}