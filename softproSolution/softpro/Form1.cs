using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softpro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1Container db;
        Customer _selectedCustomer;
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Model1Container();

          
            dataGridView1.DataSource = db.CustomerSet.ToList();
            dataGridViewRoom.DataSource = db.RoomSet.ToList();
            buttonNew.PerformClick();//click 
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int idCus =Convert.ToInt32(textBoxIdCus.Text);//Convert string to int 
            var queryCus = from cus in db.CustomerSet// query cus whith id 
                           where cus.Id == idCus // if true
                           select cus;
            foreach (var cu in queryCus)
            {
               //MessageBox.Show(cu.FirstName +"  " +cu.LastName);
                db.CustomerSet.Remove(cu);
            }
            db.SaveChanges();

            dataGridView1.DataSource = db.CustomerSet.ToList();
        }

        private void buttonUpDate_Click(object sender, EventArgs e)
        {
            string fistName = textBoxFirst.Text;
            string lastName = textBoxLast.Text;
            int idCus = Convert.ToInt32(textBoxIdCus.Text);//Convert string to int 
            var queryCus = from cus in db.CustomerSet// query cus whith id 
                           where cus.Id == idCus // if true
                           select cus;
            foreach (var cu in queryCus)
            {
                //MessageBox.Show(cu.FirstName +"  " +cu.LastName);
                //db.CustomerSet.Remove(cu);
                cu.FirstName = fistName;
                cu.LastName = lastName;
               
            }
            db.SaveChanges();

            dataGridView1.DataSource = db.CustomerSet.ToList();
           
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            _selectedCustomer = new Customer() { 
                Id=0,
                FirstName="",
                LastName=""
            
            };

            textBoxIdCus.Text = _selectedCustomer.Id.ToString();
            textBoxFirst.Text = _selectedCustomer.FirstName;
            textBoxLast.Text = _selectedCustomer.LastName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedCustomer.Id = Convert.ToInt32(textBoxIdCus.Text);
            _selectedCustomer.FirstName = textBoxFirst.Text;
            _selectedCustomer.LastName = textBoxLast.Text;


            db.CustomerSet.Add(_selectedCustomer);
            db.SaveChanges();

            dataGridView1.DataSource = db.CustomerSet.ToList();
        }
    }
}
