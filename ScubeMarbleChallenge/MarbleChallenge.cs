using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScubeMarbleChallenge
{
    public static class MarbleChallenge
    {
        public static List<Marble> SortAndFilter(List<Marble> marbles)
        {
            Dictionary<string, int> colorLookup = new Dictionary<string, int>()
            {
                {"red", 1},
                {"orange", 2},
                {"yellow", 3},
                {"green", 4},
                {"blue", 5},
                {"indigo", 6},
                {"violet" , 7}
            };

            List<Marble> filteredMarbles = marbles.Where(m => m.Weight >= 0.5 && StringHelper.IsPalindrome(m.Name)).ToList();
            List<Marble> sortedMarbles = filteredMarbles.OrderBy(m => colorLookup[m.Color]).ToList();
            return sortedMarbles;
        }
    }
}
