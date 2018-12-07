namespace TriviaVS.View
{
	partial class Categorizing
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
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label id_questionLabel;
			System.Windows.Forms.Label categoryLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categorizing));
			this.BoxFind = new System.Windows.Forms.TextBox();
			this.LblQuestion = new System.Windows.Forms.Label();
			this.BtnGuest = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.triviaDataSet = new TriviaVS.triviaDataSet();
			this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.categoriesTableAdapter = new TriviaVS.triviaDataSetTableAdapters.CategoriesTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSetTableAdapters.TableAdapterManager();
			this.categoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.categoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.id_questionTextBox = new System.Windows.Forms.TextBox();
			this.categoryTextBox = new System.Windows.Forms.TextBox();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
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
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(101, 148);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(18, 13);
			idLabel.TabIndex = 18;
			idLabel.Text = "id:";
			// 
			// id_questionLabel
			// 
			id_questionLabel.AutoSize = true;
			id_questionLabel.Location = new System.Drawing.Point(101, 174);
			id_questionLabel.Name = "id_questionLabel";
			id_questionLabel.Size = new System.Drawing.Size(61, 13);
			id_questionLabel.TabIndex = 20;
			id_questionLabel.Text = "id question:";
			// 
			// categoryLabel
			// 
			categoryLabel.AutoSize = true;
			categoryLabel.Location = new System.Drawing.Point(101, 200);
			categoryLabel.Name = "categoryLabel";
			categoryLabel.Size = new System.Drawing.Size(51, 13);
			categoryLabel.TabIndex = 22;
			categoryLabel.Text = "category:";
			// 
			// BoxFind
			// 
			this.BoxFind.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BoxFind.Location = new System.Drawing.Point(99, 37);
			this.BoxFind.Margin = new System.Windows.Forms.Padding(0);
			this.BoxFind.Name = "BoxFind";
			this.BoxFind.Size = new System.Drawing.Size(184, 28);
			this.BoxFind.TabIndex = 12;
			// 
			// LblQuestion
			// 
			this.LblQuestion.AutoSize = true;
			this.LblQuestion.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblQuestion.Location = new System.Drawing.Point(12, 40);
			this.LblQuestion.Name = "LblQuestion";
			this.LblQuestion.Size = new System.Drawing.Size(84, 21);
			this.LblQuestion.TabIndex = 13;
			this.LblQuestion.Text = "Cari Soal";
			this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtnGuest
			// 
			this.BtnGuest.BackColor = System.Drawing.Color.LimeGreen;
			this.BtnGuest.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.BtnGuest.FlatAppearance.BorderSize = 0;
			this.BtnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGuest.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuest.ForeColor = System.Drawing.Color.White;
			this.BtnGuest.Location = new System.Drawing.Point(289, 37);
			this.BtnGuest.Name = "BtnGuest";
			this.BtnGuest.Size = new System.Drawing.Size(80, 30);
			this.BtnGuest.TabIndex = 14;
			this.BtnGuest.Text = "CARI";
			this.BtnGuest.UseVisualStyleBackColor = false;
			this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LimeGreen;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(289, 77);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 30);
			this.button1.TabIndex = 15;
			this.button1.Text = "SIMPAN";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Raleway", 13F);
			this.label1.Location = new System.Drawing.Point(12, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 21);
			this.label1.TabIndex = 16;
			this.label1.Text = "Ubah Kategori";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(150, 77);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(133, 21);
			this.cmbCategory.TabIndex = 17;
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
			this.categoriesBindingNavigator.Size = new System.Drawing.Size(886, 25);
			this.categoriesBindingNavigator.TabIndex = 18;
			this.categoriesBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// categoriesBindingNavigatorSaveItem
			// 
			this.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.categoriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBindingNavigatorSaveItem.Image")));
			this.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem";
			this.categoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.categoriesBindingNavigatorSaveItem.Text = "Save Data";
			this.categoriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriesBindingNavigatorSaveItem_Click);
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "id", true));
			this.idTextBox.Location = new System.Drawing.Point(168, 145);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 19;
			// 
			// id_questionTextBox
			// 
			this.id_questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "id_question", true));
			this.id_questionTextBox.Location = new System.Drawing.Point(168, 171);
			this.id_questionTextBox.Name = "id_questionTextBox";
			this.id_questionTextBox.Size = new System.Drawing.Size(100, 20);
			this.id_questionTextBox.TabIndex = 21;
			// 
			// categoryTextBox
			// 
			this.categoryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "category", true));
			this.categoryTextBox.Location = new System.Drawing.Point(168, 197);
			this.categoryTextBox.Name = "categoryTextBox";
			this.categoryTextBox.ReadOnly = true;
			this.categoryTextBox.Size = new System.Drawing.Size(100, 20);
			this.categoryTextBox.TabIndex = 23;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
			this.dataGridViewTextBoxColumn3.HeaderText = "category";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_question";
			this.dataGridViewTextBoxColumn2.HeaderText = "id_question";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
			this.categoriesDataGridView.Location = new System.Drawing.Point(339, 122);
			this.categoriesDataGridView.Name = "categoriesDataGridView";
			this.categoriesDataGridView.Size = new System.Drawing.Size(300, 220);
			this.categoriesDataGridView.TabIndex = 18;
			// 
			// Categorizing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 362);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(id_questionLabel);
			this.Controls.Add(this.id_questionTextBox);
			this.Controls.Add(categoryLabel);
			this.Controls.Add(this.categoryTextBox);
			this.Controls.Add(this.categoriesDataGridView);
			this.Controls.Add(this.categoriesBindingNavigator);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnGuest);
			this.Controls.Add(this.LblQuestion);
			this.Controls.Add(this.BoxFind);
			this.Name = "Categorizing";
			this.Text = "Categorizing";
			this.Load += new System.EventHandler(this.Categorizing_Load);
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

		private System.Windows.Forms.TextBox BoxFind;
		private System.Windows.Forms.Label LblQuestion;
		private System.Windows.Forms.Button BtnGuest;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbCategory;
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
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox id_questionTextBox;
		private System.Windows.Forms.TextBox categoryTextBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridView categoriesDataGridView;
	}
}