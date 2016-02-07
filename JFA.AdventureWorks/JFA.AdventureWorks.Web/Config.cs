using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JFA.AdventureWorks.Web
{
    public static class Config
    {
        public static int MaxPagerCount
        {
            get
            {
                int i;
                if (!int.TryParse(ConfigurationManager.AppSettings["MaxPagerCount"], out i))
                {
                    i = 5;
                }

                return i;
            }
        }

        public static int PageSize
        {
            get
            {
                int i;
                if (!int.TryParse(ConfigurationManager.AppSettings["PageSize"], out i))
                {
                    i = 10;
                }

                return i;
            }
        }
    }
}
