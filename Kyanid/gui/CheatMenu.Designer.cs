using System;
using System.ComponentModel;
using System.Linq;
using Kyanid.managers;

namespace Kyanid.gui
{
    partial class CheatMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.minCpsSlider = new MaterialSkin.Controls.MaterialSlider();
            this.maxCpsSlider = new MaterialSkin.Controls.MaterialSlider();
            this.attackRequiredSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.autoclickerSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.autoclickerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // minCpsSlider
            // 
            this.minCpsSlider.Depth = 0;
            this.minCpsSlider.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.minCpsSlider.Location = new System.Drawing.Point(27, 118);
            this.minCpsSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.minCpsSlider.Name = "minCpsSlider";
            this.minCpsSlider.Size = new System.Drawing.Size(335, 40);
            this.minCpsSlider.TabIndex = 0;
            this.minCpsSlider.Text = "Min";
            this.minCpsSlider.Value = 10;
            this.minCpsSlider.ValueMax = 100;
            this.minCpsSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.minCpsSlider_onValueChanged);
            // 
            // maxCpsSlider
            // 
            this.maxCpsSlider.Depth = 0;
            this.maxCpsSlider.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (222)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))), ((int) (((byte) (0)))));
            this.maxCpsSlider.Location = new System.Drawing.Point(27, 164);
            this.maxCpsSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.maxCpsSlider.Name = "maxCpsSlider";
            this.maxCpsSlider.Size = new System.Drawing.Size(335, 40);
            this.maxCpsSlider.TabIndex = 1;
            this.maxCpsSlider.Text = "Max";
            this.maxCpsSlider.Value = 12;
            this.maxCpsSlider.ValueMax = 100;
            this.maxCpsSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.maxCpsSlider_onValueChanged);
            // 
            // attackRequiredSwitch
            // 
            this.attackRequiredSwitch.Checked = true;
            this.attackRequiredSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.attackRequiredSwitch.Depth = 0;
            this.attackRequiredSwitch.Location = new System.Drawing.Point(27, 224);
            this.attackRequiredSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.attackRequiredSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.attackRequiredSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.attackRequiredSwitch.Name = "attackRequiredSwitch";
            this.attackRequiredSwitch.Ripple = true;
            this.attackRequiredSwitch.Size = new System.Drawing.Size(334, 44);
            this.attackRequiredSwitch.TabIndex = 2;
            this.attackRequiredSwitch.Text = "Attack required";
            this.attackRequiredSwitch.UseVisualStyleBackColor = true;
            this.attackRequiredSwitch.CheckStateChanged += new System.EventHandler(this.attackRequiredSwitch_CheckStateChanged);
            // 
            // autoclickerSwitch
            // 
            this.autoclickerSwitch.Checked = true;
            this.autoclickerSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoclickerSwitch.Depth = 0;
            this.autoclickerSwitch.Location = new System.Drawing.Point(27, 268);
            this.autoclickerSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.autoclickerSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.autoclickerSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoclickerSwitch.Name = "autoclickerSwitch";
            this.autoclickerSwitch.Ripple = true;
            this.autoclickerSwitch.Size = new System.Drawing.Size(334, 44);
            this.autoclickerSwitch.TabIndex = 3;
            this.autoclickerSwitch.Text = "Enabled";
            this.autoclickerSwitch.UseVisualStyleBackColor = true;
            this.autoclickerSwitch.CheckedChanged += new System.EventHandler(this.autoclicker_CheckedChanged);
            // 
            // autoclickerLabel
            // 
            this.autoclickerLabel.Depth = 0;
            this.autoclickerLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.autoclickerLabel.Location = new System.Drawing.Point(27, 92);
            this.autoclickerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.autoclickerLabel.Name = "autoclickerLabel";
            this.autoclickerLabel.Size = new System.Drawing.Size(137, 23);
            this.autoclickerLabel.TabIndex = 5;
            this.autoclickerLabel.Text = "Autoclicker";
            // 
            // CheatMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 531);
            this.Controls.Add(this.autoclickerLabel);
            this.Controls.Add(this.autoclickerSwitch);
            this.Controls.Add(this.attackRequiredSwitch);
            this.Controls.Add(this.maxCpsSlider);
            this.Controls.Add(this.minCpsSlider);
            this.MaximizeBox = false;
            this.Name = "CheatMenu";
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kyanid :3";
            this.Load += new System.EventHandler(this.CheatMenu_Load);
            this.ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialLabel autoclickerLabel;

        private MaterialSkin.Controls.MaterialSwitch autoclickerSwitch;

        private MaterialSkin.Controls.MaterialSwitch attackRequiredSwitch;

        private MaterialSkin.Controls.MaterialSlider minCpsSlider;
        private MaterialSkin.Controls.MaterialSlider maxCpsSlider;

        #endregion
    }
}