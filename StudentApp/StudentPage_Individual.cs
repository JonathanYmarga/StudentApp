using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentApp
{
    public partial class StudentPage_Individual : Form
    {
        private string connectionString = "server=LocalCon;database=StudentInfoDB;uid=root;pwd=password;"; // Replace with your credentials
        private int studentId;

        public StudentPage_Individual(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM StudentRecordTB WHERE studentId = @studentId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentId", studentId);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                StudentIdLabel.Text = "Student ID: " + reader.GetInt32("studentId").ToString();
                                FirstNameLabel.Text = "First Name: " + reader.GetString("firstName");
                                LastNameLabel.Text = "Last Name: " + reader.GetString("lastName");
                                MiddleNameLabel.Text = "Middle Name: " + reader.GetString("middleName");
                                HouseNoLabel.Text = "House No: " + reader.GetInt32("houseNo").ToString();
                                BrgyNameLabel.Text = "Barangay: " + reader.GetString("brgyName");
                                MunicipalityLabel.Text = "Municipality: " + reader.GetString("municipality");
                                ProvinceLabel.Text = "Province: " + reader.GetString("province");
                                RegionLabel.Text = "Region: " + reader.GetString("region");
                                CountryLabel.Text = "Country: " + reader.GetString("country");
                                BirthdateLabel.Text = "Birthdate: " + reader.GetString("birthdate");
                                AgeLabel.Text = "Age: " + reader.GetInt32("age").ToString();
                                StudContactNoLabel.Text = "Contact No: " + reader.GetString("studContactNo");
                                EmailAddressLabel.Text = "Email: " + reader.GetString("emailAddress");
                                GuardianFirstNameLabel.Text = "Guardian First Name: " + reader.GetString("guardianFirstName");
                                GuardianLastNameLabel.Text = "Guardian Last Name: " + reader.GetString("guardianLastName");
                                HobbiesLabel.Text = "Hobbies: " + reader.GetString("hobbies");
                                NicknameLabel.Text = "Nickname: " + reader.GetString("nickname");
                            }
                            else
                            {
                                MessageBox.Show("Student not found.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading student details: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}