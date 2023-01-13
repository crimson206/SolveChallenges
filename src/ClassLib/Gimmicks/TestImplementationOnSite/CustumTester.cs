namespace TestImplementationOnSite;

public class CustomTester
{
    List<Delegate> _tests = new List<Delegate>{};
    List<object> _inputs = new List<object>{};
    List<object> _expectedResults = new List<object>{};

    public void RegisterTest(Delegate method, object inputs, object expectedResults)
    {
        _tests.Add(method);
        _inputs.Add(inputs);
        _expectedResults.Add(expectedResults);
    }

    public string ReadTests()
    {
        string testsInfo = String.Empty;

        foreach(var test in _tests)
        {
            testsInfo += "ClassInfo : " + test.Target;
            testsInfo += ", MethodInfo : " + test.Method + "\n";
        }

        return testsInfo;
    }
}
