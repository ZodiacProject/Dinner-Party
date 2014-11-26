namespace WindowsFormsApplication_222_elbook
{
    partial class Form1
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
            this.numericUpDownPeople = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Costlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.Location = new System.Drawing.Point(22, 34);
            this.numericUpDownPeople.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownPeople.TabIndex = 0;
            this.numericUpDownPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownPeople.ValueChanged += new System.EventHandler(this.numericUpDownPeople_ValueChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Number of People";
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Checked = true;
            this.fancyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBox.Location = new System.Drawing.Point(22, 81);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(110, 17);
            this.fancyBox.TabIndex = 2;
            this.fancyBox.Text = "Fancy Decoration";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(22, 126);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(117, 17);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "Healthy Decoration";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cost";
            // 
            // Costlabel
            // 
            this.Costlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Costlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Costlabel.Location = new System.Drawing.Point(66, 171);
            this.Costlabel.Name = "Costlabel";
            this.Costlabel.Size = new System.Drawing.Size(40, 18);
            this.Costlabel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 230);
            this.Controls.Add(this.Costlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.healthyBox);
            this.Controls.Add(this.fancyBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.numericUpDownPeople);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPeople;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Costlabel;
    }
}

