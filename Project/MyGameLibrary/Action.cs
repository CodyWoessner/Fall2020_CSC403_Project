using System;

public class Action
{
	public Action(string ItemAbility, int PlayerDamage, int EnemyDamage)
	{
    // Attack event
    public void btnAtk(string Name, int PlayerDamage, int EnemyDamage)
    {
      // updates the dialogue
      updateDialogue();
      player.OnAttack(PlayerDamage);
      if (enemy.Health > 0)
      {
        enemy.OnAttack(EnemyDamage);
      }

      UpdateHealthBars();
    }
	}
	
  Slash = new Action("Slash", -3, -3)

}
