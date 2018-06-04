namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        ///Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Clear all used resources.
        /// </summary>
        ///<param name="disposing">if the managed resources should be dispose true; otherwise it is false.</param>
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
        /// The method required for designer support -  
        ///Do not change the content with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.values = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.g0 = new System.Windows.Forms.PictureBox();
            this.r0 = new System.Windows.Forms.PictureBox();
            this.names = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.g0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.r0)).BeginInit();
            this.SuspendLayout();
            // 
            // values
            // 
            this.values.BackColor = System.Drawing.Color.Transparent;
            this.values.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.values.Location = new System.Drawing.Point(163, 9);
            this.values.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.values.Name = "values";
            this.values.Padding = new System.Windows.Forms.Padding(5);
            this.values.Size = new System.Drawing.Size(211, 250);
            this.values.TabIndex = 0;
            this.values.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 10000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // g0
            // 
            this.g0.Enabled = false;
            this.g0.Image = ((System.Drawing.Image)(resources.GetObject("g0.Image")));
            this.g0.Location = new System.Drawing.Point(343, 12);
            this.g0.Name = "g0";
            this.g0.Size = new System.Drawing.Size(25, 25);
            this.g0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.g0.TabIndex = 42;
            this.g0.TabStop = false;
            this.g0.Visible = false;
            // 
            // r0
            // 
            this.r0.Enabled = false;
            this.r0.Image = ((System.Drawing.Image)(resources.GetObject("r0.Image")));
            this.r0.Location = new System.Drawing.Point(343, 12);
            this.r0.Name = "r0";
            this.r0.Size = new System.Drawing.Size(25, 25);
            this.r0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.r0.TabIndex = 47;
            this.r0.TabStop = false;
            this.r0.Visible = false;
            // 
            // names
            // 
            this.names.BackColor = System.Drawing.Color.Transparent;
            this.names.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.names.Location = new System.Drawing.Point(13, 9);
            this.names.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.names.Name = "names";
            this.names.Padding = new System.Windows.Forms.Padding(5);
            this.names.Size = new System.Drawing.Size(142, 250);
            this.names.TabIndex = 48;
            this.names.Text = "Name :\r\nCurrent :\r\nCurrency :\r\nChange :\r\n% Change :\r\nHigh :\r\nLow :\r\nVolume :";
            this.names.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(383, 268);
            this.Controls.Add(this.names);
            this.Controls.Add(this.r0);
            this.Controls.Add(this.g0);
            this.Controls.Add(this.values);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Crypto Market Ticker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.g0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.r0)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label values;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.PictureBox g0;
        private System.Windows.Forms.PictureBox r0;
        private System.Windows.Forms.Label names;
    }
}

