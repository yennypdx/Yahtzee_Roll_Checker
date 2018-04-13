using System.Collections.Generic;

namespace YahtzeeRollChecker
{
    public interface IRoll
    {
        IList<IDice> Die { get; set; }
    }
}