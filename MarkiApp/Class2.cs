using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkiApp
{
    public partial class Mark
    {
        public decimal PriceX => Price * Convert.ToInt32(Edition);

    }
}
