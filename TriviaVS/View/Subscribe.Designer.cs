namespace TriviaVS.View
{
	partial class Subscribe
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
			this.label2 = new System.Windows.Forms.Label();
			this.BoxFind = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.triviaDataSet2 = new TriviaVS.triviaDataSet2();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersTableAdapter = new TriviaVS.triviaDataSet2TableAdapters.UsersTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager();
			this.usersDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Raleway", 12F);
			this.label2.Location = new System.Drawing.Point(12, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(156, 19);
			this.label2.TabIndex = 6;
			this.label2.Text = "Find friend by name";
			// 
			// BoxFind
			// 
			this.BoxFind.Font = new System.Drawing.Font("Lato", 12F);
			this.BoxFind.Location = new System.Drawing.Point(174, 10);
			this.BoxFind.Name = "BoxFind";
			this.BoxFind.Size = new System.Drawing.Size(296, 27);
			this.BoxFind.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LimeGreen;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(476, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(61, 27);
			this.button1.TabIndex = 8;
			this.button1.Text = "FIND";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.QuestionsTableAdapter = null;
			this.tableAdapterManager.ReportsTableAdapter = null;
			this.tableAdapterManager.ScoresTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
			// 
			// usersDataGridView
			// 
			this.usersDataGridView.AutoGenerateColumns = false;
			this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.usersDataGridView.DataSource = this.usersBindingSource;
			this.usersDataGridView.Location = new System.Drawing.Point(16, 82);
			this.usersDataGridView.Name = "usersDataGridView";
			this.usersDataGridView.Size = new System.Drawing.Size(241, 215);
			this.usersDataGridView.TabIndex = 9;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
			this.dataGridViewTextBoxColumn2.HeaderText = "username";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Raleway", 12F);
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 19);
			this.label1.TabIndex = 10;
			this.label1.Text = "Find Result";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LimeGreen;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(543, 10);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 27);
			this.button2.TabIndex = 12;
			this.button2.Text = "FOLLOW";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Subscribe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 309);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.usersDataGridView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BoxFind);
			this.Controls.Add(this.label2);
			this.Name = "Subscribe";
			this.Text = "Friend";
			this.Load += new System.EventHandler(this.Friend_Load);
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox BoxFind;
		private System.Windows.Forms.Button button1;
		private triviaDataSet2 triviaDataSet2;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private triviaDataSet2TableAdapters.UsersTableAdapter usersTableAdapter;
		private triviaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView usersDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
	}
}