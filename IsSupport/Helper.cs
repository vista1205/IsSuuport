using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public void CloseWindow()
        {
            foreach (Window window in App.Current.Windows)
            {
                if (window is AddEmployee)
                {
                    window.Close();
                }
            }
        }
        public void CloseParentWondow()
        {
            foreach (Window window in App.Current.Windows)
            {
                if (window is MainWindow)
                {
                    window.Close();
                }
            }
        }
    }
}
