namespace ToDo.modules
{
    partial class FormClients
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
            this.panelAddClient = new System.Windows.Forms.Panel();
            this.groupAddClient = new System.Windows.Forms.GroupBox();
            this.boxClientPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxClientPatronymic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.boxClientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxClientSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseApplication = new System.Windows.Forms.PictureBox();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAddClient.SuspendLayout();
            this.groupAddClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Location = new System.Drawing.Point(12, 42);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(770, 288);
            this.panelData.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelAddClient
            // 
            this.panelAddClient.Controls.Add(this.groupAddClient);
            this.panelAddClient.Location = new System.Drawing.Point(12, 336);
            this.panelAddClient.Name = "panelAddClient";
            this.panelAddClient.Size = new System.Drawing.Size(770, 292);
            this.panelAddClient.TabIndex = 2;
            // 
            // groupAddClient
            // 
            this.groupAddClient.Controls.Add(this.boxClientPhoneNumber);
            this.groupAddClient.Controls.Add(this.label3);
            this.groupAddClient.Controls.Add(this.boxClientPatronymic);
            this.groupAddClient.Controls.Add(this.label4);
            this.groupAddClient.Controls.Add(this.buttonSaveData);
            this.groupAddClient.Controls.Add(this.boxClientName);
            this.groupAddClient.Controls.Add(this.label2);
            this.groupAddClient.Controls.Add(this.boxClientSurname);
            this.groupAddClient.Controls.Add(this.label1);
            this.groupAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupAddClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddClient.ForeColor = System.Drawing.Color.White;
            this.groupAddClient.Location = new System.Drawing.Point(4, 3);
            this.groupAddClient.Name = "groupAddClient";
            this.groupAddClient.Size = new System.Drawing.Size(763, 286);
            this.groupAddClient.TabIndex = 0;
            this.groupAddClient.TabStop = false;
            this.groupAddClient.Text = "Клиент";
            // 
            // boxClientPhoneNumber
            // 
            this.boxClientPhoneNumber.Location = new System.Drawing.Point(153, 165);
            this.boxClientPhoneNumber.Mask = "+7 (999) 000-00-00";
            this.boxClientPhoneNumber.Name = "boxClientPhoneNumber";
            this.boxClientPhoneNumber.Size = new System.Drawing.Size(594, 29);
            this.boxClientPhoneNumber.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Номер телефона:";
            // 
            // boxClientPatronymic
            // 
            this.boxClientPatronymic.Location = new System.Drawing.Point(153, 119);
            this.boxClientPatronymic.Name = "boxClientPatronymic";
            this.boxClientPatronymic.Size = new System.Drawing.Size(594, 29);
            this.boxClientPatronymic.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество клиента:";
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonSaveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveData.Location = new System.Drawing.Point(590, 216);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(157, 45);
            this.buttonSaveData.TabIndex = 4;
            this.buttonSaveData.Text = "Сохранить";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // boxClientName
            // 
            this.boxClientName.Location = new System.Drawing.Point(153, 74);
            this.boxClientName.Name = "boxClientName";
            this.boxClientName.Size = new System.Drawing.Size(594, 29);
            this.boxClientName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя клиента:";
            // 
            // boxClientSurname
            // 
            this.boxClientSurname.Location = new System.Drawing.Point(153, 28);
            this.boxClientSurname.Name = "boxClientSurname";
            this.boxClientSurname.Size = new System.Drawing.Size(594, 29);
            this.boxClientSurname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия клиента:";
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
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(794, 640);
            this.Controls.Add(this.buttonCloseApplication);
            this.Controls.Add(this.panelAddClient);
            this.Controls.Add(this.panelData);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormClients";
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAddClient.ResumeLayout(false);
            this.groupAddClient.ResumeLayout(false);
            this.groupAddClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelAddClient;
        private System.Windows.Forms.GroupBox groupAddClient;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.TextBox boxClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxClientSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxClientPatronymic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox boxClientPhoneNumber;
        private System.Windows.Forms.PictureBox buttonCloseApplication;
    }
}