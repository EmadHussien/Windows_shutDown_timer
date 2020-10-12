namespace shutdownTimer
{
    partial class logoff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logoff));
            this.Shutodwn = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Shutodwn
            // 
            this.Shutodwn.Location = new System.Drawing.Point(119, 125);
            this.Shutodwn.Name = "Shutodwn";
            this.Shutodwn.Size = new System.Drawing.Size(102, 27);
            this.Shutodwn.TabIndex = 0;
            this.Shutodwn.Text = "ok";
            this.Shutodwn.UseVisualStyleBackColor = true;
            this.Shutodwn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(208, 66);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(154, 22);
            this.Time.TabIndex = 1;
            this.Time.TextChanged += new System.EventHandler(this.Time_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(260, 125);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(103, 27);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel timer";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter time in Minutes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logoff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Shutodwn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logoff";
            this.Text = "Shutdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Shutodwn;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
    }
}

