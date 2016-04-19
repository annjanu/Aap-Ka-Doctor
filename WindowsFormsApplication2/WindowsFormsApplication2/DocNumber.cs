﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication2
{

    public partial class DocNumber : MetroFramework.Forms.MetroForm
    {
        String[] docs = { "03151234123", "03161234123", "03171234123", "03181234123", "03191234123" };
        public DocNumber()
        {
            InitializeComponent();
        }

        
        
        private void Login_Load(object sender, EventArgs e)
        {
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Name = "Login Portal";
            this.metroTile2.MouseEnter += new EventHandler(backScrMsg);

        }

        private void backScrMsg(object sender, EventArgs e)
        {
            SoundPlayer s = new SoundPlayer(@"..\..\Resources\backScrMsg.wav");
            s.PlaySync();
        }
        public String loginNumber ()
        {
            return this.phoneNumber.Text;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text != "") 
                this.phoneNumber.Text = phoneNumber.Text.Remove((phoneNumber.Text.Length) - 1);
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
           foreach (var c in docs)
           {
               if(c == phoneNumber.Text)
               {
                   this.Hide();
                   return;
               }
           }

           SoundPlayer s = new SoundPlayer(@"..\..\Resources\Wrong number.wav");
           s.Play();
                
        }
        private void masked_box(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13) 
                this.phoneNumber.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (this.phoneNumber.Text.Length < 13)
                this.phoneNumber.Text += "9";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if(this.phoneNumber.Text.Length < 13)
                this.phoneNumber.Text += "0";
        }

        public string getNumber()
        {
            return phoneNumber.Text;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
