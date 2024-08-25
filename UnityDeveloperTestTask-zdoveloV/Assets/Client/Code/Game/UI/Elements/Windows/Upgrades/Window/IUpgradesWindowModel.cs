using Client.Code.Common.Data.Items;
using UniRx;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Window
{
    public interface IUpgradesWindowModel
    {
        ReactiveCollection<ItemData> Items { get; }
    }
}