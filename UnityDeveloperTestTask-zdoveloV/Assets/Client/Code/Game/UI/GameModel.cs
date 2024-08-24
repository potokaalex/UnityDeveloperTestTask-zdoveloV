using System.Collections.Generic;
using Client.Code.Game.Data;
using Client.Code.Game.UI.Elements.Upgrades.Window;

namespace Client.Code.Game.UI
{
    public class GameModel : IUpgradesWindowModel
    {
        public List<UpgradeItemType> AvailableItems { get; } = new()
        {
            UpgradeItemType.WatchATutorial,
            UpgradeItemType.MadeWithLove,
            UpgradeItemType.MaturedForLonger,
            UpgradeItemType.VisitAUniversityJobFair,
            UpgradeItemType.BiggerPortion,
            
            
            UpgradeItemType.WatchATutorial,
            UpgradeItemType.MadeWithLove,
            UpgradeItemType.MaturedForLonger,
            UpgradeItemType.VisitAUniversityJobFair,
            UpgradeItemType.BiggerPortion
        };
    }
}