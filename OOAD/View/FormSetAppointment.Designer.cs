using System.Windows.Forms;

namespace OOAD.View
{
    partial class FormSetAppointment
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
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxTieuDe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxdescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxReminder = new System.Windows.Forms.ComboBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.dateTimePickerstarttime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerendtime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(109, 105);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(276, 350);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(169, 350);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(62, 350);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBoxTieuDe
            // 
            this.textBoxTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxTieuDe.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTieuDe.Location = new System.Drawing.Point(109, 28);
            this.textBoxTieuDe.Name = "textBoxTieuDe";
            this.textBoxTieuDe.Size = new System.Drawing.Size(201, 33);
            this.textBoxTieuDe.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reminder";
            // 
            // richTextBoxdescription
            // 
            this.richTextBoxdescription.Location = new System.Drawing.Point(111, 228);
            this.richTextBoxdescription.Name = "richTextBoxdescription";
            this.richTextBoxdescription.Size = new System.Drawing.Size(228, 77);
            this.richTextBoxdescription.TabIndex = 10;
            this.richTextBoxdescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "--";
            // 
            // comboBoxReminder
            // 
            this.comboBoxReminder.DisplayMember = "None";
            this.comboBoxReminder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReminder.FormattingEnabled = true;
            this.comboBoxReminder.Items.AddRange(new object[] {
            "5 minutes before",
            "10 minutes before",
            "15 minutes before",
            "30 minutes before",
            "1 hour before",
            "1 day before",
            "None"});
            this.comboBoxReminder.Location = new System.Drawing.Point(111, 184);
            this.comboBoxReminder.Name = "comboBoxReminder";
            this.comboBoxReminder.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReminder.TabIndex = 13;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(109, 147);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(230, 20);
            this.textBoxLocation.TabIndex = 14;
            // 
            // dateTimePickerstarttime
            // 
            this.dateTimePickerstarttime.CustomFormat = "HH:mm";
            this.dateTimePickerstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerstarttime.Location = new System.Drawing.Point(222, 105);
            this.dateTimePickerstarttime.Name = "dateTimePickerstarttime";
            this.dateTimePickerstarttime.ShowUpDown = true;
            this.dateTimePickerstarttime.Size = new System.Drawing.Size(70, 20);
            this.dateTimePickerstarttime.TabIndex = 15;
            // 
            // dateTimePickerendtime
            // 
            this.dateTimePickerendtime.CustomFormat = "HH:mm";
            this.dateTimePickerendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerendtime.Location = new System.Drawing.Point(327, 105);
            this.dateTimePickerendtime.Name = "dateTimePickerendtime";
            this.dateTimePickerendtime.ShowUpDown = true;
            this.dateTimePickerendtime.Size = new System.Drawing.Size(70, 20);
            this.dateTimePickerendtime.TabIndex = 16;
            // 
            // FormSetAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 395);
            this.Controls.Add(this.dateTimePickerendtime);
            this.Controls.Add(this.dateTimePickerstarttime);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.comboBoxReminder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxdescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTieuDe);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDate);
            this.Name = "FormSetAppointment";
            this.Text = "FormSetAppointment";
            this.Load += new System.EventHandler(this.FormSetAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxTieuDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxdescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxReminder;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.DateTimePicker dateTimePickerstarttime;
        private DateTimePicker dateTimePickerendtime;
    }
}