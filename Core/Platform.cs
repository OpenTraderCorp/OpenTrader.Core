using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library;

namespace Core
{
    public class Platform
    {
        public IEnumerable<IAutonomousAgent> Agents
        {
            get
            {
                return null;
            }
        }

        public Task<IAutonomousAgent> LoadAutonomousAgent<T>() where T : IAutonomousAgent
        {
            return null;
        }
    }
}
