using GameEngine.Equipment;
using GameEngine.Inventory.Interfaces;
using GameEngine.MerchantMechanics.Services;
using GameEngine.Player;
using System;

namespace GameEngine.MerchantMechanics
{
    public class TradeManager
    {
        public TradingService PlayerTradingService { get; private set; }
        public TradingService MerchantTradingService { get; private set; }
        public IInventoryItemsList PlayerInventory { get; private set; }
        public WearedEquipment PlayerEquipment{ get; private set; }
        public IInventoryItemsList MerchantInventory { get; private set; }
        public ItemEntity ItemToTrade { get; set; }
        public TradeManager(PlayerConsumablesData playerConsumables, PlayerConsumablesData merchantConsumables, IInventoryItemsList playerInventory, IInventoryItemsList merchantInventory, WearedEquipment playerEquipment = null)
        {
            PlayerTradingService = new TradingService(playerConsumables);
            MerchantTradingService = new TradingService(merchantConsumables);
            PlayerInventory = playerInventory;
            MerchantInventory = merchantInventory;
            PlayerEquipment = playerEquipment ?? new WearedEquipment();
        }
        public void Buy()
        {
            if (PlayerTradingService.PlayerConsumables.AbsoluteMoneyValue < ItemToTrade.Model.Price.AbsoluteMoneyValue)
            {
                throw new Exception("Not enought money");
            }

            else
            {
                PlayerTradingService.DecreasePlayerMoneyValue(ItemToTrade.Model.Price.AbsoluteMoneyValue);
                MerchantInventory.RemoveItem(ItemToTrade);
                MerchantTradingService.IncreasePlayerMoneyValue(ItemToTrade.Model.Price.AbsoluteMoneyValue);

                PlayerInventory.AddItem(ItemToTrade);
            }
        }
        public void Sell()
        {
            PlayerTradingService.IncreasePlayerMoneyValue(ItemToTrade.Model.Price.AbsoluteMoneyValue);

            if (ItemToTrade.Model.Status == WEARED_STATUS.Weared)
            {
                var itemEntity = new ItemEntity();
                foreach (var item in PlayerEquipment.ItemsList)
                {
                    if (item.Model.ID == ItemToTrade.Model.ID && item.ItemDurability.Value == ItemToTrade.ItemDurability.Value)
                    {
                        itemEntity = item;
                        break;
                    }
                }
                PlayerEquipment.ItemsList.Remove(itemEntity);
            }

            else PlayerInventory.RemoveItem(ItemToTrade);

            MerchantTradingService.DecreasePlayerMoneyValue(ItemToTrade.Model.Price.AbsoluteMoneyValue);
            MerchantInventory.AddItem(ItemToTrade);
        }
    }
}
