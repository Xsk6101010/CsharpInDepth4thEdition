using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPractice
{
   public class OverridedArray : ArrayList
    {
        public override int Count { get; }
    }
}
