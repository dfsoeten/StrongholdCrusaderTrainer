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
        int goodsAmount = 200;

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

        }

        //Auto add all goods
        private void cbAutoAddAllGoods_CheckedChanged(object sender, EventArgs e)
        {
            
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

        
    }
}
