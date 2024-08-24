using UnityEngine;

namespace Client.Code.Game.UI.Elements.Upgrades
{
    public interface IUpgradesUIProvider
    {
        UpgradesConfig Config { get; }
        
        Transform WindowRoot { get; }
    }
}