namespace MyPinger
{
    public partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHosts = new System.Windows.Forms.DataGridView();
            this.Host = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timeout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbAddHost = new System.Windows.Forms.TextBox();
            this.btnAddHost = new System.Windows.Forms.Button();
            this.btnEditHost = new System.Windows.Forms.Button();
            this.btnDeleteHost = new System.Windows.Forms.Button();
            this.cbHosts = new System.Windows.Forms.ComboBox();
            this.lblAddHost = new System.Windows.Forms.Label();
            this.lblAddTimeout = new System.Windows.Forms.Label();
            this.tbAddTimeout = new System.Windows.Forms.TextBox();
            this.tbEditHost = new System.Windows.Forms.TextBox();
            this.tbEditTimeout = new System.Windows.Forms.TextBox();
            this.lblEditHost = new System.Windows.Forms.Label();
            this.lblEditTimeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHosts
            // 
            this.dgvHosts.AllowUserToAddRows = false;
            this.dgvHosts.AllowUserToDeleteRows = false;
            this.dgvHosts.AllowUserToResizeColumns = false;
            this.dgvHosts.AllowUserToResizeRows = false;
            this.dgvHosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHosts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Host,
            this.Timeout,
            this.Status});
            this.dgvHosts.Location = new System.Drawing.Point(12, 12);
            this.dgvHosts.Name = "dgvHosts";
            this.dgvHosts.ReadOnly = true;
            this.dgvHosts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHosts.Size = new System.Drawing.Size(556, 260);
            this.dgvHosts.TabIndex = 0;
            // 
            // Host
            // 
            this.Host.HeaderText = "Host";
            this.Host.Name = "Host";
            this.Host.ReadOnly = true;
            // 
            // Timeout
            // 
            this.Timeout.HeaderText = "Timeout";
            this.Timeout.Name = "Timeout";
            this.Timeout.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tbAddHost
            // 
            this.tbAddHost.Location = new System.Drawing.Point(91, 280);
            this.tbAddHost.Name = "tbAddHost";
            this.tbAddHost.Size = new System.Drawing.Size(196, 20);
            this.tbAddHost.TabIndex = 1;
            // 
            // btnAddHost
            // 
            this.btnAddHost.Location = new System.Drawing.Point(414, 278);
            this.btnAddHost.Name = "btnAddHost";
            this.btnAddHost.Size = new System.Drawing.Size(154, 23);
            this.btnAddHost.TabIndex = 3;
            this.btnAddHost.Text = "Add Host";
            this.btnAddHost.UseVisualStyleBackColor = true;
            this.btnAddHost.Click += new System.EventHandler(this.btnAddHost_Click);
            // 
            // btnEditHost
            // 
            this.btnEditHost.Enabled = false;
            this.btnEditHost.Location = new System.Drawing.Point(414, 308);
            this.btnEditHost.Name = "btnEditHost";
            this.btnEditHost.Size = new System.Drawing.Size(154, 23);
            this.btnEditHost.TabIndex = 7;
            this.btnEditHost.Text = "Edit Host";
            this.btnEditHost.UseVisualStyleBackColor = true;
            this.btnEditHost.Click += new System.EventHandler(this.btnEditHost_Click);
            // 
            // btnDeleteHost
            // 
            this.btnDeleteHost.Enabled = false;
            this.btnDeleteHost.Location = new System.Drawing.Point(111, 342);
            this.btnDeleteHost.Name = "btnDeleteHost";
            this.btnDeleteHost.Size = new System.Drawing.Size(176, 23);
            this.btnDeleteHost.TabIndex = 8;
            this.btnDeleteHost.Text = "Delete Host";
            this.btnDeleteHost.UseVisualStyleBackColor = true;
            this.btnDeleteHost.Click += new System.EventHandler(this.btnDeleteHost_Click);
            // 
            // cbHosts
            // 
            this.cbHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHosts.FormattingEnabled = true;
            this.cbHosts.Location = new System.Drawing.Point(12, 310);
            this.cbHosts.Name = "cbHosts";
            this.cbHosts.Size = new System.Drawing.Size(90, 21);
            this.cbHosts.TabIndex = 4;
            this.cbHosts.SelectionChangeCommitted += new System.EventHandler(this.cbHosts_SelectionChangeCommitted);
            // 
            // lblAddHost
            // 
            this.lblAddHost.AutoSize = true;
            this.lblAddHost.Location = new System.Drawing.Point(12, 283);
            this.lblAddHost.Name = "lblAddHost";
            this.lblAddHost.Size = new System.Drawing.Size(73, 13);
            this.lblAddHost.TabIndex = 7;
            this.lblAddHost.Text = "Host Address:";
            // 
            // lblAddTimeout
            // 
            this.lblAddTimeout.AutoSize = true;
            this.lblAddTimeout.Location = new System.Drawing.Point(293, 283);
            this.lblAddTimeout.Name = "lblAddTimeout";
            this.lblAddTimeout.Size = new System.Drawing.Size(48, 13);
            this.lblAddTimeout.TabIndex = 8;
            this.lblAddTimeout.Text = "Timeout:";
            // 
            // tbAddTimeout
            // 
            this.tbAddTimeout.Location = new System.Drawing.Point(347, 280);
            this.tbAddTimeout.Name = "tbAddTimeout";
            this.tbAddTimeout.Size = new System.Drawing.Size(60, 20);
            this.tbAddTimeout.TabIndex = 2;
            // 
            // tbEditHost
            // 
            this.tbEditHost.Location = new System.Drawing.Point(187, 310);
            this.tbEditHost.Name = "tbEditHost";
            this.tbEditHost.ReadOnly = true;
            this.tbEditHost.Size = new System.Drawing.Size(100, 20);
            this.tbEditHost.TabIndex = 5;
            // 
            // tbEditTimeout
            // 
            this.tbEditTimeout.Location = new System.Drawing.Point(347, 310);
            this.tbEditTimeout.Name = "tbEditTimeout";
            this.tbEditTimeout.ReadOnly = true;
            this.tbEditTimeout.Size = new System.Drawing.Size(60, 20);
            this.tbEditTimeout.TabIndex = 6;
            // 
            // lblEditHost
            // 
            this.lblEditHost.AutoSize = true;
            this.lblEditHost.Location = new System.Drawing.Point(108, 313);
            this.lblEditHost.Name = "lblEditHost";
            this.lblEditHost.Size = new System.Drawing.Size(73, 13);
            this.lblEditHost.TabIndex = 13;
            this.lblEditHost.Text = "Host Address:";
            // 
            // lblEditTimeout
            // 
            this.lblEditTimeout.AutoSize = true;
            this.lblEditTimeout.Location = new System.Drawing.Point(293, 313);
            this.lblEditTimeout.Name = "lblEditTimeout";
            this.lblEditTimeout.Size = new System.Drawing.Size(48, 13);
            this.lblEditTimeout.TabIndex = 14;
            this.lblEditTimeout.Text = "Timeout:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.lblEditTimeout);
            this.Controls.Add(this.lblEditHost);
            this.Controls.Add(this.tbEditTimeout);
            this.Controls.Add(this.tbEditHost);
            this.Controls.Add(this.tbAddTimeout);
            this.Controls.Add(this.lblAddTimeout);
            this.Controls.Add(this.lblAddHost);
            this.Controls.Add(this.cbHosts);
            this.Controls.Add(this.btnDeleteHost);
            this.Controls.Add(this.btnEditHost);
            this.Controls.Add(this.btnAddHost);
            this.Controls.Add(this.tbAddHost);
            this.Controls.Add(this.dgvHosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Host Pinger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Host;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timeout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox tbAddHost;
        private System.Windows.Forms.Button btnAddHost;
        private System.Windows.Forms.Button btnEditHost;
        private System.Windows.Forms.Button btnDeleteHost;
        private System.Windows.Forms.ComboBox cbHosts;
        private System.Windows.Forms.Label lblAddHost;
        private System.Windows.Forms.Label lblAddTimeout;
        private System.Windows.Forms.TextBox tbAddTimeout;
        private System.Windows.Forms.TextBox tbEditHost;
        private System.Windows.Forms.TextBox tbEditTimeout;
        private System.Windows.Forms.Label lblEditHost;
        private System.Windows.Forms.Label lblEditTimeout;
        private System.Windows.Forms.DataGridView dgvHosts;
    }
}

