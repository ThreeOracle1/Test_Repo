using System.Windows.Forms;

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
            this.btnSearchDatabase = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // btnSearchDatabase
            // 
            this.btnSearchDatabase.Location = new System.Drawing.Point(468, 188);
            this.btnSearchDatabase.Name = "btnSearchDatabase";
            this.btnSearchDatabase.Size = new System.Drawing.Size(159, 29);
            this.btnSearchDatabase.TabIndex = 2;
            this.btnSearchDatabase.Text = "Search Database";
            this.btnSearchDatabase.UseVisualStyleBackColor = true;
            this.btnSearchDatabase.Click += new System.EventHandler(this.btnSearchDatabase_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(85, 340);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(85, 413);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(125, 27);
            this.txtAge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearchDatabase);
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
        private Button btnSearchDatabase;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label1;
        private Label label3;
    }
}