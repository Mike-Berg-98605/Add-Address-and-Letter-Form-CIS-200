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
    public partial class AddLetterForm : Form
    {

        internal decimal FixedCost
        {
            //precondition: fixed cost was entered
            //postcondition: fixed cost set
            get { return decimal.Parse(fixedCostTxt.Text); }          
        }
        internal int Origon
        {
            //precondition: origon address selected
            //postcondtion: origon address set
            get { return OriginCombo.SelectedIndex; }
            set { OriginCombo.SelectedIndex = value; }
        }
        internal int Destination
        {
            //precondition: destination address selected
            //postcondition: dest address set
            get { return DestinationCombo.SelectedIndex; }
            set { DestinationCombo.SelectedIndex = value; }
        }        
        public AddLetterForm(List <Address> list)
        {
            InitializeComponent();                      

            foreach (Address a in list)
            {
                OriginCombo.Items.Add(a.Name.ToString());
                DestinationCombo.Items.Add(a.Name.ToString());
            }
        }                   
        
        private void OriginCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           int index = OriginCombo.SelectedIndex;
        }

        private void DestinationCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DestinationCombo.SelectedIndex;
        }
       //precondition: fixed cost is entered
       //postcondition: fixed cost is either accepted or rejected
        private void fixedCostTxt_Validating(object sender, CancelEventArgs e)
        {
            decimal fixedcost;
            if (!decimal.TryParse(fixedCostTxt.Text, out fixedcost))
            {
                e.Cancel = true;
                fixedCostTxt.SelectAll();
                MessageBox.Show("Enter a valid ammount.");
            }
            else if (fixedcost < 0)
                MessageBox.Show("Fixed Cost must be greater than Zero!");                          
                
        }
        //precondition: addresses have been selected
        //postcondition: letter is created
        private void buttonAddLetter_Click(object sender, EventArgs e)
        {
            if (OriginCombo.SelectedIndex != DestinationCombo.SelectedIndex)
            {
                if (this.ValidateChildren())
                {
                    this.DialogResult = DialogResult.OK;

                    MessageBox.Show("Letter has been added!");                }
            }
            else
                MessageBox.Show("Letter cannot be sent to itself!");
        }


        private void buttonCancelLetter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //precondition: address combo boxes have been selected
        //postcondition: letter is validated or not
        private void AddressCombo_Validating(object sender, CancelEventArgs e)
        {
            if (OriginCombo.SelectedIndex == DestinationCombo.SelectedIndex)
            {
                e.Cancel = true;
                MessageBox.Show("Cannot send a letter to yourself!");
            }
            else if (OriginCombo.SelectedIndex == -1 || DestinationCombo.SelectedIndex == -1)
                MessageBox.Show("Select both an origin and destination address");

        }
        //precondition: combo boxes have been selected
        //postondition: letter is created or not
        private void AddLetterFields_Validated(object sender, EventArgs e)
        {
            Control control = sender as Control;
            errorProvider1.SetError(control, "");
        }
    }
}
