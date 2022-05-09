namespace BrickBreaker
{
    partial class HowToPlayTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlayTwo));
            this.backButtonHowTo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.htpTitle = new System.Windows.Forms.Label();
            this.nextButtonOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.backButtonHowTo.Location = new System.Drawing.Point(16, 596);
            this.backButtonHowTo.Margin = new System.Windows.Forms.Padding(4);
            this.backButtonHowTo.Name = "backButtonHowTo";
            this.backButtonHowTo.Size = new System.Drawing.Size(204, 77);
            this.backButtonHowTo.TabIndex = 2;
            this.backButtonHowTo.Text = "Back";
            this.backButtonHowTo.UseVisualStyleBackColor = false;
            this.backButtonHowTo.Click += new System.EventHandler(this.backButtonHowTo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Power-Ups";
            // 
            // htpTitle
            // 
            this.htpTitle.AutoSize = true;
            this.htpTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.htpTitle.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold);
            this.htpTitle.Location = new System.Drawing.Point(9, 12);
            this.htpTitle.Name = "htpTitle";
            this.htpTitle.Size = new System.Drawing.Size(318, 41);
            this.htpTitle.TabIndex = 3;
            this.htpTitle.Text = "How To Play:";
            // 
            // nextButtonOne
            // 
            this.nextButtonOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButtonOne.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nextButtonOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.nextButtonOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.nextButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButtonOne.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButtonOne.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nextButtonOne.Location = new System.Drawing.Point(850, 596);
            this.nextButtonOne.Margin = new System.Windows.Forms.Padding(4);
            this.nextButtonOne.Name = "nextButtonOne";
            this.nextButtonOne.Size = new System.Drawing.Size(204, 77);
            this.nextButtonOne.TabIndex = 15;
            this.nextButtonOne.Text = "Next";
            this.nextButtonOne.UseVisualStyleBackColor = false;
            this.nextButtonOne.Click += new System.EventHandler(this.nextButtonOne_Click);
            // 
            // HowToPlayTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.nextButtonOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.htpTitle);
            this.Controls.Add(this.backButtonHowTo);
            this.Name = "HowToPlayTwo";
            this.Size = new System.Drawing.Size(1067, 677);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButtonHowTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label htpTitle;
        private System.Windows.Forms.Button nextButtonOne;
    }
}
