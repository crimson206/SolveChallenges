namespace TestImplementationOnSite;

public class CustomTester
{
    string _testName;
    Delegate _method;
    object[][] _inputs;
    object _expectedResults;

    public CustomTester(Delegate method, object[][] inputs, object[] expectedResults)
    {

        _testName = "Test" + method.Method.Name;
        _method = method;
        _inputs = inputs;
        _expectedResults = expectedResults;
    }

    public string TestName {get => _testName;}

    public string ReadTests()
    {
        string testsInfo = String.Empty;

        testsInfo += "ClassInfo : " + _method!.Method.DeclaringType;
        testsInfo += ", MethodInfo : " + _method.Method;

        return testsInfo;
    }
}
