﻿using System;

namespace _8QuanHau
{
    partial class fNguoiVSMay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNguoiVSMay));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prgbCoolDown = new System.Windows.Forms.ProgressBar();
            this.txtNguoi1 = new System.Windows.Forms.TextBox();
            this.pnBanCo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_sound = new System.Windows.Forms.Button();
            this.pibNguoi1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibNguoi1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(730, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.prgbCoolDown);
            this.panel2.Controls.Add(this.pibNguoi1);
            this.panel2.Controls.Add(this.txtNguoi1);
            this.panel2.Location = new System.Drawing.Point(475, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 127);
            this.panel2.TabIndex = 10;
            // 
            // prgbCoolDown
            // 
            this.prgbCoolDown.Location = new System.Drawing.Point(107, 31);
            this.prgbCoolDown.Name = "prgbCoolDown";
            this.prgbCoolDown.Size = new System.Drawing.Size(121, 43);
            this.prgbCoolDown.TabIndex = 4;
            // 
            // txtNguoi1
            // 
            this.txtNguoi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNguoi1.Location = new System.Drawing.Point(3, 3);
            this.txtNguoi1.Name = "txtNguoi1";
            this.txtNguoi1.Size = new System.Drawing.Size(225, 22);
            this.txtNguoi1.TabIndex = 0;
            this.txtNguoi1.Text = "Player";
            // 
            // pnBanCo
            // 
            this.pnBanCo.Location = new System.Drawing.Point(3, 35);
            this.pnBanCo.Name = "pnBanCo";
            this.pnBanCo.Size = new System.Drawing.Size(466, 422);
            this.pnBanCo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gợi ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_sound
            // 
            this.btn_sound.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_sound.BackgroundImage = global::_8QuanHau.Properties.Resources.sound;
            this.btn_sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sound.Location = new System.Drawing.Point(670, 413);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(39, 37);
            this.btn_sound.TabIndex = 11;
            this.btn_sound.UseVisualStyleBackColor = false;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click);
            // 
            // pibNguoi1
            // 
            this.pibNguoi1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pibNguoi1.Location = new System.Drawing.Point(3, 27);
            this.pibNguoi1.Name = "pibNguoi1";
            this.pibNguoi1.Size = new System.Drawing.Size(101, 97);
            this.pibNguoi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibNguoi1.TabIndex = 0;
            this.pibNguoi1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BackgroundImage = global::_8QuanHau.Properties.Resources.banco;
            this.flowLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(475, 170);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(243, 234);
            this.flowLayoutPanel3.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Check";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fNguoiVSMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(730, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sound);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnBanCo);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNguoiVSMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Người Vs Máy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fNguoiVSMay_FormClosing);
            this.Load += new System.EventHandler(this.fNguoiVSMay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibNguoi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnBanCo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNguoi1;
        private System.Windows.Forms.PictureBox pibNguoi1;
        private System.Windows.Forms.Button btn_sound;
        private System.Windows.Forms.ProgressBar prgbCoolDown;
        private System.Windows.Forms.Button button1;
        private EventHandler button1_Click;
        private System.Windows.Forms.Button button2;
    }
}