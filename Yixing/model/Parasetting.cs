using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yixing.model
{
    abstract class Parasetting
    {
        
        public abstract void write2File(String filePath);

        public  int type { get; set; }

        public  int upCount { get; set; }

        public  int downCount { get; set; }

        public List<ParasettingDUC> ducList { get; set; }
        
    }
}
