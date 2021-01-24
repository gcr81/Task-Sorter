namespace Lab2_OligertCrroj
{
    partial class TaskOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskOrder));
            this.pnlIntro = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.kbkTask = new System.Windows.Forms.Label();
            this.lblPriorityTask = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTotalTask = new System.Windows.Forms.Label();
            this.lblTaskCompleted = new System.Windows.Forms.Label();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlIntro
            // 
            this.pnlIntro.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlIntro.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.pnlIntro, "pnlIntro");
            this.pnlIntro.Name = "pnlIntro";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // btnShow
            // 
            resources.ApplyResources(this.btnShow, "btnShow");
            this.btnShow.Name = "btnShow";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtTask
            // 
            resources.ApplyResources(this.txtTask, "txtTask");
            this.txtTask.Name = "txtTask";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            resources.ApplyResources(this.cbPriority, "cbPriority");
            this.cbPriority.Name = "cbPriority";
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // kbkTask
            // 
            resources.ApplyResources(this.kbkTask, "kbkTask");
            this.kbkTask.Name = "kbkTask";
            // 
            // lblPriorityTask
            // 
            resources.ApplyResources(this.lblPriorityTask, "lblPriorityTask");
            this.lblPriorityTask.Name = "lblPriorityTask";
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // lblTotalTask
            // 
            resources.ApplyResources(this.lblTotalTask, "lblTotalTask");
            this.lblTotalTask.Name = "lblTotalTask";
            // 
            // lblTaskCompleted
            // 
            resources.ApplyResources(this.lblTaskCompleted, "lblTaskCompleted");
            this.lblTaskCompleted.Name = "lblTaskCompleted";
            // 
            // btnPeek
            // 
            resources.ApplyResources(this.btnPeek, "btnPeek");
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // Lab2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.lblTaskCompleted);
            this.Controls.Add(this.lblTotalTask);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPriorityTask);
            this.Controls.Add(this.kbkTask);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pnlIntro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Lab2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Lab2_Paint);
            this.pnlIntro.ResumeLayout(false);
            this.pnlIntro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlIntro;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label kbkTask;
        private System.Windows.Forms.Label lblPriorityTask;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTotalTask;
        private System.Windows.Forms.Label lblTaskCompleted;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Splitter splitter1;
    }
}

