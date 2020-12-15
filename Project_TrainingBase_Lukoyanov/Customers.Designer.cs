
namespace Project_TrainingBase_Lukoyanov
{
	partial class Customers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
			this.training_base_LukoyanovDataSet = new Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSet();
			this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customersTableAdapter = new Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSetTableAdapters.CustomersTableAdapter();
			this.tableAdapterManager = new Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSetTableAdapters.TableAdapterManager();
			this.customersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.customersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.customersDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.saveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.training_base_LukoyanovDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).BeginInit();
			this.customersBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// training_base_LukoyanovDataSet
			// 
			this.training_base_LukoyanovDataSet.DataSetName = "Training_base_LukoyanovDataSet";
			this.training_base_LukoyanovDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// customersBindingSource
			// 
			this.customersBindingSource.DataMember = "Customers";
			this.customersBindingSource.DataSource = this.training_base_LukoyanovDataSet;
			// 
			// customersTableAdapter
			// 
			this.customersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
			this.tableAdapterManager.Order_DetailsTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.ProductTableAdapter = null;
			this.tableAdapterManager.SalespeopleTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Project_TrainingBase_Lukoyanov.Training_base_LukoyanovDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// customersBindingNavigator
			// 
			this.customersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.customersBindingNavigator.BindingSource = this.customersBindingSource;
			this.customersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.customersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.customersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.customersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customersBindingNavigatorSaveItem});
			this.customersBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.customersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.customersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.customersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.customersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.customersBindingNavigator.Name = "customersBindingNavigator";
			this.customersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.customersBindingNavigator.Size = new System.Drawing.Size(971, 31);
			this.customersBindingNavigator.TabIndex = 0;
			this.customersBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
			// customersBindingNavigatorSaveItem
			// 
			this.customersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.customersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customersBindingNavigatorSaveItem.Image")));
			this.customersBindingNavigatorSaveItem.Name = "customersBindingNavigatorSaveItem";
			this.customersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
			this.customersBindingNavigatorSaveItem.Text = "Сохранить данные";
			this.customersBindingNavigatorSaveItem.Click += new System.EventHandler(this.customersBindingNavigatorSaveItem_Click);
			// 
			// customersDataGridView
			// 
			this.customersDataGridView.AutoGenerateColumns = false;
			this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.customersDataGridView.DataSource = this.customersBindingSource;
			this.customersDataGridView.Location = new System.Drawing.Point(12, 79);
			this.customersDataGridView.Name = "customersDataGridView";
			this.customersDataGridView.RowHeadersWidth = 51;
			this.customersDataGridView.RowTemplate.Height = 24;
			this.customersDataGridView.Size = new System.Drawing.Size(947, 233);
			this.customersDataGridView.TabIndex = 1;
			this.customersDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.customersDataGridView_UserDeletingRow);
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "SNUM";
			this.dataGridViewTextBoxColumn5.HeaderText = "SNUM";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 150;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "RATING";
			this.dataGridViewTextBoxColumn4.HeaderText = "RATING";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "CITY";
			this.dataGridViewTextBoxColumn3.HeaderText = "CITY";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 150;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CNAME";
			this.dataGridViewTextBoxColumn2.HeaderText = "CNAME";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 150;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "CNUM";
			this.dataGridViewTextBoxColumn1.HeaderText = "CNUM";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 150;
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.saveButton.Location = new System.Drawing.Point(12, 334);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(193, 46);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Сохранить";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// Customers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(971, 450);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.customersDataGridView);
			this.Controls.Add(this.customersBindingNavigator);
			this.Name = "Customers";
			this.Text = "Покупатели";
			this.Load += new System.EventHandler(this.Customers_Load);
			((System.ComponentModel.ISupportInitialize)(this.training_base_LukoyanovDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customersBindingNavigator)).EndInit();
			this.customersBindingNavigator.ResumeLayout(false);
			this.customersBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Training_base_LukoyanovDataSet training_base_LukoyanovDataSet;
		private System.Windows.Forms.BindingSource customersBindingSource;
		private Training_base_LukoyanovDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
		private Training_base_LukoyanovDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator customersBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton customersBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView customersDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button saveButton;
	}
}