using Client.Code.Common.UI.Base.Window;
using UnityEngine;

namespace Client.Code.Game.UI.Elements.Upgrades.Window
{
    public class UpgradesWindow : WindowBase
    {
        public Transform ItemsRoot;

        public override WindowType BaseType => WindowType.Upgrades;
    }
}