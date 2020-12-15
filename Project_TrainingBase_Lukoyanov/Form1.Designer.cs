
namespace Project_TrainingBase_Lukoyanov
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
			this.label1 = new System.Windows.Forms.Label();
			this.salesPeopleButton = new System.Windows.Forms.Button();
			this.customersButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(150, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Учебная база данных";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// salesPeopleButton
			// 
			this.salesPeopleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.salesPeopleButton.Location = new System.Drawing.Point(155, 54);
			this.salesPeopleButton.Name = "salesPeopleButton";
			this.salesPeopleButton.Size = new System.Drawing.Size(258, 48);
			this.salesPeopleButton.TabIndex = 1;
			this.salesPeopleButton.Text = "Продавцы";
			this.salesPeopleButton.UseVisualStyleBackColor = true;
			this.salesPeopleButton.Click += new System.EventHandler(this.salesPeopleButton_Click);
			// 
			// customersButton
			// 
			this.customersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.customersButton.Location = new System.Drawing.Point(155, 120);
			this.customersButton.Name = "customersButton";
			this.customersButton.Size = new System.Drawing.Size(258, 48);
			this.customersButton.TabIndex = 2;
			this.customersButton.Text = "Покупатели";
			this.customersButton.UseVisualStyleBackColor = true;
			this.customersButton.Click += new System.EventHandler(this.customersButton_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(155, 184);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(258, 47);
			this.button3.TabIndex = 3;
			this.button3.Text = "Заказы";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.Location = new System.Drawing.Point(155, 245);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(257, 47);
			this.button4.TabIndex = 4;
			this.button4.Text = "Детали заказа";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button5.Location = new System.Drawing.Point(154, 308);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(258, 47);
			this.button5.TabIndex = 5;
			this.button5.Text = "Продукты";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 384);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.customersButton);
			this.Controls.Add(this.salesPeopleButton);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Учебная база";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button salesPeopleButton;
		private System.Windows.Forms.Button customersButton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
	}
}

