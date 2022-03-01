using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSupport
{
    internal class Helper
    {
        private static IsSupportContext _context;
         public static IsSupportContext GetIsSupportContext()
        {
            if (_context == null)
            {
                _context = new IsSupportContext();
            }
            return _context;
        }
    }
}
