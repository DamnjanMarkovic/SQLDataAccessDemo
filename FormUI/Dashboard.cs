using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            Updatebinding();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void Updatebinding()
        {
            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            //people = db.GetPeopleByFirstName(lastNameText.Text);

            people = db.GetPeople(lastNameText.Text);

            Updatebinding();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            db.InsertPerson(firstNameText.Text, lastNameTextInsert.Text, emailAddressText.Text, phoneNUmberText.Text);
            firstNameText.Text = "";
            lastNameTextInsert.Text = "";
            emailAddressText.Text = "";
            phoneNUmberText.Text = "";

        }


    }
}
