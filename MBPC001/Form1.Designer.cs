namespace MBPC001
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
            this.cb_ListMembers = new System.Windows.Forms.ComboBox();
            this.b_GetLotForMember = new System.Windows.Forms.Button();
            this.lb_LotsForMember = new System.Windows.Forms.ListBox();
            this.l_members = new System.Windows.Forms.Label();
            this.l_lotsOfMember = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsl_DB = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_ListMembers
            // 
            this.cb_ListMembers.FormattingEnabled = true;
            this.cb_ListMembers.Location = new System.Drawing.Point(27, 79);
            this.cb_ListMembers.Name = "cb_ListMembers";
            this.cb_ListMembers.Size = new System.Drawing.Size(244, 21);
            this.cb_ListMembers.TabIndex = 0;
            // 
            // b_GetLotForMember
            // 
            this.b_GetLotForMember.Location = new System.Drawing.Point(312, 77);
            this.b_GetLotForMember.Name = "b_GetLotForMember";
            this.b_GetLotForMember.Size = new System.Drawing.Size(113, 23);
            this.b_GetLotForMember.TabIndex = 1;
            this.b_GetLotForMember.Text = "Get Lot";
            this.b_GetLotForMember.UseVisualStyleBackColor = true;
            this.b_GetLotForMember.Click += new System.EventHandler(this.b_GetLotForMember_Click);
            // 
            // lb_LotsForMember
            // 
            this.lb_LotsForMember.FormattingEnabled = true;
            this.lb_LotsForMember.Location = new System.Drawing.Point(468, 80);
            this.lb_LotsForMember.Name = "lb_LotsForMember";
            this.lb_LotsForMember.Size = new System.Drawing.Size(307, 277);
            this.lb_LotsForMember.TabIndex = 2;
            // 
            // l_members
            // 
            this.l_members.AutoSize = true;
            this.l_members.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_members.Location = new System.Drawing.Point(28, 53);
            this.l_members.Name = "l_members";
            this.l_members.Size = new System.Drawing.Size(50, 13);
            this.l_members.TabIndex = 3;
            this.l_members.Text = "Members";
            // 
            // l_lotsOfMember
            // 
            this.l_lotsOfMember.AutoSize = true;
            this.l_lotsOfMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l_lotsOfMember.Location = new System.Drawing.Point(468, 53);
            this.l_lotsOfMember.Name = "l_lotsOfMember";
            this.l_lotsOfMember.Size = new System.Drawing.Size(124, 13);
            this.l_lotsOfMember.TabIndex = 4;
            this.l_lotsOfMember.Text = "Lots of Selected member";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_DB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsl_DB
            // 
            this.tsl_DB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsl_DB.Name = "tsl_DB";
            this.tsl_DB.Size = new System.Drawing.Size(28, 17);
            this.tsl_DB.Text = "DB: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.l_lotsOfMember);
            this.Controls.Add(this.l_members);
            this.Controls.Add(this.lb_LotsForMember);
            this.Controls.Add(this.b_GetLotForMember);
            this.Controls.Add(this.cb_ListMembers);
            this.Name = "Form1";
            this.Text = "Modern British Philatelic Circle (MBPC)";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ListMembers;
        private System.Windows.Forms.Button b_GetLotForMember;
        private System.Windows.Forms.ListBox lb_LotsForMember;
        private System.Windows.Forms.Label l_members;
        private System.Windows.Forms.Label l_lotsOfMember;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_DB;
    }
}

