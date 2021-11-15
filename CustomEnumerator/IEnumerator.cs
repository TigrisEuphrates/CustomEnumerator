using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    interface CIEnumerator
    {
            bool MoveNext();
            object Current { get; }
            void Reset();
    }
}
