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
            this.labelLevel = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonUpLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonUpRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDownLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonDownRight = new System.Windows.Forms.Button();
            this.gameResul = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSound = new System.Windows.Forms.Button();
            this.resultsLevel1 = new System.Windows.Forms.Label();
            this.resultsLevel2 = new System.Windows.Forms.Label();
            this.field = new InertiaUI.Field();
            this.SuspendLayout();
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Items.AddRange(new object[] {
            "0 - 8х4",
            "1 - 10х10",
            "2 - 12x13"});
            this.comboBoxLevel.Location = new System.Drawing.Point(85, 12);
            this.comboBoxLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLevel.TabIndex = 1;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(12, 15);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(43, 16);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Level:";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(85, 42);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(121, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.Play_Click);
            // 
            // buttonUpLeft
            // 
            this.buttonUpLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpLeft.Location = new System.Drawing.Point(11, 84);
            this.buttonUpLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpLeft.Name = "buttonUpLeft";
            this.buttonUpLeft.Size = new System.Drawing.Size(40, 39);
            this.buttonUpLeft.TabIndex = 4;
            this.buttonUpLeft.Text = "↖";
            this.buttonUpLeft.UseVisualStyleBackColor = true;
            this.buttonUpLeft.Click += new System.EventHandler(this.buttonUpLeft_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Location = new System.Drawing.Point(57, 84);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(40, 39);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonUpRight
            // 
            this.buttonUpRight.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpRight.Location = new System.Drawing.Point(103, 84);
            this.buttonUpRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpRight.Name = "buttonUpRight";
            this.buttonUpRight.Size = new System.Drawing.Size(40, 39);
            this.buttonUpRight.TabIndex = 6;
            this.buttonUpRight.Text = "↗";
            this.buttonUpRight.UseVisualStyleBackColor = true;
            this.buttonUpRight.Click += new System.EventHandler(this.buttonUpRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeft.Location = new System.Drawing.Point(11, 129);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 39);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Text = "←";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRight.Location = new System.Drawing.Point(103, 129);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 39);
            this.buttonRight.TabIndex = 8;
            this.buttonRight.Text = "→";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonDownLeft
            // 
            this.buttonDownLeft.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownLeft.Location = new System.Drawing.Point(11, 175);
            this.buttonDownLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownLeft.Name = "buttonDownLeft";
            this.buttonDownLeft.Size = new System.Drawing.Size(40, 39);
            this.buttonDownLeft.TabIndex = 9;
            this.buttonDownLeft.Text = "↙";
            this.buttonDownLeft.UseVisualStyleBackColor = true;
            this.buttonDownLeft.Click += new System.EventHandler(this.buttonDownLeft_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Location = new System.Drawing.Point(57, 175);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(40, 39);
            this.buttonDown.TabIndex = 10;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonDownRight
            // 
            this.buttonDownRight.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownRight.Location = new System.Drawing.Point(103, 175);
            this.buttonDownRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownRight.Name = "buttonDownRight";
            this.buttonDownRight.Size = new System.Drawing.Size(40, 39);
            this.buttonDownRight.TabIndex = 11;
            this.buttonDownRight.Text = "↘";
            this.buttonDownRight.UseVisualStyleBackColor = true;
            this.buttonDownRight.Click += new System.EventHandler(this.buttonDownRight_Click);
            // 
            // gameResul
            // 
            this.gameResul.AutoSize = true;
            this.gameResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameResul.Location = new System.Drawing.Point(212, 0);
            this.gameResul.Name = "gameResul";
            this.gameResul.Size = new System.Drawing.Size(0, 36);
            this.gameResul.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 160);
            this.label3.TabIndex = 13;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // buttonSound
            // 
            this.buttonSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSound.Location = new System.Drawing.Point(11, 34);
            this.buttonSound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.Size = new System.Drawing.Size(40, 30);
            this.buttonSound.TabIndex = 14;
            this.buttonSound.Text = "🔈";
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // resultsLevel1
            // 
            this.resultsLevel1.AutoSize = true;
            this.resultsLevel1.Location = new System.Drawing.Point(564, 182);
            this.resultsLevel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLevel1.Name = "resultsLevel1";
            this.resultsLevel1.Size = new System.Drawing.Size(141, 32);
            this.resultsLevel1.TabIndex = 15;
            this.resultsLevel1.Text = "Level 1\r\ntime                           lives";
            // 
            // resultsLevel2
            // 
            this.resultsLevel2.AutoSize = true;
            this.resultsLevel2.Location = new System.Drawing.Point(790, 182);
            this.resultsLevel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultsLevel2.Name = "resultsLevel2";
            this.resultsLevel2.Size = new System.Drawing.Size(141, 32);
            this.resultsLevel2.TabIndex = 16;
            this.resultsLevel2.Text = "Level 2\r\ntime                           lives";
            // 
            // field
            // 
            this.field.Location = new System.Drawing.Point(149, 84);
            this.field.Margin = new System.Windows.Forms.Padding(4);
            this.field.Name = "field";
            this.field.Size = new System.Drawing.Size(200, 185);
            this.field.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.resultsLevel2);
            this.Controls.Add(this.resultsLevel1);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameResul);
            this.Controls.Add(this.buttonDownRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonDownLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUpRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonUpLeft);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.field);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Inertia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonUpLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonUpRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDownLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonDownRight;
        private System.Windows.Forms.Label gameResul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Label resultsLevel1;
        private System.Windows.Forms.Label resultsLevel2;
        internal Field field;
    }
}

