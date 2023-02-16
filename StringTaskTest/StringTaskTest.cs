using StringTask;
using Xunit;

namespace StringTaskTest;

public class StringTaskTest
{
    [Fact]
    public void CompareStrings_ShouldBe_True()
    {
        // Arrange
        string strFirstTest = "dog";
        string strSecondTest = "dgo";

        // Act
        var response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.True(response);

        // Arrange
        strFirstTest = "dogd";
        strSecondTest = "ddog";

        // Act
        response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.True(response);
    }

    [Fact]
    public void CompareStrings_ShouldBe_False()
    {
        // Arrange
        string strFirstTest = "dog";
        string strSecondTest = "dfo";

        // Act
        var response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.False(response);

        // Arrange
        strFirstTest = "doog";
        strSecondTest = "ddog";

        // Act
        response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.False(response);
    }

    [Fact]
    public void CompareStrings_IsNullOrEmptyStr_ShouldBe_False()
    {
        // Arrange
        string strFirstTest = "dog";
        string strSecondTest = "";

        // Act
        var response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.False(response);

        // Arrange
        strFirstTest = "";
        strSecondTest = "ddog";

        // Act
        response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.False(response);

        // Arrange
        strFirstTest = null;
        strSecondTest = null;

        // Act
        response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.False(response);
    }

    [Fact]
    public void CompareStrings_DifferentlengthStr_ShouldBe_False()
    {
        // Arrange
        string strFirstTest = "dog";
        string strSecondTest = "dogg";

        // Act
        var response = StringOperation.CompareStrings(strFirstTest, strSecondTest);

        // Assert
        Assert.False(response);
    }
}
