namespace Client_Chat___Nada_Aldubaie
{
    partial class SendInPrivateForm
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
            this.inputPrivate = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputPrivate
            // 
            this.inputPrivate.BackColor = System.Drawing.Color.Gainsboro;
            this.inputPrivate.ForeColor = System.Drawing.Color.Black;
            this.inputPrivate.Location = new System.Drawing.Point(47, 354);
            this.inputPrivate.Margin = new System.Windows.Forms.Padding(4);
            this.inputPrivate.Multiline = true;
            this.inputPrivate.Name = "inputPrivate";
            this.inputPrivate.Size = new System.Drawing.Size(213, 33);
            this.inputPrivate.TabIndex = 6;
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.Gainsboro;
            this.history.ForeColor = System.Drawing.Color.Black;
            this.history.Location = new System.Drawing.Point(47, 75);
            this.history.Margin = new System.Windows.Forms.Padding(4);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history.Size = new System.Drawing.Size(291, 243);
            this.history.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(277, 357);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 30);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // SendInPrivateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(460, 450);
            this.Controls.Add(this.inputPrivate);
            this.Controls.Add(this.history);
            this.Controls.Add(this.btnSend);
            this.Name = "SendInPrivateForm";
            this.Text = "SendInPrivateForm";
            this.Load += new System.EventHandler(this.SendInPrivateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPrivate;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.Button btnSend;
    }
}