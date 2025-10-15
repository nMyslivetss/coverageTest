using Xunit;
using Chipply.BusinessLogic;

public class MathHelperTests
{
    [Fact]
    public void Sum_AddsTwoNumbers()
    {
        var math = new MathHelper();
        Assert.Equal(5, math.Sum(2, 3));
    }
}
