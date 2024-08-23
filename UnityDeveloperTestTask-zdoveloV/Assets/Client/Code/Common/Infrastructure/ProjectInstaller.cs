using Client.Code.Common.Services.Assets;
using UnityEngine;
using Zenject;

namespace Client.Code.Common.Infrastructure
{
    public class ProjectInstaller : MonoInstaller
    {
        [SerializeField] private AssetsConfig _assetsConfig;

        public override void InstallBindings() => Container.Bind<AssetsLoader>().AsSingle().WithArguments(_assetsConfig);
    }
}