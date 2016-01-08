namespace NoteBook
{
    partial class NoteBook
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Notes = new System.Windows.Forms.DataGridView();
            this.FirstNameAndLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.deleteNumber = new System.Windows.Forms.Button();
            this.addNumber = new System.Windows.Forms.Button();
            this.Numbers = new System.Windows.Forms.Label();
            this.NoteNumbers = new System.Windows.Forms.ListView();
            this.Description = new System.Windows.Forms.Label();
            this.NoteDescription = new System.Windows.Forms.RichTextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.NumberBox = new System.Windows.Forms.GroupBox();
            this.closeNumbPanel = new System.Windows.Forms.Button();
            this.Addn = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.NumberType = new System.Windows.Forms.ComboBox();
            this.FullName = new System.Windows.Forms.GroupBox();
            this.PatronymicN = new System.Windows.Forms.Label();
            this.LastN = new System.Windows.Forms.Label();
            this.FirstN = new System.Windows.Forms.Label();
            this.Patronymic = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).BeginInit();
            this.InfoPanel.SuspendLayout();
            this.NumberBox.SuspendLayout();
            this.FullName.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notes
            // 
            this.Notes.AllowUserToAddRows = false;
            this.Notes.BackgroundColor = System.Drawing.Color.White;
            this.Notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Notes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstNameAndLastName});
            this.Notes.GridColor = System.Drawing.Color.White;
            this.Notes.Location = new System.Drawing.Point(3, 48);
            this.Notes.Name = "Notes";
            this.Notes.RowHeadersVisible = false;
            this.Notes.Size = new System.Drawing.Size(247, 247);
            this.Notes.TabIndex = 0;
            this.Notes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Notes_CellClick);
            // 
            // FirstNameAndLastName
            // 
            this.FirstNameAndLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstNameAndLastName.HeaderText = "";
            this.FirstNameAndLastName.Name = "FirstNameAndLastName";
            this.FirstNameAndLastName.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(109, 6);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(67, 32);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(182, 6);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(68, 32);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Visible = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.deleteNumber);
            this.InfoPanel.Controls.Add(this.addNumber);
            this.InfoPanel.Controls.Add(this.Numbers);
            this.InfoPanel.Controls.Add(this.NoteNumbers);
            this.InfoPanel.Controls.Add(this.Description);
            this.InfoPanel.Controls.Add(this.NoteDescription);
            this.InfoPanel.Controls.Add(this.Accept);
            this.InfoPanel.Controls.Add(this.NumberBox);
            this.InfoPanel.Controls.Add(this.FullName);
            this.InfoPanel.Location = new System.Drawing.Point(262, 6);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(279, 298);
            this.InfoPanel.TabIndex = 4;
            this.InfoPanel.Visible = false;
            // 
            // deleteNumber
            // 
            this.deleteNumber.Location = new System.Drawing.Point(29, 124);
            this.deleteNumber.Name = "deleteNumber";
            this.deleteNumber.Size = new System.Drawing.Size(22, 23);
            this.deleteNumber.TabIndex = 18;
            this.deleteNumber.Text = "-";
            this.deleteNumber.UseVisualStyleBackColor = true;
            this.deleteNumber.Click += new System.EventHandler(this.deleteNumber_Click);
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(3, 124);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(20, 23);
            this.addNumber.TabIndex = 17;
            this.addNumber.Text = "+";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.Addnumber_Click);
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Location = new System.Drawing.Point(0, 105);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(49, 13);
            this.Numbers.TabIndex = 16;
            this.Numbers.Text = "Numbers";
            // 
            // NoteNumbers
            // 
            this.NoteNumbers.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.NoteNumbers.Location = new System.Drawing.Point(3, 153);
            this.NoteNumbers.Name = "NoteNumbers";
            this.NoteNumbers.Size = new System.Drawing.Size(99, 66);
            this.NoteNumbers.TabIndex = 15;
            this.NoteNumbers.UseCompatibleStateImageBehavior = false;
            this.NoteNumbers.View = System.Windows.Forms.View.List;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(0, 222);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 14;
            this.Description.Text = "Description";
            // 
            // NoteDescription
            // 
            this.NoteDescription.Location = new System.Drawing.Point(3, 238);
            this.NoteDescription.Name = "NoteDescription";
            this.NoteDescription.Size = new System.Drawing.Size(263, 51);
            this.NoteDescription.TabIndex = 13;
            this.NoteDescription.Text = "";
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(196, 2);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(58, 30);
            this.Accept.TabIndex = 12;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // NumberBox
            // 
            this.NumberBox.Controls.Add(this.label1);
            this.NumberBox.Controls.Add(this.closeNumbPanel);
            this.NumberBox.Controls.Add(this.Addn);
            this.NumberBox.Controls.Add(this.PhoneNumber);
            this.NumberBox.Controls.Add(this.NumberType);
            this.NumberBox.Location = new System.Drawing.Point(111, 117);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(143, 102);
            this.NumberBox.TabIndex = 11;
            this.NumberBox.TabStop = false;
            this.NumberBox.Text = "Number";
            // 
            // closeNumbPanel
            // 
            this.closeNumbPanel.Location = new System.Drawing.Point(70, 72);
            this.closeNumbPanel.Name = "closeNumbPanel";
            this.closeNumbPanel.Size = new System.Drawing.Size(58, 23);
            this.closeNumbPanel.TabIndex = 14;
            this.closeNumbPanel.Text = "Close";
            this.closeNumbPanel.UseVisualStyleBackColor = true;
            this.closeNumbPanel.Click += new System.EventHandler(this.closeNumbPanel_Click);
            // 
            // Addn
            // 
            this.Addn.Location = new System.Drawing.Point(6, 73);
            this.Addn.Name = "Addn";
            this.Addn.Size = new System.Drawing.Size(58, 23);
            this.Addn.TabIndex = 13;
            this.Addn.Text = "Add";
            this.Addn.UseVisualStyleBackColor = true;
            this.Addn.Click += new System.EventHandler(this.Addn_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(6, 46);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.PhoneNumber.TabIndex = 12;
            // 
            // NumberType
            // 
            this.NumberType.AllowDrop = true;
            this.NumberType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NumberType.FormattingEnabled = true;
            this.NumberType.Location = new System.Drawing.Point(6, 19);
            this.NumberType.Name = "NumberType";
            this.NumberType.Size = new System.Drawing.Size(58, 21);
            this.NumberType.Sorted = true;
            this.NumberType.TabIndex = 6;
            // 
            // FullName
            // 
            this.FullName.Controls.Add(this.PatronymicN);
            this.FullName.Controls.Add(this.LastN);
            this.FullName.Controls.Add(this.FirstN);
            this.FullName.Controls.Add(this.Patronymic);
            this.FullName.Controls.Add(this.LastName);
            this.FullName.Controls.Add(this.FirstName);
            this.FullName.Location = new System.Drawing.Point(3, 2);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(187, 100);
            this.FullName.TabIndex = 10;
            this.FullName.TabStop = false;
            this.FullName.Text = "Full Name";
            // 
            // PatronymicN
            // 
            this.PatronymicN.AutoSize = true;
            this.PatronymicN.Location = new System.Drawing.Point(20, 69);
            this.PatronymicN.Name = "PatronymicN";
            this.PatronymicN.Size = new System.Drawing.Size(59, 13);
            this.PatronymicN.TabIndex = 11;
            this.PatronymicN.Text = "Patronymic";
            // 
            // LastN
            // 
            this.LastN.AutoSize = true;
            this.LastN.Location = new System.Drawing.Point(20, 43);
            this.LastN.Name = "LastN";
            this.LastN.Size = new System.Drawing.Size(58, 13);
            this.LastN.TabIndex = 10;
            this.LastN.Text = "Last Name";
            // 
            // FirstN
            // 
            this.FirstN.AutoSize = true;
            this.FirstN.Location = new System.Drawing.Point(19, 17);
            this.FirstN.Name = "FirstN";
            this.FirstN.Size = new System.Drawing.Size(57, 13);
            this.FirstN.TabIndex = 9;
            this.FirstN.Text = "First Name";
            // 
            // Patronymic
            // 
            this.Patronymic.Location = new System.Drawing.Point(82, 66);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(100, 20);
            this.Patronymic.TabIndex = 8;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(82, 40);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 7;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(82, 14);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(3, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(103, 32);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "";
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type";
            // 
            // NoteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(569, 319);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Notes);
            this.Name = "NoteBook";
            this.Text = "NoteBook";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NoteBook_FormClosed);
            this.Load += new System.EventHandler(this.NoteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notes)).EndInit();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.NumberBox.ResumeLayout(false);
            this.NumberBox.PerformLayout();
            this.FullName.ResumeLayout(false);
            this.FullName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstNameAndLastName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.GroupBox NumberBox;
        private System.Windows.Forms.GroupBox FullName;
        private System.Windows.Forms.Label PatronymicN;
        private System.Windows.Forms.Label LastN;
        private System.Windows.Forms.Label FirstN;
        private System.Windows.Forms.TextBox Patronymic;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.RichTextBox NoteDescription;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label Numbers;
        private System.Windows.Forms.ListView NoteNumbers;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Button Addn;
        private System.Windows.Forms.ComboBox NumberType;
        private System.Windows.Forms.Button deleteNumber;
        private System.Windows.Forms.RichTextBox SearchBox;
        private System.Windows.Forms.Button closeNumbPanel;
        private System.Windows.Forms.Label label1;
    }
}

