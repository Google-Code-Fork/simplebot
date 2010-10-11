﻿namespace SimpleBot.Forms
{
    partial class Extras
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
            this.uxCheckEatFood = new System.Windows.Forms.CheckBox();
            this.uxCheckXRay = new System.Windows.Forms.CheckBox();
            this.uxCheckFullLight = new System.Windows.Forms.CheckBox();
            this.uxCheckFramerateControl = new System.Windows.Forms.CheckBox();
            this.uxReplaceTrees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxCheckEatFood
            // 
            this.uxCheckEatFood.AutoSize = true;
            this.uxCheckEatFood.Location = new System.Drawing.Point(12, 12);
            this.uxCheckEatFood.Name = "uxCheckEatFood";
            this.uxCheckEatFood.Size = new System.Drawing.Size(69, 17);
            this.uxCheckEatFood.TabIndex = 0;
            this.uxCheckEatFood.Text = "Eat Food";
            this.uxCheckEatFood.UseVisualStyleBackColor = true;
            this.uxCheckEatFood.CheckedChanged += new System.EventHandler(this.uxCheckEatFood_CheckedChanged);
            // 
            // uxCheckXRay
            // 
            this.uxCheckXRay.AutoSize = true;
            this.uxCheckXRay.Location = new System.Drawing.Point(12, 58);
            this.uxCheckXRay.Name = "uxCheckXRay";
            this.uxCheckXRay.Size = new System.Drawing.Size(55, 17);
            this.uxCheckXRay.TabIndex = 1;
            this.uxCheckXRay.Text = "X-Ray";
            this.uxCheckXRay.UseVisualStyleBackColor = true;
            this.uxCheckXRay.CheckedChanged += new System.EventHandler(this.uxCheckXRay_CheckedChanged);
            // 
            // uxCheckFullLight
            // 
            this.uxCheckFullLight.AutoSize = true;
            this.uxCheckFullLight.Location = new System.Drawing.Point(12, 35);
            this.uxCheckFullLight.Name = "uxCheckFullLight";
            this.uxCheckFullLight.Size = new System.Drawing.Size(68, 17);
            this.uxCheckFullLight.TabIndex = 2;
            this.uxCheckFullLight.Text = "Full Light";
            this.uxCheckFullLight.UseVisualStyleBackColor = true;
            this.uxCheckFullLight.CheckedChanged += new System.EventHandler(this.uxCheckFullLight_CheckedChanged);
            // 
            // uxCheckFramerateControl
            // 
            this.uxCheckFramerateControl.AutoSize = true;
            this.uxCheckFramerateControl.Location = new System.Drawing.Point(12, 81);
            this.uxCheckFramerateControl.Name = "uxCheckFramerateControl";
            this.uxCheckFramerateControl.Size = new System.Drawing.Size(109, 17);
            this.uxCheckFramerateControl.TabIndex = 4;
            this.uxCheckFramerateControl.Text = "Framerate Control";
            this.uxCheckFramerateControl.UseVisualStyleBackColor = true;
            this.uxCheckFramerateControl.CheckedChanged += new System.EventHandler(this.uxCheckFramerateControl_CheckedChanged);
            // 
            // uxReplaceTrees
            // 
            this.uxReplaceTrees.Location = new System.Drawing.Point(12, 104);
            this.uxReplaceTrees.Name = "uxReplaceTrees";
            this.uxReplaceTrees.Size = new System.Drawing.Size(109, 23);
            this.uxReplaceTrees.TabIndex = 5;
            this.uxReplaceTrees.Text = "Replace Trees";
            this.uxReplaceTrees.UseVisualStyleBackColor = true;
            this.uxReplaceTrees.Click += new System.EventHandler(this.uxReplaceTrees_Click);
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 133);
            this.Controls.Add(this.uxReplaceTrees);
            this.Controls.Add(this.uxCheckFramerateControl);
            this.Controls.Add(this.uxCheckFullLight);
            this.Controls.Add(this.uxCheckXRay);
            this.Controls.Add(this.uxCheckEatFood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Extras";
            this.Text = "Extras";
            this.Load += new System.EventHandler(this.Extras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox uxCheckEatFood;
        public System.Windows.Forms.CheckBox uxCheckXRay;
        public System.Windows.Forms.CheckBox uxCheckFullLight;
        public System.Windows.Forms.CheckBox uxCheckFramerateControl;
        public System.Windows.Forms.Button uxReplaceTrees;

    }
}