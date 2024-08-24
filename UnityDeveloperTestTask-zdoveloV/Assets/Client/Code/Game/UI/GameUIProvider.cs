﻿using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI.Elements.Upgrades;
using UnityEngine;

namespace Client.Code.Game.UI
{
    public class GameUIProvider : IUpgradesUIProvider
    {
        private readonly GameAssetsProvider _assetsProvider;

        public GameUIProvider(GameAssetsProvider assetsProvider) => _assetsProvider = assetsProvider;

        public UpgradesConfig Config => _assetsProvider.UI.Upgrades;
        
        public Transform WindowRoot { get; private set; }

        public void Initialize(Transform windowRoot) => WindowRoot = windowRoot;
    }
}