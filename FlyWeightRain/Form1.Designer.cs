namespace FlyWeightRain
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnDrop = new System.Windows.Forms.Button();
            this.BtnFlyDrop = new System.Windows.Forms.Button();
            this.BtnRain = new System.Windows.Forms.Button();
            this.TmrRain = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            this.BtnDrop.Location = new System.Drawing.Point(12, 12);
            this.BtnDrop.Name = "BtnDrop";
            this.BtnDrop.Size = new System.Drawing.Size(110, 25);
            this.BtnDrop.TabIndex = 0;
            this.BtnDrop.Text = "Крапля";
            this.BtnDrop.UseVisualStyleBackColor = true;
            this.BtnDrop.Click += new System.EventHandler(this.BtnDrop_Click);

            this.BtnFlyDrop.Location = new System.Drawing.Point(12, 43);
            this.BtnFlyDrop.Name = "BtnFlyDrop";
            this.BtnFlyDrop.Size = new System.Drawing.Size(110, 25);
            this.BtnFlyDrop.TabIndex = 1;
            this.BtnFlyDrop.Text = "Легка крапля";
            this.BtnFlyDrop.UseVisualStyleBackColor = true;
            this.BtnFlyDrop.Click += new System.EventHandler(this.BtnFlyDrop_Click);

            this.BtnRain.Location = new System.Drawing.Point(12, 74);
            this.BtnRain.Name = "BtnRain";
            this.BtnRain.Size = new System.Drawing.Size(110, 25);
            this.BtnRain.TabIndex = 2;
            this.BtnRain.Text = "Імітація дощу";
            this.BtnRain.UseVisualStyleBackColor = true;
            this.BtnRain.Click += new System.EventHandler(this.BtnRain_Click);


            this.TmrRain.Interval = 50;
            this.TmrRain.Tick += new System.EventHandler(this.TmrRain_Tick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.BtnRain);
            this.Controls.Add(this.BtnFlyDrop);
            this.Controls.Add(this.BtnDrop);
            this.Name = "Form1";
            this.Text = "Імітація дощу";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button BtnDrop;
        private System.Windows.Forms.Button BtnFlyDrop;
        private System.Windows.Forms.Button BtnRain;
        private System.Windows.Forms.Timer TmrRain;
    }
}
