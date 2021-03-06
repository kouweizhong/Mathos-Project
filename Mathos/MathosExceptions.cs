﻿using System;
using System.Runtime.Serialization;

namespace Mathos
{
    namespace Exceptions
    {
        /// <summary>
        /// Occurs when assigning the denominator value to zero.
        /// </summary>
        [Serializable]
        public class DenominatorZeroException : Exception
        {
            /// <summary>
            /// Default constructor.
            /// </summary>
            public DenominatorZeroException() { }

            /// <summary>
            /// Constructor that takes a <paramref name="message"/>.
            /// </summary>
            /// <param name="message">The exception message.</param>
            public DenominatorZeroException(string message) : base(message) { }
            
            /// <summary>
            /// Constructor that takes a <paramref name="message"/> with a specified exception, <paramref name="inner"/>.
            /// </summary>
            /// <param name="message">The exception message.</param>
            /// <param name="inner">The inner exception.</param>
            public DenominatorZeroException(string message, Exception inner) : base(message, inner) { }

            /// <summary>
            /// A protected constructor that takes serialization <paramref name="info"/> alongside a streaming <paramref name="context"/>.
            /// </summary>
            /// <param name="info">The serialization info.</param>
            /// <param name="context">The context of the stream.</param>
            /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
            /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
            protected DenominatorZeroException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }

        /// <summary>
        /// Occurs when the format of the coordinate in the string variable is invalid during the implicit conversion
        /// </summary>
        [Serializable]
        public class InvalidCoordinateFormat : Exception
        {
            /// <summary>
            /// Default constructor
            /// </summary>
            public InvalidCoordinateFormat() { }

            /// <summary>
            /// Constructor that takes a "message"
            /// </summary>
            /// <param name="message">The exception message.</param>
            public InvalidCoordinateFormat(string message) : base(message) { }
            
            /// <summary>
            /// Constructor that takes a <paramref name="message"/> with a specified exception, <paramref name="inner"/>.
            /// </summary>
            /// <param name="message">The exception message.</param>
            /// <param name="inner">The inner exception.</param>
            public InvalidCoordinateFormat(string message, Exception inner) : base(message, inner) { }

            /// <summary>
            /// A protected constructor that takes serialization <paramref name="info"/> alongside a streaming <paramref name="context"/>.
            /// </summary>
            /// <param name="info">The serialization info.</param>
            /// <param name="context">The context of the stream.</param>
            /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
            /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
            protected InvalidCoordinateFormat(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }

        /// <summary>
        /// Occurs when the format of the fraction in the string variable is invalid during the implicit conversion
        /// </summary>
        [Serializable]
        public class InvalidFractionFormatException : Exception
        {
            /// <summary>
            /// Default constructor
            /// </summary>
            public InvalidFractionFormatException() { }
            
            /// <summary>
            /// Constructor that takes a <paramref name="message"/>.
            /// </summary>
            /// <param name="message">The exception message.</param>
            public InvalidFractionFormatException(string message) : base(message) { }
            
            /// <summary>
            /// Constructor that takes a <paramref name="message"/> with a specified exception, <paramref name="inner"/>.
            /// </summary>
            /// <param name="message">The exception message</param>
            /// <param name="inner">The inner exception.</param>
            public InvalidFractionFormatException(string message, Exception inner) : base(message, inner) { }

            /// <summary>
            /// A protected constructor that takes serialization <paramref name="info"/> alongside a streaming <paramref name="context"/>.
            /// </summary>
            /// <param name="info">The serialization info.</param>
            /// <param name="context">The context of the stream.</param>
            /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
            /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
            protected InvalidFractionFormatException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }

        /// <summary>
        /// Occurs when an invalid triangle is given.
        /// </summary>
        [Serializable]
        public class InvalidTriangleException : Exception
        {
            /// <summary>
            /// Default constructor
            /// </summary>
            public InvalidTriangleException() { }

            /// <summary>
            /// Constructor that takes a <paramref name="message"/>.
            /// </summary>
            /// <param name="message">The exception message.</param>
            public InvalidTriangleException(string message) : base(message) { }
            
            /// <summary>
            /// Constructor that takes a <paramref name="message"/> with a specified exception, <paramref name="inner"/>.
            /// </summary>
            /// <param name="message">The exception message.</param>
            /// <param name="inner">The inner exception.</param>
            public InvalidTriangleException(string message, Exception inner) : base(message, inner) { }

            /// <summary>
            /// A protected constructor that takes serialization <paramref name="info"/> alongside a streaming <paramref name="context"/>.
            /// </summary>
            /// <param name="info">The serialization info.</param>
            /// <param name="context">The context of the stream.</param>
            /// <exception cref="ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
            /// <exception cref="SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
            protected InvalidTriangleException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        }
    }
}
