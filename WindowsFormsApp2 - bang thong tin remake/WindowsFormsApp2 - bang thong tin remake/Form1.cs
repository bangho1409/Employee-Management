using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2___bang_thong_tin_remake
{
    public partial class Form1 : Form
    {
        static Employee[] emp = new Employee[100];
        static int l = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(Cursor.Position);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string namenv = name.Text;
            string agenv = age.Text;
            string addressnv = address.Text;
            string shiftnv = shift.Text;
            string jobnv = job.Text;
            string paynv = pay.Text;
           
            if (checkname(namenv) == false)
            {
                InsertData(l, namenv, agenv, addressnv,shiftnv, jobnv, paynv); l++;
                listbox.Items.Add(name.Text.ToString());
            }

        }
        static int getEmpIdx(String id)
        {
            for (int i = 0; i < l; i++)
                if (emp[i].getname() == id)
                    return i;

            return -1;
        }

        static bool checkname(String id)
        {
            for (int i = 0; i < l; i++)
                if (emp[i].getname() == id)
                    return true;

            return false;
        }


        static void InsertData(int lx, string nanv, string agnv, string addnv, string ronv, string jonv,string panv)
        {
            emp[lx] = new Employee(nanv, agnv, addnv, ronv, jonv,panv);

        }



        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void room_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = ((dynamic)sender).SelectedIndex;
            Employee selectedEmp = emp[selectedIndex];
            if (selectedEmp == null) return;
            richTextBox1.Text = "Name: \t" + selectedEmp.getname()
                + "\n\n Age: \t" + selectedEmp.getage()
                + "\n\n Address: \t" + selectedEmp.getaddress()
                + "\n\n Shift: \t" + selectedEmp.getshift()
                + "\n\n Job: \t" + selectedEmp.getjob()
                + "\n\n Payrate: " + selectedEmp.getpay();
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("E:\\emp.text");
            txt.Write(richTextBox1.Text);
            txt.Close();
        }
    }
}
