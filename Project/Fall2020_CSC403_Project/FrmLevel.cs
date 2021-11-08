using Fall2020_CSC403_Project.code;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
  public partial class FrmLevel : Form
  {
    private Player player;

    private Enemy enemyPoisonPacket;
    private Enemy bossKoolaid;
    private Enemy enemyCheeto;
    private Character[] walls;
    public Item[] itemList;

    private DateTime timeBegin;
    private FrmBattle frmBattle;
    private FrmInventory playerInventory;

    public FrmLevel()
    {
      InitializeComponent();
    }

    private void FrmLevel_Load(object sender, EventArgs e)
    {
      const int PADDING = 7;
      const int NUM_WALLS = 13;
      const int NUM_ITEMS = 3;

      player = new Player(CreatePosition(picPlayer), CreateCollider(picPlayer, PADDING));
      bossKoolaid = new Enemy(CreatePosition(picBossKoolAid), CreateCollider(picBossKoolAid, PADDING));
      enemyPoisonPacket = new Enemy(CreatePosition(picEnemyPoisonPacket), CreateCollider(picEnemyPoisonPacket, PADDING));
      enemyCheeto = new Enemy(CreatePosition(picEnemyCheeto), CreateCollider(picEnemyCheeto, PADDING));

      bossKoolaid.Img = picBossKoolAid.BackgroundImage;
      enemyPoisonPacket.Img = picEnemyPoisonPacket.BackgroundImage;
      enemyCheeto.Img = picEnemyCheeto.BackgroundImage;

      bossKoolaid.Color = Color.Red;
      enemyPoisonPacket.Color = Color.Green;
      enemyCheeto.Color = Color.FromArgb(255, 245, 161);

      itemList = new Item[NUM_ITEMS];
      itemList[0] = new Item("empty", "noName", global::Fall2020_CSC403_Project.Properties.Resources.empty, "noDesc");
      itemList[1] = new Weapon("peanut_cane", "Mr. Peanut's Cane", global::Fall2020_CSC403_Project.Properties.Resources.cane, "A crude bludgeoning weopon.");
      itemList[2] = new Weapon("cheeto_knives", "Flamin' Hot Blades", global::Fall2020_CSC403_Project.Properties.Resources.flamin_hot_blades, "Hot to the touch.");

      player.Equipment[0] = itemList[0];
      player.Equipment[1] = itemList[2];
      player.Equipment[2] = itemList[0];
      player.Equipment[3] = itemList[0];
      player.Equipment[4] = itemList[0];
      player.Equipment[5] = itemList[0];

      player.Inventory[0] = itemList[1];
      player.Inventory[1] = itemList[0];
      player.Inventory[2] = itemList[0];
      player.Inventory[3] = itemList[0];
      player.Inventory[4] = itemList[0];
      player.Inventory[5] = itemList[0];
      player.Inventory[6] = itemList[0];
      player.Inventory[7] = itemList[0];
      player.Inventory[8] = itemList[0];
      player.Inventory[9] = itemList[0];
      player.Inventory[10] = itemList[0];
      player.Inventory[11] = itemList[0];
      player.Inventory[12] = itemList[0];
      player.Inventory[13] = itemList[0];
      player.Inventory[14] = itemList[0];
      player.Inventory[15] = itemList[0];

      walls = new Character[NUM_WALLS];
      for (int w = 0; w < NUM_WALLS; w++)
      {
        PictureBox pic = Controls.Find("picWall" + w.ToString(), true)[0] as PictureBox;
        walls[w] = new Character(CreatePosition(pic), CreateCollider(pic, PADDING));
      }

      Game.player = player;
      timeBegin = DateTime.Now;
    }

    private Vector2 CreatePosition(PictureBox pic)
    {
      return new Vector2(pic.Location.X, pic.Location.Y);
    }

    private Collider CreateCollider(PictureBox pic, int padding)
    {
      Rectangle rect = new Rectangle(pic.Location, new Size(pic.Size.Width - padding, pic.Size.Height - padding));
      return new Collider(rect);
    }

    private void FrmLevel_KeyUp(object sender, KeyEventArgs e)
    {
      player.ResetMoveSpeed();
    }

    private void tmrUpdateInGameTime_Tick(object sender, EventArgs e)
    {
      TimeSpan span = DateTime.Now - timeBegin;
      string time = span.ToString(@"hh\:mm\:ss");
      lblInGameTime.Text = "Time: " + time.ToString();
    }

    private void tmrPlayerMove_Tick(object sender, EventArgs e)
    {
      // move player
      player.Move();

      // check collision with walls
      if (HitAWall(player))
      {
        player.MoveBack();
      }

      // check collision with enemies
      if (HitAChar(player, enemyPoisonPacket))
      {
        Fight(enemyPoisonPacket);
      }
      else if (HitAChar(player, enemyCheeto))
      {
        Fight(enemyCheeto);
      }
      if (HitAChar(player, bossKoolaid))
      {
        Fight(bossKoolaid);
      }

      // update player's picture box
      picPlayer.Location = new Point((int)player.Position.x, (int)player.Position.y);
    }

    private bool HitAWall(Character c)
    {
      bool hitAWall = false;
      for (int w = 0; w < walls.Length; w++)
      {
        if (c.Collider.Intersects(walls[w].Collider))
        {
          hitAWall = true;
          break;
        }
      }
      return hitAWall;
    }

    private bool HitAChar(Character you, Character other)
    {
      return you.Collider.Intersects(other.Collider);
    }

    private void Fight(Enemy enemy)
    {
      player.ResetMoveSpeed();
      player.MoveBack();
      frmBattle = FrmBattle.GetInstance(enemy);
      frmBattle.Show();

      if (enemy == bossKoolaid)
      {
        frmBattle.SetupForBossBattle();
      }
    }

    private void FrmLevel_KeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.Left:
          player.GoLeft();
          break;

        case Keys.Right:
          player.GoRight();
          break;

        case Keys.Up:
          player.GoUp();
          break;

        case Keys.Down:
          player.GoDown();
          break;

        case Keys.I:
          playerInventory = new FrmInventory();
          playerInventory.Show();
          break;

        default:
          player.ResetMoveSpeed();
          break;
      }
    }

    private void lblInGameTime_Click(object sender, EventArgs e)
    {

    }

    private void inventoryButton_Click(object sender, EventArgs e)
    {
      playerInventory = new FrmInventory();
      playerInventory.Show();
    }
  }
}
