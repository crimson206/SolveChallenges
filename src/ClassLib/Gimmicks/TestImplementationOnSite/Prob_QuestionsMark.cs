namespace TestImplementationOnSite;

using System;
using System.Collections.Generic;

class MainClass {

  public static string QuestionsMarks(string str) {

    Test test = new Test();
    Solver solver = new Solver();

    return solver.Do(str);
  }
}

public class Solver
{
  public string Do(string str)
  {
    int leftIndex = FindIndexOfNextNum(str, 0);
    int rightIndex = 0;
    bool atLeast = false;

    for(int i = 0; i < str.Length; i++)
    {
      
      rightIndex = FindIndexOfNextNum(str, leftIndex + 1);
      if(rightIndex == -1)
        break;
      if(AddTwoNumber(str, leftIndex, rightIndex) == 10)
      {
        atLeast = true;
        if(CountMarks(str, leftIndex, rightIndex) != 3)
          return "false";
      }
      leftIndex = rightIndex;
    }

    if(atLeast == false)
      return "false";

    return "true";
  }

  public int FindIndexOfNextNum(string str, int startIndex)
  {

    for(int i = startIndex; i < str.Length; i++)
    {
      if(str[i] >= '0' && str[i] <= '9')
        return i;
    }

    return -1;
  }

  public int CountMarks(string str, int startIndex, int endIndex)
  {
    int result = 0;

    for(int i = startIndex; i <= endIndex; i++)
    {
      if(str[i] == '?')
        result++;
    }

    return result;
  }

  public int AddTwoNumber(string str, int index1, int index2)
  {
    int sum = str[index1] + str[index2] - '0' - '0';

    return sum;
  }
}

public class Test
{
  Solver _solver = new Solver();
  string _result = String.Empty;

  public string Do()
  {
    _TestFindIndexOfNextNum();
    _TestCountMarks();
    _TestAddTwoNumber();
    return _result;
  }

  private void _TestFindIndexOfNextNum()
  {
    List<bool> results = new List<bool>();

    results.Add(_solver.FindIndexOfNextNum("aef??5fea", 2) == 5);
    results.Add(_solver.FindIndexOfNextNum("13aef??5fea", 2) == 7);
    results.Add(_solver.FindIndexOfNextNum("13aef?fea", 6) == -1);
  
    _result += ConvertBoolsString(results) + "TestFindIndexOfNextNum\n";
  }

  private void _TestCountMarks()
  {
    List<bool> results = new List<bool>();

    results.Add(_solver.CountMarks("aef??5fea", 2, 7) == 2);
    results.Add(_solver.CountMarks("13aef??5fea", 1, 4) == 0);
  
    _result += ConvertBoolsString(results) + "CountMarks\n";
  }

  private void _TestAddTwoNumber()
  {
    List<bool> results = new List<bool>();

    results.Add(_solver.AddTwoNumber("a2ef??5fea", 1, 6) == 7);
    results.Add(_solver.AddTwoNumber("13aef??5fea", 0, 1) == 4);

    _result += ConvertBoolsString(results) + "AddTwoNumber\n";
  }

  private string ConvertBoolsString(List<bool> bools)
  {
    string result = String.Empty;

    foreach(var bl in bools)
    {
      result += bl.ToString() + ", ";
    }

    return result;
  }
}
