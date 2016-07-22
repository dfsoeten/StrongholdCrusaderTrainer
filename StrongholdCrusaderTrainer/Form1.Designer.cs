namespace StrongholdCrusaderTrainer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbStatusofgame = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbGeneralAndExtra = new System.Windows.Forms.GroupBox();
            this.cbAutoAddAllGoods = new System.Windows.Forms.CheckBox();
            this.btnAddAllGoods = new System.Windows.Forms.Button();
            this.txtChickens = new System.Windows.Forms.TextBox();
            this.btnChickens = new System.Windows.Forms.Button();
            this.txtGold = new System.Windows.Forms.TextBox();
            this.btnGold = new System.Windows.Forms.Button();
            this.gbRawMaterials = new System.Windows.Forms.GroupBox();
            this.btnAddAllMaterials = new System.Windows.Forms.Button();
            this.btnPitch = new System.Windows.Forms.Button();
            this.btnIron = new System.Windows.Forms.Button();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnWood = new System.Windows.Forms.Button();
            this.gbFoods = new System.Windows.Forms.GroupBox();
            this.btnAddAllFoods = new System.Windows.Forms.Button();
            this.btnWheat = new System.Windows.Forms.Button();
            this.btnAle = new System.Windows.Forms.Button();
            this.btnHops = new System.Windows.Forms.Button();
            this.btnMeat = new System.Windows.Forms.Button();
            this.btnApples = new System.Windows.Forms.Button();
            this.btnCheese = new System.Windows.Forms.Button();
            this.btnBread = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.gbWeapons = new System.Windows.Forms.GroupBox();
            this.btnAddAllWeapons = new System.Windows.Forms.Button();
            this.btnIronArmor = new System.Windows.Forms.Button();
            this.btnLeatherArmor = new System.Windows.Forms.Button();
            this.btnSwords = new System.Windows.Forms.Button();
            this.btnMaces = new System.Windows.Forms.Button();
            this.btnPikes = new System.Windows.Forms.Button();
            this.btnSpears = new System.Windows.Forms.Button();
            this.btnBows = new System.Windows.Forms.Button();
            this.lbValueInfo = new System.Windows.Forms.Label();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.btnCrossBows = new System.Windows.Forms.Button();
            this.gbGeneralAndExtra.SuspendLayout();
            this.gbRawMaterials.SuspendLayout();
            this.gbFoods.SuspendLayout();
            this.gbWeapons.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.ForeColor = System.Drawing.Color.White;
            this.lbStatus.Location = new System.Drawing.Point(13, 13);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status:";
            // 
            // lbStatusofgame
            // 
            this.lbStatusofgame.AutoSize = true;
            this.lbStatusofgame.BackColor = System.Drawing.Color.Transparent;
            this.lbStatusofgame.ForeColor = System.Drawing.Color.Red;
            this.lbStatusofgame.Location = new System.Drawing.Point(59, 13);
            this.lbStatusofgame.Name = "lbStatusofgame";
            this.lbStatusofgame.Size = new System.Drawing.Size(52, 13);
            this.lbStatusofgame.TabIndex = 1;
            this.lbStatusofgame.Text = "Waiting...";
            // 
            // gbGeneralAndExtra
            // 
            this.gbGeneralAndExtra.BackColor = System.Drawing.Color.Transparent;
            this.gbGeneralAndExtra.Controls.Add(this.cbAutoAddAllGoods);
            this.gbGeneralAndExtra.Controls.Add(this.btnAddAllGoods);
            this.gbGeneralAndExtra.Controls.Add(this.txtChickens);
            this.gbGeneralAndExtra.Controls.Add(this.btnChickens);
            this.gbGeneralAndExtra.Controls.Add(this.txtGold);
            this.gbGeneralAndExtra.Controls.Add(this.btnGold);
            this.gbGeneralAndExtra.ForeColor = System.Drawing.Color.White;
            this.gbGeneralAndExtra.Location = new System.Drawing.Point(16, 39);
            this.gbGeneralAndExtra.Name = "gbGeneralAndExtra";
            this.gbGeneralAndExtra.Size = new System.Drawing.Size(229, 134);
            this.gbGeneralAndExtra.TabIndex = 2;
            this.gbGeneralAndExtra.TabStop = false;
            this.gbGeneralAndExtra.Text = "General And Extra";
            // 
            // cbAutoAddAllGoods
            // 
            this.cbAutoAddAllGoods.AutoSize = true;
            this.cbAutoAddAllGoods.Location = new System.Drawing.Point(7, 104);
            this.cbAutoAddAllGoods.Name = "cbAutoAddAllGoods";
            this.cbAutoAddAllGoods.Size = new System.Drawing.Size(118, 17);
            this.cbAutoAddAllGoods.TabIndex = 5;
            this.cbAutoAddAllGoods.Text = "Auto Add All Goods";
            this.cbAutoAddAllGoods.UseVisualStyleBackColor = true;
            // 
            // btnAddAllGoods
            // 
            this.btnAddAllGoods.BackColor = System.Drawing.Color.DimGray;
            this.btnAddAllGoods.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAllGoods.Location = new System.Drawing.Point(6, 75);
            this.btnAddAllGoods.Name = "btnAddAllGoods";
            this.btnAddAllGoods.Size = new System.Drawing.Size(217, 23);
            this.btnAddAllGoods.TabIndex = 4;
            this.btnAddAllGoods.Text = "Add All Goods";
            this.btnAddAllGoods.UseVisualStyleBackColor = false;
            this.btnAddAllGoods.Click += new System.EventHandler(this.btnAddAllGoods_Click);
            // 
            // txtChickens
            // 
            this.txtChickens.Location = new System.Drawing.Point(123, 48);
            this.txtChickens.MaxLength = 9;
            this.txtChickens.Name = "txtChickens";
            this.txtChickens.Size = new System.Drawing.Size(100, 20);
            this.txtChickens.TabIndex = 3;
            this.txtChickens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_numeric_KeyPress);
            // 
            // btnChickens
            // 
            this.btnChickens.BackColor = System.Drawing.Color.DimGray;
            this.btnChickens.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChickens.Location = new System.Drawing.Point(7, 46);
            this.btnChickens.Name = "btnChickens";
            this.btnChickens.Size = new System.Drawing.Size(110, 23);
            this.btnChickens.TabIndex = 2;
            this.btnChickens.Text = "Chickens/Skips";
            this.btnChickens.UseVisualStyleBackColor = false;
            this.btnChickens.Click += new System.EventHandler(this.btnChickens_Click);
            // 
            // txtGold
            // 
            this.txtGold.Location = new System.Drawing.Point(123, 22);
            this.txtGold.MaxLength = 9;
            this.txtGold.Name = "txtGold";
            this.txtGold.Size = new System.Drawing.Size(100, 20);
            this.txtGold.TabIndex = 1;
            this.txtGold.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_numeric_KeyPress);
            // 
            // btnGold
            // 
            this.btnGold.BackColor = System.Drawing.Color.DimGray;
            this.btnGold.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGold.Location = new System.Drawing.Point(7, 20);
            this.btnGold.Name = "btnGold";
            this.btnGold.Size = new System.Drawing.Size(110, 23);
            this.btnGold.TabIndex = 0;
            this.btnGold.Text = "Gold";
            this.btnGold.UseVisualStyleBackColor = false;
            this.btnGold.Click += new System.EventHandler(this.btnGold_Click);
            // 
            // gbRawMaterials
            // 
            this.gbRawMaterials.BackColor = System.Drawing.Color.Transparent;
            this.gbRawMaterials.Controls.Add(this.btnAddAllMaterials);
            this.gbRawMaterials.Controls.Add(this.btnPitch);
            this.gbRawMaterials.Controls.Add(this.btnIron);
            this.gbRawMaterials.Controls.Add(this.btnStone);
            this.gbRawMaterials.Controls.Add(this.btnWood);
            this.gbRawMaterials.ForeColor = System.Drawing.Color.White;
            this.gbRawMaterials.Location = new System.Drawing.Point(16, 179);
            this.gbRawMaterials.Name = "gbRawMaterials";
            this.gbRawMaterials.Size = new System.Drawing.Size(229, 170);
            this.gbRawMaterials.TabIndex = 3;
            this.gbRawMaterials.TabStop = false;
            this.gbRawMaterials.Text = "Raw Materials";
            // 
            // btnAddAllMaterials
            // 
            this.btnAddAllMaterials.BackColor = System.Drawing.Color.DimGray;
            this.btnAddAllMaterials.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAllMaterials.Location = new System.Drawing.Point(7, 134);
            this.btnAddAllMaterials.Name = "btnAddAllMaterials";
            this.btnAddAllMaterials.Size = new System.Drawing.Size(217, 23);
            this.btnAddAllMaterials.TabIndex = 9;
            this.btnAddAllMaterials.Text = "Add All Raw Materials";
            this.btnAddAllMaterials.UseVisualStyleBackColor = false;
            this.btnAddAllMaterials.Click += new System.EventHandler(this.btnAddAllMaterials_Click);
            // 
            // btnPitch
            // 
            this.btnPitch.BackColor = System.Drawing.Color.DimGray;
            this.btnPitch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPitch.Location = new System.Drawing.Point(6, 105);
            this.btnPitch.Name = "btnPitch";
            this.btnPitch.Size = new System.Drawing.Size(217, 23);
            this.btnPitch.TabIndex = 8;
            this.btnPitch.Text = "Pitch";
            this.btnPitch.UseVisualStyleBackColor = false;
            this.btnPitch.Click += new System.EventHandler(this.btnPitch_Click);
            // 
            // btnIron
            // 
            this.btnIron.BackColor = System.Drawing.Color.DimGray;
            this.btnIron.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIron.Location = new System.Drawing.Point(6, 77);
            this.btnIron.Name = "btnIron";
            this.btnIron.Size = new System.Drawing.Size(217, 23);
            this.btnIron.TabIndex = 7;
            this.btnIron.Text = "Iron";
            this.btnIron.UseVisualStyleBackColor = false;
            this.btnIron.Click += new System.EventHandler(this.btnIron_Click);
            // 
            // btnStone
            // 
            this.btnStone.BackColor = System.Drawing.Color.DimGray;
            this.btnStone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStone.Location = new System.Drawing.Point(6, 48);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(217, 23);
            this.btnStone.TabIndex = 6;
            this.btnStone.Text = "Stone";
            this.btnStone.UseVisualStyleBackColor = false;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnWood
            // 
            this.btnWood.BackColor = System.Drawing.Color.DimGray;
            this.btnWood.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWood.Location = new System.Drawing.Point(7, 19);
            this.btnWood.Name = "btnWood";
            this.btnWood.Size = new System.Drawing.Size(217, 23);
            this.btnWood.TabIndex = 5;
            this.btnWood.Text = "Wood";
            this.btnWood.UseVisualStyleBackColor = false;
            this.btnWood.Click += new System.EventHandler(this.btnWood_Click);
            // 
            // gbFoods
            // 
            this.gbFoods.BackColor = System.Drawing.Color.Transparent;
            this.gbFoods.Controls.Add(this.btnAddAllFoods);
            this.gbFoods.Controls.Add(this.btnWheat);
            this.gbFoods.Controls.Add(this.btnAle);
            this.gbFoods.Controls.Add(this.btnHops);
            this.gbFoods.Controls.Add(this.btnMeat);
            this.gbFoods.Controls.Add(this.btnApples);
            this.gbFoods.Controls.Add(this.btnCheese);
            this.gbFoods.Controls.Add(this.btnBread);
            this.gbFoods.ForeColor = System.Drawing.Color.White;
            this.gbFoods.Location = new System.Drawing.Point(262, 39);
            this.gbFoods.Name = "gbFoods";
            this.gbFoods.Size = new System.Drawing.Size(310, 134);
            this.gbFoods.TabIndex = 4;
            this.gbFoods.TabStop = false;
            this.gbFoods.Text = "Foods";
            // 
            // btnAddAllFoods
            // 
            this.btnAddAllFoods.BackColor = System.Drawing.Color.DimGray;
            this.btnAddAllFoods.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAllFoods.Location = new System.Drawing.Point(158, 106);
            this.btnAddAllFoods.Name = "btnAddAllFoods";
            this.btnAddAllFoods.Size = new System.Drawing.Size(146, 23);
            this.btnAddAllFoods.TabIndex = 13;
            this.btnAddAllFoods.Text = "Add All Foods";
            this.btnAddAllFoods.UseVisualStyleBackColor = false;
            this.btnAddAllFoods.Click += new System.EventHandler(this.btnAddAllFoods_Click);
            // 
            // btnWheat
            // 
            this.btnWheat.BackColor = System.Drawing.Color.DimGray;
            this.btnWheat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWheat.Location = new System.Drawing.Point(6, 106);
            this.btnWheat.Name = "btnWheat";
            this.btnWheat.Size = new System.Drawing.Size(146, 23);
            this.btnWheat.TabIndex = 12;
            this.btnWheat.Text = "Wheat";
            this.btnWheat.UseVisualStyleBackColor = false;
            this.btnWheat.Click += new System.EventHandler(this.btnWheat_Click);
            // 
            // btnAle
            // 
            this.btnAle.BackColor = System.Drawing.Color.DimGray;
            this.btnAle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAle.Location = new System.Drawing.Point(158, 77);
            this.btnAle.Name = "btnAle";
            this.btnAle.Size = new System.Drawing.Size(146, 23);
            this.btnAle.TabIndex = 11;
            this.btnAle.Text = "Ale";
            this.btnAle.UseVisualStyleBackColor = false;
            this.btnAle.Click += new System.EventHandler(this.btnAle_Click);
            // 
            // btnHops
            // 
            this.btnHops.BackColor = System.Drawing.Color.DimGray;
            this.btnHops.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHops.Location = new System.Drawing.Point(6, 77);
            this.btnHops.Name = "btnHops";
            this.btnHops.Size = new System.Drawing.Size(146, 23);
            this.btnHops.TabIndex = 10;
            this.btnHops.Text = "Hops";
            this.btnHops.UseVisualStyleBackColor = false;
            this.btnHops.Click += new System.EventHandler(this.btnHops_Click);
            // 
            // btnMeat
            // 
            this.btnMeat.BackColor = System.Drawing.Color.DimGray;
            this.btnMeat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMeat.Location = new System.Drawing.Point(158, 48);
            this.btnMeat.Name = "btnMeat";
            this.btnMeat.Size = new System.Drawing.Size(146, 23);
            this.btnMeat.TabIndex = 9;
            this.btnMeat.Text = "Meat";
            this.btnMeat.UseVisualStyleBackColor = false;
            this.btnMeat.Click += new System.EventHandler(this.btnMeat_Click);
            // 
            // btnApples
            // 
            this.btnApples.BackColor = System.Drawing.Color.DimGray;
            this.btnApples.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnApples.Location = new System.Drawing.Point(6, 48);
            this.btnApples.Name = "btnApples";
            this.btnApples.Size = new System.Drawing.Size(146, 23);
            this.btnApples.TabIndex = 8;
            this.btnApples.Text = "Apples";
            this.btnApples.UseVisualStyleBackColor = false;
            this.btnApples.Click += new System.EventHandler(this.btnApples_Click);
            // 
            // btnCheese
            // 
            this.btnCheese.BackColor = System.Drawing.Color.DimGray;
            this.btnCheese.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheese.Location = new System.Drawing.Point(158, 19);
            this.btnCheese.Name = "btnCheese";
            this.btnCheese.Size = new System.Drawing.Size(146, 23);
            this.btnCheese.TabIndex = 7;
            this.btnCheese.Text = "Cheese";
            this.btnCheese.UseVisualStyleBackColor = false;
            this.btnCheese.Click += new System.EventHandler(this.btnCheese_Click);
            // 
            // btnBread
            // 
            this.btnBread.BackColor = System.Drawing.Color.DimGray;
            this.btnBread.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBread.Location = new System.Drawing.Point(6, 19);
            this.btnBread.Name = "btnBread";
            this.btnBread.Size = new System.Drawing.Size(146, 23);
            this.btnBread.TabIndex = 6;
            this.btnBread.Text = "Bread";
            this.btnBread.UseVisualStyleBackColor = false;
            this.btnBread.Click += new System.EventHandler(this.btnBread_Click);
            // 
            // gbWeapons
            // 
            this.gbWeapons.BackColor = System.Drawing.Color.Transparent;
            this.gbWeapons.Controls.Add(this.btnCrossBows);
            this.gbWeapons.Controls.Add(this.btnAddAllWeapons);
            this.gbWeapons.Controls.Add(this.btnIronArmor);
            this.gbWeapons.Controls.Add(this.btnLeatherArmor);
            this.gbWeapons.Controls.Add(this.btnSwords);
            this.gbWeapons.Controls.Add(this.btnMaces);
            this.gbWeapons.Controls.Add(this.btnPikes);
            this.gbWeapons.Controls.Add(this.btnSpears);
            this.gbWeapons.Controls.Add(this.btnBows);
            this.gbWeapons.ForeColor = System.Drawing.Color.White;
            this.gbWeapons.Location = new System.Drawing.Point(262, 179);
            this.gbWeapons.Name = "gbWeapons";
            this.gbWeapons.Size = new System.Drawing.Size(310, 170);
            this.gbWeapons.TabIndex = 5;
            this.gbWeapons.TabStop = false;
            this.gbWeapons.Text = "Weapons";
            // 
            // btnAddAllWeapons
            // 
            this.btnAddAllWeapons.BackColor = System.Drawing.Color.DimGray;
            this.btnAddAllWeapons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAllWeapons.Location = new System.Drawing.Point(6, 134);
            this.btnAddAllWeapons.Name = "btnAddAllWeapons";
            this.btnAddAllWeapons.Size = new System.Drawing.Size(298, 23);
            this.btnAddAllWeapons.TabIndex = 14;
            this.btnAddAllWeapons.Text = "Add All Weapons";
            this.btnAddAllWeapons.UseVisualStyleBackColor = false;
            this.btnAddAllWeapons.Click += new System.EventHandler(this.btnAddAllWeapons_Click);
            // 
            // btnIronArmor
            // 
            this.btnIronArmor.BackColor = System.Drawing.Color.DimGray;
            this.btnIronArmor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIronArmor.Location = new System.Drawing.Point(158, 105);
            this.btnIronArmor.Name = "btnIronArmor";
            this.btnIronArmor.Size = new System.Drawing.Size(146, 23);
            this.btnIronArmor.TabIndex = 13;
            this.btnIronArmor.Text = "Iron Armor";
            this.btnIronArmor.UseVisualStyleBackColor = false;
            this.btnIronArmor.Click += new System.EventHandler(this.btnIronArmor_Click);
            // 
            // btnLeatherArmor
            // 
            this.btnLeatherArmor.BackColor = System.Drawing.Color.DimGray;
            this.btnLeatherArmor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLeatherArmor.Location = new System.Drawing.Point(6, 105);
            this.btnLeatherArmor.Name = "btnLeatherArmor";
            this.btnLeatherArmor.Size = new System.Drawing.Size(146, 23);
            this.btnLeatherArmor.TabIndex = 12;
            this.btnLeatherArmor.Text = "Leather Armor";
            this.btnLeatherArmor.UseVisualStyleBackColor = false;
            this.btnLeatherArmor.Click += new System.EventHandler(this.btnLeatherArmor_Click);
            // 
            // btnSwords
            // 
            this.btnSwords.BackColor = System.Drawing.Color.DimGray;
            this.btnSwords.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSwords.Location = new System.Drawing.Point(158, 76);
            this.btnSwords.Name = "btnSwords";
            this.btnSwords.Size = new System.Drawing.Size(146, 23);
            this.btnSwords.TabIndex = 11;
            this.btnSwords.Text = "Swords";
            this.btnSwords.UseVisualStyleBackColor = false;
            this.btnSwords.Click += new System.EventHandler(this.btnSwords_Click);
            // 
            // btnMaces
            // 
            this.btnMaces.BackColor = System.Drawing.Color.DimGray;
            this.btnMaces.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaces.Location = new System.Drawing.Point(6, 76);
            this.btnMaces.Name = "btnMaces";
            this.btnMaces.Size = new System.Drawing.Size(146, 23);
            this.btnMaces.TabIndex = 10;
            this.btnMaces.Text = "Maces";
            this.btnMaces.UseVisualStyleBackColor = false;
            this.btnMaces.Click += new System.EventHandler(this.btnMaces_Click);
            // 
            // btnPikes
            // 
            this.btnPikes.BackColor = System.Drawing.Color.DimGray;
            this.btnPikes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPikes.Location = new System.Drawing.Point(158, 47);
            this.btnPikes.Name = "btnPikes";
            this.btnPikes.Size = new System.Drawing.Size(146, 23);
            this.btnPikes.TabIndex = 9;
            this.btnPikes.Text = "Pikes";
            this.btnPikes.UseVisualStyleBackColor = false;
            this.btnPikes.Click += new System.EventHandler(this.btnPikes_Click);
            // 
            // btnSpears
            // 
            this.btnSpears.BackColor = System.Drawing.Color.DimGray;
            this.btnSpears.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSpears.Location = new System.Drawing.Point(6, 48);
            this.btnSpears.Name = "btnSpears";
            this.btnSpears.Size = new System.Drawing.Size(146, 23);
            this.btnSpears.TabIndex = 8;
            this.btnSpears.Text = "Spears";
            this.btnSpears.UseVisualStyleBackColor = false;
            this.btnSpears.Click += new System.EventHandler(this.btnSpears_Click);
            // 
            // btnBows
            // 
            this.btnBows.BackColor = System.Drawing.Color.DimGray;
            this.btnBows.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBows.Location = new System.Drawing.Point(6, 19);
            this.btnBows.Name = "btnBows";
            this.btnBows.Size = new System.Drawing.Size(146, 23);
            this.btnBows.TabIndex = 7;
            this.btnBows.Text = "Bows";
            this.btnBows.UseVisualStyleBackColor = false;
            this.btnBows.Click += new System.EventHandler(this.btnBows_Click);
            // 
            // lbValueInfo
            // 
            this.lbValueInfo.AutoSize = true;
            this.lbValueInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbValueInfo.ForeColor = System.Drawing.Color.White;
            this.lbValueInfo.Location = new System.Drawing.Point(117, 13);
            this.lbValueInfo.Name = "lbValueInfo";
            this.lbValueInfo.Size = new System.Drawing.Size(175, 13);
            this.lbValueInfo.TabIndex = 6;
            this.lbValueInfo.Text = "Each button adds x of those goods.";
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lbCreatedBy.ForeColor = System.Drawing.Color.White;
            this.lbCreatedBy.Location = new System.Drawing.Point(345, 13);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(227, 13);
            this.lbCreatedBy.TabIndex = 7;
            this.lbCreatedBy.Text = "Created by Dan with help from Newage Soldier";
            // 
            // btnCrossBows
            // 
            this.btnCrossBows.BackColor = System.Drawing.Color.DimGray;
            this.btnCrossBows.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrossBows.Location = new System.Drawing.Point(158, 19);
            this.btnCrossBows.Name = "btnCrossBows";
            this.btnCrossBows.Size = new System.Drawing.Size(146, 23);
            this.btnCrossBows.TabIndex = 15;
            this.btnCrossBows.Text = "Crossbows";
            this.btnCrossBows.UseVisualStyleBackColor = false;
            this.btnCrossBows.Click += new System.EventHandler(this.btnCrossBows_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lbCreatedBy);
            this.Controls.Add(this.lbValueInfo);
            this.Controls.Add(this.gbWeapons);
            this.Controls.Add(this.gbFoods);
            this.Controls.Add(this.gbRawMaterials);
            this.Controls.Add(this.gbGeneralAndExtra);
            this.Controls.Add(this.lbStatusofgame);
            this.Controls.Add(this.lbStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.Text = "Stronghold Crusader Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbGeneralAndExtra.ResumeLayout(false);
            this.gbGeneralAndExtra.PerformLayout();
            this.gbRawMaterials.ResumeLayout(false);
            this.gbFoods.ResumeLayout(false);
            this.gbWeapons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbStatusofgame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbGeneralAndExtra;
        private System.Windows.Forms.Button btnGold;
        private System.Windows.Forms.TextBox txtGold;
        private System.Windows.Forms.CheckBox cbAutoAddAllGoods;
        private System.Windows.Forms.Button btnAddAllGoods;
        private System.Windows.Forms.TextBox txtChickens;
        private System.Windows.Forms.Button btnChickens;
        private System.Windows.Forms.GroupBox gbRawMaterials;
        private System.Windows.Forms.Button btnPitch;
        private System.Windows.Forms.Button btnIron;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnWood;
        private System.Windows.Forms.Button btnAddAllMaterials;
        private System.Windows.Forms.GroupBox gbFoods;
        private System.Windows.Forms.Button btnAddAllFoods;
        private System.Windows.Forms.Button btnWheat;
        private System.Windows.Forms.Button btnAle;
        private System.Windows.Forms.Button btnHops;
        private System.Windows.Forms.Button btnMeat;
        private System.Windows.Forms.Button btnApples;
        private System.Windows.Forms.Button btnCheese;
        private System.Windows.Forms.Button btnBread;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox gbWeapons;
        private System.Windows.Forms.Button btnAddAllWeapons;
        private System.Windows.Forms.Button btnIronArmor;
        private System.Windows.Forms.Button btnLeatherArmor;
        private System.Windows.Forms.Button btnSwords;
        private System.Windows.Forms.Button btnMaces;
        private System.Windows.Forms.Button btnPikes;
        private System.Windows.Forms.Button btnSpears;
        private System.Windows.Forms.Button btnBows;
        private System.Windows.Forms.Label lbValueInfo;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.Button btnCrossBows;
    }
}

