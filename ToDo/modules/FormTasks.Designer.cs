namespace ToDo.modules
{
    partial class FormTasks
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
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAddTask = new System.Windows.Forms.Panel();
            this.groupAddTasks = new System.Windows.Forms.GroupBox();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.boxTasksDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxTasksName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseApplication = new System.Windows.Forms.PictureBox();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupAddTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Location = new System.Drawing.Point(12, 42);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(770, 362);
            this.panelData.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelAddTask
            // 
            this.panelAddTask.Location = new System.Drawing.Point(12, 418);
            this.panelAddTask.Name = "panelAddTask";
            this.panelAddTask.Size = new System.Drawing.Size(770, 210);
            this.panelAddTask.TabIndex = 1;
            // 
            // groupAddTasks
            // 
            this.groupAddTasks.Controls.Add(this.buttonSaveData);
            this.groupAddTasks.Controls.Add(this.boxTasksDescription);
            this.groupAddTasks.Controls.Add(this.label2);
            this.groupAddTasks.Controls.Add(this.boxTasksName);
            this.groupAddTasks.Controls.Add(this.label1);
            this.groupAddTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupAddTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddTasks.ForeColor = System.Drawing.Color.White;
            this.groupAddTasks.Location = new System.Drawing.Point(16, 410);
            this.groupAddTasks.Name = "groupAddTasks";
            this.groupAddTasks.Size = new System.Drawing.Size(766, 204);
            this.groupAddTasks.TabIndex = 0;
            this.groupAddTasks.TabStop = false;
            this.groupAddTasks.Text = "Задача";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveData.Location = new System.Drawing.Point(590, 141);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(157, 45);
            this.buttonSaveData.TabIndex = 4;
            this.buttonSaveData.Text = "Сохранить";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // boxTasksDescription
            // 
            this.boxTasksDescription.Location = new System.Drawing.Point(153, 100);
            this.boxTasksDescription.Name = "boxTasksDescription";
            this.boxTasksDescription.Size = new System.Drawing.Size(594, 29);
            this.boxTasksDescription.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание задачи:";
            // 
            // boxTasksName
            // 
            this.boxTasksName.Location = new System.Drawing.Point(153, 54);
            this.boxTasksName.Name = "boxTasksName";
            this.boxTasksName.Size = new System.Drawing.Size(594, 29);
            this.boxTasksName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок задачи:";
            // 
            // buttonCloseApplication
            // 
            this.buttonCloseApplication.Image = global::ToDo.Properties.Resources.closeApp;
            this.buttonCloseApplication.Location = new System.Drawing.Point(755, 12);
            this.buttonCloseApplication.Name = "buttonCloseApplication";
            this.buttonCloseApplication.Size = new System.Drawing.Size(24, 24);
            this.buttonCloseApplication.TabIndex = 3;
            this.buttonCloseApplication.TabStop = false;
            this.buttonCloseApplication.Click += new System.EventHandler(this.buttonCloseApplication_Click);
            // 
            // FormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(794, 640);
            this.Controls.Add(this.buttonCloseApplication);
            this.Controls.Add(this.groupAddTasks);
            this.Controls.Add(this.panelAddTask);
            this.Controls.Add(this.panelData);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTasks";
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupAddTasks.ResumeLayout(false);
            this.groupAddTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelAddTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupAddTasks;
        private System.Windows.Forms.TextBox boxTasksDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxTasksName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.PictureBox buttonCloseApplication;
    }
}