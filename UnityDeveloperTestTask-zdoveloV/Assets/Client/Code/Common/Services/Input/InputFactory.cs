using Client.Code.Common.Services.Assets;
using Zenject;

namespace Client.Code.Common.Services.Input
{
    public class InputFactory
    {
        private readonly IInstantiator _instantiator;
        private readonly ProjectAssetsProvider _projectAssetsProvider;

        public InputFactory(IInstantiator instantiator, ProjectAssetsProvider projectAssetsProvider)
        {
            _instantiator = instantiator;
            _projectAssetsProvider = projectAssetsProvider;
        }

        public void Create()
        {
            var prefab = _projectAssetsProvider.Config.InputPrefab;
            _instantiator.InstantiatePrefab(prefab);
        }
    }
}