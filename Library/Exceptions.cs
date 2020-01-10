using System;
namespace Library
{
    /// <summary>
    /// Represents a exception which has already been captured and handled. It's
    /// supposed that it can be safely propagated up
    /// </summary>
    [Serializable]
    public class HandledException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:HandledException"/> class
        /// </summary>
        public HandledException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HandledException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        public HandledException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HandledException"/> class
        /// </summary>
        /// <param name="message">A <see cref="T:System.String"/> that describes the exception. </param>
        /// <param name="inner">The exception that is the cause of the current exception. </param>
        public HandledException(string message, System.Exception inner) : base(message, inner)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:HandledException"/> class
        /// </summary>
        /// <param name="context">The contextual information about the source or destination.</param>
        /// <param name="info">The object that holds the serialized object data.</param>
        protected HandledException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}
