namespace CodelandUsernameValidation;


public class Test
{
    string _strFalse = "false";
    string _strTrue = "true";
    private Solver _solver= new Solver();
    public delegate bool DelTest();
    public List<DelTest> allTests = new List<DelTest>();

    public Test()
    {
        allTests.Add(PutFirstCharNotAsLetter_ReturnFalse);
        allTests.Add(PutPassableStrings_ReturnTrue);
        allTests.Add(PutMiddleSomeCharNotAsLetterNorNumNorUnderscore_ReturnFalse);
        allTests.Add(PutLastCharAsUnderscore_ReturnFalse);
    
    }

    public bool PutLastCharAsUnderscore_ReturnFalse()
    {
        string[] strings =
        {
            "asfdfs_",
            "Bdf__df132_",
            "dfe__w!b_"
        };

        foreach(var str in strings)
        {
            if(_solver.DO(str) != _strFalse)
                return false;
        }

        return true;
    }

    public bool PutMiddleSomeCharNotAsLetterNorNumNorUnderscore_ReturnFalse()
    {
        string[] strings =
        {
            "asfd§/fs",
            "Bdf__d?f132",
            "dfe__w!b"
        };

        foreach(var str in strings)
        {
            if(_solver.DO(str) != _strFalse)
                return false;
        }

        return true;
    }


    public bool PutPassableStrings_ReturnTrue()
    {
        string[] strings =
        {
            "ZsfdAfs",
            "adf__df132",
            "dfe__wb",
            "afpp_bA"
        };

        foreach(var str in strings)
        {
            if(_solver.DO(str) != _strTrue)
                return false;
        }

        return true;
    }

    public bool PutFirstCharNotAsLetter_ReturnFalse()
    {
        string[] strings =
        {
            "_ZsfdAfs",
            "1adf__df132",
            "%dfe__wb",
            "0afpp_bA"
        };

        foreach(var str in strings)
        {
            if(_solver.DO(str) != _strFalse)
                return false;
        }

        return true;
    }
}
