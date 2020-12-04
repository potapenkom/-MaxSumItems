using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSumItems
{
   public class Result
    {
        public int MaxRowIndex { private set; get; }
        public List<int> RejectedLines { private set; get; }

        public Result(int maxRowIndex, List<int> rejectedLines)
        {
            MaxRowIndex = maxRowIndex;
            RejectedLines = rejectedLines;
        }

        public void ShowResult()
        {
            Console.WriteLine($"Line number with the maximum sum of elements is {MaxRowIndex}");
            char separator = ',';
            string str = String.Join(separator, RejectedLines);
            Console.WriteLine($"Line numbers where non-numeric items are encountered ('rejected lines') is { str}");
        }

    }
}
