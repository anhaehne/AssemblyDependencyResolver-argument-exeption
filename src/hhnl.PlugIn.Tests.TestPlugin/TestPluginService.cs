using System.Threading.Tasks;
using hhnl.PlugIn.Tests.Contract;

namespace hhnl.PlugIn.Tests.TestPlugin
{
    public class TestPluginService : ITestPluginService
    {
        public Task<string> AddTestToStringAsync(string param)
        {
            return Task.FromResult(param + "Test");
        }
    }
}