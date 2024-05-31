namespace WinFormsApp1
{
    partial class Form1
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
            practice11 = new WinFormsControlLibrary1.Practice1();
            SuspendLayout();
            // 
            // practice11
            // 
            practice11.Location = new Point(90, 48);
            practice11.MaxValue = 100D;
            practice11.MinValue = 0D;
            practice11.Name = "practice11";
            practice11.Size = new Size(214, 154);
            practice11.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 276);
            Controls.Add(practice11);
            Name = "Form1";
            Text = "Form1";
            SizeChanged += Size;
            ResumeLayout(false);
        }

        #endregion

        private WinFormsControlLibrary1.Practice1 practice11;
    }
}
