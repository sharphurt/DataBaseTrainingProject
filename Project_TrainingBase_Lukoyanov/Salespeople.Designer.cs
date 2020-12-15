
namespace Project_TrainingBase_Lukoyanov
{
	partial class Salespeople
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salespeople));
			System.Windows.Forms.Label sNAMELabel;
			System.Windows.Forms.Label cOMMLabel;
			System.Windows.Forms.Label cITYLabel;
			this.label1 = new System.Windows.Forms.Label();
			this.training_base_LukoyanovDataSet = new Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSet();
			this.salespeopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.salespeopleTableAdapter = new Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSetTableAdapters.SalespeopleTableAdapter();
			this.tableAdapterManager = new Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSetTableAdapters.TableAdapterManager();
			this.salespeopleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.salespeopleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.sNAMETextBox = new System.Windows.Forms.TextBox();
			this.cOMMTextBox = new System.Windows.Forms.TextBox();
			this.cITYTextBox = new System.Windows.Forms.TextBox();
			sNAMELabel = new System.Windows.Forms.Label();
			cOMMLabel = new System.Windows.Forms.Label();
			cITYLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.training_base_LukoyanovDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.salespeopleBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.salespeopleBindingNavigator)).BeginInit();
			this.salespeopleBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(285, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(184, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Продавцы";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// training_base_LukoyanovDataSet
			// 
			this.training_base_LukoyanovDataSet.DataSetName = "Training_base_LukoyanovDataSet";
			this.training_base_LukoyanovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// salespeopleBindingSource
			// 
			this.salespeopleBindingSource.DataMember = "Salespeople";
			this.salespeopleBindingSource.DataSource = this.training_base_LukoyanovDataSet;
			// 
			// salespeopleTableAdapter
			// 
			this.salespeopleTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = null;
			this.tableAdapterManager.Order_DetailsTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.ProductTableAdapter = null;
			this.tableAdapterManager.SalespeopleTableAdapter = this.salespeopleTableAdapter;
			this.tableAdapterManager.UpdateOrder = Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// salespeopleBindingNavigator
			// 
			this.salespeopleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.salespeopleBindingNavigator.BindingSource = this.salespeopleBindingSource;
			this.salespeopleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.salespeopleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.salespeopleBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.salespeopleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.salespeopleBindingNavigatorSaveItem});
			this.salespeopleBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.salespeopleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.salespeopleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.salespeopleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.salespeopleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.salespeopleBindingNavigator.Name = "salespeopleBindingNavigator";
			this.salespeopleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.salespeopleBindingNavigator.Size = new System.Drawing.Size(800, 27);
			this.salespeopleBindingNavigator.TabIndex = 1;
			this.salespeopleBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Положение";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
			this.bindingNavigatorCountItem.Text = "для {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
			this.bindingNavigatorAddNewItem.Text = "Добавить";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
			this.bindingNavigatorDeleteItem.Text = "Удалить";
			// 
			// salespeopleBindingNavigatorSaveItem
			// 
			this.salespeopleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.salespeopleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("salespeopleBindingNavigatorSaveItem.Image")));
			this.salespeopleBindingNavigatorSaveItem.Name = "salespeopleBindingNavigatorSaveItem";
			this.salespeopleBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
			this.salespeopleBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.salespeopleBindingNavigatorSaveItem.Click += new System.EventHandler(this.salespeopleBindingNavigatorSaveItem_Click);
			// 
			// sNAMELabel
			// 
			sNAMELabel.AutoSize = true;
			sNAMELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			sNAMELabel.Location = new System.Drawing.Point(195, 143);
			sNAMELabel.Name = "sNAMELabel";
			sNAMELabel.Size = new System.Drawing.Size(104, 29);
			sNAMELabel.TabIndex = 2;
			sNAMELabel.Text = "SNAME:";
			// 
			// sNAMETextBox
			// 
			this.sNAMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salespeopleBindingSource, "SNAME", true));
			this.sNAMETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.sNAMETextBox.Location = new System.Drawing.Point(327, 140);
			this.sNAMETextBox.Name = "sNAMETextBox";
			this.sNAMETextBox.Size = new System.Drawing.Size(192, 34);
			this.sNAMETextBox.TabIndex = 3;
			// 
			// cOMMLabel
			// 
			cOMMLabel.AutoSize = true;
			cOMMLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			cOMMLabel.Location = new System.Drawing.Point(204, 223);
			cOMMLabel.Name = "cOMMLabel";
			cOMMLabel.Size = new System.Drawing.Size(95, 29);
			cOMMLabel.TabIndex = 4;
			cOMMLabel.Text = "COMM:";
			// 
			// cOMMTextBox
			// 
			this.cOMMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salespeopleBindingSource, "COMM", true));
			this.cOMMTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cOMMTextBox.Location = new System.Drawing.Point(327, 220);
			this.cOMMTextBox.Name = "cOMMTextBox";
			this.cOMMTextBox.Size = new System.Drawing.Size(192, 34);
			this.cOMMTextBox.TabIndex = 5;
			// 
			// cITYLabel
			// 
			cITYLabel.AutoSize = true;
			cITYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			cITYLabel.Location = new System.Drawing.Point(225, 183);
			cITYLabel.Name = "cITYLabel";
			cITYLabel.Size = new System.Drawing.Size(74, 29);
			cITYLabel.TabIndex = 6;
			cITYLabel.Text = "CITY:";
			// 
			// cITYTextBox
			// 
			this.cITYTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salespeopleBindingSource, "CITY", true));
			this.cITYTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cITYTextBox.Location = new System.Drawing.Point(327, 180);
			this.cITYTextBox.Name = "cITYTextBox";
			this.cITYTextBox.Size = new System.Drawing.Size(192, 34);
			this.cITYTextBox.TabIndex = 7;
			// 
			// Salespeople
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(cITYLabel);
			this.Controls.Add(this.cITYTextBox);
			this.Controls.Add(cOMMLabel);
			this.Controls.Add(this.cOMMTextBox);
			this.Controls.Add(sNAMELabel);
			this.Controls.Add(this.sNAMETextBox);
			this.Controls.Add(this.salespeopleBindingNavigator);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Salespeople";
			this.Text = "Продавцы";
			this.Load += new System.EventHandler(this.Salespeople_Load);
			((System.ComponentModel.ISupportInitialize)(this.training_base_LukoyanovDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.salespeopleBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.salespeopleBindingNavigator)).EndInit();
			this.salespeopleBindingNavigator.ResumeLayout(false);
			this.salespeopleBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Training_base_LukoyanovDataSet training_base_LukoyanovDataSet;
		private System.Windows.Forms.BindingSource salespeopleBindingSource;
		private Training_base_LukoyanovDataSetTableAdapters.SalespeopleTableAdapter salespeopleTableAdapter;
		private Training_base_LukoyanovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator salespeopleBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton salespeopleBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox sNAMETextBox;
		private System.Windows.Forms.TextBox cOMMTextBox;
		private System.Windows.Forms.TextBox cITYTextBox;
	}
}