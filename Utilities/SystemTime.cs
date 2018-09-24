using System;

namespace Utilities
{
    public static class SystemTime
    {
        public static Func<DateTime> Current = () => DateTime.UtcNow;

    }

}
