namespace basisopdracht7
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(379, 180);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(94, 29);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "click!";
            this.testButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.testButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            this.testButton.MouseEnter += new System.EventHandler(this.testButton_MouseEnter);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testButton);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button testButton;
    }
}