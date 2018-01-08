namespace ASEABugTracker
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.labelBugID = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelApplication = new System.Windows.Forms.Label();
            this.txtSymptom = new System.Windows.Forms.TextBox();
            this.txtCause = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtLineNoStart = new System.Windows.Forms.TextBox();
            this.txtLineNoEnd = new System.Windows.Forms.TextBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelLineNoStart = new System.Windows.Forms.Label();
            this.labelLineNoEnd = new System.Windows.Forms.Label();
            this.labelSymptom = new System.Windows.Forms.Label();
            this.labelCause = new System.Windows.Forms.Label();
            this.labelLineTitle = new System.Windows.Forms.Label();
            this.txtCode = new ICSharpCode.TextEditor.TextEditorControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHyphen1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFix = new System.Windows.Forms.TextBox();
            this.buttonFix = new System.Windows.Forms.Button();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTipFixed = new System.Windows.Forms.ToolTip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitAuditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInput
            // 
            this.listBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInput.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.Location = new System.Drawing.Point(-1, 22);
            this.listBoxInput.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxInput.MaximumSize = new System.Drawing.Size(300, 2);
            this.listBoxInput.MinimumSize = new System.Drawing.Size(300, 210);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.ScrollAlwaysVisible = true;
            this.listBoxInput.Size = new System.Drawing.Size(300, 210);
            this.listBoxInput.TabIndex = 1;
            this.listBoxInput.Tag = "";
            this.listBoxInput.SelectedIndexChanged += new System.EventHandler(this.ListBoxInput_SelectedIndexChanged);
            // 
            // txtBugId
            // 
            this.txtBugId.BackColor = System.Drawing.SystemColors.Control;
            this.txtBugId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBugId.Location = new System.Drawing.Point(71, 10);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.ReadOnly = true;
            this.txtBugId.Size = new System.Drawing.Size(40, 13);
            this.txtBugId.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(81, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(110, 13);
            this.txtUsername.TabIndex = 3;
            // 
            // txtApplication
            // 
            this.txtApplication.BackColor = System.Drawing.SystemColors.Control;
            this.txtApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApplication.Location = new System.Drawing.Point(71, 35);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.ReadOnly = true;
            this.txtApplication.Size = new System.Drawing.Size(524, 13);
            this.txtApplication.TabIndex = 4;
            // 
            // labelBugID
            // 
            this.labelBugID.AutoSize = true;
            this.labelBugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBugID.Location = new System.Drawing.Point(32, 11);
            this.labelBugID.Name = "labelBugID";
            this.labelBugID.Size = new System.Drawing.Size(33, 12);
            this.labelBugID.TabIndex = 5;
            this.labelBugID.Text = "Bug ID";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(17, 6);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(59, 12);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Logged in as:";
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplication.Location = new System.Drawing.Point(14, 36);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(51, 12);
            this.labelApplication.TabIndex = 7;
            this.labelApplication.Text = "Application";
            // 
            // txtSymptom
            // 
            this.txtSymptom.BackColor = System.Drawing.SystemColors.Control;
            this.txtSymptom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymptom.Location = new System.Drawing.Point(71, 83);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.ReadOnly = true;
            this.txtSymptom.Size = new System.Drawing.Size(524, 13);
            this.txtSymptom.TabIndex = 10;
            // 
            // txtCause
            // 
            this.txtCause.BackColor = System.Drawing.SystemColors.Control;
            this.txtCause.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCause.Location = new System.Drawing.Point(71, 109);
            this.txtCause.Name = "txtCause";
            this.txtCause.ReadOnly = true;
            this.txtCause.Size = new System.Drawing.Size(524, 13);
            this.txtCause.TabIndex = 11;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.Control;
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClass.Location = new System.Drawing.Point(71, 134);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(524, 13);
            this.txtClass.TabIndex = 12;
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.Control;
            this.txtMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMethod.Location = new System.Drawing.Point(71, 160);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(524, 13);
            this.txtMethod.TabIndex = 13;
            // 
            // txtLineNoStart
            // 
            this.txtLineNoStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtLineNoStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineNoStart.Location = new System.Drawing.Point(71, 188);
            this.txtLineNoStart.Name = "txtLineNoStart";
            this.txtLineNoStart.ReadOnly = true;
            this.txtLineNoStart.Size = new System.Drawing.Size(40, 13);
            this.txtLineNoStart.TabIndex = 14;
            this.txtLineNoStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineNoEnd
            // 
            this.txtLineNoEnd.BackColor = System.Drawing.SystemColors.Control;
            this.txtLineNoEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineNoEnd.Location = new System.Drawing.Point(125, 188);
            this.txtLineNoEnd.Name = "txtLineNoEnd";
            this.txtLineNoEnd.ReadOnly = true;
            this.txtLineNoEnd.Size = new System.Drawing.Size(40, 13);
            this.txtLineNoEnd.TabIndex = 15;
            this.txtLineNoEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(36, 135);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(29, 12);
            this.labelClass.TabIndex = 16;
            this.labelClass.Text = "Class";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethod.Location = new System.Drawing.Point(28, 161);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(37, 12);
            this.labelMethod.TabIndex = 17;
            this.labelMethod.Text = "Method";
            // 
            // labelLineNoStart
            // 
            this.labelLineNoStart.AutoSize = true;
            this.labelLineNoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineNoStart.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelLineNoStart.Location = new System.Drawing.Point(79, 208);
            this.labelLineNoStart.Name = "labelLineNoStart";
            this.labelLineNoStart.Size = new System.Drawing.Size(25, 12);
            this.labelLineNoStart.TabIndex = 18;
            this.labelLineNoStart.Text = "Start";
            // 
            // labelLineNoEnd
            // 
            this.labelLineNoEnd.AutoSize = true;
            this.labelLineNoEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineNoEnd.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelLineNoEnd.Location = new System.Drawing.Point(135, 208);
            this.labelLineNoEnd.Name = "labelLineNoEnd";
            this.labelLineNoEnd.Size = new System.Drawing.Size(21, 12);
            this.labelLineNoEnd.TabIndex = 19;
            this.labelLineNoEnd.Text = "End";
            // 
            // labelSymptom
            // 
            this.labelSymptom.AutoSize = true;
            this.labelSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymptom.Location = new System.Drawing.Point(20, 84);
            this.labelSymptom.Name = "labelSymptom";
            this.labelSymptom.Size = new System.Drawing.Size(45, 12);
            this.labelSymptom.TabIndex = 20;
            this.labelSymptom.Text = "Symptom";
            // 
            // labelCause
            // 
            this.labelCause.AutoSize = true;
            this.labelCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCause.Location = new System.Drawing.Point(33, 110);
            this.labelCause.Name = "labelCause";
            this.labelCause.Size = new System.Drawing.Size(32, 12);
            this.labelCause.TabIndex = 21;
            this.labelCause.Text = "Cause";
            // 
            // labelLineTitle
            // 
            this.labelLineTitle.AutoSize = true;
            this.labelLineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineTitle.ForeColor = System.Drawing.Color.Black;
            this.labelLineTitle.Location = new System.Drawing.Point(8, 189);
            this.labelLineTitle.Name = "labelLineTitle";
            this.labelLineTitle.Size = new System.Drawing.Size(57, 12);
            this.labelLineTitle.TabIndex = 22;
            this.labelLineTitle.Text = "Line Number";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(0, 257);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.MinimumSize = new System.Drawing.Size(100, 300);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(920, 471);
            this.txtCode.TabIndex = 24;
            this.txtCode.Load += new System.EventHandler(this.TxtCode_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.submitAuditToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(180, 6);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // labelHyphen1
            // 
            this.labelHyphen1.AutoSize = true;
            this.labelHyphen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHyphen1.Location = new System.Drawing.Point(113, 185);
            this.labelHyphen1.Name = "labelHyphen1";
            this.labelHyphen1.Size = new System.Drawing.Size(11, 15);
            this.labelHyphen1.TabIndex = 26;
            this.labelHyphen1.Text = "-";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.labelFix);
            this.panel1.Controls.Add(this.buttonFix);
            this.panel1.Controls.Add(this.txtLanguage);
            this.panel1.Controls.Add(this.labelLanguage);
            this.panel1.Controls.Add(this.labelHyphen1);
            this.panel1.Controls.Add(this.txtApplication);
            this.panel1.Controls.Add(this.labelLineTitle);
            this.panel1.Controls.Add(this.txtBugId);
            this.panel1.Controls.Add(this.labelCause);
            this.panel1.Controls.Add(this.labelBugID);
            this.panel1.Controls.Add(this.labelSymptom);
            this.panel1.Controls.Add(this.labelApplication);
            this.panel1.Controls.Add(this.labelLineNoEnd);
            this.panel1.Controls.Add(this.txtSymptom);
            this.panel1.Controls.Add(this.labelLineNoStart);
            this.panel1.Controls.Add(this.txtCause);
            this.panel1.Controls.Add(this.labelMethod);
            this.panel1.Controls.Add(this.txtClass);
            this.panel1.Controls.Add(this.labelClass);
            this.panel1.Controls.Add(this.txtMethod);
            this.panel1.Controls.Add(this.txtLineNoEnd);
            this.panel1.Controls.Add(this.txtLineNoStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MaximumSize = new System.Drawing.Size(1000, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(205, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 233);
            this.panel1.TabIndex = 27;
            // 
            // labelFix
            // 
            this.labelFix.BackColor = System.Drawing.SystemColors.Control;
            this.labelFix.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFix.Location = new System.Drawing.Point(537, 181);
            this.labelFix.Name = "labelFix";
            this.labelFix.ReadOnly = true;
            this.labelFix.Size = new System.Drawing.Size(73, 20);
            this.labelFix.TabIndex = 31;
            this.labelFix.Text = "Unfixed";
            this.labelFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTipFixed.SetToolTip(this.labelFix, "Only source code creator may change \'Fixed\' status of bug.");
            // 
            // buttonFix
            // 
            this.buttonFix.Location = new System.Drawing.Point(536, 203);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(75, 23);
            this.buttonFix.TabIndex = 30;
            this.buttonFix.Text = "Change";
            this.toolTipFixed.SetToolTip(this.buttonFix, "Only source code creator may change \'Fixed\' status of bug.");
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.ButtonFix_Click);
            // 
            // txtLanguage
            // 
            this.txtLanguage.BackColor = System.Drawing.SystemColors.Control;
            this.txtLanguage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLanguage.Location = new System.Drawing.Point(71, 59);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(524, 13);
            this.txtLanguage.TabIndex = 28;
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLanguage.ForeColor = System.Drawing.Color.Black;
            this.labelLanguage.Location = new System.Drawing.Point(20, 60);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(45, 12);
            this.labelLanguage.TabIndex = 27;
            this.labelLanguage.Text = "Language";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.listBoxInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(620, 24);
            this.panel2.MaximumSize = new System.Drawing.Size(300, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 233);
            this.panel2.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Audit List:";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.labelUsername);
            this.panel3.Controls.Add(this.txtUsername);
            this.panel3.Location = new System.Drawing.Point(723, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 24);
            this.panel3.TabIndex = 29;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::ASEABugTracker.Properties.Resources.File_icon_new;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.newToolStripMenuItem.Text = "New (Bug)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::ASEABugTracker.Properties.Resources.File_Download_icon;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.openToolStripMenuItem.Text = "Open (Bug)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // submitAuditToolStripMenuItem
            // 
            this.submitAuditToolStripMenuItem.Image = global::ASEABugTracker.Properties.Resources.Add_File_icon;
            this.submitAuditToolStripMenuItem.Name = "submitAuditToolStripMenuItem";
            this.submitAuditToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.submitAuditToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.submitAuditToolStripMenuItem.Text = "Submit (Edit)";
            this.submitAuditToolStripMenuItem.Click += new System.EventHandler(this.SubmitAuditToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::ASEABugTracker.Properties.Resources.User_Interface_Exit_icon;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::ASEABugTracker.Properties.Resources.Close_Window_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::ASEABugTracker.Properties.Resources.Very_Basic_Help_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(920, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(936, 767);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.Label labelBugID;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.TextBox txtSymptom;
        private System.Windows.Forms.TextBox txtCause;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtLineNoStart;
        private System.Windows.Forms.TextBox txtLineNoEnd;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelLineNoStart;
        private System.Windows.Forms.Label labelLineNoEnd;
        private System.Windows.Forms.Label labelSymptom;
        private System.Windows.Forms.Label labelCause;
        private System.Windows.Forms.Label labelLineTitle;
        private System.Windows.Forms.TextBox txtBugId;
        private ICSharpCode.TextEditor.TextEditorControl txtCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label labelHyphen1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem submitAuditToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.TextBox labelFix;
        private System.Windows.Forms.ToolTip toolTipFixed;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

