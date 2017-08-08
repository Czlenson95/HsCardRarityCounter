namespace HearthstoneCardRarityCounter
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
            this.btnRare = new System.Windows.Forms.Button();
            this.btnEpic = new System.Windows.Forms.Button();
            this.btnLegend = new System.Windows.Forms.Button();
            this.btnCommon = new System.Windows.Forms.Button();
            this.lblCommon = new System.Windows.Forms.Label();
            this.lblRare = new System.Windows.Forms.Label();
            this.lblEpic = new System.Windows.Forms.Label();
            this.lblLegend = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblPacksSumCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRare
            // 
            this.btnRare.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRare.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRare.Location = new System.Drawing.Point(13, 43);
            this.btnRare.Name = "btnRare";
            this.btnRare.Size = new System.Drawing.Size(75, 23);
            this.btnRare.TabIndex = 1;
            this.btnRare.Text = "Rare";
            this.btnRare.UseVisualStyleBackColor = false;
            this.btnRare.Click += new System.EventHandler(this.btnRare_Click);
            // 
            // btnEpic
            // 
            this.btnEpic.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEpic.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEpic.Location = new System.Drawing.Point(13, 73);
            this.btnEpic.Name = "btnEpic";
            this.btnEpic.Size = new System.Drawing.Size(75, 23);
            this.btnEpic.TabIndex = 2;
            this.btnEpic.Text = "Epic";
            this.btnEpic.UseVisualStyleBackColor = false;
            this.btnEpic.Click += new System.EventHandler(this.btnEpic_Click);
            // 
            // btnLegend
            // 
            this.btnLegend.BackColor = System.Drawing.Color.Gold;
            this.btnLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegend.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLegend.Location = new System.Drawing.Point(13, 103);
            this.btnLegend.Name = "btnLegend";
            this.btnLegend.Size = new System.Drawing.Size(75, 23);
            this.btnLegend.TabIndex = 3;
            this.btnLegend.Text = "Legendary";
            this.btnLegend.UseVisualStyleBackColor = false;
            this.btnLegend.Click += new System.EventHandler(this.btnLegend_Click);
            // 
            // btnCommon
            // 
            this.btnCommon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommon.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommon.Location = new System.Drawing.Point(13, 13);
            this.btnCommon.Name = "btnCommon";
            this.btnCommon.Size = new System.Drawing.Size(75, 23);
            this.btnCommon.TabIndex = 4;
            this.btnCommon.Text = "Common";
            this.btnCommon.UseVisualStyleBackColor = true;
            this.btnCommon.Click += new System.EventHandler(this.btnCommon_Click);
            // 
            // lblCommon
            // 
            this.lblCommon.AutoSize = true;
            this.lblCommon.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCommon.Location = new System.Drawing.Point(150, 14);
            this.lblCommon.Name = "lblCommon";
            this.lblCommon.Size = new System.Drawing.Size(84, 17);
            this.lblCommon.TabIndex = 5;
            this.lblCommon.Text = "Common: 0";
            // 
            // lblRare
            // 
            this.lblRare.AutoSize = true;
            this.lblRare.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRare.Location = new System.Drawing.Point(150, 44);
            this.lblRare.Name = "lblRare";
            this.lblRare.Size = new System.Drawing.Size(54, 17);
            this.lblRare.TabIndex = 6;
            this.lblRare.Text = "Rare: 0";
            // 
            // lblEpic
            // 
            this.lblEpic.AutoSize = true;
            this.lblEpic.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEpic.Location = new System.Drawing.Point(150, 74);
            this.lblEpic.Name = "lblEpic";
            this.lblEpic.Size = new System.Drawing.Size(50, 17);
            this.lblEpic.TabIndex = 7;
            this.lblEpic.Text = "Epic: 0";
            // 
            // lblLegend
            // 
            this.lblLegend.AutoSize = true;
            this.lblLegend.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegend.Location = new System.Drawing.Point(150, 104);
            this.lblLegend.Name = "lblLegend";
            this.lblLegend.Size = new System.Drawing.Size(91, 17);
            this.lblLegend.TabIndex = 8;
            this.lblLegend.Text = "Legendary: 0";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(106, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Bell MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(187, 183);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblPacksSumCount
            // 
            this.lblPacksSumCount.AutoSize = true;
            this.lblPacksSumCount.Font = new System.Drawing.Font("Bell MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacksSumCount.Location = new System.Drawing.Point(10, 144);
            this.lblPacksSumCount.Name = "lblPacksSumCount";
            this.lblPacksSumCount.Size = new System.Drawing.Size(125, 19);
            this.lblPacksSumCount.TabIndex = 11;
            this.lblPacksSumCount.Text = "Packs Summary: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(274, 218);
            this.Controls.Add(this.lblPacksSumCount);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblLegend);
            this.Controls.Add(this.lblEpic);
            this.Controls.Add(this.lblRare);
            this.Controls.Add(this.lblCommon);
            this.Controls.Add(this.btnCommon);
            this.Controls.Add(this.btnLegend);
            this.Controls.Add(this.btnEpic);
            this.Controls.Add(this.btnRare);
            this.Name = "Form1";
            this.Text = "CardCounter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRare;
        private System.Windows.Forms.Button btnEpic;
        private System.Windows.Forms.Button btnLegend;
        private System.Windows.Forms.Button btnCommon;
        private System.Windows.Forms.Label lblCommon;
        private System.Windows.Forms.Label lblRare;
        private System.Windows.Forms.Label lblEpic;
        private System.Windows.Forms.Label lblLegend;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblPacksSumCount;
    }
}

