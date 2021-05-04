
namespace dz_converter
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
            this.TextBoxInValue = new System.Windows.Forms.TextBox();
            this.TextBoxExitValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonConvert = new System.Windows.Forms.Button();
            this.labelTransaction = new System.Windows.Forms.Label();
            this.textBoxSummOfTransaction = new System.Windows.Forms.TextBox();
            this.balanceInEuro = new System.Windows.Forms.TextBox();
            this.balanceInDollar = new System.Windows.Forms.TextBox();
            this.balanceInRub = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxInValue
            // 
            this.TextBoxInValue.BackColor = System.Drawing.Color.Chartreuse;
            this.TextBoxInValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxInValue.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TextBoxInValue.Location = new System.Drawing.Point(18, 143);
            this.TextBoxInValue.Name = "TextBoxInValue";
            this.TextBoxInValue.Size = new System.Drawing.Size(172, 64);
            this.TextBoxInValue.TabIndex = 1;
            // 
            // TextBoxExitValue
            // 
            this.TextBoxExitValue.BackColor = System.Drawing.Color.Chartreuse;
            this.TextBoxExitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxExitValue.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TextBoxExitValue.Location = new System.Drawing.Point(15, 233);
            this.TextBoxExitValue.Name = "TextBoxExitValue";
            this.TextBoxExitValue.Size = new System.Drawing.Size(172, 64);
            this.TextBoxExitValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Баланс в ₽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(415, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Баланс в €";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(541, -79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Баланс в €";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(224, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Баланс в $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите искомую валюту (RUB,USD,EU)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(-3, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(393, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Введите выходную валюту (RUB,USD,EU)";
            // 
            // ButtonConvert
            // 
            this.ButtonConvert.BackColor = System.Drawing.Color.Gold;
            this.ButtonConvert.Enabled = false;
            this.ButtonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonConvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonConvert.Location = new System.Drawing.Point(396, 120);
            this.ButtonConvert.Name = "ButtonConvert";
            this.ButtonConvert.Size = new System.Drawing.Size(220, 275);
            this.ButtonConvert.TabIndex = 6;
            this.ButtonConvert.Text = "КОНВЕРТИРОВАТЬ";
            this.ButtonConvert.UseVisualStyleBackColor = false;
            this.ButtonConvert.Click += new System.EventHandler(this.ButtonConvert_Click);
            // 
            // labelTransaction
            // 
            this.labelTransaction.AutoSize = true;
            this.labelTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransaction.Location = new System.Drawing.Point(-2, 300);
            this.labelTransaction.Name = "labelTransaction";
            this.labelTransaction.Size = new System.Drawing.Size(246, 20);
            this.labelTransaction.TabIndex = 7;
            this.labelTransaction.Text = "Введите сумму перевода";
            // 
            // textBoxSummOfTransaction
            // 
            this.textBoxSummOfTransaction.BackColor = System.Drawing.Color.Red;
            this.textBoxSummOfTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSummOfTransaction.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxSummOfTransaction.Location = new System.Drawing.Point(15, 323);
            this.textBoxSummOfTransaction.Name = "textBoxSummOfTransaction";
            this.textBoxSummOfTransaction.Size = new System.Drawing.Size(207, 64);
            this.textBoxSummOfTransaction.TabIndex = 8;
            // 
            // balanceInEuro
            // 
            this.balanceInEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.balanceInEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceInEuro.Location = new System.Drawing.Point(420, 59);
            this.balanceInEuro.Name = "balanceInEuro";
            this.balanceInEuro.Size = new System.Drawing.Size(176, 55);
            this.balanceInEuro.TabIndex = 9;
            // 
            // balanceInDollar
            // 
            this.balanceInDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.balanceInDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceInDollar.Location = new System.Drawing.Point(229, 59);
            this.balanceInDollar.Name = "balanceInDollar";
            this.balanceInDollar.Size = new System.Drawing.Size(184, 55);
            this.balanceInDollar.TabIndex = 10;
            // 
            // balanceInRub
            // 
            this.balanceInRub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.balanceInRub.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balanceInRub.Location = new System.Drawing.Point(10, 59);
            this.balanceInRub.Name = "balanceInRub";
            this.balanceInRub.Size = new System.Drawing.Size(213, 55);
            this.balanceInRub.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(265, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 146);
            this.button1.TabIndex = 12;
            this.button1.Text = "Запомнить баланс";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(616, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.balanceInRub);
            this.Controls.Add(this.balanceInDollar);
            this.Controls.Add(this.balanceInEuro);
            this.Controls.Add(this.textBoxSummOfTransaction);
            this.Controls.Add(this.labelTransaction);
            this.Controls.Add(this.ButtonConvert);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxExitValue);
            this.Controls.Add(this.TextBoxInValue);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxInValue;
        private System.Windows.Forms.TextBox TextBoxExitValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonConvert;
        private System.Windows.Forms.Label labelTransaction;
        private System.Windows.Forms.TextBox textBoxSummOfTransaction;
        private System.Windows.Forms.TextBox balanceInEuro;
        private System.Windows.Forms.TextBox balanceInDollar;
        private System.Windows.Forms.TextBox balanceInRub;
        private System.Windows.Forms.Button button1;
    }
}

