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
  }
}
