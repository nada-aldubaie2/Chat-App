namespace Server_Chat___Nada_Aldubaie
{
    partial class Server
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Private = new System.Windows.Forms.Button();
            this.inputPrivate = new System.Windows.Forms.TextBox();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOnline = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.listBox1.ContextMenuStrip = this.contextMenuStrip;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(56, 172);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 180);
            this.listBox1.TabIndex = 12;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(152, 28);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(397, 127);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(320, 312);
            this.textBox1.TabIndex = 11;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(56, 81);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 29);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Private
            // 
            this.Private.BackColor = System.Drawing.Color.ForestGreen;
            this.Private.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Private.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Private.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Private.ForeColor = System.Drawing.Color.White;
            this.Private.Location = new System.Drawing.Point(248, 415);
            this.Private.Margin = new System.Windows.Forms.Padding(0);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(110, 29);
            this.Private.TabIndex = 18;
            this.Private.Text = "Send";
            this.Private.UseVisualStyleBackColor = false;
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // inputPrivate
            // 
            this.inputPrivate.BackColor = System.Drawing.Color.Gainsboro;
            this.inputPrivate.Location = new System.Drawing.Point(56, 408);
            this.inputPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.inputPrivate.Multiline = true;
            this.inputPrivate.Name = "inputPrivate";
            this.inputPrivate.Size = new System.Drawing.Size(177, 42);
            this.inputPrivate.TabIndex = 17;
            this.inputPrivate.TextChanged += new System.EventHandler(this.InputPrivate_TextChanged);
            // 
            // btnServerStop
            // 
            this.btnServerStop.BackColor = System.Drawing.Color.ForestGreen;
            this.btnServerStop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnServerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerStop.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStop.ForeColor = System.Drawing.Color.White;
            this.btnServerStop.Location = new System.Drawing.Point(179, 81);
            this.btnServerStop.Margin = new System.Windows.Forms.Padding(0);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(110, 29);
            this.btnServerStop.TabIndex = 16;
            this.btnServerStop.Text = "Stop Server";
            this.btnServerStop.UseVisualStyleBackColor = false;
            this.btnServerStop.Click += new System.EventHandler(this.BtnServerStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(401, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chat log";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(283, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Server Chat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblOnline.Location = new System.Drawing.Point(59, 150);
            this.lblOnline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(95, 17);
            this.lblOnline.TabIndex = 13;
            this.lblOnline.Text = "Clients Online";
            this.lblOnline.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(644, 477);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "By Nada Aldubaie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(763, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Private);
            this.Controls.Add(this.inputPrivate);
            this.Controls.Add(this.btnServerStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOnline);
            this.Name = "Server";
            this.Text = "Server";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button Private;
        private System.Windows.Forms.TextBox inputPrivate;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label label3;
    }
}

