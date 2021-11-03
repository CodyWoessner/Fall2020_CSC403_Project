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

    public void InventoryAddItem(Item item)
    {
      if(InventoryIsFull(Inventory) == false)
      {

      }
    }

    public void InventoryRemoveItem(Item item)
    {
      if (InventoryIsEmpty(Inventory) == false)
      {

      }
    }

    public void EquipmentAddItem(Item item)
    {
      if (InventoryIsFull(Equipment) == false)
      {

      }
    }

    public void EquipmentRemoveItem(Item item)
    {
      if (InventoryIsEmpty(Equipment) == false)
      {

      }
    }

    private bool InventoryIsFull(Item [] inv)
    {
      bool isFull = false;
      int invLastSlot = inv.GetUpperBound(0);

      if(inv[invLastSlot].ItemID != "empty")
      {
        isFull = true;
      }
      return isFull;
    }

    private bool InventoryIsEmpty(Item [] inv)
    {
      bool isEmpty = false;
      int invFirstSlot = inv.GetLowerBound(0);

      if (inv[invFirstSlot].ItemID == "empty")
      {
        isEmpty = true;
      }
      return isEmpty;
    }
  }
}
