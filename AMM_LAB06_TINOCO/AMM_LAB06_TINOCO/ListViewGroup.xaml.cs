using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AMM_LAB06_TINOCO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ListViewGroup()
        {
            InitializeComponent();

            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(
                    new Student
                    {
                        Name = "Nombres " + i.ToString(),
                        Lastname = "Apellidos " + i.ToString(),
                        Address = "Adress" + i.ToString(),
                        Age = i
                    }
                    ); ;
            }
            lvStudents.ItemsSource = students;
        }
    }
}