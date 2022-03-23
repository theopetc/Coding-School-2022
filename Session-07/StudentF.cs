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
    public partial class StudentF : Form
    {
        public List<Student> Students { get; set; }

        private Student _selectedStudent = new Student();
        private Student _originalStudent = new Student();
        public StudentF()
        {
            InitializeComponent();
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            //University university = new University();
            //university.Students = new List<Student>();


            //Student student = new Student();    
            //Students.Add(student);


            bsStudents.DataSource = Students;
            
            //bsStudents.




            SetDataBindings();
            ShowList();
        }

        private void SetDataBindings()
        {            
            ctrlAge.DataBindings.Add(new Binding("EditValue", bsStudents, "Age", true));
            ctrlListBox.DataBindings.Add(new Binding("ValueMember", bsStudents, "Name", true));
        }

        private void listBoxSelectedIndexChanged()
        {
            
        }



        private void SelectStudent()
        {            
            if (_selectedStudent != null)
            {
                _selectedStudent = Students[ctrlListBox.SelectedIndex];
            }
        }
        private void DisplayStudent()
        {
            if (_selectedStudent != null)
            {
                ctrlName.Text = _selectedStudent.Name;
                ctrlAge.Text = _selectedStudent.Age.ToString(); 
                ctrlRegNumber.Text = _selectedStudent.RegistrationNumber.ToString();

                if ((_selectedStudent.Courses != null) && (_selectedStudent.Courses.Count != 0))
                {
                    for (int i = 0; i < _selectedStudent.Courses.Count; i++)
                    {
                        string s = _selectedStudent.Courses[i].ToString();

                        if (ctrlCourses.Items.Contains(s))
                        {
                            int index = ctrlCourses.Items.IndexOf(s);
                            ctrlCourses.SetItemChecked(index , true);                            
                        }
                        
                        
                    }
                }                                                
            }
            else
            {                
                ctrlName.Text = string.Empty;
                ctrlAge.Text = "0";
            }
        }        
        private void ShowList()
        {
            ctrlListBox.Items.Clear();
            if(Students != null)
            {
                foreach (Student item in Students)
                {
                    if (item != null)
                    {
                        ctrlListBox.Items.Add(string.Format("{0}", item.Name));
                    }
                }
            }                        
        }
        private void UpdateStudent()
        {
            _originalStudent = _selectedStudent.ShallowCopy();

            _selectedStudent.Name = ctrlName.Text;
            _selectedStudent.Age = Convert.ToInt32(ctrlAge.Text);
            _selectedStudent.RegistrationNumber = Convert.ToInt32(ctrlRegNumber.Text);

            if (ctrlCourses.CheckedItems.Count != 0)
            {
                bool flag = false;
                for (int i = 0; i < ctrlCourses.CheckedItems.Count; i++)
                {                                      
                    string s = ctrlCourses.CheckedItems[i].ToString();
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

        private void listBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            
            string selectedName = listBox.SelectedItem.ToString();

                        






            //bsListBox.DataSource = listBox;
            //ctrlName.DataBindings.Add(new Binding("EditValue", bsListBox, "SelectedItem", true));
        }
    }
}
