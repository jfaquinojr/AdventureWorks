using JFA.AdventureWorks.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JFA.AdventureWorks.UnitTests
{
    [TestClass]
    public class PaginationTests
    {
        [TestMethod]
        public void Pagination_Check10of100_MustReturnValidPageAndRowCounts()
        {

            // prepare 100 ints
            List<int> theList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                theList.Add(i);
            }

            var p = new Paginator<int>(theList);
            p.RowCount = 10;
            p.PageNumber = 1;

            Assert.AreEqual(p.TotalPages, 10);         // should be 10 because 100 / 10 = 10
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // Rowcount should be 10 in this test
            Assert.AreEqual(p.Rows[0], 0);


            // go to next page
            p.PageNumber = 2;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 10);

            // go to next page
            p.PageNumber = 3;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 20);

            // go to next page
            p.PageNumber = 4;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 30);

            // go to next page
            p.PageNumber = 5;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 40);

            // go to next page
            p.PageNumber = 6;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 50);

            // go to next page
            p.PageNumber = 7;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 60);

            // go to next page
            p.PageNumber = 8;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 70);

            // go to next page
            p.PageNumber = 9;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 80);

            // go to next page
            p.PageNumber = 10;

            Assert.AreEqual(p.TotalPages, 10);         // should still be 10 
            Assert.AreEqual(p.TotalRows, 100);         // should still be 100
            Assert.AreEqual(p.RowCount, p.Rows.Count); // should still be 10 in this test
            Assert.AreEqual(p.Rows[0], 90);

        }

    }
}
