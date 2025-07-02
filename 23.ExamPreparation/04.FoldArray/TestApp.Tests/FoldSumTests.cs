using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[0], "")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, "2 2 2 2")]
    [TestCase(new int[] { 1, -2, 3, 4, 5, -6, -7, 8 }, "1 5 13 -13")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 30, 50 }, "7 7 7 57 38 29")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Arrange

        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
