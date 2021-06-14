namespace InertiaUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonUpRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDownLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonDownRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.field = new InertiaUI.Field();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSound = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "1 - 8х4",
            "2 - 10х10",
            "3 - Бонус"});
            this.comboBoxLevel.Location = new System.Drawing.Point(64, 10);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(92, 21);
            this.comboBoxLevel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Уровень:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonUpLeft
            // 
            this.buttonUpLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpLeft.Location = new System.Drawing.Point(8, 68);
            this.buttonUpLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpLeft.Name = "buttonUpLeft";
            this.buttonUpLeft.Size = new System.Drawing.Size(30, 32);
            this.buttonUpLeft.TabIndex = 4;
            this.buttonUpLeft.Text = "↖";
            this.buttonUpLeft.UseVisualStyleBackColor = true;
            this.buttonUpLeft.Click += new System.EventHandler(this.buttonUpLeft_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(43, 68);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 32);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonUpRight
            // 
            this.buttonUpRight.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpRight.Location = new System.Drawing.Point(77, 68);
            this.buttonUpRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(30, 32);
            this.buttonUpRight.TabIndex = 6;
            this.buttonUpRight.Text = "↗";
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.buttonUpRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(8, 105);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 32);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(77, 105);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 32);
            this.buttonRight.TabIndex = 8;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDownLeft
            // 
            this.buttonDownLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownLeft.Location = new System.Drawing.Point(8, 142);
            this.buttonDownLeft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownLeft.Name = "buttonDownLeft";
            this.buttonDownLeft.Size = new System.Drawing.Size(30, 32);
            this.buttonDownLeft.TabIndex = 9;
            this.buttonDownLeft.Text = "↙";
            this.buttonDownLeft.UseVisualStyleBackColor = true;
            this.buttonDownLeft.Click += new System.EventHandler(this.buttonDownLeft_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(43, 142);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 32);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownRight.Location = new System.Drawing.Point(77, 142);
            this.buttonDownRight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(30, 32);
            this.buttonDownRight.TabIndex = 11;
            this.buttonDownRight.Text = "↘";
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.buttonDownRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 12;
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(112, 68);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(150, 150);
            this.field.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 130);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // buttonSound
            // 
            this.buttonSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSound.Location = new System.Drawing.Point(8, 28);
            this.buttonSound.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(30, 24);
            this.buttonSound.TabIndex = 14;
            this.buttonSound.Text = "🔈";
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "уровень 1\r\nвремя                      жизни\r\n                  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(598, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 39);
            this.label5.TabIndex = 16;
            this.label5.Text = "уровень 2\r\nвремя                         жизни\r\n                  ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDownRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonDownLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUpRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonUpLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.field);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inertia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Field field;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonUpRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDownLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonDownRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

