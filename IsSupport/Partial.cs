using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSupport
{
public partial class Kartridjs
    {
        public string ImagePath 
        {
            get
            {
                string imagePath = null;
                if (Image != null)
                {
                    imagePath = Environment.CurrentDirectory + Image;
                }
                return imagePath;
            }
        }
    }
}
