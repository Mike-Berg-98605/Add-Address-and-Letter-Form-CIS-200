
namespace UPVApp
{
    partial class AddAddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addNameTxt = new System.Windows.Forms.TextBox();
            this.add1Txt = new System.Windows.Forms.TextBox();
            this.add2Txt = new System.Windows.Forms.TextBox();
            this.addCityTxt = new System.Windows.Forms.TextBox();
            this.addZipTxt = new System.Windows.Forms.TextBox();
            this.addAddress = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.addStateCombo = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "ZIP:";
            // 
            // addNameTxt
            // 
            this.addNameTxt.Location = new System.Drawing.Point(103, 57);
            this.addNameTxt.Name = "addNameTxt";
            this.addNameTxt.Size = new System.Drawing.Size(100, 22);
            this.addNameTxt.TabIndex = 6;
            this.addNameTxt.Validating += new System.ComponentModel.CancelEventHandler(this.StringTextValidating);
            this.addNameTxt.Validated += new System.EventHandler(this.AddAddressForm_Validated);
            // 
            // add1Txt
            // 
            this.add1Txt.Location = new System.Drawing.Point(103, 94);
            this.add1Txt.Name = "add1Txt";
            this.add1Txt.Size = new System.Drawing.Size(100, 22);
            this.add1Txt.TabIndex = 7;
            this.add1Txt.Validating += new System.ComponentModel.CancelEventHandler(this.StringTextValidating);
            this.add1Txt.Validated += new System.EventHandler(this.AddAddressForm_Validated);
            // 
            // add2Txt
            // 
            this.add2Txt.Location = new System.Drawing.Point(103, 136);
            this.add2Txt.Name = "add2Txt";
            this.add2Txt.Size = new System.Drawing.Size(100, 22);
            this.add2Txt.TabIndex = 8;
            // 
            // addCityTxt
            // 
            this.addCityTxt.Location = new System.Drawing.Point(102, 174);
            this.addCityTxt.Name = "addCityTxt";
            this.addCityTxt.Size = new System.Drawing.Size(100, 22);
            this.addCityTxt.TabIndex = 9;
            this.addCityTxt.Validating += new System.ComponentModel.CancelEventHandler(this.StringTextValidating);
            this.addCityTxt.Validated += new System.EventHandler(this.AddAddressForm_Validated);
            // 
            // addZipTxt
            // 
            this.addZipTxt.Location = new System.Drawing.Point(103, 257);
            this.addZipTxt.Name = "addZipTxt";
            this.addZipTxt.Size = new System.Drawing.Size(100, 22);
            this.addZipTxt.TabIndex = 11;
            this.addZipTxt.Validating += new System.ComponentModel.CancelEventHandler(this.addZipTxt_Validating);
            this.addZipTxt.Validated += new System.EventHandler(this.AddAddressForm_Validated);
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(50, 316);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(117, 40);
            this.addAddress.TabIndex = 12;
            this.addAddress.Text = "Add Address";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.addAddress_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(223, 316);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(113, 40);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            this.cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cancel_MouseDown);
            // 
            // addStateCombo
            // 
            this.addStateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addStateCombo.FormattingEnabled = true;
            this.addStateCombo.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MN",
            "MO",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.addStateCombo.Location = new System.Drawing.Point(103, 206);
            this.addStateCombo.Name = "addStateCombo";
            this.addStateCombo.Size = new System.Drawing.Size(121, 24);
            this.addStateCombo.TabIndex = 10;
            this.addStateCombo.Validating += new System.ComponentModel.CancelEventHandler(this.addStateCombo_Validating);
            this.addStateCombo.Validated += new System.EventHandler(this.AddAddressForm_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // AddAddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 398);
            this.Controls.Add(this.addStateCombo);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.addZipTxt);
            this.Controls.Add(this.addCityTxt);
            this.Controls.Add(this.add2Txt);
            this.Controls.Add(this.add1Txt);
            this.Controls.Add(this.addNameTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAddressForm";
            this.Text = "Add Address Form";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddAddressForm_Load);
            this.Validated += new System.EventHandler(this.AddAddressForm_Validated);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addNameTxt;
        private System.Windows.Forms.TextBox add1Txt;
        private System.Windows.Forms.TextBox add2Txt;
        private System.Windows.Forms.TextBox addCityTxt;
        private System.Windows.Forms.TextBox addZipTxt;
        private System.Windows.Forms.Button addAddress;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ComboBox addStateCombo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}