namespace TriviaVS.View
{
	partial class Category
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label id_questionLabel;
			System.Windows.Forms.Label categoryLabel;
			this.triviaDataSet = new TriviaVS.triviaDataSet();
			this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.categoriesTableAdapter = new TriviaVS.triviaDataSetTableAdapters.CategoriesTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSetTableAdapters.TableAdapterManager();
			this.categoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.categoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.id_questionTextBox = new System.Windows.Forms.TextBox();
			this.categoryTextBox = new System.Windows.Forms.TextBox();
			idLabel = new System.Windows.Forms.Label();
			id_questionLabel = new System.Windows.Forms.Label();
			categoryLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).BeginInit();
			this.categoriesBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// triviaDataSet
			// 
			this.triviaDataSet.DataSetName = "triviaDataSet";
			this.triviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// categoriesBindingSource
			// 
			this.categoriesBindingSource.DataMember = "Categories";
			this.categoriesBindingSource.DataSource = this.triviaDataSet;
			// 
			// categoriesTableAdapter
			// 
			this.categoriesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
			this.tableAdapterManager.FriendsTableAdapter = null;
			this.tableAdapterManager.QuestionsTableAdapter = null;
			this.tableAdapterManager.ReportsTableAdapter = null;
			this.tableAdapterManager.ScoresTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TriviaVS.triviaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = null;
			// 
			// categoriesBindingNavigator
			// 
			this.categoriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.categoriesBindingNavigator.BindingSource = this.categoriesBindingSource;
			this.categoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.categoriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.categoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.categoriesBindingNavigatorSaveItem});
			this.categoriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.categoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.categoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.categoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.categoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.categoriesBindingNavigator.Name = "categoriesBindingNavigator";
			this.categoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.categoriesBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.categoriesBindingNavigator.TabIndex = 0;
			this.categoriesBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// categoriesBindingNavigatorSaveItem
			// 
			this.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.categoriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBindingNavigatorSaveItem.Image")));
			this.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem";
			this.categoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.categoriesBindingNavigatorSaveItem.Text = "Save Data";
			this.categoriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriesBindingNavigatorSaveItem_Click);
			// 
			// categoriesDataGridView
			// 
			this.categoriesDataGridView.AutoGenerateColumns = false;
			this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.categoriesDataGridView.DataSource = this.categoriesBindingSource;
			this.categoriesDataGridView.Location = new System.Drawing.Point(397, 61);
			this.categoriesDataGridView.Name = "categoriesDataGridView";
			this.categoriesDataGridView.Size = new System.Drawing.Size(300, 220);
			this.categoriesDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_question";
			this.dataGridViewTextBoxColumn2.HeaderText = "id_question";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
			this.dataGridViewTextBoxColumn3.HeaderText = "category";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(161, 122);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(18, 13);
			idLabel.TabIndex = 2;
			idLabel.Text = "id:";
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "id", true));
			this.idTextBox.Location = new System.Drawing.Point(228, 119);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 3;
			// 
			// id_questionLabel
			// 
			id_questionLabel.AutoSize = true;
			id_questionLabel.Location = new System.Drawing.Point(161, 148);
			id_questionLabel.Name = "id_questionLabel";
			id_questionLabel.Size = new System.Drawing.Size(61, 13);
			id_questionLabel.TabIndex = 4;
			id_questionLabel.Text = "id question:";
			// 
			// id_questionTextBox
			// 
			this.id_questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "id_question", true));
			this.id_questionTextBox.Location = new System.Drawing.Point(228, 145);
			this.id_questionTextBox.Name = "id_questionTextBox";
			this.id_questionTextBox.ReadOnly = true;
			this.id_questionTextBox.Size = new System.Drawing.Size(100, 20);
			this.id_questionTextBox.TabIndex = 5;
			// 
			// categoryLabel
			// 
			categoryLabel.AutoSize = true;
			categoryLabel.Location = new System.Drawing.Point(161, 174);
			categoryLabel.Name = "categoryLabel";
			categoryLabel.Size = new System.Drawing.Size(51, 13);
			categoryLabel.TabIndex = 6;
			categoryLabel.Text = "category:";
			// 
			// categoryTextBox
			// 
			this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "category", true));
			this.categoryTextBox.Location = new System.Drawing.Point(228, 171);
			this.categoryTextBox.Name = "categoryTextBox";
			this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
			this.categoryTextBox.TabIndex = 7;
			// 
			// Category
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 319);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(id_questionLabel);
			this.Controls.Add(this.id_questionTextBox);
			this.Controls.Add(categoryLabel);
			this.Controls.Add(this.categoryTextBox);
			this.Controls.Add(this.categoriesDataGridView);
			this.Controls.Add(this.categoriesBindingNavigator);
			this.Name = "Category";
			this.Text = "Category";
			this.Load += new System.EventHandler(this.Category_Load);
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).EndInit();
			this.categoriesBindingNavigator.ResumeLayout(false);
			this.categoriesBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private triviaDataSet triviaDataSet;
		private System.Windows.Forms.BindingSource categoriesBindingSource;
		private triviaDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
		private triviaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator categoriesBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton categoriesBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView categoriesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox id_questionTextBox;
		private System.Windows.Forms.TextBox categoryTextBox;
	}
}