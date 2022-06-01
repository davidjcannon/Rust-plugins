using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("Hardcore", "dcannon121", 0.1)]
    [Description("A plugin that makes rust much harder for no reason")]
    public class Hardcore : RustPlugin
    {

        void OnUserChat(BasePlayer player)
        {
            player.Hurt(0.5f);
        }

        void OnMeleeAttack(BasePlayer player)
        {
            player.Hurt(1);
        }

        void OnActiveItemChange(BasePlayer player)
        {
            player.Hurt(0.1f);
        }

        void OnPayForUpgrade(BasePlayer player)
        {
            player.Hurt(0.1f);
        }

        void OnPayForPlacement(BasePlayer player)
        {
            player.Hurt(0.1f);
        }

        void CanCraft(BasePlayer player)
        {
            player.Hurt(0.5f);
        }

        void CanDemolish(BasePlayer player)
        {
            player.Hurt(5);
        }

        void CanHackCrate(BasePlayer player)
        {
            player.Hurt(50);
        }

        void CanLootEntity(BasePlayer player)
        {
            player.Hurt(1);
        }

        void CanPickupEntity(BasePlayer player)
        {
            player.Hurt(1);
        }

        void CanWearItem(BasePlayer player)
        {
            player.Hurt(1);
        }

        void OnPlayerInput(BasePlayer player)
        {
            player.Hurt(0.025f);
        }

        void OnHealingItemUse(BasePlayer player)
        {
            player.Hurt(5);
        }

        void OnItemCraftCancelled(BasePlayer player)
        {
            player.Hurt(10);
        }

        void OnItemCraftFinished(BasePlayer player)
        {
            player.Hurt(1);
        }

        void OnItemUse(BasePlayer player)
        {
            player.Hurt(0.5f);
        }


        void SendMessage(BasePlayer player, string msg, params object[] args)
        {
            PrintToChat(player, msg, args);
        }

        void Broadcast(string msg, params object[] args)
        {
            PrintToChat(msg, args);
        }
        void Loaded()
        {
            Broadcast("Plugin loaded");
        }
    }
}
