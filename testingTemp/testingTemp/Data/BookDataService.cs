using EndToEndDB.Data.EndToEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndToEnd.Data
{
    public class BookDataService
    {
        private readonly EndtoEndContext _context;

        public BookDataService(EndtoEndContext context)
        {
            _context = context;
        }

        public Task<List<BookData>>
            GetBookAsync(string strCurrentUser)
        {
            List<BookData> colBooksData = new List<BookData>();
            //Get Book data
            colBooksData = (from bookData in _context.BookData
                                //only get entries for the current logged in user
                            where bookData.UserName == strCurrentUser
                            select bookData).ToList();
            return Task.FromResult(colBooksData);
        }
        public Task<BookData>
            CreateBookAsync(BookData objBookData)
        {
            _context.BookData.Add(objBookData);
            _context.SaveChanges();
            return Task.FromResult(objBookData);
        }
    }
}
