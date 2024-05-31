namespace WinFormsControlLibrary1
{
    partial class Practice1
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
            Input = new TextBox();
            Indicator = new Label();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new Point(47, 55);
            Input.Name = "Input";
            Input.PlaceholderText = "Input some numbers";
            Input.Size = new Size(126, 23);
            Input.TabIndex = 0;
            Input.TabStop = false;
            // 
            // Indicator
            // 
            Indicator.AutoSize = true;
            Indicator.Location = new Point(47, 81);
            Indicator.Name = "Indicator";
            Indicator.Size = new Size(38, 15);
            Indicator.TabIndex = 1;
            Indicator.Text = "label1";
            Indicator.Visible = false;
            // 
            // Practice1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Indicator);
            Controls.Add(Input);
            Name = "Practice1";
            Size = new Size(214, 154);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input;
        private Label Indicator;
    }
}
