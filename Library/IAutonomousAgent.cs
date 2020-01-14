﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// The base abstraction for a operating robot
    /// </summary>
    public interface IAutonomousAgent
    {
        /// <summary>
        /// The human friendly name of this agent
        /// </summary>
        string AgentName { get; }

        /// <summary>
        /// A short description of this agent 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The standard output stream of the platform
        /// </summary>
        Stream StandardOutput { get; set; }

        /// <summary>
        /// The unique identifier of this agent. This Id is provided when the
        /// platform instantiates the agent.
        /// </summary>
        Guid InstanceId { get; set; }

        /// <summary>
        /// This method is called right after the instantiation and provides
        /// the configurations relevant to all the agents
        /// </summary>
        /// <param name="configurations">A read only dictionaries of
        /// configurations on the string:string format</param>
        /// <returns></returns>
        Task Configure(IReadOnlyDictionary<string, string> configurations);

        /// <summary>
        /// Starts or unpauses the agent, signaling that it's cleared to issue
        /// orders.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task Start(CancellationToken cancellationToken);

        /// <summary>
        /// Pauses the agent, signaling that it should stop issuing orders. It
        /// will continue to receive Quotes, Ticks and other events
        /// </summary>
        /// <returns></returns>
        Task Pause();

        /// <summary>
        /// Signals the agent that it should stop all activities.
        /// </summary>
        /// <returns></returns>
        Task Shutdown(ShutdownOrderSeverity severity);

        /// <summary>
        /// Summarized report on the status of the current agent
        /// </summary>
        /// <returns></returns>
        Task<AgentStatus> Healthcheck();

    }
}
