using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaffemaskinenDel1
{
    public abstract class Machine
    {
        public abstract string Start();
        public abstract string Stop();
    }
}
