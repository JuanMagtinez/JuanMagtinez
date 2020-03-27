namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.TextBox();
            this.CEL = new System.Windows.Forms.RadioButton();
            this.FAR = new System.Windows.Forms.RadioButton();
            this.enviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 84);
            this.button2.TabIndex = 1;
            this.button2.Text = "desconect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PON LA TEMERATURA AQUI -->";
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(399, 98);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(158, 22);
            this.temp.TabIndex = 3;
            // 
            // CEL
            // 
            this.CEL.AutoSize = true;
            this.CEL.Location = new System.Drawing.Point(119, 238);
            this.CEL.Name = "CEL";
            this.CEL.Size = new System.Drawing.Size(147, 21);
            this.CEL.TabIndex = 4;
            this.CEL.TabStop = true;
            this.CEL.Text = "QUIERO CELSIUS!";
            this.CEL.UseVisualStyleBackColor = true;
            this.CEL.CheckedChanged += new System.EventHandler(this.CEL_CheckedChanged);
            // 
            // FAR
            // 
            this.FAR.AutoSize = true;
            this.FAR.Location = new System.Drawing.Point(490, 238);
            this.FAR.Name = "FAR";
            this.FAR.Size = new System.Drawing.Size(189, 21);
            this.FAR.TabIndex = 5;
            this.FAR.TabStop = true;
            this.FAR.Text = "QUIERO FAHRENHEIGH!";
            this.FAR.UseVisualStyleBackColor = true;
            this.FAR.CheckedChanged += new System.EventHandler(this.FAR_CheckedChanged);
            // 
            // enviar
            // 
            this.enviar.Location = new System.Drawing.Point(321, 330);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(277, 78);
            this.enviar.TabIndex = 6;
            this.enviar.Text = "enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 525);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.FAR);
            this.Controls.Add(this.CEL);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.RadioButton CEL;
        private System.Windows.Forms.RadioButton FAR;
        private System.Windows.Forms.Button enviar;
    }
}