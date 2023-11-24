
using gluschKt_42_20.Model;

namespace glusch_kt_42_20.Tests
{
    public class GroupTests
    {
        [Fact]
        public void IsValidGroupName_KT4120_True()
        {
            var testGroup = new Group
            {
                GroupName = "KT-41-20"
            };
            var result = testGroup.IsValidGroupName();
            Assert.True(result);
        }
    }
}