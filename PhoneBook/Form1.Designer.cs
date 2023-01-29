
namespace PhoneBook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstName_TextBox = new System.Windows.Forms.TextBox();
            this.LastName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumber_TextBox = new System.Windows.Forms.TextBox();
            this.AddPhoneBook_Button = new System.Windows.Forms.Button();
            this.Human_ListBox = new System.Windows.Forms.ListBox();
            this.Search_TextBox = new System.Windows.Forms.TextBox();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Search_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LastName_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.FirstName_RadioButton = new System.Windows.Forms.RadioButton();
            this.DeleteHuman_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstName_TextBox
            // 
            this.FirstName_TextBox.Location = new System.Drawing.Point(12, 135);
            this.FirstName_TextBox.Name = "FirstName_TextBox";
            this.FirstName_TextBox.Size = new System.Drawing.Size(238, 22);
            this.FirstName_TextBox.TabIndex = 0;
            // 
            // LastName_TextBox
            // 
            this.LastName_TextBox.Location = new System.Drawing.Point(15, 205);
            this.LastName_TextBox.Name = "LastName_TextBox";
            this.LastName_TextBox.Size = new System.Drawing.Size(235, 22);
            this.LastName_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите фамилию";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите номер телефона";
            // 
            // PhoneNumber_TextBox
            // 
            this.PhoneNumber_TextBox.Location = new System.Drawing.Point(12, 274);
            this.PhoneNumber_TextBox.Name = "PhoneNumber_TextBox";
            this.PhoneNumber_TextBox.Size = new System.Drawing.Size(238, 22);
            this.PhoneNumber_TextBox.TabIndex = 5;
            // 
            // AddPhoneBook_Button
            // 
            this.AddPhoneBook_Button.Location = new System.Drawing.Point(12, 302);
            this.AddPhoneBook_Button.Name = "AddPhoneBook_Button";
            this.AddPhoneBook_Button.Size = new System.Drawing.Size(238, 57);
            this.AddPhoneBook_Button.TabIndex = 6;
            this.AddPhoneBook_Button.Text = "Добавить в справочник";
            this.AddPhoneBook_Button.UseVisualStyleBackColor = true;
            this.AddPhoneBook_Button.Click += new System.EventHandler(this.AddPhoneBook_Button_Click);
            // 
            // Human_ListBox
            // 
            this.Human_ListBox.FormattingEnabled = true;
            this.Human_ListBox.ItemHeight = 16;
            this.Human_ListBox.Location = new System.Drawing.Point(408, 135);
            this.Human_ListBox.Name = "Human_ListBox";
            this.Human_ListBox.Size = new System.Drawing.Size(268, 260);
            this.Human_ListBox.TabIndex = 7;
            // 
            // Search_TextBox
            // 
            this.Search_TextBox.Location = new System.Drawing.Point(408, 77);
            this.Search_TextBox.Name = "Search_TextBox";
            this.Search_TextBox.Size = new System.Drawing.Size(238, 22);
            this.Search_TextBox.TabIndex = 8;
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(277, 76);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(125, 23);
            this.Search_Button.TabIndex = 9;
            this.Search_Button.Text = "Найти";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Search_ComboBox
            // 
            this.Search_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Search_ComboBox.FormattingEnabled = true;
            this.Search_ComboBox.Items.AddRange(new object[] {
            "По имени",
            "По фамилии",
            "По номеру телефона"});
            this.Search_ComboBox.Location = new System.Drawing.Point(408, 105);
            this.Search_ComboBox.Name = "Search_ComboBox";
            this.Search_ComboBox.Size = new System.Drawing.Size(238, 24);
            this.Search_ComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.LastName_RadioButton2);
            this.groupBox1.Controls.Add(this.FirstName_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(277, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировать";
            // 
            // LastName_RadioButton2
            // 
            this.LastName_RadioButton2.AutoSize = true;
            this.LastName_RadioButton2.Location = new System.Drawing.Point(0, 65);
            this.LastName_RadioButton2.Name = "LastName_RadioButton2";
            this.LastName_RadioButton2.Size = new System.Drawing.Size(109, 21);
            this.LastName_RadioButton2.TabIndex = 1;
            this.LastName_RadioButton2.TabStop = true;
            this.LastName_RadioButton2.Text = "по фамилии";
            this.LastName_RadioButton2.UseVisualStyleBackColor = true;
            this.LastName_RadioButton2.CheckedChanged += new System.EventHandler(this.LastName_RadioButton2_CheckedChanged);
            // 
            // FirstName_RadioButton
            // 
            this.FirstName_RadioButton.AutoSize = true;
            this.FirstName_RadioButton.Location = new System.Drawing.Point(0, 30);
            this.FirstName_RadioButton.Name = "FirstName_RadioButton";
            this.FirstName_RadioButton.Size = new System.Drawing.Size(90, 21);
            this.FirstName_RadioButton.TabIndex = 0;
            this.FirstName_RadioButton.TabStop = true;
            this.FirstName_RadioButton.Text = "по имени";
            this.FirstName_RadioButton.UseVisualStyleBackColor = true;
            this.FirstName_RadioButton.CheckedChanged += new System.EventHandler(this.FirstName_RadioButton_CheckedChanged);
            // 
            // DeleteHuman_Button
            // 
            this.DeleteHuman_Button.Location = new System.Drawing.Point(293, 285);
            this.DeleteHuman_Button.Name = "DeleteHuman_Button";
            this.DeleteHuman_Button.Size = new System.Drawing.Size(109, 43);
            this.DeleteHuman_Button.TabIndex = 12;
            this.DeleteHuman_Button.Text = "Удалить";
            this.DeleteHuman_Button.UseVisualStyleBackColor = true;
            this.DeleteHuman_Button.Click += new System.EventHandler(this.DeleteHuman_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 709);
            this.Controls.Add(this.DeleteHuman_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Search_ComboBox);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.Search_TextBox);
            this.Controls.Add(this.Human_ListBox);
            this.Controls.Add(this.AddPhoneBook_Button);
            this.Controls.Add(this.PhoneNumber_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastName_TextBox);
            this.Controls.Add(this.FirstName_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName_TextBox;
        private System.Windows.Forms.TextBox LastName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumber_TextBox;
        private System.Windows.Forms.Button AddPhoneBook_Button;
        private System.Windows.Forms.ListBox Human_ListBox;
        private System.Windows.Forms.TextBox Search_TextBox;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.ComboBox Search_ComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LastName_RadioButton2;
        private System.Windows.Forms.RadioButton FirstName_RadioButton;
        private System.Windows.Forms.Button DeleteHuman_Button;
    }
}

