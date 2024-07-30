namespace P1T2
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.rbcircumference = new System.Windows.Forms.RadioButton();
            this.rbAreaCircle = new System.Windows.Forms.RadioButton();
            this.rbAreaSphere = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblradius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(169, 438);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 0;
            // 
            // rbcircumference
            // 
            this.rbcircumference.AutoSize = true;
            this.rbcircumference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcircumference.Location = new System.Drawing.Point(67, 175);
            this.rbcircumference.Name = "rbcircumference";
            this.rbcircumference.Size = new System.Drawing.Size(247, 29);
            this.rbcircumference.TabIndex = 1;
            this.rbcircumference.TabStop = true;
            this.rbcircumference.Text = "Circumference of a circle";
            this.rbcircumference.UseVisualStyleBackColor = true;
            // 
            // rbAreaCircle
            // 
            this.rbAreaCircle.AutoSize = true;
            this.rbAreaCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAreaCircle.Location = new System.Drawing.Point(67, 216);
            this.rbAreaCircle.Name = "rbAreaCircle";
            this.rbAreaCircle.Size = new System.Drawing.Size(167, 29);
            this.rbAreaCircle.TabIndex = 2;
            this.rbAreaCircle.TabStop = true;
            this.rbAreaCircle.Text = "Area of a Circle";
            this.rbAreaCircle.UseVisualStyleBackColor = true;
            // 
            // rbAreaSphere
            // 
            this.rbAreaSphere.AutoSize = true;
            this.rbAreaSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAreaSphere.Location = new System.Drawing.Point(67, 262);
            this.rbAreaSphere.Name = "rbAreaSphere";
            this.rbAreaSphere.Size = new System.Drawing.Size(181, 29);
            this.rbAreaSphere.TabIndex = 3;
            this.rbAreaSphere.TabStop = true;
            this.rbAreaSphere.Text = "Area of a Sphere";
            this.rbAreaSphere.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(136, 338);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(273, 61);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(127, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(520, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "CIRCLE CALCULATION";
            // 
            // lblradius
            // 
            this.lblradius.AutoSize = true;
            this.lblradius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblradius.Location = new System.Drawing.Point(120, 299);
            this.lblradius.Name = "lblradius";
            this.lblradius.Size = new System.Drawing.Size(127, 25);
            this.lblradius.TabIndex = 6;
            this.lblradius.Text = "Enter radius :";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(269, 299);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblradius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbAreaSphere);
            this.Controls.Add(this.rbAreaCircle);
            this.Controls.Add(this.rbcircumference);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton rbcircumference;
        private System.Windows.Forms.RadioButton rbAreaCircle;
        private System.Windows.Forms.RadioButton rbAreaSphere;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblradius;
        private System.Windows.Forms.TextBox txtRadius;
    }
}

