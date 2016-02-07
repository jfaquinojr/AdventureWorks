using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFA.AdventureWorks.Web.ViewModel
{
    public class PagerBase
    {
        public int CurrentPage { get; set; } = 1;
        public int PreviousPage { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages
        {
            get
            {
                return TotalRecords / PageSize;
            }
        }

        public int GetStartingPagerNumber(int pagerCount)
        {

            int middlePager = (int)(pagerCount / 2) + 1;

            int start = CurrentPage - middlePager;
            if (start < 0) start = 0;

            return start;

        }
    }
}
