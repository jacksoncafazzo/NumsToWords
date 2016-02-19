using System;
using System.Collections.Generic;
using Xunit;

namespace NumtoWordsNamespace
{
  public class NumtoWordsTest
  {
    [Fact]
    public void WordIt_Sending1WillReturnOne_true()
    {
      NumtoWords newNumToWords = new NumtoWords(1);
      Assert.Equal("one", newNumToWords.WordIt());
    }
    [Fact]
    public void WordIt_Sending11WillReturnEleven_true()
    {
      NumtoWords newNumToWords = new NumtoWords(11);
      Assert.Equal("eleven", newNumToWords.WordIt());
    }
    [Fact]
    public void WordIt_Sending19WillReturnNineteen_true()
    {
      NumtoWords newNumToWords = new NumtoWords(19);
      Assert.Equal("nineteen", newNumToWords.WordIt());
    }
    [Fact]
    public void WordIt_Sending37WillReturnThirtySeven_true()
    {
      NumtoWords newNumToWords = new NumtoWords(37);
      Assert.Equal("thirty seven", newNumToWords.WordIt());
    }
    [Fact]
    public void WordIt_Sending187WillReturnOneHundredEigthySeven_true()
    {
      NumtoWords newNumToWords = new NumtoWords(187);
      Assert.Equal("one hundred and eighty seven", newNumToWords.WordIt());
    }
    [Fact]
    public void WordIt_Sending3482WillReturnTheText_true()
    {
      NumtoWords newNumToWords = new NumtoWords(3482);
      Assert.Equal("three thousand, four hundred and eighty two", newNumToWords.WordIt());
    }
    [Fact]
    public void WordIt_Sending94610WillReturnTheText_true()
    {
      NumtoWords newNumToWords = new NumtoWords(94610);
      Assert.Equal("ninety four thousand, four hundred and eighty two", newNumToWords.WordIt());
    }
  }
}
