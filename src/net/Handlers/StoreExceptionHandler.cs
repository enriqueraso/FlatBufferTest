using System;
using McMaster.Extensions.Hosting.CommandLine;
using Microsoft.Extensions.Logging;

namespace FlatBufferTest.Handlers
{
    /// <summary>
    /// Implementation of <see cref="IUnhandledExceptionHandler"/> that stores an unhandled exception so it can later be rethrown.
    /// </summary>
    internal class StoreExceptionHandler : IUnhandledExceptionHandler
    {
        public StoreExceptionHandler(ILogger<StoreExceptionHandler> logger)
        {
            Logger = logger;
        }

        /// <summary>
        /// The captured exception, if any
        /// </summary>
        public Exception StoredException { get; private set; }

        /// <summary>
        /// This will store the first unhandled exception and throw an <see cref="AggregateException"/> if called a second time.
        /// </summary>
        /// <param name="e">The unhandled exception to store</param>
        /// <exception cref="AggregateException">
        /// If called a second time an <see cref="AggregateException"/> containing both exceptions is raised.
        /// </exception>
        public void HandleException(Exception e)
        {
            if (StoredException != null)
            {
                throw new AggregateException("Second exception received!", StoredException, e);
            }

            Logger.LogError(e.Message);

            StoredException = e;
        }

        private readonly ILogger<StoreExceptionHandler> Logger;
    }
}
