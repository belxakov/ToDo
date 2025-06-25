namespace ToDo.modules
{
    partial class MainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtonZone = new System.Windows.Forms.Panel();
            this.buttonGoImportantDate = new System.Windows.Forms.Button();
            this.buttonGoClients = new System.Windows.Forms.Button();
            this.buttonGoTasks = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.buttonCloseApplication = new System.Windows.Forms.PictureBox();
            this.panelClients = new System.Windows.Forms.Panel();
            this.titleClients = new System.Windows.Forms.Label();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.panelImportantDate = new System.Windows.Forms.Panel();
            this.titleTasks = new System.Windows.Forms.Label();
            this.completeTasks = new System.Windows.Forms.Label();
            this.allCountTasks = new System.Windows.Forms.Label();
            this.gridTasks = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.panelButtonZone.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApplication)).BeginInit();
            this.panelClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            this.panelImportantDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panelMenu.Controls.Add(this.panelButtonZone);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 640);
            this.panelMenu.TabIndex = 0;
            // 
            // panelButtonZone
            // 
            this.panelButtonZone.Controls.Add(this.buttonGoImportantDate);
            this.panelButtonZone.Controls.Add(this.buttonGoClients);
            this.panelButtonZone.Controls.Add(this.buttonGoTasks);
            this.panelButtonZone.Location = new System.Drawing.Point(0, 206);
            this.panelButtonZone.Name = "panelButtonZone";
            this.panelButtonZone.Size = new System.Drawing.Size(230, 200);
            this.panelButtonZone.TabIndex = 0;
            // 
            // buttonGoImportantDate
            // 
            this.buttonGoImportantDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGoImportantDate.FlatAppearance.BorderSize = 0;
            this.buttonGoImportantDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoImportantDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoImportantDate.ForeColor = System.Drawing.Color.White;
            this.buttonGoImportantDate.Image = global::ToDo.Properties.Resources.calendar_month_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24_1;
            this.buttonGoImportantDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoImportantDate.Location = new System.Drawing.Point(0, 100);
            this.buttonGoImportantDate.Name = "buttonGoImportantDate";
            this.buttonGoImportantDate.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonGoImportantDate.Size = new System.Drawing.Size(230, 50);
            this.buttonGoImportantDate.TabIndex = 2;
            this.buttonGoImportantDate.Text = "Важные даты";
            this.buttonGoImportantDate.UseVisualStyleBackColor = true;
            // 
            // buttonGoClients
            // 
            this.buttonGoClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGoClients.FlatAppearance.BorderSize = 0;
            this.buttonGoClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoClients.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoClients.ForeColor = System.Drawing.Color.White;
            this.buttonGoClients.Image = global::ToDo.Properties.Resources.person_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24_1;
            this.buttonGoClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoClients.Location = new System.Drawing.Point(0, 50);
            this.buttonGoClients.Name = "buttonGoClients";
            this.buttonGoClients.Padding = new System.Windows.Forms.Padding(25, 0, 35, 0);
            this.buttonGoClients.Size = new System.Drawing.Size(230, 50);
            this.buttonGoClients.TabIndex = 1;
            this.buttonGoClients.Text = "Клиенты";
            this.buttonGoClients.UseVisualStyleBackColor = true;
            this.buttonGoClients.Click += new System.EventHandler(this.buttonGoClients_Click);
            // 
            // buttonGoTasks
            // 
            this.buttonGoTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGoTasks.FlatAppearance.BorderSize = 0;
            this.buttonGoTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoTasks.ForeColor = System.Drawing.Color.White;
            this.buttonGoTasks.Image = global::ToDo.Properties.Resources.assignment_returned_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24_1;
            this.buttonGoTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoTasks.Location = new System.Drawing.Point(0, 0);
            this.buttonGoTasks.Name = "buttonGoTasks";
            this.buttonGoTasks.Padding = new System.Windows.Forms.Padding(25, 0, 45, 0);
            this.buttonGoTasks.Size = new System.Drawing.Size(230, 50);
            this.buttonGoTasks.TabIndex = 0;
            this.buttonGoTasks.Text = "Задачи";
            this.buttonGoTasks.UseVisualStyleBackColor = true;
            this.buttonGoTasks.Click += new System.EventHandler(this.buttonGoTasks_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.buttonCloseApplication);
            this.panelDesktop.Controls.Add(this.panelClients);
            this.panelDesktop.Controls.Add(this.panelImportantDate);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(794, 640);
            this.panelDesktop.TabIndex = 1;
            // 
            // buttonCloseApplication
            // 
            this.buttonCloseApplication.Image = global::ToDo.Properties.Resources.closeApp;
            this.buttonCloseApplication.Location = new System.Drawing.Point(758, 11);
            this.buttonCloseApplication.Name = "buttonCloseApplication";
            this.buttonCloseApplication.Size = new System.Drawing.Size(24, 24);
            this.buttonCloseApplication.TabIndex = 2;
            this.buttonCloseApplication.TabStop = false;
            this.buttonCloseApplication.Click += new System.EventHandler(this.buttonCloseApplication_Click);
            // 
            // panelClients
            // 
            this.panelClients.Controls.Add(this.titleClients);
            this.panelClients.Controls.Add(this.gridClients);
            this.panelClients.Location = new System.Drawing.Point(412, 41);
            this.panelClients.Name = "panelClients";
            this.panelClients.Size = new System.Drawing.Size(370, 250);
            this.panelClients.TabIndex = 1;
            // 
            // titleClients
            // 
            this.titleClients.AutoSize = true;
            this.titleClients.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleClients.ForeColor = System.Drawing.Color.White;
            this.titleClients.Location = new System.Drawing.Point(154, 8);
            this.titleClients.Name = "titleClients";
            this.titleClients.Size = new System.Drawing.Size(77, 21);
            this.titleClients.TabIndex = 4;
            this.titleClients.Text = "Клиенты";
            // 
            // gridClients
            // 
            this.gridClients.AllowUserToAddRows = false;
            this.gridClients.AllowUserToDeleteRows = false;
            this.gridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClients.Location = new System.Drawing.Point(0, 32);
            this.gridClients.Name = "gridClients";
            this.gridClients.ReadOnly = true;
            this.gridClients.Size = new System.Drawing.Size(370, 218);
            this.gridClients.TabIndex = 1;
            // 
            // panelImportantDate
            // 
            this.panelImportantDate.Controls.Add(this.titleTasks);
            this.panelImportantDate.Controls.Add(this.completeTasks);
            this.panelImportantDate.Controls.Add(this.allCountTasks);
            this.panelImportantDate.Controls.Add(this.gridTasks);
            this.panelImportantDate.Location = new System.Drawing.Point(17, 41);
            this.panelImportantDate.Name = "panelImportantDate";
            this.panelImportantDate.Size = new System.Drawing.Size(370, 250);
            this.panelImportantDate.TabIndex = 0;
            // 
            // titleTasks
            // 
            this.titleTasks.AutoSize = true;
            this.titleTasks.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTasks.ForeColor = System.Drawing.Color.White;
            this.titleTasks.Location = new System.Drawing.Point(154, 8);
            this.titleTasks.Name = "titleTasks";
            this.titleTasks.Size = new System.Drawing.Size(63, 21);
            this.titleTasks.TabIndex = 3;
            this.titleTasks.Text = "Задачи";
            // 
            // completeTasks
            // 
            this.completeTasks.AutoSize = true;
            this.completeTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.completeTasks.ForeColor = System.Drawing.Color.White;
            this.completeTasks.Location = new System.Drawing.Point(242, 222);
            this.completeTasks.Name = "completeTasks";
            this.completeTasks.Size = new System.Drawing.Size(106, 21);
            this.completeTasks.TabIndex = 2;
            this.completeTasks.Text = "Выполнено:";
            // 
            // allCountTasks
            // 
            this.allCountTasks.AutoSize = true;
            this.allCountTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCountTasks.ForeColor = System.Drawing.Color.White;
            this.allCountTasks.Location = new System.Drawing.Point(4, 222);
            this.allCountTasks.Name = "allCountTasks";
            this.allCountTasks.Size = new System.Drawing.Size(58, 21);
            this.allCountTasks.TabIndex = 1;
            this.allCountTasks.Text = "Всего:";
            // 
            // gridTasks
            // 
            this.gridTasks.AllowUserToAddRows = false;
            this.gridTasks.AllowUserToDeleteRows = false;
            this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTasks.Location = new System.Drawing.Point(0, 32);
            this.gridTasks.Name = "gridTasks";
            this.gridTasks.ReadOnly = true;
            this.gridTasks.Size = new System.Drawing.Size(370, 183);
            this.gridTasks.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelButtonZone.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApplication)).EndInit();
            this.panelClients.ResumeLayout(false);
            this.panelClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            this.panelImportantDate.ResumeLayout(false);
            this.panelImportantDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelButtonZone;
        private System.Windows.Forms.Button buttonGoTasks;
        private System.Windows.Forms.Button buttonGoImportantDate;
        private System.Windows.Forms.Button buttonGoClients;
        private System.Windows.Forms.Panel panelImportantDate;
        private System.Windows.Forms.Panel panelClients;
        private System.Windows.Forms.PictureBox buttonCloseApplication;
        private System.Windows.Forms.DataGridView gridClients;
        private System.Windows.Forms.DataGridView gridTasks;
        private System.Windows.Forms.Label allCountTasks;
        private System.Windows.Forms.Label completeTasks;
        private System.Windows.Forms.Label titleTasks;
        private System.Windows.Forms.Label titleClients;
    }
}