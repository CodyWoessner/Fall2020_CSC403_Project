using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#pragma warning disable 1591 // use this to disable comment warnings

namespace Fall2020_CSC403_Project.code {
  public class BattleCharacter : Character {
    public int Health { get; private set; }
    public int MaxHealth { get; private set; }
    public Item [] Inventory { get; private set; }
    public Item [] Equipment { get; private set; }
    private float strength;
    private int i = 0;


    public event Action<int> AttackEvent;

    public BattleCharacter(Vector2 initPos, Collider collider) : base(initPos, collider) {
      MaxHealth = 20;
      strength = 2;
      Health = MaxHealth;
      const int INVENTORY_SIZE = 16;
      const int EQUIPMENT_SIZE = 6;

      Inventory = new Item [INVENTORY_SIZE]; // 16 slots for items held but not equipped
      Equipment = new Item [EQUIPMENT_SIZE]; // 6 slots for items that are equipped
    }

    public void OnAttack(int amount) {
      AttackEvent((int)(amount * strength));
      // get weapon effect
    }

    public void AlterHealth(int amount) {
      Health += amount;
    }

    public void AddItem(Item item)
    {
      int destIndex;
      if (InventoryIsFull(Inventory) == false)
      {
        destIndex = FirstEmptySlot(Inventory);
        Inventory[destIndex] = item;
      }
    }

    public void DeleteItem(int itemIndex)
    {
      if (InventoryIsEmpty(Inventory) == false)
      {
        //Inventory[itemIndex] = Fall2020_CSC403_Project.code.
      }
    }

    public void DropItem(Item item)
    {
      if (InventoryIsEmpty(Equipment) == false)
      {

      }
    }

    public void EquipItem(Item inputItem, int sourceIndex)
    {
      Item tempItem;
      int destIndex;
      if (inputItem.ItemType == "helmet")
      {
        destIndex = 0;
        tempItem = Equipment[destIndex];
        Equipment[destIndex] = inputItem;
        Inventory[sourceIndex] = tempItem;
      }
      if (inputItem.ItemType == "weapon")
      {
        destIndex = 1;
        tempItem = Equipment[destIndex];
        Equipment[destIndex] = inputItem;
        Inventory[sourceIndex] = tempItem;
      }
      if (inputItem.ItemType == "chest")
      {
        destIndex = 2;
        tempItem = Equipment[destIndex];
        Equipment[destIndex] = inputItem;
        Inventory[sourceIndex] = tempItem;
      }
      if (inputItem.ItemType == "shield")
      {
        destIndex = 3;
        tempItem = Equipment[destIndex];
        Equipment[destIndex] = inputItem;
        Inventory[sourceIndex] = tempItem;
      }
      if (inputItem.ItemType == "legs")
      {
        destIndex = 4;
        tempItem = Equipment[destIndex];
        Equipment[destIndex] = inputItem;
        Inventory[sourceIndex] = tempItem;
      }
      if (inputItem.ItemType == "feet")
      {
        destIndex = 5;
        tempItem = Equipment[destIndex];
        Equipment[destIndex] = inputItem;
        Inventory[sourceIndex] = tempItem;
      }
      else
      {

      }
    }



    private bool InventoryIsFull(Item[] inv)
    {
      bool isFull = true;
      /*int invLastSlot = inv.GetUpperBound(0);

      if(inv[invLastSlot].ItemID != "empty")
      {
        isFull = true;
      }*/
      foreach (Item i in inv)
      {
        if (i.ItemID == "empty")
        {
          isFull = false;
          break;
        }
      }
      return isFull;
    }

    private bool InventoryIsEmpty(Item[] inv)
    {
      bool isEmpty = true;
      /*int invFirstSlot = inv.GetLowerBound(0);

      if (inv[invFirstSlot].ItemID == "empty")
      {
        isEmpty = true;
      }*/
      foreach (Item i in inv)
      {
        if (i.ItemID != "empty")
        {
          isEmpty = false;
          break;
        }
      }
      return isEmpty;
    }

    private int FirstEmptySlot(Item[] inv)
    {
      int index = inv.GetLowerBound(0);
      for (int i = inv.GetLowerBound(0); i <= inv.GetUpperBound(0); i++)
      {
        if (inv[i].ItemID == "empty")
        {
          index = i;
          break;
        }
      }
      return index;
    }
  }
}
