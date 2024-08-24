using Client.Code.Game.UI.Elements.Upgrades.Window;
using UnityEngine;

namespace Client.Code.Game.UI.Elements.Upgrades
{
    public interface IUpgradesUIProvider
    {
        UpgradesWindow WindowPrefab { get; }

        Transform WindowRoot { get; }
    }
}