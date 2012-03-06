using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BareMugShot.Core.Formatting
{
    public interface ISqlFormatter
    {
        string PrettyItUp(string unformattedSql);
    }
}
