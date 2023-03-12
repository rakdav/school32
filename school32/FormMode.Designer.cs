namespace school32
{
    partial class FormMode
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
            this.buttonModeUser = new System.Windows.Forms.Button();
            this.buttonModeAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonModeUser
            // 
            this.buttonModeUser.Location = new System.Drawing.Point(46, 31);
            this.buttonModeUser.Name = "buttonModeUser";
            this.buttonModeUser.Size = new System.Drawing.Size(185, 23);
            this.buttonModeUser.TabIndex = 0;
            this.buttonModeUser.Text = "Обычный режим";
            this.buttonModeUser.UseVisualStyleBackColor = true;
            this.buttonModeUser.Click += new System.EventHandler(this.buttonModeUser_Click);
            // 
            // buttonModeAdmin
            // 
            this.buttonModeAdmin.Location = new System.Drawing.Point(46, 84);
            this.buttonModeAdmin.Name = "buttonModeAdmin";
            this.buttonModeAdmin.Size = new System.Drawing.Size(185, 23);
            this.buttonModeAdmin.TabIndex = 1;
            this.buttonModeAdmin.Text = "Режим администратора";
            this.buttonModeAdmin.UseVisualStyleBackColor = true;
            this.buttonModeAdmin.Click += new System.EventHandler(this.buttonModeAdmin_Click);
            // 
            // FormMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 157);
            this.Controls.Add(this.buttonModeAdmin);
            this.Controls.Add(this.buttonModeUser);
            this.Name = "FormMode";
            this.Text = "Выбор режима";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonModeUser;
        private System.Windows.Forms.Button buttonModeAdmin;
    }
}

