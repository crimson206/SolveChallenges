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
    public static (string, int)[] StrIntInputs_L2 = new (string, int)[]
    {
        ("a", 1),
        ("b", 2),
    };

    public static (string[], int[])[] StrsIntsInputs_L2 = new (string[], int[])[]
    {
        (new string[]{"a", "b"}, new int[]{1, 2}),
        (new string[]{"c", "d"}, new int[]{3, 4}),
    };

    public static int[] IntResults_L2 = new int[]
    {
        1,
        2
    };

    public static string[] StrResults_L2 = new string[]
    {
        "1",
        "2"
    };
}

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void RegisterMethodWithInputsAndExpectedResults_ReadRegisteredMothodsInfo()
    {
        CustomTester customTester = new CustomTester();

        customTester.RegisterTest(Class1.FromStrIntToInt, TestSets.StrIntInputs_L2, TestSets.IntResults_L2);
        customTester.RegisterTest(Class1.FromStrsIntsToInt, TestSets.StrsIntsInputs_L2, TestSets.IntResults_L2);

        string expected = "ClassInfo : Tests.Class1, MethodInfo : Int32 FromStrIntToInt(System.String, Int32)\n";
        expected += "ClassInfo : Tests.Class1, MethodInfo : Int32 FromStrsIntsToInt(System.String[], Int32[])\n";
        string result = customTester.ReadTests();
        Assert.AreEqual(expected, result);
    }

    [DataRow()]
    [DataRow()]
    [DataRow()]
    [DataTestMethod]
    public void RegisterFunctionWithWrongArgs_ThrowError()
    {
        CustomTester customTester = new CustomTester();

        customTester.RegisterTest(Class1.FromStrIntToInt, TestSets.StrsIntsInputs_L2, TestSets.IntResults_L2);
        Assert.ThrowsException<Exception>(() => customTester.RegisterTest(Class1.FromStrIntToInt, TestSets.StrsIntsInputs_L2, TestSets.IntResults_L2));

    }

    [TestMethod]
    public void PlannedUnittests()
    {
        /// DoATest_ReturnTrue_IfMethodReturnsExpectedValue
        /// DoAllTest_ReturnTestResult_IncludingBoolValueClassNameMethodName
        /// DoATest_ReturnTestResult_IncludingBoolValueClassNameMethodName
    }
}