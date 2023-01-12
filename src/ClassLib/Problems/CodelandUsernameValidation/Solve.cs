namespace CodelandUsernameValidation;

public class Solver
{
    string strFalse = "false";
    string strTrue = "true";
    byte minLetter = (byte)'A';
    byte maxLetter = (byte)'z';
    byte minNum = (byte)'0';
    byte maxNum = (byte)'9';

    public string DO(string name)
    {
        if(CheckLetter(name[0]) == false)
            return strFalse;        

        foreach(var c in name)
        {
            if(CheckLetter(c) == true
            || CheckNum(c) == true
            || CheckUnderscore(c) == true)
                continue;
            else
                return strFalse;
        }

        return strTrue;
    }

    public bool CheckLetter(char c)
    {
        if(c <= maxLetter && c >= minLetter)
            return true;
        return false;
    }

    public bool CheckNum(char c)
    {
        if(c <= maxNum && c >= minNum)
            return true;
        return false;
    }

    private bool CheckUnderscore(char c)
    {
        if(c == '_')
            return true;
        return false;
    }

}

