using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using PS3Lib;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public static int SpawnKillCount = 0;
        bool ForceHost = false;
        public Form1()
        {
            InitializeComponent();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();

            groupControl1.Top = 176;
            groupControl2.Top = 176;
            groupControl3.Top = 176;
            groupControl4.Top = 176;
            groupControl7.Top = 176;
            groupControl8.Top = 176;
            groupControl9.Top = 176;
            groupControl10.Top = 176;
            groupControl12.Top = 176;
            groupControl1.Left = 150;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 1000;
            groupControl8.Left = 1000;
            groupControl9.Left = 1000;
            groupControl10.Left = 1000;
            groupControl12.Left = 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DevExpress.UserSkins.BonusSkins.Register();
            SkinHelper.InitSkinPopupMenu(SkinsLink);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var gallery = new
            DevExpress.XtraBars.Ribbon.GalleryDropDown();
            gallery.Manager = barManager1;
            SkinHelper.InitSkinGalleryDropDown(gallery);
            gallery.ShowPopup(MousePosition);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (RPC.PS3.ConnectTarget())
            {
                if (RPC.PS3.AttachProcess())
                {
                    labelControl2.Text = "Connected And Attach";
                    labelControl2.ForeColor = Color.Blue;
                    RPC.Init();
                }
                else
                {
                    labelControl2.Text = "Could Not Attach";
                    labelControl2.ForeColor = Color.Red;
                }
            }
            else
            {
                labelControl2.Text = "Could Not Connect";
                labelControl2.ForeColor = Color.Red;
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            RPC.PS3.DisconnectTarget();
            labelControl2.Text = "Disconnected";
            labelControl2.ForeColor = Color.Red;
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 150;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 1000;
            groupControl8.Left = 1000;
            groupControl9.Left = 1000;
            groupControl10.Left = 1000;
            groupControl12.Left = 1000;
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 1000;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 1000;
            groupControl8.Left = 1000;
            groupControl9.Left = 150;
            groupControl10.Left = 1000;
            groupControl12.Left = 1000;
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 1000;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 1000;
            groupControl8.Left = 1000;
            groupControl9.Left = 1000;
            groupControl10.Left = 150;
            groupControl12.Left = 1000;
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 1000;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 150;
            groupControl7.Left = 1000;
            groupControl8.Left = 1000;
            groupControl9.Left = 1000;
            groupControl10.Left = 1000;
            groupControl12.Left = 1000;
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 1000;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 150;
            groupControl8.Left = 1000;
            groupControl9.Left = 1000;
            groupControl10.Left = 1000;
            groupControl12.Left = 1000;
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 1000;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 1000;
            groupControl8.Left = 150;
            groupControl9.Left = 1000;
            groupControl10.Left = 1000;
            groupControl12.Left = 1000;
        }
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            groupControl1.Left = 1000;
            groupControl2.Left = 1000;
            groupControl3.Left = 1000;
            groupControl4.Left = 1000;
            groupControl7.Left = 1000;
            groupControl8.Left = 1000;
            groupControl9.Left = 1000;
            groupControl10.Left = 1000;
            groupControl12.Left = 150;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.UnlockAll, new byte[] { 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x01, 0x01, 0x01, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x02, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x11, 0x00, 0x00 });
        }

        private void toggleSwitch10_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch10.IsOn)
            {
                checkEdit1.Checked = true;
                checkEdit2.Checked = true;
                checkEdit3.Checked = true;
                checkEdit4.Checked = true;
                checkEdit5.Checked = true;
                checkEdit6.Checked = true;
                checkEdit7.Checked = true;
                checkEdit8.Checked = true;
                checkEdit9.Checked = true;
                checkEdit10.Checked = true;
                checkEdit11.Checked = true;
                checkEdit12.Checked = true;
                checkEdit13.Checked = true;
                checkEdit14.Checked = true;
                checkEdit15.Checked = true;
                checkEdit16.Checked = true;
            }
            else
            {
                checkEdit1.Checked = false;
                checkEdit2.Checked = false;
                checkEdit3.Checked = false;
                checkEdit4.Checked = false;
                checkEdit5.Checked = false;
                checkEdit6.Checked = false;
                checkEdit7.Checked = false;
                checkEdit8.Checked = false;
                checkEdit9.Checked = false;
                checkEdit10.Checked = false;
                checkEdit11.Checked = false;
                checkEdit12.Checked = false;
                checkEdit13.Checked = false;
                checkEdit14.Checked = false;
                checkEdit15.Checked = false;
                checkEdit16.Checked = false;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Prestige, Convert.ToInt32(textEdit1.Text));
            }
            if (checkEdit2.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.XPSoldier, Convert.ToInt32(textEdit6.Text));
            }
            if (checkEdit3.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Kills, Convert.ToInt32(textEdit5.Text));
            }
            if (checkEdit4.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Deaths, Convert.ToInt32(textEdit7.Text));
            }
            if (checkEdit5.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Score, Convert.ToInt32(textEdit4.Text));
            }
            if (checkEdit6.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Wins, Convert.ToInt32(textEdit3.Text));
            }
            if (checkEdit7.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Losses, Convert.ToInt32(textEdit2.Text));
            }
            if (checkEdit8.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.SquadPoints, Convert.ToInt32(textEdit11.Text));
            }
            if (checkEdit9.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.TimePlayed, Convert.ToInt32(textEdit16.Text));
            }
            if (checkEdit10.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.GamesPlayed, Convert.ToInt32(textEdit15.Text));
            }
            if (checkEdit11.Checked)
            {
                byte[] Weapons = { 0x58, 0x57, 0x70, 0x0A, 0x07, 0xA3, 0x05, 0x03, 0x01, 0x10, 0x11, 0x12, 0x15, 0x16, 0x17, 0x18, 0x19, 0x20, 0x21, 0x22, 0x24, 0x25, 0x26, 0x27, 0x29, 0x30, 0x31, 0x33, 0x34, 0x35, 0x36, 0x37, 0x41, 0x44, 0x45, 0x47, 0x48, 0x2a, 0x0F, 0x0C, 0x7A, 0x3A, 0x1B, 0x2B, 0x2D, 0x3B };
                RPC.PS3.Extension.WriteByte(Addresses.PreferredWeapon, Weapons[comboBoxEdit1.SelectedIndex]);

            }
            if (checkEdit12.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Misses, Convert.ToInt32(textEdit13.Text));
            }
            if (checkEdit13.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Hits, Convert.ToInt32(textEdit8.Text));
            }
            if (checkEdit14.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Winstreak, Convert.ToInt32(textEdit9.Text));
            }
            if (checkEdit15.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Currentstreak, Convert.ToInt32(textEdit12.Text));
            }
            if (checkEdit16.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Killstreak, Convert.ToInt32(textEdit10.Text));
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteString(Addresses.Name, textEdit17.Text);
            RPC.PS3.Extension.WriteString(Addresses.ClanTag, textEdit18.Text);
        }

        public int RainbowCurrent = 0;
        private void flashname_Tick(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteString(Addresses.Name, "^" + RainbowCurrent.ToString() + textEdit17.Text);
            RainbowCurrent++;
            if (RainbowCurrent > 9)
            {
                RainbowCurrent = 0;
            }
        }

        private void toggleSwitch11_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                flashname.Enabled = true;
            }
            else
            {
                flashname.Enabled = false;
            }
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.UAV, new byte[] { 0x01 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.UAV, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch5_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch5.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.AdvancedUAV, new byte[] { 0x01 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.AdvancedUAV, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch4_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch4.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.RedBoxes, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.RedBoxes, new byte[] { 0x41, 0x82, 0x00, 0x0C });
            }
        }

        private void toggleSwitch6_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch6.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.Wallhack, new byte[] { 0x42, 0x80 });
                RPC.PS3.Extension.WriteBytes(Addresses.WallhackGlow, new byte[] { 0xF9 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.Wallhack, new byte[] { 0x40, 0x80 });
                RPC.PS3.Extension.WriteBytes(Addresses.WallhackGlow, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch3_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch3.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.Laser, new byte[] { 0x01 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.Laser, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch9_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch9.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.SteadyAim, new byte[] { 0x2C, 0x03, 0x00, 0x00 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.SteadyAim, new byte[] { 0x2C, 0x03, 0x00, 0x02 });
            }
        }

        private void toggleSwitch8_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch8.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.ChromePlayer, new byte[] { 0x01 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.ChromePlayer, new byte[] { 0x00 });
            }
        }

        private void toggleSwitch7_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch7.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.NoRecoil, new byte[] { 0x60, 0x00, 0x00, 0x00 });
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.NoRecoil, new byte[] { 0x4B, 0xB9, 0x7D, 0xCD });
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/user/WelshMods");
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Addresses.ClientIndex = listBoxControl1.SelectedIndex - 1;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
            listBoxControl1.Items.Add("All Players");
            for (int i = 0; i <= Addresses.MaxClients - 1; i++)
            {
                listBoxControl1.Items.Add(Functions.GetNames(i));
            }
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton1.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        Functions.iPrintln(i, "All Players Godmode ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)Addresses.ClientIndex * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Godmode ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                        Functions.iPrintln(i, "All Players Godmode ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)Addresses.ClientIndex * Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Godmode ^1OFF");
                }
            }
        }

        private void checkButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton2.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        Functions.iPrintln(i, "All Players Unlimited Ammo ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Unlimited Ammo ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        Functions.iPrintln(i, "All Players Unlimited Ammo ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Unlimited Ammo ^1OFF");
                }
            }
        }

        private void checkButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton3.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)i * Addresses.ClientInterval), new byte[] { 0x07 });
                        Functions.iPrintln(i, "All Players Third Person ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)Addresses.ClientInterval), new byte[] { 0x07 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Third Person ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Third Person ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Third Person ^1OFF");
                }
            }
        }

        private void checkButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton4.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)i * Addresses.ClientInterval), new byte[] { 0x50 });
                        Functions.iPrintln(i, "All Players Red Boxes ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)Addresses.ClientInterval), new byte[] { 0x50 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Red Boxes ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Red Boxes ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Red Boxes ^1OFF");
                }
            }
        }

        private void checkButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton5.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.HostUAV + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players UAV ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.HostUAV + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " UAV ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.HostUAV + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players UAV ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.HostUAV + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " UAV ^1OFF");
                }
            }
        }

        private void checkButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton6.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AllPerks + ((uint)i * Addresses.ClientInterval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                        Functions.iPrintln(i, "All Players All Perks ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AllPerks + ((uint)Addresses.ClientInterval), new byte[] { 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " All Perks ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AllPerks + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0xC0, 0x80, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                        Functions.iPrintln(i, "All Players All Perks ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AllPerks + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0x00, 0xC0, 0x80, 0x00, 0x00, 0x00, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " AllPerks ^1OFF");
                }
            }
        }

        private void checkButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton7.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.ImpactBullets + ((uint)i * Addresses.ClientInterval), new byte[] { 0xFF });
                        Functions.iPrintln(i, "All Players Impact Bullets ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.ImpactBullets + ((uint)Addresses.ClientInterval), new byte[] { 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Impact Bullets ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.ImpactBullets + ((uint)i * Addresses.ClientInterval), new byte[] { 0x60 });
                        Functions.iPrintln(i, "All Players Impact Bullets ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.ImpactBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x60 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Impact Bullets ^1OFF");
                }
            }
        }

        private void checkButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton8.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.KillAndScare + ((uint)i * Addresses.ClientInterval), new byte[] { 0xFF });
                        Functions.iPrintln(i, "All Players Kill And Scare ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.KillAndScare + ((uint)Addresses.ClientInterval), new byte[] { 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Kill And Scare ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        XtraMessageBox.Show("Client Has To Kill Himself For It To Stop");
                        Functions.iPrintln(i, "All Players Kill And Scare ^1OFF");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Client Has To Kill Himself For It To Stop");
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Kill And Scare ^1OFF");
                }
            }
        }

        private void checkButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton9.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players Akimbo Primary ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Primary ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Akimbo Primary ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Primary ^1OFF");
                }
            }
        }

        private void checkButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton10.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players Akimbo Secondary ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Secondary ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Akimbo Secondary ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Secondary ^1OFF");
                }
            }
        }

        private void checkButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton11.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.Jammer + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players Laser ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.Jammer + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Laser ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.Jammer + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Laser ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.Jammer + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Laser ^1OFF");
                }
            }
        }

        private void checkButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton12.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x02 });
                        Functions.iPrintln(i, "All Players UFO ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x02 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " UFO ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players UFO ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " UFO ^1OFF");
                }
            }
        }

        private void checkButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton13.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players No Clip ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " No Clip ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players No Clip ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " No Clip ^1OFF");
                }
            }
        }

        private void checkButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton14.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x04 });
                        Functions.iPrintln(i, "Freeze All Players ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x04 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + "Freeze " + Functions.GetNames(Addresses.ClientIndex) + "^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "Freeze All Players ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + "Freeze " + Functions.GetNames(Addresses.ClientIndex) + "^1OFF");
                }
            }
        }

        private void checkButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton15.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PlayerSpeed + ((uint)i * Addresses.ClientInterval), new byte[] { 0x40 });
                        Functions.iPrintln(i, "All Players Super Speed ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PlayerSpeed + ((uint)Addresses.ClientInterval), new byte[] { 0x40 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Super Speed ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PlayerSpeed + ((uint)i * Addresses.ClientInterval), new byte[] { 0x3F });
                        Functions.iPrintln(i, "All Players Super Speed ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PlayerSpeed + ((uint)Addresses.ClientInterval), new byte[] { 0x3F });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Super Speed ^1OFF");
                }
            }
        }

        private void checkButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton16.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PlayerSpeed + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Lag ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PlayerSpeed + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Lag ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.Lag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x02 });
                        Functions.iPrintln(i, "All Players Lag ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.Lag + ((uint)Addresses.ClientInterval), new byte[] { 0x02 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Lag ^1OFF");
                }
            }
        }

        private void checkButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton17.Checked)
            {
                Aimbot.Enabled = true;
                Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Aimbot ^2ON");
            }
            else
            {
                Aimbot.Enabled = false;
                Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Aimbot ^1OFF");
            }
        }

        private void checkButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton18.Checked)
            {
                    Jetpack.Enabled = true;
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " JetPack ^2ON");
            }
            else
            {
                    Jetpack.Enabled = false;
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " JetPack ^1OFF");
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Functions.SetModel(Addresses.ClientIndex, comboBoxEdit2.Properties.Items[comboBoxEdit2.SelectedIndex].ToString());
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            byte[] Weapon = { 20, 121, 37, 120, 118, 119, 117, 30, 126, 132, 122, 15, 113, 22, 128, 131, 134, 115, 5, 25, 94, 102, 13, 96, 24, 29, 12, 53, 52, 84, 80, 73, 66, 41, 40, 48, 38, 43, 89, 86, 55, 46, 85, 69, 49, 45, 88, 79, 54, 50, 42, 57, 56, 51, 39, 87, 74, 65, 44, 78, 76, 75, 72, 62, 58, 82, 81, 77, 71, 70, 68, 67, 63, 23, 59, 60, 61, 135, 137, 136 };
            Functions.GiveWeapon(Addresses.ClientIndex, Weapon[comboBoxEdit3.SelectedIndex], 999, 0);
        }

        private void zoomTrackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.LobbyPlayerSpeed, (float)zoomTrackBarControl1.Value);
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.LobbyPlayerSpeed, new byte[] { 0x38, 0xA0, 0x00, 0xBE });
        }

        private void zoomTrackBarControl2_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.JumpHeight, (float)zoomTrackBarControl2.Value);
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.JumpHeight, new byte[] { 0x42, 0x1C });
        }

        private void zoomTrackBarControl3_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.Gravity, (float)zoomTrackBarControl3.Value);
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.Gravity, new byte[] { 0x03, 0x20 });
        }

        private void zoomTrackBarControl4_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.Knockback, (float)zoomTrackBarControl4.Value);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.Knockback, 1000);
        }

        private void simpleButton12_Click(object sender, EventArgs e)
        {
            Functions.SetXP(zoomTrackBarControl5.Value);
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            Functions.SetTimelimit(zoomTrackBarControl6.Value);
        }

        private void simpleButton13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Addresses.MaxClients; i++)
            {
                Functions.iPrintlnBold(i, textEdit14.Text);
            }
        }

        private void Advertise_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Addresses.MaxClients; i++)
            {
                Functions.iPrintlnBold(i, textEdit19.Text);
            }
        }

        private void checkButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton19.Checked)
            {
                for (int i = 0; i < Addresses.MaxClients; i++)
                {
                    Functions.iPrintlnBold(i, textEdit3.Text);
                }
                Advertise.Enabled = true;
            }
            else
            {
                Advertise.Enabled = false;
            }
        }

        private void host_Tick(object sender, EventArgs e)
        {
            if (ForceHost)
            {
                Functions.ForceHostON();
            }
        }

        private void simpleButton18_Click(object sender, EventArgs e)
        {
            Functions.Cbuf_AddText(0, textEdit20.Text);
        }

        private void simpleButton19_Click(object sender, EventArgs e)
        {
            Functions.SV_GameSendServerCommand(0, textEdit21.Text);
        }

        private void checkButton20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton20.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.SkateMode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players Skate Mod ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.SkateMode + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Skate Mod ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.SkateMode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Skate Mod ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.SkateMode + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Skate Mod ^1OFF");
                }
            }
        }

        private void checkButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton20.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.Spining_Mode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0f, 0xff });
                        Functions.iPrintln(i, "All Players Spining Mode ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.Spining_Mode + ((uint)Addresses.ClientInterval), new byte[] { 0x0f, 0xff });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Spining Mode ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.Spining_Mode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x80, 0x00 });
                        Functions.iPrintln(i, "All Players Spining Mode ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.Spining_Mode + ((uint)Addresses.ClientInterval), new byte[] { 0x80, 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Spining Mode ^1OFF");
                }
            }
        }

        private void simpleButton20_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedIndex == 0)
            {
                for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                {
                    byte[] map = { 0x08 , 0x03 , 0x01 , 0x02 };
                    RPC.PS3.Extension.WriteByte(Addresses.PreferredWeapon + ((uint)i *Addresses.ClientInterval), map[comboBoxEdit6.SelectedIndex]);
                }
            }
            else
            {
                byte[] map = { 0x08, 0x03, 0x01, 0x02 };
                RPC.PS3.Extension.WriteByte(Addresses.PreferredWeapon + ((uint)Addresses.ClientInterval), map[comboBoxEdit6.SelectedIndex]);
            }
        }

        private void toggleSwitch13_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch13.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.GodModeAll, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                Functions.iPrintln(0, "All Players Godmode ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.GodModeAll, new byte[] { 0x90, 0x9B, 0x01, 0xA8 });
                Functions.iPrintln(0, "All Players Godmode ^1OFF");
            }
        }

        private void toggleSwitch14_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch14.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.JumpHeight, new byte[] { 0x45, 0x48 });
                Functions.iPrintln(0, "Super Jump ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.JumpHeight, new byte[] { 0x42, 0x1C });
                Functions.iPrintln(0, "Super Jump ^1OFF");
            }
        }

        private void toggleSwitch15_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch15.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.LobbyPlayerSpeed, new byte[] { 0x20, 0xA0, 0x05, 0xBE });
                Functions.iPrintln(0, "Super Speed ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.LobbyPlayerSpeed, new byte[] { 0x38, 0xA0, 0x00, 0xBE });
                Functions.iPrintln(0, "Super Speed ^1OFF");
            }
        }

        private void toggleSwitch16_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch16.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.MaxFallDamage, new byte[] { 0x47, 0x7F, 0x49, 0x00 });
                Functions.iPrintln(0, "No Fall Damage ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.MaxFallDamage, new byte[] { 0x43, 0x00, 0x00 });
                Functions.iPrintln(0, "No Fall Damage ^1OFF");
            }
        }

        private void toggleSwitch17_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch17.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.FullAuto, new byte[] { 0x3B, 0x60, 0x00, 0x00 });
                Functions.iPrintln(0, "Full Auto ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.FullAuto, new byte[] { 0x60, 0x00, 0x01 });
                Functions.iPrintln(0, "Full Auto ^1OFF");
            }
        }

        private void checkButton25_CheckedChanged(object sender, EventArgs e)
        {
            Functions.Vision(Addresses.ClientIndex, comboBoxEdit7.Properties.Items[comboBoxEdit7.SelectedIndex].ToString());
        }

        private void checkButton21_CheckedChanged_1(object sender, EventArgs e)
        {
            Functions.KickWithError(Addresses.ClientIndex, textEdit22.Text);
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
             if (listBoxControl1.SelectedIndex == 0)
            {
                for (int i = 1; i <= Addresses.MaxClients - 1; i++)
                {
                    Functions.TeleportPlayerToPlayer(Addresses.ClientIndex, 0);
                    Functions.iPrintln(0, " All Players ^2 Teleported To Me");
                }
            }
            else
            {
                Functions.TeleportPlayerToPlayer(Addresses.ClientIndex, 0);
                Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + "^2 Teleported To Me");
            }
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            Functions.TeleportPlayerToPlayer(0, Addresses.ClientIndex);
            Functions.iPrintln(0, "Teleported To ^2" + Functions.GetNames(Addresses.ClientIndex));
        }

        private void SpawnKill_Tick(object sender, EventArgs e)
        {
            Functions.TeleportPlayerToPlayer(SpawnKillCount, 0);
            SpawnKillCount++;
            if (SpawnKillCount == Addresses.MaxClients)
            {
                SpawnKillCount = 0;
            }
        }

        private void checkButton22_CheckedChanged(object sender, EventArgs e)
        {
             if (checkButton22.Checked)
                {
                    SpawnKill.Enabled = true;
                }
                else
                {
                    SpawnKill.Enabled = false;
                }
            }

        private void Aimbot_Tick(object sender, EventArgs e)
        {
            PWNBOT.setClientViewAngles(Addresses.ClientIndex);
        
        }

        private void Jetpack_Tick(object sender, EventArgs e)
        {
            if (Buttons.ButtonPressed(0, Buttons.X))
                Functions.JetPack(0);
        }

        private void toggleSwitch18_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch18.IsOn)
            {
                checkEdit17.Checked = true;
                checkEdit18.Checked = true;
                checkEdit19.Checked = true;
                checkEdit20.Checked = true;
                checkEdit21.Checked = true;
                checkEdit22.Checked = true;
                checkEdit23.Checked = true;
            }
            else
            {
                checkEdit17.Checked = false;
                checkEdit18.Checked = false;
                checkEdit19.Checked = false;
                checkEdit20.Checked = false;
                checkEdit21.Checked = false;
                checkEdit22.Checked = false;
                checkEdit23.Checked = false;
            }
        }

        private void simpleButton21_Click(object sender, EventArgs e)
        {
            if (checkEdit23.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.ExtictionPrestige, Convert.ToInt32(textEdit29.Text));
            }
            if (checkEdit22.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Level, Convert.ToInt32(textEdit24.Text));
            }
            if (checkEdit21.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Teeth, Convert.ToInt32(textEdit25.Text));
            }
            if (checkEdit20.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Revive, Convert.ToInt32(textEdit23.Text));
            }
            if (checkEdit19.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.MissionCompleted, Convert.ToInt32(textEdit26.Text));
            }
            if (checkEdit18.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.MaxRelics, Convert.ToInt32(textEdit27.Text));
            }
            if (checkEdit17.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.AliensKilled, Convert.ToInt32(textEdit28.Text));
            }
        }

        private void toggleSwitch19_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch19.IsOn)
            {
                checkEdit24.Checked = true;
                checkEdit25.Checked = true;
                checkEdit26.Checked = true;
                checkEdit27.Checked = true;
                checkEdit28.Checked = true;
                checkEdit29.Checked = true;
                checkEdit30.Checked = true;
                checkEdit31.Checked = true;
            }
            else
            {
                checkEdit24.Checked = false;
                checkEdit25.Checked = false;
                checkEdit26.Checked = false;
                checkEdit27.Checked = false;
                checkEdit28.Checked = false;
                checkEdit29.Checked = false;
                checkEdit30.Checked = false;
                checkEdit31.Checked = false;
            }
        }

        private void simpleButton22_Click(object sender, EventArgs e)
        {
            if (checkEdit30.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.ExtictionRevives, Convert.ToInt32(textEdit36.Text));
            }
            if (checkEdit29.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.ExtictionScore, Convert.ToInt32(textEdit31.Text));
            }
            if (checkEdit28.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.ExtictionKills, Convert.ToInt32(textEdit32.Text));
            }
            if (checkEdit27.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.Downs, Convert.ToInt32(textEdit30.Text));
            }
            if (checkEdit26.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.CashFlow, Convert.ToInt32(textEdit33.Text));
            }
            if (checkEdit25.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.HivesDestroyed, Convert.ToInt32(textEdit34.Text));
            }
            if (checkEdit24.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.CompletedChallenges, Convert.ToInt32(textEdit35.Text));
            }
            if (checkEdit31.Checked)
            {
                RPC.PS3.Extension.WriteInt32(Addresses.AttemteptedChallenges, Convert.ToInt32(textEdit37.Text));
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.AntibanOffset1, new byte[] { 0x30, 0xA5 });
            RPC.PS3.Extension.WriteBytes(Addresses.AntibanOffset2, new byte[] { 0x39 });
            RPC.PS3.Extension.WriteBytes(Addresses.AntibanOffset3, new byte[] { 0x38, 0x60 });
            RPC.PS3.Extension.WriteBytes(Addresses.AntibanOffset4, new byte[] { 0x38, 0xC0 });
            RPC.PS3.Extension.WriteBytes(Addresses.AntibanOffset5, new byte[] { 0x30, 0xE7 });
            RPC.PS3.Extension.WriteBytes(Addresses.AntibanOffset6, new byte[] { 0x3B, 160 });
            labelControl38.Text = "Enabled";
            labelControl38.ForeColor = Color.Blue;
        }

        private void listBoxControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Addresses.ClientIndex = listBoxControl1.SelectedIndex - 1;
        }

        private void toggleSwitch20_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch20.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.GodModeAll, new byte[] { 0x60, 0x00, 0x00, 0x00 });
                Functions.iPrintln(0, "All Players Godmode ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.GodModeAll, new byte[] { 0x90, 0x9B, 0x01, 0xA8 });
                Functions.iPrintln(0, "All Players Godmode ^1OFF");
            }
        }

        private void toggleSwitch23_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch23.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.LobbyPlayerSpeed, new byte[] { 0x20, 0xA0, 0x05, 0xBE });
                Functions.iPrintln(0, "Super Speed ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.LobbyPlayerSpeed, new byte[] { 0x38, 0xA0, 0x00, 0xBE });
                Functions.iPrintln(0, "Super Speed ^1OFF");
            }
        }

        private void toggleSwitch22_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch22.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.JumpHeight, new byte[] { 0x45, 0x48 });
                Functions.iPrintln(0, "Super Jump ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.JumpHeight, new byte[] { 0x42, 0x1C });
                Functions.iPrintln(0, "Super Jump ^1OFF");
            }
        }

        private void toggleSwitch21_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch21.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.MaxFallDamage, new byte[] { 0x47, 0x7F, 0x49, 0x00 });
                Functions.iPrintln(0, "No Fall Damage ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.MaxFallDamage, new byte[] { 0x43, 0x00, 0x00 });
                Functions.iPrintln(0, "No Fall Damage ^1OFF");
            }
        }

        private void toggleSwitch24_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch24.IsOn)
            {
                RPC.PS3.Extension.WriteBytes(Addresses.FullAuto, new byte[] { 0x3B, 0x60, 0x00, 0x00 });
                Functions.iPrintln(0, "Full Auto ^2ON");
            }
            else
            {
                RPC.PS3.Extension.WriteBytes(Addresses.FullAuto, new byte[] { 0x60, 0x00, 0x01 });
                Functions.iPrintln(0, "Full Auto ^1OFF");
            }
        }

        private void zoomTrackBarControl10_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.LobbyPlayerSpeed, (float)zoomTrackBarControl10.Value);
        }

        private void simpleButton26_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.LobbyPlayerSpeed, new byte[] { 0x38, 0xA0, 0x00, 0xBE });
        }

        private void zoomTrackBarControl9_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.JumpHeight, (float)zoomTrackBarControl9.Value);
        }

        private void simpleButton25_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.JumpHeight, new byte[] { 0x42, 0x1C });
        }

        private void zoomTrackBarControl8_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.Gravity, (float)zoomTrackBarControl8.Value);
        }

        private void simpleButton24_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteBytes(Addresses.Gravity, new byte[] { 0x03, 0x20 });
        }

        private void zoomTrackBarControl7_EditValueChanged(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.Knockback, (float)zoomTrackBarControl7.Value);
        }

        private void simpleButton23_Click(object sender, EventArgs e)
        {
            RPC.PS3.Extension.WriteFloat(Addresses.Knockback, 1000);
        }

        private void simpleButton27_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Addresses.MaxClientsExt; i++)
            {
                Functions.iPrintlnBold(i, textEdit38.Text);
            }
        }

        private void AdvertiseExt_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < Addresses.MaxClientsExt; i++)
            {
                Functions.iPrintlnBold(i, textEdit39.Text);
            }
        }

        private void checkButton23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton23.Checked)
            {
                for (int i = 0; i < Addresses.MaxClientsExt; i++)
                {
                    Functions.iPrintlnBold(i, textEdit39.Text);
                }
                AdvertiseExt.Enabled = true;
            }
            else
            {
                AdvertiseExt.Enabled = false;
            }
        }

        private void simpleButton29_Click(object sender, EventArgs e)
        {
            Functions.Cbuf_AddText(0, textEdit40.Text);
        }

        private void simpleButton30_Click(object sender, EventArgs e)
        {
            Functions.SV_GameSendServerCommand(0, textEdit41.Text);
        }

        private void checkButton24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton24.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        Functions.iPrintln(i, "All Players Godmode ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)Addresses.ClientIndex * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Godmode ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                        Functions.iPrintln(i, "All Players Godmode ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.godmode + ((uint)Addresses.ClientIndex * Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Godmode ^1OFF");
                }
            }
        }

        private void checkButton26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton26.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)i * Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                        Functions.iPrintln(i, "All Players Unlimited Ammo ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x0F, 0xFF, 0xFF, 0xFF });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Unlimited Ammo ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                        Functions.iPrintln(i, "All Players Unlimited Ammo ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.PrimaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryClip + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.SecondaryBullets + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.Lethal + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    RPC.PS3.Extension.WriteBytes(Addresses.Tactical + ((uint)Addresses.ClientInterval), new byte[] { 0x00, 0x00, 0x00, 0x1E });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Unlimited Ammo ^1OFF");
                }
            }
        }

        private void checkButton27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton27.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players Akimbo Primary ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Primary ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Akimbo Primary ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboPrimary + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Primary ^1OFF");
                }
            }
        }

        private void checkButton28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton28.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players Akimbo Secondary ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Secondary ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Akimbo Secondary ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.AkimboSecondary + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Akimbo Secondary ^1OFF");
                }
            }
        }

        private void checkButton29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton29.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x02 });
                        Functions.iPrintln(i, "All Players UFO ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x02 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " UFO ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players UFO ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " UFO ^1OFF");
                }
            }
        }

        private void checkButton30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton30.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x01 });
                        Functions.iPrintln(i, "All Players No Clip ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x01 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " No Clip ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players No Clip ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.mFlag + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " No Clip ^1OFF");
                }
            }
        }

        private void checkButton31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkButton31.Checked)
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)i * Addresses.ClientInterval), new byte[] { 0x50 });
                        Functions.iPrintln(i, "All Players Red Boxes ^2ON");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)Addresses.ClientInterval), new byte[] { 0x50 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Red Boxes ^2ON");
                }
            }
            else
            {
                if (listBoxControl1.SelectedIndex == 0)
                {
                    for (int i = 1; i <= Addresses.MaxClientsExt - 1; i++)
                    {
                        RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)i * Addresses.ClientInterval), new byte[] { 0x00 });
                        Functions.iPrintln(i, "All Players Red Boxes ^1OFF");
                    }
                }
                else
                {
                    RPC.PS3.Extension.WriteBytes(Addresses.OrangeBoxes + ((uint)Addresses.ClientInterval), new byte[] { 0x00 });
                    Functions.iPrintln(0, Functions.GetNames(Addresses.ClientIndex) + " Red Boxes ^1OFF");
                }
            }
        }

        private void simpleButton28_Click(object sender, EventArgs e)
        {
            byte[] Weapon = { 20, 121, 37, 120, 118, 119, 117, 30, 126, 132, 122, 15, 113, 22, 128, 131, 134, 115, 5, 25, 94, 102, 13, 96, 24, 29, 12, 53, 52, 84, 80, 73, 66, 41, 40, 48, 38, 43, 89, 86, 55, 46, 85, 69, 49, 45, 88, 79, 54, 50, 42, 57, 56, 51, 39, 87, 74, 65, 44, 78, 76, 75, 72, 62, 58, 82, 81, 77, 71, 70, 68, 67, 63, 23, 59, 60, 61, 135, 137, 136 };
            Functions.GiveWeapon(Addresses.ClientIndex, Weapon[comboBoxEdit8.SelectedIndex], 999, 0);
        }

        private void simpleButton31_Click(object sender, EventArgs e)
        {
            Functions.SetModel(Addresses.ClientIndex, comboBoxEdit9.Properties.Items[comboBoxEdit9.SelectedIndex].ToString());
        }

        private void simpleButton32_Click(object sender, EventArgs e)
        {
            Functions.KickWithError(Addresses.ClientIndex, textEdit42.Text);
        }

        private void simpleButton33_Click(object sender, EventArgs e)
        {
            Functions.KickWithError(Addresses.ClientIndex, textEdit22.Text);
        }

        private void simpleButton34_Click(object sender, EventArgs e)
        {
            listBoxControl2.Items.Clear();
            listBoxControl2.Items.Add("All Players");
            for (int i = 0; i <= Addresses.MaxClientsExt - 1; i++)
            {
                listBoxControl2.Items.Add(Functions.GetNames(i));
            }
        }

        private void barToggleSwitchItem1_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barToggleSwitchItem1.Checked)
            {              
                barToggleSwitchItem1.Caption = "TMAPI";
                RPC.PS3.ChangeAPI(SelectAPI.TargetManager);
            }
            else
            {
                barToggleSwitchItem1.Caption = "TMAPI";
                RPC.PS3.ChangeAPI(SelectAPI.ControlConsole);
            }
        }
    }
}

