namespace TrailRun
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
            this.btnAccept1 = new System.Windows.Forms.Button();
            this.lblTimesClicked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccept1
            // 
            this.btnAccept1.Location = new System.Drawing.Point(85, 136);
            this.btnAccept1.Name = "btnAccept1";
            this.btnAccept1.Size = new System.Drawing.Size(94, 29);
            this.btnAccept1.TabIndex = 0;
            this.btnAccept1.Text = "Accept";
            this.btnAccept1.UseVisualStyleBackColor = true;
            this.btnAccept1.Click += new System.EventHandler(this.btnAccept1_Click);
            // 
            // lblTimesClicked
            // 
            this.lblTimesClicked.AutoSize = true;
            this.lblTimesClicked.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimesClicked.Location = new System.Drawing.Point(51, 87);
            this.lblTimesClicked.Name = "lblTimesClicked";
            this.lblTimesClicked.Size = new System.Drawing.Size(180, 37);
            this.lblTimesClicked.TabIndex = 1;
            this.lblTimesClicked.Text = "Times clicked:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 574);
            this.Controls.Add(this.lblTimesClicked);
            this.Controls.Add(this.btnAccept1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccept1;
        private Label lblTimesClicked;
    }
}