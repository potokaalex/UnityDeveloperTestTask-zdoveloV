using Client.Code.Common.UI.Elements.Windows;
using UnityEngine;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Window
{
    public class UpgradesWindow : WindowBase
    {
        public Transform ItemsRoot;

        public override WindowType BaseType => WindowType.Upgrades;
    }
}