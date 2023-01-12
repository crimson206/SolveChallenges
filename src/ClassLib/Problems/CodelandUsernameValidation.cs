namespace CodelandUsernameValidation;

public class Solve
{

    public string DO(string name)
    {
        return "test";
    }

}

public class Test
{
    public delegate bool DelTest();
    public List<DelTest> allTests = new List<DelTest>();

    public Test()
    {
        allTests.Add(NotPutFirstLetter_ReturnFalse);
    }

    public bool NotPutFirstLetter_ReturnFalse()
    {
        Solve solve = new Solve();
        string startNum = "12bad";
    
        return "false" == solve.DO(startNum);
    }
}
