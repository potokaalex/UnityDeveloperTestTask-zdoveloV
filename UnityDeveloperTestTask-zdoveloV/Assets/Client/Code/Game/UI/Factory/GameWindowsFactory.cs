﻿using System.Collections.Generic;
using Client.Code.Common.UI.Base.Window;
using Client.Code.Common.UI.Base.Window.Factory;

namespace Client.Code.Game.UI.Factory
{
    public class GameWindowsFactory
    {
        private readonly Dictionary<WindowType, IWindowFactory> _factories = new();

        public GameWindowsFactory(List<IWindowFactory> factories)
        {
            foreach (var factory in factories) 
                _factories.Add(factory.Type, factory);
        }

        public void Create(WindowType type) => _factories[type].Create();

        public void Destroy(WindowType type) => _factories[type].Destroy();
    }
}