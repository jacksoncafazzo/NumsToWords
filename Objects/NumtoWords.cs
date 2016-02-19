using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace NumtoWordsNamespace
{
  public class NumtoWords
  {
    private int _number;
    //
    // private static List<Scrabble> _instances = new List<Scrabble>(){};

    private Dictionary<int, string> _onesPlace = new Dictionary<int, string>()
    {
      { 1, "one" },
      { 2, "two" },
      { 3, "three" },
      { 4, "four" },
      { 5, "five" },
      { 6, "six" },
      { 7, "seven" },
      { 8, "eight" },
      { 9, "nine" },
      { 0, "" },
    };

    private Dictionary<int, string> _teens = new Dictionary<int, string>()
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

    private Dictionary<int, string> _tens = new Dictionary<int, string>()
    {
      { 20, "twenty" },
      { 30, "thirty" },
      { 40, "fourty" },
      { 50, "fifty" },
      { 60, "sixty" },
      { 70, "seventy" },
      { 80, "eighty" },
      { 90, "ninety" }
    };

    public NumtoWords(int input)
    {
      _number = input;
    }

    public string WordIt()
    {
      string result = "";

      int onesPlace = _number % 10;
      string finalNumberString = "";
      if ( _number > 9 && _number < 20)
      {

        result += _teens[_number];
      }
      finalNumberString = _onesPlace[onesPlace];
      _number = _number - onesPlace;

      if (_number >= 20 && _number < 100)
      {
        result += _tens[_number] + " ";
      }
      else
      {
        result += _onesPlace[_number];
      }
      return result + finalNumberString;
    }
  }
}
