namespace Lab_9
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
            this.grBox_marks = new System.Windows.Forms.GroupBox();
            this.btnAdd_marks = new System.Windows.Forms.Button();
            this.numUP_objects = new System.Windows.Forms.NumericUpDown();
            this.numUD_students = new System.Windows.Forms.NumericUpDown();
            this.lbl_objects = new System.Windows.Forms.Label();
            this.lbl_students = new System.Windows.Forms.Label();
            this.dataGV_table = new System.Windows.Forms.DataGridView();
            this.grBox_objects = new System.Windows.Forms.GroupBox();
            this.btnAdd_objects = new System.Windows.Forms.Button();
            this.comBox_objects = new System.Windows.Forms.ComboBox();
            this.grBox_fio = new System.Windows.Forms.GroupBox();
            this.txtBox_students = new System.Windows.Forms.TextBox();
            this.btnAdd_fio = new System.Windows.Forms.Button();
            this.grBox_marks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_objects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_table)).BeginInit();
            this.grBox_objects.SuspendLayout();
            this.grBox_fio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grBox_marks
            // 
            this.grBox_marks.Controls.Add(this.btnAdd_marks);
            this.grBox_marks.Controls.Add(this.numUP_objects);
            this.grBox_marks.Controls.Add(this.numUD_students);
            this.grBox_marks.Controls.Add(this.lbl_objects);
            this.grBox_marks.Controls.Add(this.lbl_students);
            this.grBox_marks.Location = new System.Drawing.Point(523, 53);
            this.grBox_marks.Name = "grBox_marks";
            this.grBox_marks.Size = new System.Drawing.Size(149, 119);
            this.grBox_marks.TabIndex = 1;
            this.grBox_marks.TabStop = false;
            this.grBox_marks.Text = "Таблица оценок";
            // 
            // btnAdd_marks
            // 
            this.btnAdd_marks.Location = new System.Drawing.Point(39, 87);
            this.btnAdd_marks.Name = "btnAdd_marks";
            this.btnAdd_marks.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_marks.TabIndex = 4;
            this.btnAdd_marks.Text = "Добавить";
            this.btnAdd_marks.UseVisualStyleBackColor = true;
            this.btnAdd_marks.Click += new System.EventHandler(this.btnAdd_marks_Click);
            // 
            // numUP_objects
            // 
            this.numUP_objects.Location = new System.Drawing.Point(92, 61);
            this.numUP_objects.Name = "numUP_objects";
            this.numUP_objects.Size = new System.Drawing.Size(46, 20);
            this.numUP_objects.TabIndex = 3;
            // 
            // numUD_students
            // 
            this.numUD_students.Location = new System.Drawing.Point(92, 30);
            this.numUD_students.Name = "numUD_students";
            this.numUD_students.Size = new System.Drawing.Size(46, 20);
            this.numUD_students.TabIndex = 2;
            // 
            // lbl_objects
            // 
            this.lbl_objects.AutoSize = true;
            this.lbl_objects.Location = new System.Drawing.Point(6, 63);
            this.lbl_objects.Name = "lbl_objects";
            this.lbl_objects.Size = new System.Drawing.Size(60, 13);
            this.lbl_objects.TabIndex = 1;
            this.lbl_objects.Text = "Предметы";
            // 
            // lbl_students
            // 
            this.lbl_students.AutoSize = true;
            this.lbl_students.Location = new System.Drawing.Point(6, 32);
            this.lbl_students.Name = "lbl_students";
            this.lbl_students.Size = new System.Drawing.Size(55, 13);
            this.lbl_students.TabIndex = 0;
            this.lbl_students.Text = "Студенты";
            // 
            // dataGV_table
            // 
            this.dataGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_table.Location = new System.Drawing.Point(39, 53);
            this.dataGV_table.Name = "dataGV_table";
            this.dataGV_table.Size = new System.Drawing.Size(432, 348);
            this.dataGV_table.TabIndex = 2;
            // 
            // grBox_objects
            // 
            this.grBox_objects.Controls.Add(this.btnAdd_objects);
            this.grBox_objects.Controls.Add(this.comBox_objects);
            this.grBox_objects.Location = new System.Drawing.Point(523, 199);
            this.grBox_objects.Name = "grBox_objects";
            this.grBox_objects.Size = new System.Drawing.Size(149, 91);
            this.grBox_objects.TabIndex = 3;
            this.grBox_objects.TabStop = false;
            this.grBox_objects.Text = "Предметы";
            // 
            // btnAdd_objects
            // 
            this.btnAdd_objects.Location = new System.Drawing.Point(39, 59);
            this.btnAdd_objects.Name = "btnAdd_objects";
            this.btnAdd_objects.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_objects.TabIndex = 5;
            this.btnAdd_objects.Text = "Добавить";
            this.btnAdd_objects.UseVisualStyleBackColor = true;
            this.btnAdd_objects.Click += new System.EventHandler(this.btnAdd_objects_Click);
            // 
            // comBox_objects
            // 
            this.comBox_objects.FormattingEnabled = true;
            this.comBox_objects.Location = new System.Drawing.Point(9, 32);
            this.comBox_objects.Name = "comBox_objects";
            this.comBox_objects.Size = new System.Drawing.Size(121, 21);
            this.comBox_objects.TabIndex = 0;
            // 
            // grBox_fio
            // 
            this.grBox_fio.Controls.Add(this.btnAdd_fio);
            this.grBox_fio.Controls.Add(this.txtBox_students);
            this.grBox_fio.Location = new System.Drawing.Point(523, 313);
            this.grBox_fio.Name = "grBox_fio";
            this.grBox_fio.Size = new System.Drawing.Size(149, 88);
            this.grBox_fio.TabIndex = 4;
            this.grBox_fio.TabStop = false;
            this.grBox_fio.Text = "ФИО Студента";
            // 
            // txtBox_students
            // 
            this.txtBox_students.Location = new System.Drawing.Point(9, 28);
            this.txtBox_students.Name = "txtBox_students";
            this.txtBox_students.Size = new System.Drawing.Size(121, 20);
            this.txtBox_students.TabIndex = 0;
            // 
            // btnAdd_fio
            // 
            this.btnAdd_fio.Location = new System.Drawing.Point(39, 54);
            this.btnAdd_fio.Name = "btnAdd_fio";
            this.btnAdd_fio.Size = new System.Drawing.Size(75, 23);
            this.btnAdd_fio.TabIndex = 6;
            this.btnAdd_fio.Text = "Добавить";
            this.btnAdd_fio.UseVisualStyleBackColor = true;
            this.btnAdd_fio.Click += new System.EventHandler(this.btnAdd_fio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.grBox_fio);
            this.Controls.Add(this.grBox_objects);
            this.Controls.Add(this.dataGV_table);
            this.Controls.Add(this.grBox_marks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBox_marks.ResumeLayout(false);
            this.grBox_marks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUP_objects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_table)).EndInit();
            this.grBox_objects.ResumeLayout(false);
            this.grBox_fio.ResumeLayout(false);
            this.grBox_fio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grBox_marks;
        private System.Windows.Forms.Label lbl_objects;
        private System.Windows.Forms.Label lbl_students;
        private System.Windows.Forms.Button btnAdd_marks;
        private System.Windows.Forms.NumericUpDown numUP_objects;
        private System.Windows.Forms.NumericUpDown numUD_students;
        private System.Windows.Forms.DataGridView dataGV_table;
        private System.Windows.Forms.GroupBox grBox_objects;
        private System.Windows.Forms.Button btnAdd_objects;
        private System.Windows.Forms.ComboBox comBox_objects;
        private System.Windows.Forms.GroupBox grBox_fio;
        private System.Windows.Forms.TextBox txtBox_students;
        private System.Windows.Forms.Button btnAdd_fio;
    }
}

