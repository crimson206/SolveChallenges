namespace CodelandUsernameValidation;

public class Solve
{
    string strFalse = "false";
    string strTrue = "true";
    byte minLetter = (byte)'A';
    byte maxLetter = (byte)'z';

    public string DO(string name)
    {
        if(CheckLetter(name[0]) == false)
            return strFalse;        

        return "test";
    }

    public bool CheckLetter(char c)
    {
        if(c <= maxLetter && c >= minLetter)
            return true;
        return false;
    }

}

