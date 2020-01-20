using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public class Platform
    {
        private IServiceCollection _serviceCollection;

        internal List<OperationalAgentInfo> RunningAgents { get; set; }


        /// <summary>
        /// Lists the Autonomous Agents that are being handled by this instance
        /// </summary>
        public IEnumerable<IAutonomousAgent> Agents
        {
            get
            {
                return RunningAgents.Select(i => i.Agent);
            }
        }

        /// <summary>
        /// Loads a implementation of IAutonomousAgent, instantiate it and makes
        /// it ready to run
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Task<IAutonomousAgent> LoadAutonomousAgent<T>() where T : class, IAutonomousAgent
        {
            return null;
        }
    }
}
