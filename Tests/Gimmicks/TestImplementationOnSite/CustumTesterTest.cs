using TestImplementationOnSite;
using System.Collections.Generic;
namespace Tests;

public static class Class1
{
    public static int FromStrIntToInt(string str, int i)
    {
        return 1;
    }

    public static int FromStrsIntsToInt(string[] strs, int[] ints)
    {
        return 1;
    }

    public static int AddTwoNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
}

public static class TestSets
{
    public static object[][] StrIntInputs_L2 = new object[][]
    {
        new object[]{"a", 1},
        new object[]{"b", 2},
    };

    public static object[][] StrsIntsInputs_L2 = new object[][]
    {
        new object[] {new object[]{"a", "b"}, new object[]{1, 2}},
        new object[] {new object[]{"c", "d"}, new object[]{3, 4}},
    };

    public static object[] IntResults_L2 = new object[]
    {
        1,
        2
    };

    public static object[] StrResults_L2 = new object[]
    {
        "1",
        "2"
    };
}

[TestClass]
public class UnitTest1
{

    [TestMethod]
    public void InitializeWithWrongArgs_ThrowException_1()
    {

        Assert.ThrowsException<Exception>(() => new CustomTester(Class1.FromStrIntToInt, TestSets.StrIntInputs_L2, TestSets.StrResults_L2));
        Assert.ThrowsException<Exception>(() => new CustomTester(Class1.FromStrIntToInt, TestSets.StrsIntsInputs_L2, TestSets.IntResults_L2));
        
    }


    [TestMethod]
    public void PlannedUnittests()
    {
        /// InitializeWithWrongArgs_ThrowException
        /// InitializeWithoutName_NameIs_TestMethodName
        /// InitializeWithName_CheckName
        /// DoATest_ReturnTrue_IfMethodReturnsExpectedValue
        /// DoATest_ReturnTestResult_IncludingBoolValueClassNameMethodName
    }
}