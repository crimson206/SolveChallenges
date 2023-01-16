namespace TestImplementationOnSite;

using System;
using System.Collections;
using System.Collections.Generic;

/// with an example problem, Bracket Combinations
/// to check the result of the test,
/// 1. conduct "Solve(int)" method
/// 2. Check the return value of "GetResultString()" method
public class BracketCombinations : EachInvokeTester
{

    string _resultString = String.Empty;

    /// num is an integer >= 1
    /// No shield against a large input was not implemented
    public int Solve(int num)
    {
    int numCopy = num;

    int size = CalTestSize(numCopy);
    Dictionary<int, int> binarySumDict = GenerateBinarySumDict(num, size);
    int sum = AddUpSquareOfValuesBiggerThanMinus2(binarySumDict);

    _RegisterTestResult("Solve", new object[]{num, sum});
    return sum;
    }

    public int CalTestSize(int num)
    {
    int size = 1;

    for(int i = 0; i < num -1; i++)
    {
        size *= 2;
    }

    _RegisterTestResult("CalTestSize",new object[]{num, size});
    return size;
    }

    public Dictionary<int, int> GenerateBinarySumDict(int num, int size)
    {

    Dictionary<int, int> binarySumDict = new Dictionary<int, int>();

    for(int i = 0; i < size; i++)
    {
        int sum = CalBinarySum_ReturnMinus2IfNotValid(num, i);
        if(binarySumDict.ContainsKey(sum) == true)
        {
        binarySumDict[sum]++;
        }
        else
        {
        binarySumDict[sum] = 1;
        }
    }

    _RegisterTestResult("GenerateBinarySumDict", new object[]{num, size, binarySumDict});

    return binarySumDict;
    }

    public int AddUpSquareOfValuesBiggerThanMinus2(Dictionary<int, int> binarySumDict)
    {
    int sum = 0;

    foreach(var pair in binarySumDict)
    {
        if(pair.Key >= -1)
        {
        sum += pair.Value * pair.Value;
        }
    }

    _RegisterTestResult("AddUpSquareOfValuesBiggerThanMinus2", new object[]{binarySumDict, sum});

    return sum;
    }

    public int CalBinarySum_ReturnMinus2IfNotValid(int num, int index)
    {
    int indexCopy = index;
    int binarySum = 0;

    for(int i = 0; i < num - 1; i++)
    {
        if(indexCopy % 2 == 0)
        {
          binarySum++;
        }
        else
        {
          binarySum--;
          if(binarySum < -1)
          {
            break;
          }
        }

        indexCopy /= 2;
    }

    _RegisterTestResult("CalBinarySum_ReturnMinus2IfNotValid", new object[]{num, index, binarySum});

    return binarySum;
    }
}

public class EachInvokeTester
{
    string _resultString = String.Empty;

    /// the core implementation of the test is from here
    public string GetResultString()
    {
    return _resultString;
    }

    protected void _RegisterTestResult(string methodName, object[] inputs)
    {
    _resultString += "\n\n" + methodName;

    foreach(var input in inputs)
    {
        if(input is IEnumerable)
        _resultString += "\n" + _ConvertEnumerableToString(input);
        else
        _resultString += "\n" + input.ToString();
    }
    }

    protected string _ConvertEnumerableToString(object target)
    {
    string str = String.Empty;

    foreach(var ele in (IEnumerable)target)
        str += ele.ToString() + ",";

    return str;
    }
}