using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace StrongholdCrusaderTrainer
{
    public partial class Form1 : Form
    {
        public string codeFile = Application.StartupPath + @"\strongholdcrusader.ini";
        public Mem MemLib = new Mem();
        int gameProcId = 0;
        int goodsAmount = 100;
        int goodLimiter = 40;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbValueInfo.Text = "Each button adds " + goodsAmount + " of those goods.";

            if (backgroundWorker1.IsBusy == false)
                backgroundWorker1.RunWorkerAsync();
        }

        private void openGame()
        {
            gameProcId = MemLib.getProcIDFromName("Stronghold Crusader");

            if (gameProcId != 0)
            {
                //Open game's Process
                MemLib.OpenGameProcess(gameProcId);

                //Update Status
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.Text = "Ready!"; }));
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.ForeColor = System.Drawing.Color.Green; }));
            }
            else
            {
                //Update Status
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.Text = "Waiting..."; }));
                lbStatusofgame.Invoke(new MethodInvoker(delegate { lbStatusofgame.ForeColor = System.Drawing.Color.Red; }));
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (gameProcId != 0)
                {
                    gameProcId = MemLib.getProcIDFromName("Stronghold Crusader");

                    if (cbAutoAddAllGoods.Checked)
                        autoAddAllGoods();
                }
                else
                    openGame();
            }
        }

        //Numeric Only
        private void textbox_numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //                                      General & Extra                                            *
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

        //Gold
        private void btnGold_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0 || txtGold.Text == "")
                return;

            MemLib.writeMemory("Gold", codeFile, "int", txtGold.Text);

            txtGold.Text = "";
        }

        //Chickesn/Skips
        private void btnChickens_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0 || txtChickens.Text == "")
                return;

            MemLib.writeMemory("SkipChickens", codeFile, "int", txtChickens.Text);

            txtChickens.Text = "";
        }

        //Add all goods
        private void btnAddAllGoods_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            //Raw Materials
            MemLib.writeMemory("WoodWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("StoneWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("IronWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("PitchWrite", codeFile, "int", goodsAmount.ToString());

            //Foods
            MemLib.writeMemory("BreadWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("CheeseWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("ApplesWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("MeatWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("HopsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("AleWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("WheatWrite", codeFile, "int", goodsAmount.ToString());

            //Weapons
            MemLib.writeMemory("BowsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("CrossBowsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("SpearsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("PikesWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("MacesWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("SwordsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("LeatherarmorWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("IronarmorWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Auto add all goods 
        private void autoAddAllGoods()
        {
            //Raw Materials
            if (MemLib.readInt("WoodRead", codeFile) < goodLimiter && MemLib.readInt("WoodWrite", codeFile) < goodsAmount) 
                MemLib.writeMemory("WoodWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("StoneRead", codeFile) < goodLimiter && MemLib.readInt("StoneWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("StoneWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("IronRead", codeFile) < goodLimiter && MemLib.readInt("IronWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("IronWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("PitchRead", codeFile) < goodLimiter && MemLib.readInt("PitchWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("PitchWrite", codeFile, "int", goodsAmount.ToString());

            //Foods
            if (MemLib.readInt("BreadRead", codeFile) < goodLimiter && MemLib.readInt("BreadWrite", codeFile) == 0 && MemLib.readInt("UnitsOfFood", codeFile) < (goodsAmount * 4))
                MemLib.writeMemory("BreadWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("CheeseRead", codeFile) < goodLimiter && MemLib.readInt("CheeseWrite", codeFile) == 0 && MemLib.readInt("UnitsOfFood", codeFile) < (goodsAmount * 4))
                MemLib.writeMemory("CheeseWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("ApplesRead", codeFile) < goodLimiter && MemLib.readInt("ApplesWrite", codeFile) == 0 && MemLib.readInt("UnitsOfFood", codeFile) < (goodsAmount * 4))
                MemLib.writeMemory("ApplesWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("MeatRead", codeFile) < goodLimiter && MemLib.readInt("MeatWrite", codeFile) == 0 && MemLib.readInt("UnitsOfFood", codeFile) < (goodsAmount * 4)) 
                MemLib.writeMemory("MeatWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("HopsRead", codeFile) < goodLimiter && MemLib.readInt("HopsWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("HopsWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("WheatRead", codeFile) < goodLimiter && MemLib.readInt("WheatWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("WheatWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("AleRead", codeFile) < goodLimiter && MemLib.readInt("AleWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("AleWrite", codeFile, "int", goodsAmount.ToString());
             
            //Weapons
            if (MemLib.readInt("BowsRead", codeFile) < goodLimiter && MemLib.readInt("BowsWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("BowsWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("CrossBowsRead", codeFile) < goodLimiter && MemLib.readInt("CrossBowsWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("CrossBowsWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("SpearsRead", codeFile) < goodLimiter && MemLib.readInt("SpearsWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("SpearsWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("PikesRead", codeFile) < goodLimiter && MemLib.readInt("PikesWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("PikesWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("MacesRead", codeFile) < goodLimiter && MemLib.readInt("MacesWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("MacesWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("SwordsRead", codeFile) < goodLimiter && MemLib.readInt("SwordsWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("SwordsWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("LeatherarmorRead", codeFile) < goodLimiter && MemLib.readInt("LeatherarmorWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("LeatherarmorWrite", codeFile, "int", goodsAmount.ToString());

            if (MemLib.readInt("IronarmorRead", codeFile) < goodLimiter && MemLib.readInt("IronarmorWrite", codeFile) < goodsAmount)
                MemLib.writeMemory("IronarmorWrite", codeFile, "int", goodsAmount.ToString());
        }

        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //                                       Raw Materials                                             *
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

        //Wood
        private void btnWood_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("WoodWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Stone
        private void btnStone_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("StoneWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Iron
        private void btnIron_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("IronWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Pitch
        private void btnPitch_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("PitchWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Add all raw materials
        private void btnAddAllMaterials_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("WoodWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("StoneWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("IronWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("PitchWrite", codeFile, "int", goodsAmount.ToString());
        }

        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //                                              Foods                                              *
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

        //Bread
        private void btnBread_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("BreadWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Cheese
        private void btnCheese_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("CheeseWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Apples
        private void btnApples_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("ApplesWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Meat
        private void btnMeat_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("MeatWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Hops
        private void btnHops_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("HopsWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Ale
        private void btnAle_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("AleWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Wheat
        private void btnWheat_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("WheatWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Add all foods
        private void btnAddAllFoods_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("BreadWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("CheeseWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("ApplesWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("MeatWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("HopsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("AleWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("WheatWrite", codeFile, "int", goodsAmount.ToString());
        }

        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
        //                                            Weapons                                              *
        // * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *

        //Bows
        private void btnBows_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("BowsWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Crossbows
        private void btnCrossBows_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("CrossBowsWrite", codeFile, "int", goodsAmount.ToString());
        } 

        //Spears
        private void btnSpears_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("SpearsWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Pikes
        private void btnPikes_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("PikesWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Maces
        private void btnMaces_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("MacesWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Swords
        private void btnSwords_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("SwordsWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Leather Armor
        private void btnLeatherArmor_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("LeatherarmorWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Iron Armor
        private void btnIronArmor_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("IronarmorWrite", codeFile, "int", goodsAmount.ToString());
        }

        //Add all weapons
        private void btnAddAllWeapons_Click(object sender, EventArgs e)
        {
            if (gameProcId == 0)
                return;

            MemLib.writeMemory("BowsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("CrossBowsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("SpearsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("PikesWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("MacesWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("SwordsWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("LeatherarmorWrite", codeFile, "int", goodsAmount.ToString());
            MemLib.writeMemory("IronarmorWrite", codeFile, "int", goodsAmount.ToString());
        }
    }
}
