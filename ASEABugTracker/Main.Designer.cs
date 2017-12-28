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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHyphen1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxInput
            // 
            this.listBoxInput.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxInput.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.Location = new System.Drawing.Point(764, 24);
            this.listBoxInput.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.ScrollAlwaysVisible = true;
            this.listBoxInput.Size = new System.Drawing.Size(180, 205);
            this.listBoxInput.TabIndex = 1;
            // 
            // txtBugId
            // 
            this.txtBugId.BackColor = System.Drawing.SystemColors.Control;
            this.txtBugId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBugId.Location = new System.Drawing.Point(69, 32);
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
            this.txtUsername.Location = new System.Drawing.Point(822, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(110, 13);
            this.txtUsername.TabIndex = 3;
            // 
            // txtApplication
            // 
            this.txtApplication.BackColor = System.Drawing.SystemColors.Control;
            this.txtApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApplication.Location = new System.Drawing.Point(69, 57);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.ReadOnly = true;
            this.txtApplication.Size = new System.Drawing.Size(94, 13);
            this.txtApplication.TabIndex = 4;
            // 
            // labelBugID
            // 
            this.labelBugID.AutoSize = true;
            this.labelBugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBugID.Location = new System.Drawing.Point(30, 33);
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
            this.labelUsername.Location = new System.Drawing.Point(762, 5);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(59, 12);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Logged in as:";
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApplication.Location = new System.Drawing.Point(12, 58);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(51, 12);
            this.labelApplication.TabIndex = 7;
            this.labelApplication.Text = "Application";
            // 
            // txtSymptom
            // 
            this.txtSymptom.BackColor = System.Drawing.SystemColors.Control;
            this.txtSymptom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSymptom.Location = new System.Drawing.Point(69, 81);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.ReadOnly = true;
            this.txtSymptom.Size = new System.Drawing.Size(94, 13);
            this.txtSymptom.TabIndex = 10;
            // 
            // txtCause
            // 
            this.txtCause.BackColor = System.Drawing.SystemColors.Control;
            this.txtCause.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCause.Location = new System.Drawing.Point(69, 107);
            this.txtCause.Name = "txtCause";
            this.txtCause.ReadOnly = true;
            this.txtCause.Size = new System.Drawing.Size(94, 13);
            this.txtCause.TabIndex = 11;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.SystemColors.Control;
            this.txtClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClass.Location = new System.Drawing.Point(69, 132);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(94, 13);
            this.txtClass.TabIndex = 12;
            // 
            // txtMethod
            // 
            this.txtMethod.BackColor = System.Drawing.SystemColors.Control;
            this.txtMethod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMethod.Location = new System.Drawing.Point(69, 158);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.ReadOnly = true;
            this.txtMethod.Size = new System.Drawing.Size(94, 13);
            this.txtMethod.TabIndex = 13;
            // 
            // txtLineNoStart
            // 
            this.txtLineNoStart.BackColor = System.Drawing.SystemColors.Control;
            this.txtLineNoStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineNoStart.Location = new System.Drawing.Point(69, 186);
            this.txtLineNoStart.Name = "txtLineNoStart";
            this.txtLineNoStart.ReadOnly = true;
            this.txtLineNoStart.Size = new System.Drawing.Size(40, 13);
            this.txtLineNoStart.TabIndex = 14;
            this.txtLineNoStart.Text = "1";
            this.txtLineNoStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLineNoEnd
            // 
            this.txtLineNoEnd.BackColor = System.Drawing.SystemColors.Control;
            this.txtLineNoEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLineNoEnd.Location = new System.Drawing.Point(123, 186);
            this.txtLineNoEnd.Name = "txtLineNoEnd";
            this.txtLineNoEnd.ReadOnly = true;
            this.txtLineNoEnd.Size = new System.Drawing.Size(40, 13);
            this.txtLineNoEnd.TabIndex = 15;
            this.txtLineNoEnd.Text = "2";
            this.txtLineNoEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(34, 133);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(29, 12);
            this.labelClass.TabIndex = 16;
            this.labelClass.Text = "Class";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMethod.Location = new System.Drawing.Point(26, 159);
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
            this.labelLineNoStart.Location = new System.Drawing.Point(77, 206);
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
            this.labelLineNoEnd.Location = new System.Drawing.Point(133, 206);
            this.labelLineNoEnd.Name = "labelLineNoEnd";
            this.labelLineNoEnd.Size = new System.Drawing.Size(21, 12);
            this.labelLineNoEnd.TabIndex = 19;
            this.labelLineNoEnd.Text = "End";
            // 
            // labelSymptom
            // 
            this.labelSymptom.AutoSize = true;
            this.labelSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSymptom.Location = new System.Drawing.Point(18, 82);
            this.labelSymptom.Name = "labelSymptom";
            this.labelSymptom.Size = new System.Drawing.Size(45, 12);
            this.labelSymptom.TabIndex = 20;
            this.labelSymptom.Text = "Symptom";
            // 
            // labelCause
            // 
            this.labelCause.AutoSize = true;
            this.labelCause.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCause.Location = new System.Drawing.Point(31, 108);
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
            this.labelLineTitle.Location = new System.Drawing.Point(6, 187);
            this.labelLineTitle.Name = "labelLineTitle";
            this.labelLineTitle.Size = new System.Drawing.Size(57, 12);
            this.labelLineTitle.TabIndex = 22;
            this.labelLineTitle.Text = "Line Number";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(0, 229);
            this.txtCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(944, 372);
            this.txtCode.TabIndex = 24;
            this.txtCode.Load += new System.EventHandler(this.txtCode_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // labelHyphen1
            // 
            this.labelHyphen1.AutoSize = true;
            this.labelHyphen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHyphen1.Location = new System.Drawing.Point(111, 183);
            this.labelHyphen1.Name = "labelHyphen1";
            this.labelHyphen1.Size = new System.Drawing.Size(11, 15);
            this.labelHyphen1.TabIndex = 26;
            this.labelHyphen1.Text = "-";
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "";
            this.btnAdd.AccessibleName = "";
            this.btnAdd.Location = new System.Drawing.Point(684, 199);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Submit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.labelHyphen1);
            this.Controls.Add(this.labelLineTitle);
            this.Controls.Add(this.labelCause);
            this.Controls.Add(this.labelSymptom);
            this.Controls.Add(this.labelLineNoEnd);
            this.Controls.Add(this.labelLineNoStart);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.txtLineNoEnd);
            this.Controls.Add(this.txtLineNoStart);
            this.Controls.Add(this.txtMethod);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtCause);
            this.Controls.Add(this.txtSymptom);
            this.Controls.Add(this.labelApplication);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelBugID);
            this.Controls.Add(this.txtApplication);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtBugId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtCode);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(960, 640);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnAdd;
    }
}

