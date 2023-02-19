using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//<Micael Bergamini
//ID: 1416810
//Program 2

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; //creates user Parcel view instance
        
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            //Test data
            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202);
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210);
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901);
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101);

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(1), 2.19M);
            upv.AddLetter(upv.AddressAt(2), upv.AddressAt(3), 2.99M);

            
        }       
               
        //Precondition: Form Loads
        //Postcondition: info displayed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: 1416810\n" +
                "CIS 200-50\n" +
                "Program 2\n" +
                "This program explores the creation of a simple GUI, use of " +
                "dialog boxes, validation, and exception handling. ");
        }
        //precondition: form loads
        //postcondition: form closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //precondition: form is created
        //postcondition: new address is created
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressForm addressForm = new AddAddressForm();
            DialogResult result;
            string name;
            string add1;
            string add2;
            string city;
            string state;
            int zip;

            result = addressForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                name = addressForm.AddName;
                add1 = addressForm.Address1;
                add2 = addressForm.Address2;
                city = addressForm.City;
                state = addressForm.State;
                zip = addressForm.Zip;

                upv.AddAddress(name, add1, add2, city, state, zip);
            }
        }
        //precondition: letter form exists
        //postcondition: new letter is created
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLetterForm letterForm = new AddLetterForm(upv.AddressList);
            DialogResult result;            
            decimal fixedCost;
            
            if (upv.AddressCount < 1)
            {
                MessageBox.Show("Need 1 address to create a letter");
                return;
            }

            result = letterForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                fixedCost = letterForm.FixedCost;

                upv.AddLetter(upv.AddressAt(letterForm.Origon), upv.AddressAt(letterForm.Destination), fixedCost);
                
            }

            
        }
        //accidental form click
        private void Prog2Form_Load(object sender, EventArgs e)
        {
            
        }
        //precondition: addresses exist
        //postcondition: addresses are displayed
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "Adress List\r\n" +
                "--------------------------\r\n";
            foreach (Address a in upv.addresses)
            {               
                output += $"{a}\r\n\r\n";
            }
            mainOutput.Text = output;
        }        
        //precondition: parcels exist
        //postcondition: parcels are displayed
        private void listParcelsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string output = "Parcel List\r\n" +
                "--------------------------\r\n";
            foreach (Parcel p in upv.parcels)
            {
                output += $"{p}\r\n\r\n" +
                    $"--------------------------------\r\n";
            }
            mainOutput.Text = output.ToString();
        }
    }
}
