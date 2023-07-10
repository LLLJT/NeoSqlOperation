using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace NeoSqlOp;

public class NeoSqlOpWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<NeoSqlOpWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
