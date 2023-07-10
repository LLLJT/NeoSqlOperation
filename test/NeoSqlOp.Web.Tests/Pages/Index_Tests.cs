using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace NeoSqlOp.Pages;

public class Index_Tests : NeoSqlOpWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
