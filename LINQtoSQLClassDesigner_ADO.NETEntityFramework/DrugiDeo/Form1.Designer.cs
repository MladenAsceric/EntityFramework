﻿namespace DrugiDeo
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
            this.gridKlijenti = new System.Windows.Forms.DataGridView();
            this.gridServisi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridKlijenti
            // 
            this.gridKlijenti.AllowUserToAddRows = false;
            this.gridKlijenti.AllowUserToDeleteRows = false;
            this.gridKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKlijenti.Location = new System.Drawing.Point(13, 13);
            this.gridKlijenti.Name = "gridKlijenti";
            this.gridKlijenti.ReadOnly = true;
            this.gridKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKlijenti.Size = new System.Drawing.Size(339, 322);
            this.gridKlijenti.TabIndex = 0;
            // 
            // gridServisi
            // 
            this.gridServisi.AllowUserToAddRows = false;
            this.gridServisi.AllowUserToDeleteRows = false;
            this.gridServisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServisi.Location = new System.Drawing.Point(449, 13);
            this.gridServisi.Name = "gridServisi";
            this.gridServisi.ReadOnly = true;
            this.gridServisi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServisi.Size = new System.Drawing.Size(339, 322);
            this.gridServisi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read Klijenti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Insert Klijent";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(182, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update Klijent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(267, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 42);
            this.button4.TabIndex = 5;
            this.button4.Text = "Delete Klijent";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(449, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 42);
            this.button5.TabIndex = 6;
            this.button5.Text = "Read Servisi";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(533, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 42);
            this.button6.TabIndex = 7;
            this.button6.Text = "Insert Servis";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(618, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 42);
            this.button7.TabIndex = 8;
            this.button7.Text = "Update Servis";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(703, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 42);
            this.button8.TabIndex = 9;
            this.button8.Text = "Delete Servis";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(358, 399);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 42);
            this.button9.TabIndex = 10;
            this.button9.Text = "Close";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridServisi);
            this.Controls.Add(this.gridKlijenti);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridKlijenti;
        private System.Windows.Forms.DataGridView gridServisi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

