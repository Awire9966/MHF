namespace MHF
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
            this.rb = new System.Windows.Forms.Button();
            this.fu = new System.Windows.Forms.Label();
            this.thewordstatus_duh = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.inf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb
            // 
            this.rb.Location = new System.Drawing.Point(12, 75);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(286, 23);
            this.rb.TabIndex = 0;
            this.rb.Text = "RESET!";
            this.rb.UseVisualStyleBackColor = true;
            this.rb.Click += new System.EventHandler(this.rb_Click);
            // 
            // fu
            // 
            this.fu.AutoSize = true;
            this.fu.Location = new System.Drawing.Point(12, 22);
            this.fu.Name = "fu";
            this.fu.Size = new System.Drawing.Size(76, 13);
            this.fu.TabIndex = 1;
            this.fu.Text = "x/20 files used";
            // 
            // thewordstatus_duh
            // 
            this.thewordstatus_duh.AutoSize = true;
            this.thewordstatus_duh.Location = new System.Drawing.Point(12, 35);
            this.thewordstatus_duh.Name = "thewordstatus_duh";
            this.thewordstatus_duh.Size = new System.Drawing.Size(40, 13);
            this.thewordstatus_duh.TabIndex = 2;
            this.thewordstatus_duh.Text = "Status:";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Green;
            this.status.Location = new System.Drawing.Point(53, 35);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(41, 13);
            this.status.TabIndex = 3;
            this.status.Text = "Ready!";
            // 
            // inf
            // 
            this.inf.Location = new System.Drawing.Point(12, 104);
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(286, 23);
            this.inf.TabIndex = 4;
            this.inf.Text = "INFINITY MODE";
            this.inf.UseVisualStyleBackColor = true;
            this.inf.Click += new System.EventHandler(this.inf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 133);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.status);
            this.Controls.Add(this.thewordstatus_duh);
            this.Controls.Add(this.fu);
            this.Controls.Add(this.rb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaHuman Fucker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rb;
        private System.Windows.Forms.Label fu;
        private System.Windows.Forms.Label thewordstatus_duh;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button inf;
    }
}

