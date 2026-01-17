using System;
using Straddle;

namespace Straddle.Tests;

public class TestBase
{
    protected IStraddleClient client;

    public TestBase()
    {
        client = new StraddleClient()
        {
            BaseUrl =
                Environment.GetEnvironmentVariable("TEST_API_BASE_URL") ?? "http://localhost:4010",
            ApiKey = "My API Key",
        };
    }
}
