using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicFacks
{
    public interface IDynamicCalc
    {
        dynamic add(Object x,Object y);

    }
    public class DynamicCalc : IDynamicCalc
    {
        public dynamic add(object x, object y)
        {
           if(x.GetType().Name=="Int32"&&y.GetType().Name=="Int32")
                return Convert.ToInt32((Int32)x+(Int32)y);
           else
                return Convert.ToInt32(0);
        }
    }
}
