using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamSummer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PatientData db = new PatientData(); //Link to the Database

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var patientQuery = from p in db.Patients //fetch the patients from the data base
                               orderby p.Surname
                               select p;

            lbx_ListofPatients.ItemsSource = patientQuery.ToList(); //Adds to a list

        }

        private void btn_AddPatient_MouseDown(object sender, MouseButtonEventArgs e)  //Button Down to get inputted data
        {
            Patient newPatient = new Patient();
            tbx_FirstName.Text = newPatient.FirstName;
            tbx_Surname.Text = newPatient.Surname;
            tbx_PhoneNumber.Text = newPatient.ContactNumber;
            datepick_DOB.SelectedDate = newPatient.DOB;

            db.Patients.Add(newPatient); //Add to to list

            var newlistofpatients = from p in db.Patients
                                    orderby p.Surname
                                    select p;

            lbx_ListofPatients.ItemsSource= newlistofpatients.ToList();
        }

        private void btn_AddAppointments_Click(object sender, RoutedEventArgs e)
        {

            AppointmentWindow addApointmentWindow = new AppointmentWindow(); //Open New Window 

            // I couldnt create an event Handler, it gave me an error i took a screen shot
            addApointmentWindow.Show();
        }
    }
}
