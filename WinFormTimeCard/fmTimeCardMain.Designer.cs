
namespace WinFormTimeCard
{
    partial class fmTimeCardMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcurName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpMain = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.lstvUsers = new System.Windows.Forms.ListView();
            this.uName = new System.Windows.Forms.ColumnHeader();
            this.uAddress = new System.Windows.Forms.ColumnHeader();
            this.uEmail = new System.Windows.Forms.ColumnHeader();
            this.uIsAdmin = new System.Windows.Forms.ColumnHeader();
            this.tabTimeCard = new System.Windows.Forms.TabPage();
            this.grbTimeEntry = new System.Windows.Forms.GroupBox();
            this.pnlTimeCards = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCard = new System.Windows.Forms.Button();
            this.pnlOperte = new System.Windows.Forms.Panel();
            this.btnScikLv = new System.Windows.Forms.Button();
            this.btnNoSickLv = new System.Windows.Forms.Button();
            this.btnCloneLastWeek = new System.Windows.Forms.Button();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.pnlWeek = new System.Windows.Forms.Panel();
            this.lblWeekRange = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblGlobalHours = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabTimeCard.SuspendLayout();
            this.grbTimeEntry.SuspendLayout();
            this.pnlTimeCards.SuspendLayout();
            this.pnlOperte.SuspendLayout();
            this.pnlHead.SuspendLayout();
            this.pnlWeek.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteUsers);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddUser);
            this.splitContainer1.Panel1.Controls.Add(this.lblRole);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.lblcurName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tpMain);
            this.splitContainer1.Size = new System.Drawing.Size(1734, 1667);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteUsers.Location = new System.Drawing.Point(1416, 27);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(261, 66);
            this.btnDeleteUsers.TabIndex = 5;
            this.btnDeleteUsers.Text = "Delete checked ones";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Location = new System.Drawing.Point(1223, 27);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(150, 66);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add a user";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(842, 27);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(140, 54);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Role:";
            // 
            // lblcurName
            // 
            this.lblcurName.AutoSize = true;
            this.lblcurName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcurName.Location = new System.Drawing.Point(379, 27);
            this.lblcurName.Name = "lblcurName";
            this.lblcurName.Size = new System.Drawing.Size(92, 54);
            this.lblcurName.TabIndex = 1;
            this.lblcurName.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current User\'s Name:";
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tabUsers);
            this.tpMain.Controls.Add(this.tabTimeCard);
            this.tpMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpMain.Location = new System.Drawing.Point(0, 0);
            this.tpMain.Name = "tpMain";
            this.tpMain.Padding = new System.Drawing.Point(15, 5);
            this.tpMain.SelectedIndex = 0;
            this.tpMain.Size = new System.Drawing.Size(1734, 1544);
            this.tpMain.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.lstvUsers);
            this.tabUsers.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabUsers.Location = new System.Drawing.Point(8, 48);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1718, 1488);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.ToolTipText = "Admin/Staff";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // lstvUsers
            // 
            this.lstvUsers.CheckBoxes = true;
            this.lstvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uName,
            this.uAddress,
            this.uEmail,
            this.uIsAdmin});
            this.lstvUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstvUsers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvUsers.HideSelection = false;
            this.lstvUsers.Location = new System.Drawing.Point(3, 3);
            this.lstvUsers.Name = "lstvUsers";
            this.lstvUsers.Size = new System.Drawing.Size(1712, 1482);
            this.lstvUsers.TabIndex = 0;
            this.lstvUsers.UseCompatibleStateImageBehavior = false;
            this.lstvUsers.View = System.Windows.Forms.View.Details;
            // 
            // uName
            // 
            this.uName.Text = "      Name";
            this.uName.Width = 200;
            // 
            // uAddress
            // 
            this.uAddress.Text = "Address";
            this.uAddress.Width = 300;
            // 
            // uEmail
            // 
            this.uEmail.Text = "E-mail";
            this.uEmail.Width = 400;
            // 
            // uIsAdmin
            // 
            this.uIsAdmin.Text = "IsAdmin";
            this.uIsAdmin.Width = 160;
            // 
            // tabTimeCard
            // 
            this.tabTimeCard.Controls.Add(this.grbTimeEntry);
            this.tabTimeCard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabTimeCard.Location = new System.Drawing.Point(8, 48);
            this.tabTimeCard.Name = "tabTimeCard";
            this.tabTimeCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabTimeCard.Size = new System.Drawing.Size(1718, 1488);
            this.tabTimeCard.TabIndex = 1;
            this.tabTimeCard.Text = "TimeCard";
            this.tabTimeCard.ToolTipText = "TimeCard";
            this.tabTimeCard.UseVisualStyleBackColor = true;
            // 
            // grbTimeEntry
            // 
            this.grbTimeEntry.Controls.Add(this.pnlTimeCards);
            this.grbTimeEntry.Controls.Add(this.pnlOperte);
            this.grbTimeEntry.Controls.Add(this.pnlHead);
            this.grbTimeEntry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grbTimeEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTimeEntry.Location = new System.Drawing.Point(3, 3);
            this.grbTimeEntry.Name = "grbTimeEntry";
            this.grbTimeEntry.Size = new System.Drawing.Size(1712, 1482);
            this.grbTimeEntry.TabIndex = 0;
            this.grbTimeEntry.TabStop = false;
            this.grbTimeEntry.Text = "TimeEntry";
            // 
            // pnlTimeCards
            // 
            this.pnlTimeCards.AutoScroll = true;
            this.pnlTimeCards.Controls.Add(this.btnAddCard);
            this.pnlTimeCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimeCards.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlTimeCards.Location = new System.Drawing.Point(3, 268);
            this.pnlTimeCards.Name = "pnlTimeCards";
            this.pnlTimeCards.Size = new System.Drawing.Size(1706, 1211);
            this.pnlTimeCards.TabIndex = 10;
            this.pnlTimeCards.WrapContents = false;
            this.pnlTimeCards.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddCard
            // 
            this.btnAddCard.BackgroundImage = global::WinFormTimeCard.Properties.Resources.añadir_100px;
            this.btnAddCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddCard.Location = new System.Drawing.Point(3, 3);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(1700, 174);
            this.btnAddCard.TabIndex = 0;
            this.btnAddCard.Text = "Add Project/Assignment";
            this.btnAddCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // pnlOperte
            // 
            this.pnlOperte.Controls.Add(this.btnScikLv);
            this.pnlOperte.Controls.Add(this.btnNoSickLv);
            this.pnlOperte.Controls.Add(this.btnCloneLastWeek);
            this.pnlOperte.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperte.Location = new System.Drawing.Point(3, 174);
            this.pnlOperte.Name = "pnlOperte";
            this.pnlOperte.Size = new System.Drawing.Size(1706, 94);
            this.pnlOperte.TabIndex = 9;
            // 
            // btnScikLv
            // 
            this.btnScikLv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScikLv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScikLv.Location = new System.Drawing.Point(934, 14);
            this.btnScikLv.Name = "btnScikLv";
            this.btnScikLv.Size = new System.Drawing.Size(205, 66);
            this.btnScikLv.TabIndex = 11;
            this.btnScikLv.Text = "Add Sick Leave";
            this.btnScikLv.UseVisualStyleBackColor = true;
            this.btnScikLv.Click += new System.EventHandler(this.btnScikLv_Click);
            // 
            // btnNoSickLv
            // 
            this.btnNoSickLv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoSickLv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNoSickLv.Location = new System.Drawing.Point(574, 14);
            this.btnNoSickLv.Name = "btnNoSickLv";
            this.btnNoSickLv.Size = new System.Drawing.Size(261, 66);
            this.btnNoSickLv.TabIndex = 10;
            this.btnNoSickLv.Text = "Add Non-Sick Leave";
            this.btnNoSickLv.UseVisualStyleBackColor = true;
            this.btnNoSickLv.Click += new System.EventHandler(this.btnNoSickLv_Click);
            // 
            // btnCloneLastWeek
            // 
            this.btnCloneLastWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloneLastWeek.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCloneLastWeek.Location = new System.Drawing.Point(132, 14);
            this.btnCloneLastWeek.Name = "btnCloneLastWeek";
            this.btnCloneLastWeek.Size = new System.Drawing.Size(343, 66);
            this.btnCloneLastWeek.TabIndex = 9;
            this.btnCloneLastWeek.Text = "Copy from Previous Week";
            this.btnCloneLastWeek.UseVisualStyleBackColor = false;
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlHead.Controls.Add(this.btnNext);
            this.pnlHead.Controls.Add(this.pnlWeek);
            this.pnlHead.Controls.Add(this.btnLast);
            this.pnlHead.Controls.Add(this.lblGlobalHours);
            this.pnlHead.Controls.Add(this.btnSubmit);
            this.pnlHead.Controls.Add(this.btnSave);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlHead.Location = new System.Drawing.Point(3, 50);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1706, 124);
            this.pnlHead.TabIndex = 0;
            this.pnlHead.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlHead_MouseClick);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(550, 42);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(59, 71);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlWeek
            // 
            this.pnlWeek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWeek.Controls.Add(this.lblWeekRange);
            this.pnlWeek.Controls.Add(this.btnShow);
            this.pnlWeek.Location = new System.Drawing.Point(120, 36);
            this.pnlWeek.Name = "pnlWeek";
            this.pnlWeek.Size = new System.Drawing.Size(430, 80);
            this.pnlWeek.TabIndex = 10;
            // 
            // lblWeekRange
            // 
            this.lblWeekRange.AutoSize = true;
            this.lblWeekRange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWeekRange.Location = new System.Drawing.Point(19, 22);
            this.lblWeekRange.Name = "lblWeekRange";
            this.lblWeekRange.Size = new System.Drawing.Size(300, 37);
            this.lblWeekRange.TabIndex = 2;
            this.lblWeekRange.Text = "7/07/2021-7/14/2021";
            this.lblWeekRange.Click += new System.EventHandler(this.txtWeekShow_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BackgroundImage = global::WinFormTimeCard.Properties.Resources.añadir_100px;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Location = new System.Drawing.Point(360, 10);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(60, 60);
            this.btnShow.TabIndex = 11;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.txtWeekShow_Click);
            // 
            // btnLast
            // 
            this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLast.Location = new System.Drawing.Point(60, 43);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(59, 71);
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = "<";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblGlobalHours
            // 
            this.lblGlobalHours.AutoSize = true;
            this.lblGlobalHours.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGlobalHours.Location = new System.Drawing.Point(673, 53);
            this.lblGlobalHours.Name = "lblGlobalHours";
            this.lblGlobalHours.Size = new System.Drawing.Size(212, 47);
            this.lblGlobalHours.TabIndex = 7;
            this.lblGlobalHours.Text = "Total   0 hrs";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Location = new System.Drawing.Point(1470, 36);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 66);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(1209, 36);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 66);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // fmTimeCardMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 1667);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fmTimeCardMain";
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.fmTimeCardMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabTimeCard.ResumeLayout(false);
            this.grbTimeEntry.ResumeLayout(false);
            this.pnlTimeCards.ResumeLayout(false);
            this.pnlOperte.ResumeLayout(false);
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            this.pnlWeek.ResumeLayout(false);
            this.pnlWeek.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcurName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tpMain;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabTimeCard;
        private System.Windows.Forms.ListView lstvUsers;
        private System.Windows.Forms.ColumnHeader uName;
        private System.Windows.Forms.ColumnHeader uAddress;
        private System.Windows.Forms.ColumnHeader uEmail;
        private System.Windows.Forms.ColumnHeader uIsAdmin;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUsers;
        private System.Windows.Forms.GroupBox grbTimeEntry;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblGlobalHours;
        private System.Windows.Forms.MonthCalendar mthCWeek;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel pnlWeek;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblWeekRange;
        private System.Windows.Forms.Panel pnlOperte;
        private System.Windows.Forms.Button btnScikLv;
        private System.Windows.Forms.Button btnNoSickLv;
        private System.Windows.Forms.Button btnCloneLastWeek;
        private System.Windows.Forms.FlowLayoutPanel pnlTimeCards;
        private System.Windows.Forms.Button btnAddCard;
    }
}