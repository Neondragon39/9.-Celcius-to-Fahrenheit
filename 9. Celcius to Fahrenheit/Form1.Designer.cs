namespace _9._Celcius_to_Fahrenheit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CelciusRB = new System.Windows.Forms.RadioButton();
            this.FahrenheitRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.AsteetTB = new System.Windows.Forms.TextBox();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FahrenheitRB);
            this.groupBox1.Controls.Add(this.CelciusRB);
            this.groupBox1.Location = new System.Drawing.Point(269, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miten muunnat?";
            // 
            // CelciusRB
            // 
            this.CelciusRB.AutoSize = true;
            this.CelciusRB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CelciusRB.Location = new System.Drawing.Point(9, 22);
            this.CelciusRB.Name = "CelciusRB";
            this.CelciusRB.Size = new System.Drawing.Size(91, 29);
            this.CelciusRB.TabIndex = 0;
            this.CelciusRB.TabStop = true;
            this.CelciusRB.Text = "Celcius";
            this.CelciusRB.UseVisualStyleBackColor = true;
            // 
            // FahrenheitRB
            // 
            this.FahrenheitRB.AutoSize = true;
            this.FahrenheitRB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FahrenheitRB.Location = new System.Drawing.Point(9, 57);
            this.FahrenheitRB.Name = "FahrenheitRB";
            this.FahrenheitRB.Size = new System.Drawing.Size(123, 29);
            this.FahrenheitRB.TabIndex = 1;
            this.FahrenheitRB.TabStop = true;
            this.FahrenheitRB.Text = "Fahrenheit";
            this.FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            this.AsteetTB.Location = new System.Drawing.Point(163, 143);
            this.AsteetTB.Name = "AsteetTB";
            this.AsteetTB.Size = new System.Drawing.Size(100, 23);
            this.AsteetTB.TabIndex = 2;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MuunnaBT.Location = new System.Drawing.Point(518, 141);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(113, 48);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = true;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.Location = new System.Drawing.Point(36, 274);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(79, 25);
            this.VastausLB.TabIndex = 4;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.AsteetTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Aste muunnion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton FahrenheitRB;
        private RadioButton CelciusRB;
        private Label label1;
        private TextBox AsteetTB;
        private Button MuunnaBT;
        private Label VastausLB;
    }
}