using System;
using System.Threading;
using Library;

namespace Core
{
    internal class OperationalAgentInfo
    {
        internal IAutonomousAgent Agent { get; set; }

        internal CancellationTokenSource CancellationTokenSource { get; set; }

        internal Guid UniqueID { get; set; }
    }
}
