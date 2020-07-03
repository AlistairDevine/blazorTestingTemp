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
    }
}
