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
        allTests.Add(PutFirstCharNotAsLetter_ReturnFalse_1);
        allTests.Add(PutPassableStrings_ReturnTrue_2);
        allTests.Add(PutMiddleSomeCharNotAsLetterNorNumNorUnderscore_ReturnFalse_3);
        allTests.Add(PutLastCharAsUnderscore_ReturnFalse_4);
        allTests.Add(PutNameWihtOutOfRange_ReturnFalse_5);    
    }

    public bool PutNameWihtOutOfRange_ReturnFalse_5()
    {
        string[] strings =
        {
            "as_",
            "Bdfawerafadfdafadfdsafaddaf__df132_",
            ""
        };

        foreach(var str in strings)
        {
            if(_solver.DO(str) != _strFalse)
                return false;
        }

        return true;
    }

    public bool PutLastCharAsUnderscore_ReturnFalse_4()
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

    public bool PutMiddleSomeCharNotAsLetterNorNumNorUnderscore_ReturnFalse_3()
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


    public bool PutPassableStrings_ReturnTrue_2()
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

    public bool PutFirstCharNotAsLetter_ReturnFalse_1()
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
