namespace RegisztracioAlkalmazas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.RadioButton();
            this.female = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newhobby = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.load_button = new System.Windows.Forms.Button();
            this.hobby_list = new System.Windows.Forms.ListBox();
            this.name = new System.Windows.Forms.TextBox();
            this.birth__date = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szül. dátum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nem:";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.male.Location = new System.Drawing.Point(120, 146);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 33);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "F";
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.female.Location = new System.Drawing.Point(262, 146);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(52, 33);
            this.female.TabIndex = 4;
            this.female.TabStop = true;
            this.female.Text = "N";
            this.female.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(439, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Új hobbi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(576, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kedvenc Hobbi:";
            // 
            // newhobby
            // 
            this.newhobby.Location = new System.Drawing.Point(581, 181);
            this.newhobby.Name = "newhobby";
            this.newhobby.Size = new System.Drawing.Size(207, 22);
            this.newhobby.TabIndex = 0;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.add_button.Location = new System.Drawing.Point(581, 218);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(141, 46);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Hozzáad";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.save_button.Location = new System.Drawing.Point(407, 298);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(145, 79);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Mentés";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // load_button
            // 
            this.load_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.load_button.Location = new System.Drawing.Point(591, 297);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(131, 80);
            this.load_button.TabIndex = 10;
            this.load_button.Text = "Betöltés";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // hobby_list
            // 
            this.hobby_list.DisplayMember = "Foci";
            this.hobby_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.hobby_list.FormattingEnabled = true;
            this.hobby_list.ItemHeight = 25;
            this.hobby_list.Items.AddRange(new object[] {
            "Foci",
            "Úszás",
            "Teniszezés"});
            this.hobby_list.Location = new System.Drawing.Point(581, 43);
            this.hobby_list.Name = "hobby_list";
            this.hobby_list.Size = new System.Drawing.Size(197, 129);
            this.hobby_list.TabIndex = 0;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(106, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(344, 22);
            this.name.TabIndex = 12;
            // 
            // birth__date
            // 
            this.birth__date.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.birth__date.Location = new System.Drawing.Point(174, 97);
            this.birth__date.Name = "birth__date";
            this.birth__date.Size = new System.Drawing.Size(276, 22);
            this.birth__date.TabIndex = 13;
            this.birth__date.ValueChanged += new System.EventHandler(this.birth__date_ValueChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "adatok";
            this.saveFileDialog1.Filter = "Szöveges adatformátum(*.txt)|*.txt|Minden fájt(*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.birth__date);
            this.Controls.Add(this.name);
            this.Controls.Add(this.hobby_list);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.newhobby);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newhobby;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.ListBox hobby_list;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker birth__date;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

