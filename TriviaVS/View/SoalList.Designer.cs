namespace TriviaVS.View
{
	partial class SoalList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoalList));
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label questionLabel;
			System.Windows.Forms.Label answerLabel;
			System.Windows.Forms.Label created_byLabel;
			this.triviaDataSet2 = new TriviaVS.triviaDataSet2();
			this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.questionsTableAdapter = new TriviaVS.triviaDataSet2TableAdapters.QuestionsTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager();
			this.questionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.questionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.questionsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.questionTextBox = new System.Windows.Forms.TextBox();
			this.answerTextBox = new System.Windows.Forms.TextBox();
			this.created_byTextBox = new System.Windows.Forms.TextBox();
			idLabel = new System.Windows.Forms.Label();
			questionLabel = new System.Windows.Forms.Label();
			answerLabel = new System.Windows.Forms.Label();
			created_byLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questionsBindingNavigator)).BeginInit();
			this.questionsBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// triviaDataSet2
			// 
			this.triviaDataSet2.DataSetName = "triviaDataSet2";
			this.triviaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// questionsBindingSource
			// 
			this.questionsBindingSource.DataMember = "Questions";
			this.questionsBindingSource.DataSource = this.triviaDataSet2;
			// 
			// questionsTableAdapter
			// 
			this.questionsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.QuestionsTableAdapter = this.questionsTableAdapter;
			this.tableAdapterManager.ReportsTableAdapter = null;
			this.tableAdapterManager.ScoresTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = null;
			// 
			// questionsBindingNavigator
			// 
			this.questionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.questionsBindingNavigator.BindingSource = this.questionsBindingSource;
			this.questionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.questionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.questionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.questionsBindingNavigatorSaveItem});
			this.questionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.questionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.questionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.questionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.questionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.questionsBindingNavigator.Name = "questionsBindingNavigator";
			this.questionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.questionsBindingNavigator.Size = new System.Drawing.Size(800, 25);
			this.questionsBindingNavigator.TabIndex = 0;
			this.questionsBindingNavigator.Text = "bindingNavigator1";
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
			// questionsBindingNavigatorSaveItem
			// 
			this.questionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.questionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("questionsBindingNavigatorSaveItem.Image")));
			this.questionsBindingNavigatorSaveItem.Name = "questionsBindingNavigatorSaveItem";
			this.questionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
			this.questionsBindingNavigatorSaveItem.Text = "Save Data";
			this.questionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.questionsBindingNavigatorSaveItem_Click);
			// 
			// questionsDataGridView
			// 
			this.questionsDataGridView.AutoGenerateColumns = false;
			this.questionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.questionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.questionsDataGridView.DataSource = this.questionsBindingSource;
			this.questionsDataGridView.Location = new System.Drawing.Point(397, 119);
			this.questionsDataGridView.Name = "questionsDataGridView";
			this.questionsDataGridView.Size = new System.Drawing.Size(300, 220);
			this.questionsDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "question";
			this.dataGridViewTextBoxColumn2.HeaderText = "question";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "answer";
			this.dataGridViewTextBoxColumn3.HeaderText = "answer";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "created_by";
			this.dataGridViewTextBoxColumn4.HeaderText = "created_by";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(149, 130);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(18, 13);
			idLabel.TabIndex = 2;
			idLabel.Text = "id:";
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "id", true));
			this.idTextBox.Location = new System.Drawing.Point(215, 127);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 3;
			// 
			// questionLabel
			// 
			questionLabel.AutoSize = true;
			questionLabel.Location = new System.Drawing.Point(149, 156);
			questionLabel.Name = "questionLabel";
			questionLabel.Size = new System.Drawing.Size(50, 13);
			questionLabel.TabIndex = 4;
			questionLabel.Text = "question:";
			// 
			// questionTextBox
			// 
			this.questionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "question", true));
			this.questionTextBox.Location = new System.Drawing.Point(215, 153);
			this.questionTextBox.Name = "questionTextBox";
			this.questionTextBox.Size = new System.Drawing.Size(100, 20);
			this.questionTextBox.TabIndex = 5;
			// 
			// answerLabel
			// 
			answerLabel.AutoSize = true;
			answerLabel.Location = new System.Drawing.Point(149, 182);
			answerLabel.Name = "answerLabel";
			answerLabel.Size = new System.Drawing.Size(44, 13);
			answerLabel.TabIndex = 6;
			answerLabel.Text = "answer:";
			// 
			// answerTextBox
			// 
			this.answerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "answer", true));
			this.answerTextBox.Location = new System.Drawing.Point(215, 179);
			this.answerTextBox.Name = "answerTextBox";
			this.answerTextBox.Size = new System.Drawing.Size(100, 20);
			this.answerTextBox.TabIndex = 7;
			// 
			// created_byLabel
			// 
			created_byLabel.AutoSize = true;
			created_byLabel.Location = new System.Drawing.Point(149, 208);
			created_byLabel.Name = "created_byLabel";
			created_byLabel.Size = new System.Drawing.Size(60, 13);
			created_byLabel.TabIndex = 8;
			created_byLabel.Text = "created by:";
			// 
			// created_byTextBox
			// 
			this.created_byTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "created_by", true));
			this.created_byTextBox.Location = new System.Drawing.Point(215, 205);
			this.created_byTextBox.Name = "created_byTextBox";
			this.created_byTextBox.Size = new System.Drawing.Size(100, 20);
			this.created_byTextBox.TabIndex = 9;
			// 
			// SoalList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(idLabel);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(questionLabel);
			this.Controls.Add(this.questionTextBox);
			this.Controls.Add(answerLabel);
			this.Controls.Add(this.answerTextBox);
			this.Controls.Add(created_byLabel);
			this.Controls.Add(this.created_byTextBox);
			this.Controls.Add(this.questionsDataGridView);
			this.Controls.Add(this.questionsBindingNavigator);
			this.Name = "SoalList";
			this.Text = "SoalList";
			this.Load += new System.EventHandler(this.SoalList_Load);
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questionsBindingNavigator)).EndInit();
			this.questionsBindingNavigator.ResumeLayout(false);
			this.questionsBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.questionsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private triviaDataSet2 triviaDataSet2;
		private System.Windows.Forms.BindingSource questionsBindingSource;
		private triviaDataSet2TableAdapters.QuestionsTableAdapter questionsTableAdapter;
		private triviaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator questionsBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton questionsBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView questionsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.TextBox answerTextBox;
		private System.Windows.Forms.TextBox created_byTextBox;
	}
}