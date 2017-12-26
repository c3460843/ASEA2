namespace ASEABugTracker
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxInput = new System.Windows.Forms.ListBox();
            this.txtBugId = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.labelBugID = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelApplication = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleDescription = "";
            this.btnAdd.AccessibleName = "";
            this.btnAdd.Location = new System.Drawing.Point(77, 549);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxInput
            // 
            this.listBoxInput.FormattingEnabled = true;
            this.listBoxInput.Location = new System.Drawing.Point(819, 25);
            this.listBoxInput.Name = "listBoxInput";
            this.listBoxInput.Size = new System.Drawing.Size(125, 524);
            this.listBoxInput.TabIndex = 1;
            // 
            // txtBugId
            // 
            this.txtBugId.Location = new System.Drawing.Point(91, 50);
            this.txtBugId.Name = "txtBugId";
            this.txtBugId.ReadOnly = true;
            this.txtBugId.Size = new System.Drawing.Size(138, 20);
            this.txtBugId.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(91, 91);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(138, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // txtApplication
            // 
            this.txtApplication.Location = new System.Drawing.Point(91, 132);
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.Size = new System.Drawing.Size(138, 20);
            this.txtApplication.TabIndex = 4;
            // 
            // labelBugID
            // 
            this.labelBugID.AutoSize = true;
            this.labelBugID.Location = new System.Drawing.Point(45, 53);
            this.labelBugID.Name = "labelBugID";
            this.labelBugID.Size = new System.Drawing.Size(40, 13);
            this.labelBugID.TabIndex = 5;
            this.labelBugID.Text = "Bug ID";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(47, 94);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(38, 13);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Author";
            // 
            // labelApplication
            // 
            this.labelApplication.AutoSize = true;
            this.labelApplication.Location = new System.Drawing.Point(26, 132);
            this.labelApplication.Name = "labelApplication";
            this.labelApplication.Size = new System.Drawing.Size(59, 13);
            this.labelApplication.TabIndex = 7;
            this.labelApplication.Text = "Application";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelCode.Location = new System.Drawing.Point(22, 198);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 8;
            this.labelCode.Text = "Code";
            // 
            // txtSymptom
            // 
            this.txtSymptom.Location = new System.Drawing.Point(321, 91);
            this.txtSymptom.Name = "txtSymptom";
            this.txtSymptom.Size = new System.Drawing.Size(180, 20);
            this.txtSymptom.TabIndex = 10;
            // 
            // txtCause
            // 
            this.txtCause.Location = new System.Drawing.Point(616, 91);
            this.txtCause.Name = "txtCause";
            this.txtCause.Size = new System.Drawing.Size(180, 20);
            this.txtCause.TabIndex = 11;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(303, 132);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(87, 20);
            this.txtClass.TabIndex = 12;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(471, 132);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(87, 20);
            this.txtMethod.TabIndex = 13;
            // 
            // txtLineNoStart
            // 
            this.txtLineNoStart.Location = new System.Drawing.Point(694, 132);
            this.txtLineNoStart.Name = "txtLineNoStart";
            this.txtLineNoStart.Size = new System.Drawing.Size(32, 20);
            this.txtLineNoStart.TabIndex = 14;
            // 
            // txtLineNoEnd
            // 
            this.txtLineNoEnd.Location = new System.Drawing.Point(764, 132);
            this.txtLineNoEnd.Name = "txtLineNoEnd";
            this.txtLineNoEnd.Size = new System.Drawing.Size(32, 20);
            this.txtLineNoEnd.TabIndex = 15;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(265, 135);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(32, 13);
            this.labelClass.TabIndex = 16;
            this.labelClass.Text = "Class";
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(422, 135);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(43, 13);
            this.labelMethod.TabIndex = 17;
            this.labelMethod.Text = "Method";
            // 
            // labelLineNoStart
            // 
            this.labelLineNoStart.AutoSize = true;
            this.labelLineNoStart.Location = new System.Drawing.Point(659, 135);
            this.labelLineNoStart.Name = "labelLineNoStart";
            this.labelLineNoStart.Size = new System.Drawing.Size(29, 13);
            this.labelLineNoStart.TabIndex = 18;
            this.labelLineNoStart.Text = "Start";
            // 
            // labelLineNoEnd
            // 
            this.labelLineNoEnd.AutoSize = true;
            this.labelLineNoEnd.Location = new System.Drawing.Point(732, 135);
            this.labelLineNoEnd.Name = "labelLineNoEnd";
            this.labelLineNoEnd.Size = new System.Drawing.Size(26, 13);
            this.labelLineNoEnd.TabIndex = 19;
            this.labelLineNoEnd.Text = "End";
            // 
            // labelSymptom
            // 
            this.labelSymptom.AutoSize = true;
            this.labelSymptom.Location = new System.Drawing.Point(265, 94);
            this.labelSymptom.Name = "labelSymptom";
            this.labelSymptom.Size = new System.Drawing.Size(50, 13);
            this.labelSymptom.TabIndex = 20;
            this.labelSymptom.Text = "Symptom";
            // 
            // labelCause
            // 
            this.labelCause.AutoSize = true;
            this.labelCause.Location = new System.Drawing.Point(573, 94);
            this.labelCause.Name = "labelCause";
            this.labelCause.Size = new System.Drawing.Size(37, 13);
            this.labelCause.TabIndex = 21;
            this.labelCause.Text = "Cause";
            // 
            // labelLineTitle
            // 
            this.labelLineTitle.AutoSize = true;
            this.labelLineTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLineTitle.ForeColor = System.Drawing.Color.Gray;
            this.labelLineTitle.Location = new System.Drawing.Point(586, 135);
            this.labelLineTitle.Name = "labelLineTitle";
            this.labelLineTitle.Size = new System.Drawing.Size(67, 13);
            this.labelLineTitle.TabIndex = 22;
            this.labelLineTitle.Text = "Line Number";
            // 
            // txtCode
            // 
            this.txtCode.IsReadOnly = false;
            this.txtCode.Location = new System.Drawing.Point(60, 198);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(736, 345);
            this.txtCode.TabIndex = 24;
            this.txtCode.Load += new System.EventHandler(this.txtCode_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 601);
            this.Controls.Add(this.txtCode);
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
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelApplication);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelBugID);
            this.Controls.Add(this.txtApplication);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBugId);
            this.Controls.Add(this.listBoxInput);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ASEA | Bug Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxInput;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.Label labelBugID;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelApplication;
        private System.Windows.Forms.Label labelCode;
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
    }
}

