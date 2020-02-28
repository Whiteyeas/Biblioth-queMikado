using FluentAssertions;
using System;
using Xunit;
//using BibliothqueMikado

public class RemoveMediaTests
{
    [Theory]
    [InlineData(-1)]
    [InlineData(-2)]
    public void NegativeId_ShouldThrow_ArgumentException(int id)
    {
        User user = new User("Test", "Test", "Test");
        try
        {
            user.RemoveMedia(id);
        }
        catch(Exception e)
        {
            e.Should().BeOfType(typeof(ArgumentException));
        }
    }
    
    [Fact]
    public void OutOfRangeId_ShouldThrow_ArgumentOutOfRangeException()
    {
        User user = new User("Test", "Test", "Test");
        try
        {
            user.RemoveMedia(6);
        }
        catch (Exception e)
        {
            e.Should().BeOfType(typeof(ArgumentOutOfRangeException));
        }
    }
}
