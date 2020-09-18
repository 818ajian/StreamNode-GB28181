﻿using System.Diagnostics;

namespace GB28181.Logger4Net
{
    public class Appender
    {
        public class ConsoleAppender
        {
            public Layout.ILayout Layout { get; set; }

            public ConsoleAppender()
            {
            }
        }

        public class AzureTraceAppender
        {
            protected void Append(LoggingEvent loggingEvent)
            {
                Trace.WriteLine(loggingEvent.RenderedMessage, loggingEvent.Level.ToString());
            }
        }
    }
}