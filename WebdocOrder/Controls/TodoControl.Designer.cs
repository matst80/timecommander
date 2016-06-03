namespace WebdocOrder.Controls
{
    partial class TodoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.lSender = new System.Windows.Forms.Label();
            this.lData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(4, 4);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(44, 17);
            this.cbDone.TabIndex = 0;
            this.cbDone.Text = "Klar";
            this.cbDone.UseVisualStyleBackColor = true;
            this.cbDone.CheckedChanged += new System.EventHandler(this.cbDone_CheckedChanged);
            // 
            // lSender
            // 
            this.lSender.AutoSize = true;
            this.lSender.Location = new System.Drawing.Point(348, 8);
            this.lSender.Name = "lSender";
            this.lSender.Size = new System.Drawing.Size(39, 13);
            this.lSender.TabIndex = 1;
            this.lSender.Text = "sender";
            // 
            // lData
            // 
            this.lData.AutoSize = true;
            this.lData.Location = new System.Drawing.Point(3, 24);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(35, 13);
            this.lData.TabIndex = 2;
            this.lData.Text = "label2";
            // 
            // TodoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lData);
            this.Controls.Add(this.lSender);
            this.Controls.Add(this.cbDone);
            this.Name = "TodoControl";
            this.Size = new System.Drawing.Size(491, 91);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.Label lSender;
        private System.Windows.Forms.Label lData;

    }
}
