// See https://aka.ms/new-console-template for more information

namespace Highest_and_Lowest
{
  public static class HighsetAndLowest
    {
        public static string HighAndLow(string info)
        {
            var splitData = info.Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var max = "";
            var min= "";
            foreach (var data in splitData)
            {
                if (max.Length == 0 && min.Length == 0)
                {
                    max = data;
                    min = data;
                }
                else
                {
                    foreach (var data2 in splitData)
                    {
                        if (Convert.ToInt32(max) < Convert.ToInt32(data2))
                        {
                            max = data2;
                        }
                        else
                        {
                            if (Convert.ToInt32(min) > Convert.ToInt32(data2))
                            {
                                min = data2;
                            }
                        }
                    }
                }
            }
            return $"{max} {min}";
        }
    }
}