﻿namespace Practica2
{
    partial class MainForm
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
            btnCargar = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(389, 21);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(75, 23);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargaa!";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(341, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCargar);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}