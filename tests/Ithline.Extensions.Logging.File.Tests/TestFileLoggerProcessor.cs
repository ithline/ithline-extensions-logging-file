﻿using System.Collections.Generic;

namespace Ithline.Extensions.Logging.File;

internal sealed class TestFileLoggerProcessor : FileLoggerProcessor
{
    public TestFileLoggerProcessor()
    {
    }

    public List<string> Messages { get; } = new List<string>();

    public override void Enqueue(System.DateTimeOffset timestamp, string message) => Messages.Add(message);
}
