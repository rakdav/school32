namespace school32
{
    partial class FormService
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
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonRecordService = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxDiscont = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSearchDesc = new System.Windows.Forms.TextBox();
            this.labelRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.RowHeadersWidth = 100;
            this.dataGridViewServices.Size = new System.Drawing.Size(450, 242);
            this.dataGridViewServices.TabIndex = 0;
            this.dataGridViewServices.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewServices_ColumnHeaderMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(108, 276);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonRecordService
            // 
            this.buttonRecordService.Location = new System.Drawing.Point(204, 277);
            this.buttonRecordService.Name = "buttonRecordService";
            this.buttonRecordService.Size = new System.Drawing.Size(121, 23);
            this.buttonRecordService.TabIndex = 3;
            this.buttonRecordService.Text = "Запись на услугу";
            this.buttonRecordService.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxDiscont);
            this.groupBox1.Location = new System.Drawing.Point(470, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтрация по скидке";
            // 
            // comboBoxDiscont
            // 
            this.comboBoxDiscont.FormattingEnabled = true;
            this.comboBoxDiscont.Items.AddRange(new object[] {
            "от 0 до 5%",
            "от 5% до 15%",
            "от 15% до 30%",
            "от 30% до 70%",
            "от 70% до 100%",
            "Все"});
            this.comboBoxDiscont.Location = new System.Drawing.Point(7, 20);
            this.comboBoxDiscont.Name = "comboBoxDiscont";
            this.comboBoxDiscont.Size = new System.Drawing.Size(187, 21);
            this.comboBoxDiscont.TabIndex = 0;
            this.comboBoxDiscont.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscont_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearchTitle);
            this.groupBox2.Location = new System.Drawing.Point(470, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 59);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Помск по названию";
            // 
            // textBoxSearchTitle
            // 
            this.textBoxSearchTitle.Location = new System.Drawing.Point(7, 20);
            this.textBoxSearchTitle.Name = "textBoxSearchTitle";
            this.textBoxSearchTitle.Size = new System.Drawing.Size(187, 20);
            this.textBoxSearchTitle.TabIndex = 0;
            this.textBoxSearchTitle.TextChanged += new System.EventHandler(this.textBoxSearchTitle_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSearchDesc);
            this.groupBox3.Location = new System.Drawing.Point(470, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск по описанию";
            // 
            // textBoxSearchDesc
            // 
            this.textBoxSearchDesc.Location = new System.Drawing.Point(7, 42);
            this.textBoxSearchDesc.Name = "textBoxSearchDesc";
            this.textBoxSearchDesc.Size = new System.Drawing.Size(187, 20);
            this.textBoxSearchDesc.TabIndex = 0;
            this.textBoxSearchDesc.TextChanged += new System.EventHandler(this.textBoxSearchDesc_TextChanged);
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Location = new System.Drawing.Point(356, 286);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(0, 13);
            this.labelRecords.TabIndex = 7;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 320);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRecordService);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewServices);
            this.Name = "FormService";
            this.Text = "Услуги";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonRecordService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxDiscont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxSearchTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSearchDesc;
        private System.Windows.Forms.Label labelRecords;
    }
}