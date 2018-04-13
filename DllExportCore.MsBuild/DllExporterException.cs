using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DllExportCore.MsBuild
{
    [Serializable]
    internal class DllExporterException : Exception
    {
        public DllExporterException()
        {
        }

        public DllExporterException(string message) : base(message)
        {
        }

        public DllExporterException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DllExporterException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
