namespace StudentApp
{
    partial class Student_Page
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel StudentListPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.StudentListPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();

            // StudentListPanel
            this.StudentListPanel.AutoScroll = true;
            this.StudentListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentListPanel.Location = new System.Drawing.Point(20, 20);
            this.StudentListPanel.Name = "StudentListPanel";
            this.StudentListPanel.Size = new System.Drawing.Size(400, 300);
            this.StudentListPanel.TabIndex = 0;

            // Student_Page
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.StudentListPanel);
            this.Name = "Student_Page";
            this.Text = "Student List";
            this.ResumeLayout(false);
        }
    }
}
