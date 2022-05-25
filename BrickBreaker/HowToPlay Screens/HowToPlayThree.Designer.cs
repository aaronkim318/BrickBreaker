namespace BrickBreaker
{
    partial class HowToPlayThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlayThree));
            this.label1 = new System.Windows.Forms.Label();
            this.htpTitle = new System.Windows.Forms.Label();
            this.backButtonHowTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(352, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bricks";
            // 
            // htpTitle
            // 
            this.htpTitle.AutoSize = true;
            this.htpTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htpTitle.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold);
            this.htpTitle.Location = new System.Drawing.Point(3, 17);
            this.htpTitle.Name = "htpTitle";
            this.htpTitle.Size = new System.Drawing.Size(318, 41);
            this.htpTitle.TabIndex = 5;
            this.htpTitle.Text = "How To Play:";
            // 
            // backButtonHowTo
            // 
            this.backButtonHowTo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButtonHowTo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backButtonHowTo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.backButtonHowTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.backButtonHowTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButtonHowTo.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButtonHowTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.backButtonHowTo.Location = new System.Drawing.Point(10, 587);
            this.backButtonHowTo.Margin = new System.Windows.Forms.Padding(4);
            this.backButtonHowTo.Name = "backButtonHowTo";
            this.backButtonHowTo.Size = new System.Drawing.Size(204, 77);
            this.backButtonHowTo.TabIndex = 7;
            this.backButtonHowTo.Text = "Back";
            this.backButtonHowTo.UseVisualStyleBackColor = false;
            this.backButtonHowTo.Click += new System.EventHandler(this.backButtonHowTo_Click);
            // 
            // HowToPlayThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.backButtonHowTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htpTitle);
            this.Name = "HowToPlayThree";
            this.Size = new System.Drawing.Size(1067, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label htpTitle;
        private System.Windows.Forms.Button backButtonHowTo;
    }
}
