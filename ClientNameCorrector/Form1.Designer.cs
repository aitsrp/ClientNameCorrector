namespace ClientNameCorrector
{
    partial class Form1
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
            this.textBoxInputClient = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBoxClientList = new System.Windows.Forms.ComboBox();
            this.labelInputClient = new System.Windows.Forms.Label();
            this.labelClientList = new System.Windows.Forms.Label();
            this.listBoxDBContents = new System.Windows.Forms.ListBox();
            this.buttonAddToCountry = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelCountryList = new System.Windows.Forms.Label();
            this.labelInputCountry = new System.Windows.Forms.Label();
            this.comboBoxCountryList = new System.Windows.Forms.ComboBox();
            this.textBoxInputCountry = new System.Windows.Forms.TextBox();
            this.buttonAddToClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputClient
            // 
            this.textBoxInputClient.Location = new System.Drawing.Point(12, 30);
            this.textBoxInputClient.Name = "textBoxInputClient";
            this.textBoxInputClient.Size = new System.Drawing.Size(264, 20);
            this.textBoxInputClient.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 382);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(627, 134);
            this.textBox3.TabIndex = 2;
            // 
            // comboBoxClientList
            // 
            this.comboBoxClientList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClientList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxClientList.FormattingEnabled = true;
            this.comboBoxClientList.Location = new System.Drawing.Point(12, 98);
            this.comboBoxClientList.Name = "comboBoxClientList";
            this.comboBoxClientList.Size = new System.Drawing.Size(264, 21);
            this.comboBoxClientList.TabIndex = 3;
            this.comboBoxClientList.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientList_SelectedIndexChanged);
            // 
            // labelInputClient
            // 
            this.labelInputClient.AutoSize = true;
            this.labelInputClient.Location = new System.Drawing.Point(12, 14);
            this.labelInputClient.Name = "labelInputClient";
            this.labelInputClient.Size = new System.Drawing.Size(171, 13);
            this.labelInputClient.TabIndex = 4;
            this.labelInputClient.Text = "Type in the misspelled client name:";
            // 
            // labelClientList
            // 
            this.labelClientList.AutoSize = true;
            this.labelClientList.Location = new System.Drawing.Point(12, 82);
            this.labelClientList.Name = "labelClientList";
            this.labelClientList.Size = new System.Drawing.Size(157, 13);
            this.labelClientList.TabIndex = 5;
            this.labelClientList.Text = "Choose the correct client name:";
            // 
            // listBoxDBContents
            // 
            this.listBoxDBContents.FormattingEnabled = true;
            this.listBoxDBContents.Location = new System.Drawing.Point(282, 30);
            this.listBoxDBContents.Name = "listBoxDBContents";
            this.listBoxDBContents.Size = new System.Drawing.Size(333, 277);
            this.listBoxDBContents.TabIndex = 6;
            // 
            // buttonAddToCountry
            // 
            this.buttonAddToCountry.Location = new System.Drawing.Point(12, 229);
            this.buttonAddToCountry.Name = "buttonAddToCountry";
            this.buttonAddToCountry.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToCountry.TabIndex = 7;
            this.buttonAddToCountry.Text = "Add";
            this.buttonAddToCountry.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(540, 313);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // labelCountryList
            // 
            this.labelCountryList.AutoSize = true;
            this.labelCountryList.Location = new System.Drawing.Point(9, 255);
            this.labelCountryList.Name = "labelCountryList";
            this.labelCountryList.Size = new System.Drawing.Size(167, 13);
            this.labelCountryList.TabIndex = 12;
            this.labelCountryList.Text = "Choose the correct country name:";
            // 
            // labelInputCountry
            // 
            this.labelInputCountry.AutoSize = true;
            this.labelInputCountry.Location = new System.Drawing.Point(12, 187);
            this.labelInputCountry.Name = "labelInputCountry";
            this.labelInputCountry.Size = new System.Drawing.Size(181, 13);
            this.labelInputCountry.TabIndex = 11;
            this.labelInputCountry.Text = "Type in the misspelled country name:";
            // 
            // comboBoxCountryList
            // 
            this.comboBoxCountryList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCountryList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxCountryList.FormattingEnabled = true;
            this.comboBoxCountryList.Location = new System.Drawing.Point(9, 271);
            this.comboBoxCountryList.Name = "comboBoxCountryList";
            this.comboBoxCountryList.Size = new System.Drawing.Size(267, 21);
            this.comboBoxCountryList.TabIndex = 10;
            // 
            // textBoxInputCountry
            // 
            this.textBoxInputCountry.Location = new System.Drawing.Point(12, 203);
            this.textBoxInputCountry.Name = "textBoxInputCountry";
            this.textBoxInputCountry.Size = new System.Drawing.Size(264, 20);
            this.textBoxInputCountry.TabIndex = 9;
            // 
            // buttonAddToClient
            // 
            this.buttonAddToClient.Location = new System.Drawing.Point(12, 56);
            this.buttonAddToClient.Name = "buttonAddToClient";
            this.buttonAddToClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToClient.TabIndex = 13;
            this.buttonAddToClient.Text = "Add";
            this.buttonAddToClient.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 515);
            this.Controls.Add(this.buttonAddToClient);
            this.Controls.Add(this.labelCountryList);
            this.Controls.Add(this.labelInputCountry);
            this.Controls.Add(this.comboBoxCountryList);
            this.Controls.Add(this.textBoxInputCountry);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddToCountry);
            this.Controls.Add(this.listBoxDBContents);
            this.Controls.Add(this.labelClientList);
            this.Controls.Add(this.labelInputClient);
            this.Controls.Add(this.comboBoxClientList);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxInputClient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputClient;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBoxClientList;
        private System.Windows.Forms.Label labelInputClient;
        private System.Windows.Forms.Label labelClientList;
        private System.Windows.Forms.ListBox listBoxDBContents;
        private System.Windows.Forms.Button buttonAddToCountry;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelCountryList;
        private System.Windows.Forms.Label labelInputCountry;
        private System.Windows.Forms.ComboBox comboBoxCountryList;
        private System.Windows.Forms.TextBox textBoxInputCountry;
        private System.Windows.Forms.Button buttonAddToClient;
    }
}

