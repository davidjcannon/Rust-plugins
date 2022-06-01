using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("Test plugin", "dcannon121", 0.1)]
    [Description("Just a plugin I made for fun to test various features")]
    public class Test : RustPlugin
    {
        [ChatCommand("repair")]
        void repairCommand(BasePlayer player)
        {
            var item = player.GetActiveItem();
            item.condition = player.GetActiveItem().maxCondition;
            SendMessage(player, "Your item has been repaired");
        }
        [ChatCommand("ak47")]
        void ak47Command(BasePlayer player)
        {
            Item item = ItemManager.CreateByName("rifle.ak.ice", 1);
            player.inventory.GiveItem(item);
            item = ItemManager.CreateByName("ammo.rifle", 30);
            player.inventory.GiveItem(item);
            SendMessage(player, "You've been given an AK-47 with 30 bullets");
        }
        [ChatCommand("ammo")]
        void ammoCommand(BasePlayer player)
        {
            Item item = ItemManager.CreateByName("ammo.rifle", 30);
            player.inventory.GiveItem(item);
            SendMessage(player, "You've been given 30 bullets");
        }
        [ChatCommand("heal")]
        void healCommand(BasePlayer player)
        {
            player.Heal(100);
        }
        [ChatCommand("sleep")]
        void sleepCommand(BasePlayer player)
        {
            player.StartSleeping();
        }

        void OnPlayerRespawned(BasePlayer player)
        {
            player.Heal(100);
            Puts("OnPlayerRespawned works!");
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
