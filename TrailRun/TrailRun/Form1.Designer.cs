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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAccept1 = new System.Windows.Forms.Button();
            this.lblTimesClicked = new System.Windows.Forms.Label();
            this.btnSearchDatabase = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDbAge = new System.Windows.Forms.TextBox();
            this.txtDbJob = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtAltName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(435, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAccept1
            // 
            this.btnAccept1.Location = new System.Drawing.Point(75, 63);
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
            this.lblTimesClicked.Location = new System.Drawing.Point(30, 9);
            this.lblTimesClicked.Name = "lblTimesClicked";
            this.lblTimesClicked.Size = new System.Drawing.Size(180, 37);
            this.lblTimesClicked.TabIndex = 1;
            this.lblTimesClicked.Text = "Times clicked:";
            // 
            // btnSearchDatabase
            // 
            this.btnSearchDatabase.Location = new System.Drawing.Point(757, 17);
            this.btnSearchDatabase.Name = "btnSearchDatabase";
            this.btnSearchDatabase.Size = new System.Drawing.Size(159, 29);
            this.btnSearchDatabase.TabIndex = 2;
            this.btnSearchDatabase.Text = "Add to database";
            this.btnSearchDatabase.UseVisualStyleBackColor = true;
            this.btnSearchDatabase.Click += new System.EventHandler(this.btnSearchDatabase_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(602, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(791, 75);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(125, 27);
            this.txtAge.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(825, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(166, 221);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(125, 27);
            this.txtDbName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Database Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Database Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Database Job";
            // 
            // txtDbAge
            // 
            this.txtDbAge.Location = new System.Drawing.Point(166, 263);
            this.txtDbAge.Name = "txtDbAge";
            this.txtDbAge.Size = new System.Drawing.Size(125, 27);
            this.txtDbAge.TabIndex = 12;
            // 
            // txtDbJob
            // 
            this.txtDbJob.Location = new System.Drawing.Point(166, 306);
            this.txtDbJob.Name = "txtDbJob";
            this.txtDbJob.Size = new System.Drawing.Size(125, 27);
            this.txtDbJob.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(21, 366);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(121, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(221, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(321, 366);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(94, 29);
            this.btnDisplay.TabIndex = 17;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // txtAltName
            // 
            this.txtAltName.Location = new System.Drawing.Point(30, 451);
            this.txtAltName.Name = "txtAltName";
            this.txtAltName.Size = new System.Drawing.Size(125, 27);
            this.txtAltName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "(Replacement name here)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 574);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAltName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtDbJob);
            this.Controls.Add(this.txtDbAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearchDatabase);
            this.Controls.Add(this.lblTimesClicked);
            this.Controls.Add(this.btnAccept1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnAccept1;
        private Label lblTimesClicked;
        private Button btnSearchDatabase;
        private TextBox txtName;
        private TextBox txtAge;
        private Label label1;
        private Label label3;
        private TextBox txtDbName;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtDbAge;
        private TextBox txtDbJob;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnDisplay;
        private TextBox txtAltName;
        private Label label6;
    }
}