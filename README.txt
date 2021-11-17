Zoe Semifero
Scrum Documentation

	- Feature: Items 
		* Item class: holds the attributes for the object, Item
			` Item [] --> FrmLevel.cs
				This is an array that holds the items in order to work with the inventory management array. 
		
	- Feature: Main Menu 
		* Shows a Main Menu with a "Play" and "Quit" button.
			` InitializeComponent() --> FrmMenu.Designer.cs
				This shows the two buttons: Play & Quit.
					. Play initializes FrmLevel here in   place of where FrmLevel was located, which was in Program.cs
					
					. Quit closes the engine.
					
			` button1_Click() & button2_Click() --> Program.cs
				These are the functions where the Play and Quit buttons actually gain their respective functions.
				
			` Main() --> Program.cs
				A variable was created 'frmmenu' in order to finagle with the Application.Run functions.
Broady Rivet
	- Feature: Button Layout Organization
		*All buttons only appear and are usable when they are needed, i.e Base attacks during combat and mercy and obliterate when the battle is ready to end. 
			` FrmBattle.cs
				`UpdateHealthBar(), btnAtk_Slash(), btnAtk_RiskyHit(), btnAtk_Doge(), btnMercy_Mercy(), and btnObliterate_Kill() methods all have .Visible = (true or false) code for each button to appear and/or disappear based on conditions.
	- Feature: Mercy Button
		*Displays a usable Mercy Button
			` btnMercy_Mercy --> FrmBattle.cs
				a method for the mercy button that closes out the fight and leave the boss at its current health.
	- Feature: Obliterate Button
		* Displays a usable Obliterate Button
			` btnObliterate_Kill() --> FrmBattle.cs
				. A method that creates a button that only appears when the Boss is at 1 health. 
				. Only button that can kill an enmy and create a create a win condition.
	- Feature: Kill Health Conditions
		* No matter what base attack is used, The bosses health will stop at 1 and the button layout will change to the final stage.
			` UpdateHealthBar() --> FrmBattle.cs
				. if attack would kill the enemy then the health bar only drops to one.
				. if enemy health is at 1 then all current buttons disappear and the mercy and obliterate buttons appear.

William Chisholm
	- Feature: Slash, Dodge, and Risky Hit Attacks
		A player has different options during battle, meanwhile a enemy always attacks, no dodges. 
		* Slash Attack --> FrmBattle.cs
			random num generator for hit and checks for current effects
		* Dodge Attack --> FrmBattle.cs
			random num generator for dodge and checks for current effects -- enemy has much lower odds to hit
		* Risky Hit Attack --> FrmBattle.cs
			random num generator for hit and checks for current effects, then randoms again for more damage.
	- Feature: Slash, Dodge, and Risky Hit Buttons
		A player has different options during battle and can access these options by interacting with buttons.
		* For the featured attacks above, buttons were made to display interactions with the UI.
		* FrmBattle.Designer.cs
	- Feature: Attack Effects
		* Burn & Burndamage() --> FrmBattle.cs
			checks for hit and initializes burn() effect if true. 
Dakota Hollis
	- Feature: Onomatopoeia
		This feature adds dialogue to enemy battles. Random dialogue is show under the enemy each time the player attacks
		* InitDialogue() - FrmBattle.cs
			This function initializes the dialogue by showing the empty dialogue box and hiding the other images of dialogue
		* updateDialogue() -FrmBattle.cs
			This function picks a random script of dialogue to show and hides all others, this function is called each time a player attacks an enemy
		* Other Changes: 
			Created script pictures from online website (https://www.demirramon.com/generators/undertale_text_box_generator), imported them into the Project’s data folder. In the FrmBattle.cs Designer, I added them as Picture Boxes stacked on top of each other under the enemy’s picture box.

	- Feature: Leaderboard
		This feature allows a player’s name and high scores (fastest time) to be recorded to a leaderboard that is saved locally.
		* enemyDefeated() - FrmLevel.cs
			This function is called each time an enemy is defeated. When this function reaches the total number of enemies (3), it calls the PlayerWin() function.
		* PlayerWin() - FrmLevel.cs
			This function initializes the FrmHighscore.cs class with the player’s time and show’s the window. 
		* GetInstance(string playtime) - FrmHighscore.cs
			This function sets up the High Score window and passes the playtime to the class.
		* Setup() - FrmHighscore.cs
			The first function called in the class. It sets up the leaderboard by calling getHighscoreData() and showHighscores(). It also shows the text input and Enter Name button for the player’s name.
		* getHighscoreData() - FrmHighscore.cs
			Uses StreamReader to get the locally saved scores from the project file /data/HighScores/HighScores.dat
		* writeHighscoreData() - FrmHighscore.cs
			Uses StreamWriter to save the high scores to /data/HighScores/HighScores.dat
				*** The path must be specified before runtime in order to be saved properly ***
		* showHighscores() - FrmHighscore.cs
			This function hides/shows the High Score ‘labels’ depending on how many High Scores there are. It also changes the labels’ text to the High Scores. 
		* calculateHighscores() - FrmHighscore.cs
			Uses the Timefaster() function to insert better times to the highscoreData variable. Then, it calls the showHighscores() function.
		* Timefaster() - FrmHighscore.cs
			Uses the built-in TimeSpan.ParseExact function to compare the player’s time against the leaderboard’s time. Then, it returns True if the player’s time is faster.
		* enternameBtn_Click() - FrmHighscore.cs
			Gets playerName variable and hides the button and text box. Then, it calls 3 functions that: calculates the new high scores, shows them, and then saves them. 
		* Other Changes: 
			Created FrmHighscore class and designed a form that organizes the player’s high scores with a text box and a button for the player to enter their name. 
Cody Woessner
	- Feature: Inventory
		A system for storing items a character is holding and has equipped in arrays as well as a graphical interface for it.
		* BattleCharacter()
			Inventories are created in the BattleCharacter class so that both players and enemies have them inately
			Consists of two Item type object arrays "Inventory[]" and "Equipment[]" of defined sizes. "Equipment" for worn items and "Inventory" for stored items.
			* AddItem(Item item)
				Takes as input an object of type Item. Checks to see if the inventory is full. If not full adds item to first open slot in "Inventory[]"
			* EquipItem(Item inputItem, int sourceIndex)
				Takes as input an object of type Item and the current index of the item in the array "Inventory[]." It then checks to see what type of item it is using Item.ItemType to determine what inventory slot it goes in. It then stores the Item that is currently in the destination index of "Equipment[]" as "tempItem" puts the inputItem into that index and puts tempItem into the index inputItem came from.
			* UnequipItem(Item inputItem, int sourceIndex)
				Takes as input an object of type Item and the current index of the item in the array "Equipment[]." Checks to see if there is an open inventory slot available. If so it swaps the Items using a tempItem.
			* InventoryIsFull(Item[] inv)
				Takes as input an Item type array. Starts with a boolean "isFull" initialized as true. Checks each index in the inventory checking to see if the Item.ItemID is "empty". If it finds any instance of "empty" changes bool isFull to false, breaks loop, and returns isFull. Otherwise returns isFull unchanged.
			* InventoryIsEmpty(Item[] inv)	
				Takes as input an Item type array. Starts with a boolean "isEmpty" initialized as true. Checks each index in the inventory checking to see if the Item.ItemID is NOT "empty". If it does not find any instance of "empty" changes bool isEmpty to false, breaks loop, and returns isEmpty. Otherwise returns isEmpty unchanged.
			* FirstEmptySlot(Item[] inv)
				Takes as input an Item type array. Checks each index for Item.ItemID == "empty" and returns the index of its first occurance.
		* FrmLevel()
			Inventory[] populated with empty items and Equipment[] populated with starter items
			* FrmLevel_KeyDown(object sender, KeyEventArgs e)
				On keypress "I" shows player's FrmInventory()
		* FrmInventory()
			Initializes Player player to Game.player to stay common with the version of the player in other Forms.
			* FrmInventory_Load(object sender, EventArgs e)
				Calls UpdateInventory() on load.
			* UpdateInventory()
				Updates inventory slot images and tooltips based on the Item.ItemImage and Item.ItemDesc, respectively, of the Item currently in player.Inventory[] and player.Equipment[].
			