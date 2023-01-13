using TestImplementationOnSite;
using System.Collections.Generic;
namespace Tests;

public class Class1
{
    public int FromStrIntToInt(string str, int i)
    {
        return 1;
    }

    public int FromStrsIntsToInt(string[] strs, int[] ints)
    {
        return 1;
    }
}

public class TestSets
{
    public (string, int)[] StrIntInputs_L2 = new (string, int)[]
    {
        ("a", 1),
        ("b", 2),
    };

    public (string[], int[])[] StrsIntsInputs_L2 = new (string[], int[])[]
    {
        (new string[]{"a", "b"}, new int[]{1, 2}),
        (new string[]{"c", "d"}, new int[]{3, 4}),
    };

    public int[] IntResults_L2 = new int[]
    {
        1,
        2
    };
}

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void RegisterMethodWithInputsAndExpectedResults_ReadRegisteredMothodsInfo()
    {
        CustomTester customTester = new CustomTester();
        Class1 class1 = new Class1();
        TestSets testSets = new TestSets();

        customTester.RegisterTest(class1.FromStrIntToInt, testSets.StrIntInputs_L2, testSets.IntResults_L2);
        customTester.RegisterTest(class1.FromStrsIntsToInt, testSets.StrsIntsInputs_L2, testSets.IntResults_L2);

        string expected = "ClassName : Class1, MethodName : FromStrIntToInt\n";
        expected = "ClassName : Class1, MethodName : FromStrsIntsToInt";
        string result = customTester.ReadTests();

        Assert.AreEqual(expected, result);
    }


    [TestMethod]
    public void PlannedUnittests()
    {
        /// RegisterMethodVarietyInputs
        /// ReadRegisteredMothodsInfo
        /// DoAllTest_ReturnTestResult_IncludingBoolValueClassNameMethodName
        /// DoATest_ReturnTestResult_IncludingBoolValueClassNameMethodName
        /// 
    }
}