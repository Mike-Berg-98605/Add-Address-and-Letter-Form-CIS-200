using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddAddressForm : Form
    {
        public AddAddressForm()
        {
            InitializeComponent();
        }
       
        internal string AddName
        {
            //precondition: none
            //postcondition: name set
            get { return addNameTxt.Text;  }
            set { addNameTxt.Text = value; }
        }
        internal string Address1
        {
            //precondition: none
            //postcondition: address set
            get { return add1Txt.Text;  }
            set { add1Txt.Text = value; }
        }
        internal string Address2
        {
            //precondition: none
            //postcondition: address set
            get { return add2Txt.Text; }
            set { add2Txt.Text = value; }
        }
        internal string City
        {
            //precondition: none
            //postcondition: city set
            get { return addCityTxt.Text; }            
        }
        internal string State
        {
            //precondition: none
            //postcondition: state set
            get { return addStateCombo.Text; }
            set { addStateCombo.Text = value; }
        }        
        internal int Zip
        {
            //precondition: none
            //postcondition: zip set
            get { return int.Parse(addZipTxt.Text); }           
            
        }       

        //precondition: addressese selected
        //postcondition: addresses added or not
        private void addAddress_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;               
            }
            
            
        }
        //precondition: none
        //postcondition: form canceled
        private void cancel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
        //preconditon: none
        //postcondition: text validated or not
        private void StringTextValidating(object sender, CancelEventArgs e)
        {
            string name;

            if (String.IsNullOrEmpty(addNameTxt.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(addNameTxt, "Enter a name!");
                addNameTxt.SelectAll();
            }
            else
                name = addNameTxt.Text;
        }              
        //precondition: none
        //postcondition: combobox validate or not
        private void addStateCombo_Validating(object sender, CancelEventArgs e)
        {
            string state;            

            if (addStateCombo.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider5.SetError(addStateCombo, "Pick a state!");
                addStateCombo.SelectAll();
            }
            else
                state = addStateCombo.Text;
        }       
        //precondition: none
        //postcondition: zip validated
        private void addZipTxt_Validating(object sender, CancelEventArgs e)
        {
            
            int zip;
            if (!int.TryParse(addZipTxt.Text, out zip) || zip < Address.MIN_ZIP || zip > Address.MAX_ZIP) 
            {
                e.Cancel = true;
                errorProvider6.SetError(addZipTxt, "Enter an a Zip!");
                addZipTxt.SelectAll();
            }                           
                
        }        

        private void AddAddressForm_Load(object sender, EventArgs e)
        {

        }
        //precondition: none
        //postcondition: form closed
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //preconditon: none
        //postcondition: form validated
        private void AddAddressForm_Validated(object sender, EventArgs e)
        {
            Control control = sender as Control; 
            errorProvider1.SetError(control, "");
        }
    }
}
