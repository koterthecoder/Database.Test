using System;

namespace Utilities
{
    public interface IEntity
    {
        long Id { get; }
        DateTime Modified { get; set; }
        DateTime Created { get; set; }
    }
}
