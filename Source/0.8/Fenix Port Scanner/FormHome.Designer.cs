namespace Fenix_Port_Scanner
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.gbEnterTarget = new System.Windows.Forms.GroupBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.gbScanMode = new System.Windows.Forms.GroupBox();
            this.upPortEnd = new System.Windows.Forms.NumericUpDown();
            this.udPortStart = new System.Windows.Forms.NumericUpDown();
            this.rbOnyCheckMajor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCheckPortsRange = new System.Windows.Forms.RadioButton();
            this.gbPortsFound = new System.Windows.Forms.GroupBox();
            this.lbPortFounds = new System.Windows.Forms.ListBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbEnterTarget.SuspendLayout();
            this.gbScanMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPortEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPortStart)).BeginInit();
            this.gbPortsFound.SuspendLayout();
            this.ssStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEnterTarget
            // 
            this.gbEnterTarget.BackColor = System.Drawing.Color.Transparent;
            this.gbEnterTarget.Controls.Add(this.btnScan);
            this.gbEnterTarget.Controls.Add(this.txtIP);
            this.gbEnterTarget.ForeColor = System.Drawing.Color.Lime;
            this.gbEnterTarget.Location = new System.Drawing.Point(34, 111);
            this.gbEnterTarget.Name = "gbEnterTarget";
            this.gbEnterTarget.Size = new System.Drawing.Size(356, 71);
            this.gbEnterTarget.TabIndex = 0;
            this.gbEnterTarget.TabStop = false;
            this.gbEnterTarget.Text = "Enter Target";
            // 
            // btnScan
            // 
            this.btnScan.ForeColor = System.Drawing.Color.Black;
            this.btnScan.Location = new System.Drawing.Point(212, 30);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(123, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Black;
            this.txtIP.ForeColor = System.Drawing.Color.Lime;
            this.txtIP.Location = new System.Drawing.Point(21, 30);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(185, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // gbScanMode
            // 
            this.gbScanMode.BackColor = System.Drawing.Color.Transparent;
            this.gbScanMode.Controls.Add(this.upPortEnd);
            this.gbScanMode.Controls.Add(this.udPortStart);
            this.gbScanMode.Controls.Add(this.rbOnyCheckMajor);
            this.gbScanMode.Controls.Add(this.label1);
            this.gbScanMode.Controls.Add(this.rbCheckPortsRange);
            this.gbScanMode.ForeColor = System.Drawing.Color.Lime;
            this.gbScanMode.Location = new System.Drawing.Point(34, 188);
            this.gbScanMode.Name = "gbScanMode";
            this.gbScanMode.Size = new System.Drawing.Size(356, 86);
            this.gbScanMode.TabIndex = 1;
            this.gbScanMode.TabStop = false;
            this.gbScanMode.Text = "Scan Mode";
            // 
            // upPortEnd
            // 
            this.upPortEnd.Location = new System.Drawing.Point(265, 30);
            this.upPortEnd.Name = "upPortEnd";
            this.upPortEnd.Size = new System.Drawing.Size(40, 20);
            this.upPortEnd.TabIndex = 6;
            this.upPortEnd.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            // 
            // udPortStart
            // 
            this.udPortStart.Location = new System.Drawing.Point(198, 31);
            this.udPortStart.Name = "udPortStart";
            this.udPortStart.Size = new System.Drawing.Size(40, 20);
            this.udPortStart.TabIndex = 5;
            this.udPortStart.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // rbOnyCheckMajor
            // 
            this.rbOnyCheckMajor.AutoSize = true;
            this.rbOnyCheckMajor.Checked = true;
            this.rbOnyCheckMajor.Location = new System.Drawing.Point(30, 53);
            this.rbOnyCheckMajor.Name = "rbOnyCheckMajor";
            this.rbOnyCheckMajor.Size = new System.Drawing.Size(133, 17);
            this.rbOnyCheckMajor.TabIndex = 4;
            this.rbOnyCheckMajor.TabStop = true;
            this.rbOnyCheckMajor.Text = "Only check major ports";
            this.rbOnyCheckMajor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // rbCheckPortsRange
            // 
            this.rbCheckPortsRange.AutoSize = true;
            this.rbCheckPortsRange.Location = new System.Drawing.Point(30, 30);
            this.rbCheckPortsRange.Name = "rbCheckPortsRange";
            this.rbCheckPortsRange.Size = new System.Drawing.Size(162, 17);
            this.rbCheckPortsRange.TabIndex = 0;
            this.rbCheckPortsRange.TabStop = true;
            this.rbCheckPortsRange.Text = "Check ports with this range : ";
            this.rbCheckPortsRange.UseVisualStyleBackColor = true;
            // 
            // gbPortsFound
            // 
            this.gbPortsFound.BackColor = System.Drawing.Color.Transparent;
            this.gbPortsFound.Controls.Add(this.lbPortFounds);
            this.gbPortsFound.ForeColor = System.Drawing.Color.Lime;
            this.gbPortsFound.Location = new System.Drawing.Point(35, 280);
            this.gbPortsFound.Name = "gbPortsFound";
            this.gbPortsFound.Size = new System.Drawing.Size(355, 94);
            this.gbPortsFound.TabIndex = 2;
            this.gbPortsFound.TabStop = false;
            this.gbPortsFound.Text = "Ports Found";
            // 
            // lbPortFounds
            // 
            this.lbPortFounds.BackColor = System.Drawing.Color.Black;
            this.lbPortFounds.ForeColor = System.Drawing.Color.Lime;
            this.lbPortFounds.FormattingEnabled = true;
            this.lbPortFounds.Location = new System.Drawing.Point(20, 19);
            this.lbPortFounds.Name = "lbPortFounds";
            this.lbPortFounds.ScrollAlwaysVisible = true;
            this.lbPortFounds.Size = new System.Drawing.Size(314, 56);
            this.lbPortFounds.TabIndex = 0;
            // 
            // ssStatus
            // 
            this.ssStatus.BackColor = System.Drawing.Color.Black;
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.ssStatus.Location = new System.Drawing.Point(0, 386);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(429, 22);
            this.ssStatus.TabIndex = 3;
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Lime;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(107, 17);
            this.status.Text = "[+] Program Ready";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 93);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(429, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.gbPortsFound);
            this.Controls.Add(this.gbScanMode);
            this.Controls.Add(this.gbEnterTarget);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = " - Fenix Port Scanner 0.8 - © Ismael Heredia , Argentina , 2017 - ";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.gbEnterTarget.ResumeLayout(false);
            this.gbEnterTarget.PerformLayout();
            this.gbScanMode.ResumeLayout(false);
            this.gbScanMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPortEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPortStart)).EndInit();
            this.gbPortsFound.ResumeLayout(false);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEnterTarget;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.GroupBox gbScanMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCheckPortsRange;
        private System.Windows.Forms.RadioButton rbOnyCheckMajor;
        private System.Windows.Forms.GroupBox gbPortsFound;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ListBox lbPortFounds;
        private System.Windows.Forms.NumericUpDown upPortEnd;
        private System.Windows.Forms.NumericUpDown udPortStart;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

