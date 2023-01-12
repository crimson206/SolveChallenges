namespace CodelandUsernameValidation;

public class Solver
{
    string _strFalse = "false";
    string _strTrue = "true";
    byte _minSmall = (byte)'a';
    byte _maxSmall = (byte)'z';
    byte _minLarge = (byte)'A';
    byte _maxLarge = (byte)'Z';
    byte _minNum = (byte)'0';
    byte _maxNum = (byte)'9';

    public string DO(string name)
    {
        if(name.Length < 4 || name.Length > 25)
            return _strFalse;

        if(CheckLetter(name[0]) == false)
            return _strFalse;        

        if(CheckUnderscore(name[name.Length -1]) == true)
            return _strFalse;

        foreach(var c in name)
        {
            if(CheckLetter(c) == true
            || CheckNum(c) == true
            || CheckUnderscore(c) == true)
                continue;
            else
                return _strFalse;
        }

        return _strTrue;
    }

    public bool CheckLetter(char c)
    {
        if(c <= _maxLarge
        && c >= _minLarge)
            return true;

        if(c <= _maxSmall
        && c >= _minSmall)
            return true;

        return false;
    }

    public bool CheckNum(char c)
    {
        if(c <= _maxNum && c >= _minNum)
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
