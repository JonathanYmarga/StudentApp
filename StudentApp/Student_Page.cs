using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace StudentApp
{
    public partial class Student_Page : Form
    {
        private string connectionString = "server=LocalCon;database=StudentInfoDB;uid=root;pwd=password;"; // Replace with your credentials

        public Student_Page()
        {
            InitializeComponent();
            LoadStudentRecords();
        }

        private void LoadStudentRecords()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT studentId, CONCAT(firstName, ' ', lastName) AS FullName FROM StudentRecordTB";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        StudentListPanel.Controls.Clear(); // Or StudentListGroupBox, depending on what you used
                        int y = 10;
                        while (reader.Read())
                        {
                            int studentId = reader.GetInt32("studentId");
                            string fullName = reader.GetString("FullName");

                            Label studentLabel = new Label { Text = $"{studentId} - {fullName}", Location = new Point(10, y) };
                            StudentListPanel.Controls.Add(studentLabel);

                            Button viewButton = new Button { Text = "VIEW", Location = new Point(200, y), Tag = studentId };
                            viewButton.Click += ViewButton_Click;
                            StudentListPanel.Controls.Add(viewButton);

                            y += 30;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading student records: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            Button viewButton = (Button)sender;
            int studentId = (int)viewButton.Tag;

            StudentPage_Individual individualPage = new StudentPage_Individual(studentId);
            individualPage.Show();
        }
    }
}
