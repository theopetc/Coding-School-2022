using Session_03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class formStudent : Form
    {
        public List<Student> Students { get; set; }

        private Student _selectedStudent = new Student();
        private Student _originalStudent = new Student();
        public formStudent()
        {
            InitializeComponent();
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            ShowList();
        }

        private void SelectStudent()
        {
            //TODO: revisit
            //if (_selectedStudent != null)
            //{
                _selectedStudent = Students[listBox1.SelectedIndex];
            //}
        }

        private void DisplayStudent()
        {
            if (_selectedStudent != null)
            {
                textName.Text = _selectedStudent.Name;
                textAge.Text = _selectedStudent.Age.ToString(); 
                textRegNumber.Text = _selectedStudent.RegistrationNumber.ToString();

                if ((_selectedStudent.Courses != null) && (_selectedStudent.Courses.Count != 0))
                {
                    for (int i = 0; i < _selectedStudent.Courses.Count; i++)
                    {
                        string s = _selectedStudent.Courses[i].ToString();

                        if (checkedListBoxControl1.Items.Contains(s))
                        {
                            int index = checkedListBoxControl1.Items.IndexOf(s);
                            checkedListBoxControl1.SetItemChecked(index , true);                            
                        }
                        
                        
                    }
                }
                
                
                //checkedListBoxControl1.check
            }
            else
            {                
                textName.Text = string.Empty;
                textAge.Text = "0";
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectStudent();

            DisplayStudent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //New
            Student student = new Student();

            Students.Add(student);

            ShowList();

            listBox1.SelectedIndex = Students.IndexOf(student);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateStudent();

            ShowList();
        }

        private void ShowList()
        {
            listBox1.Items.Clear();
            if(Students != null)
            {
                foreach (Student item in Students)
                {
                    if (item != null)
                    {
                        listBox1.Items.Add(string.Format("{0}", item.Name));
                    }
                }
            }                        
        }

        private void UpdateStudent()
        {
            _originalStudent = _selectedStudent.ShallowCopy();

            _selectedStudent.Name = textName.Text;
            _selectedStudent.Age = Convert.ToInt32(textAge.Text);
            _selectedStudent.RegistrationNumber = Convert.ToInt32(textRegNumber.Text);

            if (checkedListBoxControl1.CheckedItems.Count != 0)
            {
                bool flag = false;
                for (int i = 0; i < checkedListBoxControl1.CheckedItems.Count; i++)
                {                                      
                    string s = checkedListBoxControl1.CheckedItems[i].ToString();
                    if (_selectedStudent.Courses != null)
                    {
                        for (int j = 0; j < _selectedStudent.Courses.Count; j++)
                        {
                            if (_selectedStudent.Courses[j].Subject.Contains(s))
                            {
                                flag = true;
                            }
                        }
                    }                    
                    if (!flag)
                    {
                        Course c = new Course { Subject = s, Code = "1" };
                        _selectedStudent.Courses.Add(c);
                    }
                }                
            }            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textAge_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
