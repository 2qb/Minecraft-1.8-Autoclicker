namespace Autoclicker
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
            this.EnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.EnabledText = new System.Windows.Forms.Label();
            this.CPSText = new System.Windows.Forms.Label();
            this.BindEnabledText = new System.Windows.Forms.Label();
            this.KeybindName = new System.Windows.Forms.Label();
            this.slider1 = new Autoclicker.Slider();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // EnabledCheckBox
            // 
            this.EnabledCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.EnabledCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.EnabledCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.EnabledCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.EnabledCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnabledCheckBox.Location = new System.Drawing.Point(32, 28);
            this.EnabledCheckBox.Name = "EnabledCheckBox";
            this.EnabledCheckBox.Size = new System.Drawing.Size(25, 22);
            this.EnabledCheckBox.TabIndex = 0;
            this.EnabledCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EnabledCheckBox.UseVisualStyleBackColor = true;
            this.EnabledCheckBox.CheckedChanged += new System.EventHandler(this.EnabledButtonChange);
            // 
            // EnabledText
            // 
            this.EnabledText.AutoSize = true;
            this.EnabledText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabledText.Location = new System.Drawing.Point(63, 31);
            this.EnabledText.Name = "EnabledText";
            this.EnabledText.Size = new System.Drawing.Size(60, 17);
            this.EnabledText.TabIndex = 1;
            this.EnabledText.Text = "Enabled";
            this.EnabledText.Click += new System.EventHandler(this.EnabledText_Click);
            // 
            // CPSText
            // 
            this.CPSText.AutoSize = true;
            this.CPSText.Location = new System.Drawing.Point(29, 89);
            this.CPSText.Name = "CPSText";
            this.CPSText.Size = new System.Drawing.Size(55, 13);
            this.CPSText.TabIndex = 3;
            this.CPSText.Text = "CPS: 10.0";
            // 
            // BindEnabledText
            // 
            this.BindEnabledText.AutoSize = true;
            this.BindEnabledText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BindEnabledText.ForeColor = System.Drawing.Color.Gray;
            this.BindEnabledText.Location = new System.Drawing.Point(252, 31);
            this.BindEnabledText.Name = "BindEnabledText";
            this.BindEnabledText.Size = new System.Drawing.Size(39, 17);
            this.BindEnabledText.TabIndex = 4;
            this.BindEnabledText.Text = "bind:";
            // 
            // KeybindName
            // 
            this.KeybindName.AutoSize = true;
            this.KeybindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindName.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.KeybindName.Location = new System.Drawing.Point(287, 31);
            this.KeybindName.Name = "KeybindName";
            this.KeybindName.Size = new System.Drawing.Size(50, 17);
            this.KeybindName.TabIndex = 5;
            this.KeybindName.Text = "(none)";
            this.KeybindName.Click += new System.EventHandler(this.KeybindName_Click);
            // 
            // slider1
            // 
            this.slider1.Location = new System.Drawing.Point(32, 57);
            this.slider1.Maximum = 20;
            this.slider1.Minimum = 10;
            this.slider1.Name = "slider1";
            this.slider1.Size = new System.Drawing.Size(290, 29);
            this.slider1.TabIndex = 2;
            this.slider1.Value = 10D;
            this.slider1.ValueChanged += new System.EventHandler(this.slider1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(357, 135);
            this.Controls.Add(this.KeybindName);
            this.Controls.Add(this.BindEnabledText);
            this.Controls.Add(this.CPSText);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.EnabledText);
            this.Controls.Add(this.EnabledCheckBox);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EnabledCheckBox;
        private System.Windows.Forms.Label EnabledText;
        private Slider slider1;
        private System.Windows.Forms.Label CPSText;
        private System.Windows.Forms.Label BindEnabledText;
        private System.Windows.Forms.Label KeybindName;
        private System.Windows.Forms.Timer timer1;
    }
}

