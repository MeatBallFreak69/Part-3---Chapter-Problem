
namespace Part_3___Chapter_Problem
{
    partial class BasicInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.lblMessage2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(13, 65);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 2;
            this.txtHeight.TextChanged += new System.EventHandler(this.txtHeight_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(119, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Enter Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.White;
            this.lblAge.Location = new System.Drawing.Point(119, 42);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(63, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Enter Age";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.BackColor = System.Drawing.Color.Transparent;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.ForeColor = System.Drawing.Color.White;
            this.lblHeight.Location = new System.Drawing.Point(119, 68);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(99, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Enter Height (m)";
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(13, 91);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(205, 23);
            this.btnResults.TabIndex = 6;
            this.btnResults.Text = "Calculate";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(12, 160);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(49, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Results";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(15, 39);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(100, 20);
            this.nudAge.TabIndex = 8;
            this.nudAge.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lblMessage2
            // 
            this.lblMessage2.AutoSize = true;
            this.lblMessage2.BackColor = System.Drawing.Color.Black;
            this.lblMessage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage2.ForeColor = System.Drawing.Color.White;
            this.lblMessage2.Location = new System.Drawing.Point(12, 185);
            this.lblMessage2.Name = "lblMessage2";
            this.lblMessage2.Size = new System.Drawing.Size(49, 13);
            this.lblMessage2.TabIndex = 9;
            this.lblMessage2.Text = "Results";
            // 
            // BasicInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Part_3___Chapter_Problem.Properties.Resources.Me_As_Obama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(392, 235);
            this.Controls.Add(this.lblMessage2);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtName);
            this.Name = "BasicInput";
            this.Text = "Basic Input";
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.Label lblMessage2;
    }
}

