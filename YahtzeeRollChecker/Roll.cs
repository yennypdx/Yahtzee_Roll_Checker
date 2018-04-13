using System.Collections.Generic;

namespace YahtzeeRollChecker
{
    public class Roll : IRoll
    {
        public IList<IDice> Die { get; set; }
    }
}
