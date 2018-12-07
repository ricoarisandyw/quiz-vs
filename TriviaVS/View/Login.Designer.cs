namespace TriviaVS
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.button1 = new System.Windows.Forms.Button();
			this.BoxUsername = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.BoxPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.triviaDataSet11 = new TriviaVS.triviaDataSet1();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.usersTableAdapter = new TriviaVS.triviaDataSet1TableAdapters.UsersTableAdapter();
			this.tableAdapterManager = new TriviaVS.triviaDataSet1TableAdapters.TableAdapterManager();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LimeGreen;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(76, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "LOGIN";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// BoxUsername
			// 
			this.BoxUsername.Font = new System.Drawing.Font("Lato", 12F);
			this.BoxUsername.Location = new System.Drawing.Point(76, 85);
			this.BoxUsername.Name = "BoxUsername";
			this.BoxUsername.Size = new System.Drawing.Size(296, 27);
			this.BoxUsername.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSeaGreen;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(220, 170);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(152, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "REGISTER";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.BtnRegister_Click);
			// 
			// BoxPassword
			// 
			this.BoxPassword.Font = new System.Drawing.Font("Lato", 12F);
			this.BoxPassword.Location = new System.Drawing.Point(76, 128);
			this.BoxPassword.Name = "BoxPassword";
			this.BoxPassword.PasswordChar = '*';
			this.BoxPassword.Size = new System.Drawing.Size(296, 27);
			this.BoxPassword.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Raleway", 8F);
			this.label1.Location = new System.Drawing.Point(141, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "guest your answer per char";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Username";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 137);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// triviaDataSet11
			// 
			this.triviaDataSet11.DataSetName = "triviaDataSet1";
			this.triviaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.DataMember = "Users";
			this.usersBindingSource.DataSource = this.triviaDataSet11;
			// 
			// usersTableAdapter
			// 
			this.usersTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.UpdateOrder = TriviaVS.triviaDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(177, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(58, 50);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.UseWaitCursor = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 219);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BoxPassword);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BoxUsername);
			this.Controls.Add(this.button1);
			this.Name = "Login";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox BoxUsername;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox BoxPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private triviaDataSet1 triviaDataSet11;
		private System.Windows.Forms.BindingSource usersBindingSource;
		private triviaDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
		private triviaDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

