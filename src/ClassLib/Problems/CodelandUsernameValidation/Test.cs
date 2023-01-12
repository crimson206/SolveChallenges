namespace CodelandUsernameValidation;


public class Test
{
    public delegate bool DelTest();
    public List<DelTest> allTests = new List<DelTest>();

    public Test()
    {
        allTests.Add(PutFirstCharNotAsLetter_ReturnFalse);
    }

    public bool PutFirstCharNotAsLetter_ReturnFalse()
    {
        Solve solve = new Solve();
        string startNum = "12bad";
    
        return "false" == solve.DO(startNum);
    }
}
