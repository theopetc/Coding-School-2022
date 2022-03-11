using Session_03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class Form1 : Form
    {
        private const string STUDENT_FILE = "student.json";

        private List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            formProfessor p = new formProfessor();
            
            p.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            University university = new University();
            UniversityForm4 u = new UniversityForm4();

            u.Show();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Student student = new Student();    
            formStudent s = new formStudent();
            s.Students = studentList;

            s.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            LoadData(STUDENT_FILE);
        }

        private void LoadData(string fileName)
        {
            string s = File.ReadAllText(fileName);

            studentList = (List<Student>)JsonSerializer.Deserialize(s, typeof(List<Student>));
        }

        private void SaveData(string fileName)
        {
            string json = JsonSerializer.Serialize(studentList);

            File.WriteAllText(fileName, json);

            MessageBox.Show("" , "File Saved!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData(STUDENT_FILE);
        }
    }
}
