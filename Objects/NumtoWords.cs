using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NumtoWordsNamespace
{
  public class NumtoWords
  {
    private int _number;
    private string _returnString;
    private static List<NumtoWords> _instances = new List<NumtoWords>(){};

    public NumtoWords(int input)
    {
      _number = input;
      // _numLength = Math.Floor(roundy);
      //  (decimal)Math.Floor((double)Math.Log10(input) + 1);
      _instances.Add(this);
    }
    //




    private Dictionary<int, string> _teensString = new Dictionary<int, string>()
    {
      { 10, "ten" },
      { 11, "eleven" },
      { 12, "twelve" },
      { 13, "thirteen" },
      { 14, "fourteen" },
      { 15, "fifteen" },
      { 16, "sixteen" },
      { 17, "seventeen" },
      { 18, "eighteen" },
      { 19, "nineteen" },
    };

    private string[] _singlesString = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
    private string[] _tensString = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};




    public string WordIt()
    {
      string _returnString = "";
      int deleter;


      if (_number > 999 && _number < 10000)
      {
        deleter = _number / 1000;
        _returnString = _returnString + _singlesString[deleter] + " thousand, ";
        _number = _number - (deleter * 1000);
      }
      if (_number > 99 && _number < 1000)
      {
        deleter = _number / 100;
        _returnString = _returnString + _singlesString[deleter] + " hundred and ";
        _number = _number - (deleter * 100);
      }
      if (_number > 19 && _number < 100)
      {
        deleter = _number / 10;
        int onesPlace = _number % 10;
        _returnString = _returnString + _tensString[deleter-1] + " " + _singlesString[onesPlace];
      }
      if (_number > 9 && _number < 20)
      {
        _returnString = _returnString + _teensString[_number];
      }
      if (_number < 10)
      {
        _returnString = _returnString + _singlesString[_number];
      }





      // if ( _number > 9 && _number < 20)
      // {
      //
      //   result += _teens[_number];
      // }
      // finalNumberString = _onesPlace[onesPlace];
      // _number = _number - onesPlace;
      //
      // if (_number >= 20 && _number < 100)
      // {
      //   result += _tens[_number] + " ";
      // }
      // else
      // {
      //   result += _onesPlace[_number];
      // }
      return _returnString;
    }
  }
}
