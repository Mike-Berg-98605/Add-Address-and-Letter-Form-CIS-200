
namespace UPVApp
{
    partial class AddLetterForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.OriginCombo = new System.Windows.Forms.ComboBox();
            this.DestinationCombo = new System.Windows.Forms.ComboBox();
            this.fixedCostTxt = new System.Windows.Forms.TextBox();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddLetter = new System.Windows.Forms.Button();
            this.buttonCancelLetter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fixed Cost:";
            // 
            // OriginCombo
            // 
            this.OriginCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginCombo.FormattingEnabled = true;
            this.OriginCombo.Location = new System.Drawing.Point(180, 64);
            this.OriginCombo.Name = "OriginCombo";
            this.OriginCombo.Size = new System.Drawing.Size(121, 24);
            this.OriginCombo.TabIndex = 3;
            this.OriginCombo.SelectedIndexChanged += new System.EventHandler(this.OriginCombo_SelectedIndexChanged);
            this.OriginCombo.Validating += new System.ComponentModel.CancelEventHandler(this.AddressCombo_Validating);
            this.OriginCombo.Validated += new System.EventHandler(this.AddLetterFields_Validated);
            // 
            // DestinationCombo
            // 
            this.DestinationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DestinationCombo.FormattingEnabled = true;
            this.DestinationCombo.Location = new System.Drawing.Point(180, 111);
            this.DestinationCombo.Name = "DestinationCombo";
            this.DestinationCombo.Size = new System.Drawing.Size(121, 24);
            this.DestinationCombo.TabIndex = 4;
            this.DestinationCombo.SelectedIndexChanged += new System.EventHandler(this.DestinationCombo_SelectedIndexChanged);
            this.DestinationCombo.Validating += new System.ComponentModel.CancelEventHandler(this.AddressCombo_Validating);
            this.DestinationCombo.Validated += new System.EventHandler(this.AddLetterFields_Validated);
            // 
            // fixedCostTxt
            // 
            this.fixedCostTxt.Location = new System.Drawing.Point(180, 158);
            this.fixedCostTxt.Name = "fixedCostTxt";
            this.fixedCostTxt.Size = new System.Drawing.Size(100, 22);
            this.fixedCostTxt.TabIndex = 5;
            this.fixedCostTxt.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTxt_Validating);
            this.fixedCostTxt.Validated += new System.EventHandler(this.AddLetterFields_Validated);
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(Address);
            // 
            // buttonAddLetter
            // 
            this.buttonAddLetter.Location = new System.Drawing.Point(36, 272);
            this.buttonAddLetter.Name = "buttonAddLetter";
            this.buttonAddLetter.Size = new System.Drawing.Size(136, 47);
            this.buttonAddLetter.TabIndex = 6;
            this.buttonAddLetter.Text = "Add Letter";
            this.buttonAddLetter.UseVisualStyleBackColor = true;
            this.buttonAddLetter.Click += new System.EventHandler(this.buttonAddLetter_Click);
            // 
            // buttonCancelLetter
            // 
            this.buttonCancelLetter.Location = new System.Drawing.Point(217, 272);
            this.buttonCancelLetter.Name = "buttonCancelLetter";
            this.buttonCancelLetter.Size = new System.Drawing.Size(133, 47);
            this.buttonCancelLetter.TabIndex = 7;
            this.buttonCancelLetter.Text = "Cancel";
            this.buttonCancelLetter.UseVisualStyleBackColor = true;
            this.buttonCancelLetter.Click += new System.EventHandler(this.buttonCancelLetter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 417);
            this.Controls.Add(this.buttonCancelLetter);
            this.Controls.Add(this.buttonAddLetter);
            this.Controls.Add(this.fixedCostTxt);
            this.Controls.Add(this.DestinationCombo);
            this.Controls.Add(this.OriginCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLetterForm";
            this.Text = "Add Letter Form";
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OriginCombo;
        private System.Windows.Forms.ComboBox DestinationCombo;
        private System.Windows.Forms.TextBox fixedCostTxt;
        private System.Windows.Forms.BindingSource addressBindingSource;
        private System.Windows.Forms.Button buttonAddLetter;
        private System.Windows.Forms.Button buttonCancelLetter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}