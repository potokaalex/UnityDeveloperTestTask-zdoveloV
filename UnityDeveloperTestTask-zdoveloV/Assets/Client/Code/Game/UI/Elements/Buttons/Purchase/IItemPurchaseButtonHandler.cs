using Client.Code.Common.Data.Items;

namespace Client.Code.Game.UI.Elements.Buttons.Purchase
{
    public interface IItemPurchaseButtonHandler
    {
        void Handle(ItemType itemType);
    }
}