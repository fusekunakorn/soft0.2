using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softpro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model1Container db = new Model1Container();
            var queryCus = (from cus in db.CustomerSet
                           where cus.Id ==1
                           select cus).FirstOrDefault();
            if (queryCus != null)
            {
                Application.Run(new Form1());
            }
            else {
                Spawn();
                Application.Run(new Form1());
            }
        }
        static void Spawn()
        {
            Model1Container db = new Model1Container();
            Customer cus1 = new Customer();
            //cus1.Id = 1;
            cus1.FirstName = "MMM";
            cus1.LastName = "LLL";
            cus1.Sex = true;
            cus1.SSN = "123456789";
            cus1.Tel = "0987654321";


            Customer cus3 = new Customer()
            {
            //    Id = 3,
                FirstName = "BBBB",
                LastName = "dddddd",
                Sex =true,
                SSN="56765434567865",
                Tel="098765456"
            };
           

            db.CustomerSet.Add(cus1);// add add to RAM
            db.SaveChanges();
           
            db.CustomerSet.Add(cus3);
            db.SaveChanges();
          //  db.SaveChanges();
            Room r1 = new Room()
            {
                RoomId = 1,
                Rent = 1700
            };
            db.RoomSet.Add(r1);
            db.SaveChanges();/// add to database
            /// if add succes method return row of addded
            //var cusQ = from cus in db.CustomerSet
            //           where cus.FirstName == "MMM"
            //           select cus;// query result collection
            //foreach (var cu in cusQ)
            //{
            //    MessageBox.Show(cu.FirstName +"  " +cu.LastName);
            //}
        }
    }
}
