
namespace _01._04._2022
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
            this.name = new System.Windows.Forms.Label();
            this.reg = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(12, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(68, 31);
            this.name.TabIndex = 0;
            this.name.Text = "Имя";
            // 
            // reg
            // 
            this.reg.AllowDrop = true;
            this.reg.Location = new System.Drawing.Point(95, 95);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(229, 20);
            this.reg.TabIndex = 1;
            // 
            // start
            // 
            this.start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.start.Location = new System.Drawing.Point(95, 191);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(149, 54);
            this.start.TabIndex = 2;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(95, 263);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(149, 50);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 343);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.reg);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        public System.Windows.Forms.Button start;
        public System.Windows.Forms.TextBox reg;
        private System.Windows.Forms.Button Exit;
    }
}

