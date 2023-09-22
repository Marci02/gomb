
namespace WindowsFormsApp2.Forms
{
    partial class SubForm
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
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.Szoveg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // YesButton
            // 
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.YesButton.Location = new System.Drawing.Point(50, 122);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(80, 23);
            this.YesButton.TabIndex = 0;
            this.YesButton.Text = "Igen";
            this.YesButton.UseVisualStyleBackColor = true;
            // 
            // NoButton
            // 
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NoButton.Location = new System.Drawing.Point(146, 122);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Nem";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // Szoveg
            // 
            this.Szoveg.Location = new System.Drawing.Point(9, 50);
            this.Szoveg.Name = "Szoveg";
            this.Szoveg.Size = new System.Drawing.Size(266, 23);
            this.Szoveg.TabIndex = 2;
            this.Szoveg.Text = "Igen";
            this.Szoveg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 167);
            this.ControlBox = false;
            this.Controls.Add(this.Szoveg);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Name = "SubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kérdés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label Szoveg;
    }
}