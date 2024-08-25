using Client.Code.Common.Data;

namespace Client.Code.Common.Services.Assets
{
    public class ProjectAssetsProvider
    {
        public ProjectConfig Config { get; private set; }

        public void Initialize(ProjectConfig config) => Config = config;
    }
}