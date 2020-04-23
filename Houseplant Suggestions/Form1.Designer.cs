namespace Houseplant_Suggestions
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
            this.chkSouthFacing = new System.Windows.Forms.CheckBox();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.InkHousePlanatInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSouthFacing
            // 
            this.chkSouthFacing.AutoSize = true;
            this.chkSouthFacing.Location = new System.Drawing.Point(50, 47);
            this.chkSouthFacing.Name = "chkSouthFacing";
            this.chkSouthFacing.Size = new System.Drawing.Size(295, 21);
            this.chkSouthFacing.TabIndex = 0;
            this.chkSouthFacing.Text = "Do you have a south-facing window?";
            this.chkSouthFacing.UseVisualStyleBackColor = true;
            this.chkSouthFacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(74, 184);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(620, 56);
            this.trkTemp.TabIndex = 1;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.trkTemp_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "How warm is your home";
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.AutoSize = true;
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(71, 313);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(167, 17);
            this.lblSuggestion.TabIndex = 5;
            this.lblSuggestion.Text = "Plant suggestion here";
            this.lblSuggestion.Click += new System.EventHandler(this.lblSuggestion_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(727, 196);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(41, 17);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "50˚F\r\n";
            this.lblTemp.Click += new System.EventHandler(this.lblTemp_Click);
            // 
            // InkHousePlanatInfo
            // 
            this.InkHousePlanatInfo.AutoSize = true;
            this.InkHousePlanatInfo.Location = new System.Drawing.Point(629, 341);
            this.InkHousePlanatInfo.Name = "InkHousePlanatInfo";
            this.InkHousePlanatInfo.Size = new System.Drawing.Size(149, 17);
            this.InkHousePlanatInfo.TabIndex = 7;
            this.InkHousePlanatInfo.TabStop = true;
            this.InkHousePlanatInfo.Text = "houseplant411.com";
            this.InkHousePlanatInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InkHousePlanatInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 398);
            this.Controls.Add(this.InkHousePlanatInfo);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.chkSouthFacing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Houseplant Suggestions";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSouthFacing;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.LinkLabel InkHousePlanatInfo;
    }
}

