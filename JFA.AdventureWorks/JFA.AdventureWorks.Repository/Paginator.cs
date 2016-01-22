using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace JFA.AdventureWorks.Repository
{
    public class Paginator<T>
    {
        private int _rowCount = 20;
        private int _pageNo = 1;
        private int _totalRows;
        private List<T> _origList;
        private List<T> _list;
        public Paginator(List<T> list)
        {
            _origList = list;
            _totalRows = list.Count;
        }

        public int RowCount {
            get
            {
                return _rowCount;
            }

            set
            {
                _rowCount = value;

                _list = Paginate(_pageNo, _rowCount);
            }
        }

        private List<T> Paginate(int pageNo, int rows)
        {
            var result = _origList
                .Skip((pageNo - 1) * rows)
                .Take(rows)
                .ToList();

            return result;
        }

        public int PageNumber
        {
            get { return _pageNo;  }
            set
            {
                _pageNo = value;
                _list = Paginate(_pageNo, _rowCount);
            }
        }

        public int TotalPages
        {
            get { return _totalRows / _rowCount; }
        }

        public int TotalRows { get { return _totalRows; } }

        public List<T> Rows
        {
            get { return _list.ToList();  }
        }

    }
}
