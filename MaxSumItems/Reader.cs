using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSumItems
{
    public class Reader
    {
        string[] _lines;
        public Reader(UserFile userFile)
        {
            PathWrapper wrapper = new PathWrapper(userFile.Path);
            if (wrapper.PathExists())
            {
                _lines = userFile.Content();
            }
        }

        public Result Read()
        {
            int maxRowIndex = -1;
            List<int> numbers = new List<int>();
            int maxSum = int.MinValue;
            double number;
            for (int i = 0; i < _lines.Length; i++)
            {
                int sum = 0;
                string[] line = _lines[i].Split(',');
                for (int j = 0; j < line.Length; j++)
                {
                    if (!Double.TryParse(line[j], out number))
                    {
                        numbers.Add(i + 1);
                        break;
                    }
                    else
                    {
                        sum += Int32.Parse(line[j]);
                    }
                }
                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxRowIndex = i + 1;
                }
            }
            Result result = new Result(maxRowIndex, numbers);
            result.ShowResult();
            return result;
        }

    }
}
