namespace TriviaVS
{
	partial class Home
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.panel1 = new System.Windows.Forms.Panel();
			this.LblUsername = new System.Windows.Forms.Label();
			this.PicProfile = new System.Windows.Forms.PictureBox();
			this.LblQuestion = new System.Windows.Forms.Label();
			this.BtnGuest = new System.Windows.Forms.Button();
			this.BtnBermain = new System.Windows.Forms.Button();
			this.triviaDataSet2 = new TriviaVS.triviaDataSet2();
			this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.scoresTableAdapter = new TriviaVS.triviaDataSet2TableAdapters.ScoresTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager();
			this.scoresDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicProfile)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.panel1.Controls.Add(this.LblUsername);
			this.panel1.Controls.Add(this.PicProfile);
			this.panel1.Controls.Add(this.LblQuestion);
			this.panel1.Location = new System.Drawing.Point(1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 451);
			this.panel1.TabIndex = 0;
			// 
			// LblUsername
			// 
			this.LblUsername.AutoSize = true;
			this.LblUsername.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblUsername.ForeColor = System.Drawing.Color.White;
			this.LblUsername.Location = new System.Drawing.Point(14, 165);
			this.LblUsername.Name = "LblUsername";
			this.LblUsername.Size = new System.Drawing.Size(97, 21);
			this.LblUsername.TabIndex = 3;
			this.LblUsername.Text = "Username";
			this.LblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PicProfile
			// 
			this.PicProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicProfile.BackgroundImage")));
			this.PicProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.PicProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PicProfile.Location = new System.Drawing.Point(15, 43);
			this.PicProfile.Name = "PicProfile";
			this.PicProfile.Size = new System.Drawing.Size(164, 119);
			this.PicProfile.TabIndex = 2;
			this.PicProfile.TabStop = false;
			this.PicProfile.UseWaitCursor = true;
			// 
			// LblQuestion
			// 
			this.LblQuestion.AutoSize = true;
			this.LblQuestion.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblQuestion.ForeColor = System.Drawing.Color.White;
			this.LblQuestion.Location = new System.Drawing.Point(69, 19);
			this.LblQuestion.Name = "LblQuestion";
			this.LblQuestion.Size = new System.Drawing.Size(63, 21);
			this.LblQuestion.TabIndex = 1;
			this.LblQuestion.Text = "Profile";
			this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtnGuest
			// 
			this.BtnGuest.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.BtnGuest.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.BtnGuest.FlatAppearance.BorderSize = 0;
			this.BtnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGuest.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuest.ForeColor = System.Drawing.Color.White;
			this.BtnGuest.Location = new System.Drawing.Point(221, 12);
			this.BtnGuest.Name = "BtnGuest";
			this.BtnGuest.Size = new System.Drawing.Size(140, 30);
			this.BtnGuest.TabIndex = 14;
			this.BtnGuest.Text = "BUAT SOAL";
			this.BtnGuest.UseVisualStyleBackColor = false;
			this.BtnGuest.Click += new System.EventHandler(this.BtnGuest_Click);
			// 
			// BtnBermain
			// 
			this.BtnBermain.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.BtnBermain.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.BtnBermain.FlatAppearance.BorderSize = 0;
			this.BtnBermain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBermain.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBermain.ForeColor = System.Drawing.Color.White;
			this.BtnBermain.Location = new System.Drawing.Point(221, 48);
			this.BtnBermain.Name = "BtnBermain";
			this.BtnBermain.Size = new System.Drawing.Size(140, 30);
			this.BtnBermain.TabIndex = 15;
			this.BtnBermain.Text = "MULAI BERMAIN";
			this.BtnBermain.UseVisualStyleBackColor = false;
			this.BtnBermain.Click += new System.EventHandler(this.BtnBermain_Click);
			// 
			// triviaDataSet2
			// 
			this.triviaDataSet2.DataSetName = "triviaDataSet2";
			this.triviaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// scoresBindingSource
			// 
			this.scoresBindingSource.DataMember = "Scores";
			this.scoresBindingSource.DataSource = this.triviaDataSet2;
			// 
			// scoresTableAdapter
			// 
			this.scoresTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.QuestionsTableAdapter = null;
			this.tableAdapterManager.ReportsTableAdapter = null;
			this.tableAdapterManager.ScoresTableAdapter = this.scoresTableAdapter;
			this.tableAdapterManager.UpdateOrder = TriviaVS.triviaDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = null;
			// 
			// scoresDataGridView
			// 
			this.scoresDataGridView.AutoGenerateColumns = false;
			this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.scoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.scoresDataGridView.DataSource = this.scoresBindingSource;
			this.scoresDataGridView.Location = new System.Drawing.Point(230, 139);
			this.scoresDataGridView.Name = "scoresDataGridView";
			this.scoresDataGridView.Size = new System.Drawing.Size(440, 312);
			this.scoresDataGridView.TabIndex = 16;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "id_user";
			this.dataGridViewTextBoxColumn2.HeaderText = "id_user";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "id_category";
			this.dataGridViewTextBoxColumn3.HeaderText = "id_category";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "score";
			this.dataGridViewTextBoxColumn4.HeaderText = "score";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Font = new System.Drawing.Font("Raleway", 13F);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(226, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 21);
			this.label2.TabIndex = 5;
			this.label2.Text = "Scores";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(367, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(140, 30);
			this.button1.TabIndex = 17;
			this.button1.Text = "MY SUBSCRIBE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(367, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(140, 30);
			this.button2.TabIndex = 18;
			this.button2.Text = "SUBSCRIBE";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(513, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(168, 30);
			this.button3.TabIndex = 19;
			this.button3.Text = "KATEGORIKAN SOAL";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.MediumSeaGreen;
			this.button4.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(513, 48);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(168, 30);
			this.button4.TabIndex = 20;
			this.button4.Text = "DAFTAR KATEGORI";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Home
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 471);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.scoresDataGridView);
			this.Controls.Add(this.BtnBermain);
			this.Controls.Add(this.BtnGuest);
			this.Controls.Add(this.panel1);
			this.Name = "Home";
			this.Text = "Home";
			this.Load += new System.EventHandler(this.Home_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PicProfile)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox PicProfile;
		private System.Windows.Forms.Label LblQuestion;
		private System.Windows.Forms.Label LblUsername;
		private System.Windows.Forms.Button BtnGuest;
		private System.Windows.Forms.Button BtnBermain;
		private triviaDataSet2 triviaDataSet2;
		private System.Windows.Forms.BindingSource scoresBindingSource;
		private triviaDataSet2TableAdapters.ScoresTableAdapter scoresTableAdapter;
		private triviaDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView scoresDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}