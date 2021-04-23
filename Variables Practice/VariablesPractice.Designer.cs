
namespace Variables_Practice
{
    partial class VariablesPractice
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
            this.label1 = new System.Windows.Forms.Label();
            this.hockey = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.areabutton = new System.Windows.Forms.Button();
            this.carpet = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // hockey
            // 
            this.hockey.BackColor = System.Drawing.Color.White;
            this.hockey.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hockey.Location = new System.Drawing.Point(219, 179);
            this.hockey.Name = "hockey";
            this.hockey.Size = new System.Drawing.Size(122, 40);
            this.hockey.TabIndex = 1;
            this.hockey.Text = "Hockey";
            this.hockey.UseVisualStyleBackColor = false;
            this.hockey.Click += new System.EventHandler(this.runButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.outputLabel.Location = new System.Drawing.Point(25, 28);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 20);
            this.outputLabel.TabIndex = 2;
            // 
            // areabutton
            // 
            this.areabutton.BackColor = System.Drawing.Color.White;
            this.areabutton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.areabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.areabutton.Location = new System.Drawing.Point(219, 300);
            this.areabutton.Name = "areabutton";
            this.areabutton.Size = new System.Drawing.Size(122, 40);
            this.areabutton.TabIndex = 3;
            this.areabutton.Text = "Area";
            this.areabutton.UseVisualStyleBackColor = false;
            this.areabutton.Click += new System.EventHandler(this.area_Click);
            // 
            // carpet
            // 
            this.carpet.BackColor = System.Drawing.Color.White;
            this.carpet.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carpet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.carpet.Location = new System.Drawing.Point(219, 424);
            this.carpet.Name = "carpet";
            this.carpet.Size = new System.Drawing.Size(122, 40);
            this.carpet.TabIndex = 4;
            this.carpet.Text = "Carpet";
            this.carpet.UseVisualStyleBackColor = false;
            this.carpet.Click += new System.EventHandler(this.carpet_Click);
            // 
            // bill
            // 
            this.bill.BackColor = System.Drawing.Color.White;
            this.bill.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bill.Location = new System.Drawing.Point(219, 545);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(122, 40);
            this.bill.TabIndex = 5;
            this.bill.Text = "Bill";
            this.bill.UseVisualStyleBackColor = false;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // VariablesPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.carpet);
            this.Controls.Add(this.areabutton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.hockey);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Name = "VariablesPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Variables Practice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hockey;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button areabutton;
        private System.Windows.Forms.Button carpet;
        private System.Windows.Forms.Button bill;
    }
}

