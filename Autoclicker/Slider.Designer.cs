namespace Autoclicker
{
    partial class Slider
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SliderThumb = new System.Windows.Forms.Panel();
            this.SliderBody = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SliderThumb
            // 
            this.SliderThumb.BackColor = System.Drawing.Color.SteelBlue;
            this.SliderThumb.Location = new System.Drawing.Point(3, 3);
            this.SliderThumb.Name = "SliderThumb";
            this.SliderThumb.Size = new System.Drawing.Size(12, 19);
            this.SliderThumb.TabIndex = 6;
            this.SliderThumb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SliderThumb_MouseDown);
            this.SliderThumb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SliderThumb_MouseMove);
            this.SliderThumb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SliderThumb_MouseUp);
            // 
            // SliderBody
            // 
            this.SliderBody.BackColor = System.Drawing.Color.Gray;
            this.SliderBody.Location = new System.Drawing.Point(3, 9);
            this.SliderBody.Name = "SliderBody";
            this.SliderBody.Size = new System.Drawing.Size(283, 9);
            this.SliderBody.TabIndex = 5;
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SliderThumb);
            this.Controls.Add(this.SliderBody);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(289, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SliderThumb;
        private System.Windows.Forms.Panel SliderBody;
    }
}
