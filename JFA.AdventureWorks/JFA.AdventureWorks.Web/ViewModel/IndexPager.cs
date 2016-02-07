using JFA.AdventureWorks.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFA.AdventureWorks.Web.ViewModel
{
    public class IndexPager<T> : PagerBase
    {
        public IEnumerable<T> TheList { get; set; }
        public T TheClass { get; set; }
    }
}
