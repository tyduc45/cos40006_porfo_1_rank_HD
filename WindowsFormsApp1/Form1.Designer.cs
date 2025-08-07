namespace WindowsFormsApp1
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
            this.btnToggle = new System.Windows.Forms.Button();
            this.labelmsg = new System.Windows.Forms.Label();
            this.TimeLable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(151, 308);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(464, 56);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.Text = "click me to show hello world";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelmsg
            // 
            this.labelmsg.AutoSize = true;
            this.labelmsg.Location = new System.Drawing.Point(324, 172);
            this.labelmsg.Name = "labelmsg";
            this.labelmsg.Size = new System.Drawing.Size(107, 18);
            this.labelmsg.TabIndex = 1;
            this.labelmsg.Text = "hello world";
            this.labelmsg.Visible = false;
            // 
            // TimeLable
            // 
            this.TimeLable.AutoSize = true;
            this.TimeLable.Location = new System.Drawing.Point(324, 220);
            this.TimeLable.Name = "TimeLable";
            this.TimeLable.Size = new System.Drawing.Size(53, 18);
            this.TimeLable.TabIndex = 2;
            this.TimeLable.Text = "time:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(464, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "click me to see curent time ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TimeLable);
            this.Controls.Add(this.labelmsg);
            this.Controls.Add(this.btnToggle);
            this.Name = "Form1";
            this.Text = "7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Label labelmsg;
        private System.Windows.Forms.Label TimeLable;
        private System.Windows.Forms.Button button1;
    }
}

