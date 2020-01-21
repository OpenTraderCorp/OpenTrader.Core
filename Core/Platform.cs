using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Library;
using Unity;

namespace Core
{
    public class Platform
    {
        private const int _defaultTimeout = 10000;

        private IUnityContainer _container;
        
        internal IReadOnlyDictionary<string,string> Configurations { get; }
        internal List<OperationalAgentInfo> RegistredAgents { get; set; }

        /// <summary>
        /// Lists the Autonomous Agents that are being handled by this instance
        /// </summary>
        public IEnumerable<(Guid Id, string Name)> Agents
        {
            get
            {
                return RegistredAgents.Select(i => (i.Agent.InstanceId, i.Agent.AgentName));
            }
        }

        /// <summary>
        /// Loads a implementation of IAutonomousAgent, instantiate it and makes
        /// it ready to run
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public async Task<Guid> LoadAutonomousAgent<T>(string name) where T : class, IAutonomousAgent
        {
            var agent = new OperationalAgentInfo();

            _container.RegisterSingleton<IAutonomousAgent, T>(name);
            var instance = _container.Resolve<IAutonomousAgent>(name);

            var uid = Guid.NewGuid();

            instance.InstanceId = uid;
            instance.StandardOutput = Console.OpenStandardOutput();            

            agent.Agent = instance;
            agent.UniqueID = uid;
            agent.CancellationTokenSource = new CancellationTokenSource();

            RegistredAgents.Add(agent);

            return agent.UniqueID;
        }
    }
}
