namespace StudentApp
{
    partial class StudentPage_Individual
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.Label HouseNoLabel;
        private System.Windows.Forms.Label BrgyNameLabel;
        private System.Windows.Forms.Label MunicipalityLabel;
        private System.Windows.Forms.Label ProvinceLabel;
        private System.Windows.Forms.Label RegionLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label StudContactNoLabel;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.Label GuardianFirstNameLabel;
        private System.Windows.Forms.Label GuardianLastNameLabel;
        private System.Windows.Forms.Label HobbiesLabel;
        private System.Windows.Forms.Label NicknameLabel;

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
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.HouseNoLabel = new System.Windows.Forms.Label();
            this.BrgyNameLabel = new System.Windows.Forms.Label();
            this.MunicipalityLabel = new System.Windows.Forms.Label();
            this.ProvinceLabel = new System.Windows.Forms.Label();
            this.RegionLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.StudContactNoLabel = new System.Windows.Forms.Label();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.GuardianFirstNameLabel = new System.Windows.Forms.Label();
            this.GuardianLastNameLabel = new System.Windows.Forms.Label();
            this.HobbiesLabel = new System.Windows.Forms.Label();
            this.NicknameLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Setting positions for labels
            int y = 20;
            foreach (var label in new[] { StudentIdLabel, FirstNameLabel, LastNameLabel, MiddleNameLabel, HouseNoLabel,
                                           BrgyNameLabel, MunicipalityLabel, ProvinceLabel, RegionLabel, CountryLabel,
                                           BirthdateLabel, AgeLabel, StudContactNoLabel, EmailAddressLabel,
                                           GuardianFirstNameLabel, GuardianLastNameLabel, HobbiesLabel, NicknameLabel })
            {
                label.AutoSize = true;
                label.Location = new System.Drawing.Point(20, y);
                this.Controls.Add(label);
                y += 30;
            }

            // StudentPage_Individual
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Name = "StudentPage_Individual";
            this.Text = "Student Details";
            this.ResumeLayout(false);
        }
    }
}
