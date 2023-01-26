using System;

namespace Nager.Country
{
    /// <summary>
    /// Unknown Country Exception
    /// </summary>
    public class UnknownCountryException : Exception
    {
        /// <summary>
        /// UnknownCountryException
        /// </summary>
        public UnknownCountryException()
        {
        }

        /// <summary>
        /// UnknownCountryException
        /// </summary>
        /// <param name="message"></param>
        public UnknownCountryException(string message) : base(message)
        {
        }
    }
}
