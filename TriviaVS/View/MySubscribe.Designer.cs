namespace TriviaVS.View
{
	partial class MySubscribe
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MySubscribe));
			this.triviaDataSet = new TriviaVS.triviaDataSet();
			this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.friendsTableAdapter = new TriviaVS.triviaDataSetTableAdapters.FriendsTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSetTableAdapters.TableAdapterManager();
			this.friendsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.friendsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.friendsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.triviaDataSet2 = new TriviaVS.triviaDataSet2();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersTableAdapter = new TriviaVS.triviaDataSet2TableAdapters.UsersTableAdapter();
			this.tableAdapterManager1 = new TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.friendsBindingNavigator)).BeginInit();
			this.friendsBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// triviaDataSet
			// 
			this.triviaDataSet.DataSetName = "triviaDataSet";
			this.triviaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// friendsBindingSource
			// 
			this.friendsBindingSource.DataMember = "Friends";
			this.friendsBindingSource.DataSource = this.triviaDataSet;
			// 
			// friendsTableAdapter
			// 
			this.friendsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.CategoriesTableAdapter = null;
			this.tableAdapterManager.FriendsTableAdapter = this.friendsTableAdapter;
			this.tableAdapterManager.QuestionsTableAdapter = null;
			this.tableAdapterManager.ReportsTableAdapter = null;
			this.tableAdapterManager.ScoresTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TriviaVS.triviaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = null;
			// 
			// friendsBindingNavigator
			// 
			this.friendsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.friendsBindingNavigator.BindingSource = this.friendsBindingSource;
			this.friendsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.friendsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.friendsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.friendsBindingNavigatorSaveItem});
			this.friendsBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.friendsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.friendsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.friendsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.friendsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.friendsBindingNavigator.Name = "friendsBindingNavigator";
			this.friendsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.friendsBindingNavigator.Size = new System.Drawing.Size(395, 25);
			this.friendsBindingNavigator.TabIndex = 0;
			this.friendsBindingNavigator.Text = "bindingNavigator1";
			this.friendsBindingNavigator.RefreshItems += new System.EventHandler(this.friendsBindingNavigator_RefreshItems);
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
			// friendsBindingNavigatorSaveItem
			// 
			this.friendsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.friendsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("friendsBindingNavigatorSaveItem.Image")));
			this.friendsBindingNavigatorSaveItem.Name = "friendsBindingNavigatorSaveItem";
			this.friendsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.friendsBindingNavigatorSaveItem.Text = "Save Data";
			this.friendsBindingNavigatorSaveItem.Click += new System.EventHandler(this.friendsBindingNavigatorSaveItem_Click);
			// 
			// friendsDataGridView
			// 
			this.friendsDataGridView.AutoGenerateColumns = false;
			this.friendsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.friendsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
			this.friendsDataGridView.DataSource = this.friendsBindingSource;
			this.friendsDataGridView.Location = new System.Drawing.Point(26, 70);
			this.friendsDataGridView.Name = "friendsDataGridView";
			this.friendsDataGridView.Size = new System.Drawing.Size(340, 322);
			this.friendsDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_follower";
			this.dataGridViewTextBoxColumn2.HeaderText = "id_follower";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "id_followed";
			this.dataGridViewTextBoxColumn3.HeaderText = "id_followed";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Raleway", 12F);
			this.label2.Location = new System.Drawing.Point(22, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "Following";
			// 
			// triviaDataSet2
			// 
			this.triviaDataSet2.DataSetName = "triviaDataSet2";
			this.triviaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataMember = "Users";
			this.usersBindingSource.DataSource = this.triviaDataSet2;
			// 
			// usersTableAdapter
			// 
			this.usersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.QuestionsTableAdapter = null;
			this.tableAdapterManager1.ReportsTableAdapter = null;
			this.tableAdapterManager1.ScoresTableAdapter = null;
			this.tableAdapterManager1.UpdateOrder = TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager1.UsersTableAdapter = this.usersTableAdapter;
			// 
			// MySubscribe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.friendsDataGridView);
			this.Controls.Add(this.friendsBindingNavigator);
			this.Name = "MySubscribe";
			this.Text = "MySubscribe";
			this.Load += new System.EventHandler(this.MySubscribe_Load);
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.friendsBindingNavigator)).EndInit();
			this.friendsBindingNavigator.ResumeLayout(false);
			this.friendsBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.friendsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private triviaDataSet triviaDataSet;
		private System.Windows.Forms.BindingSource friendsBindingSource;
		private triviaDataSetTableAdapters.FriendsTableAdapter friendsTableAdapter;
		private triviaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator friendsBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton friendsBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView friendsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.Label label2;
		private triviaDataSet2 triviaDataSet2;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private triviaDataSet2TableAdapters.UsersTableAdapter usersTableAdapter;
		private triviaDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
	}
}