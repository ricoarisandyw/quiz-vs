namespace TriviaVS
{
	partial class Register
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BoxPassword = new System.Windows.Forms.TextBox();
			this.BtnRegister = new System.Windows.Forms.Button();
			this.BoxUsername = new System.Windows.Forms.TextBox();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.triviaDataSet11 = new TriviaVS.triviaDataSet1();
			this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(98, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(98, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 12;
			this.label2.Text = "Username";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(167, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 26);
			this.label1.TabIndex = 11;
			this.label1.Text = "Quiz";
			// 
			// BoxPassword
			// 
			this.BoxPassword.Font = new System.Drawing.Font("Lato", 12F);
			this.BoxPassword.Location = new System.Drawing.Point(99, 124);
			this.BoxPassword.Name = "BoxPassword";
			this.BoxPassword.Size = new System.Drawing.Size(200, 27);
			this.BoxPassword.TabIndex = 10;
			// 
			// BtnRegister
			// 
			this.BtnRegister.BackColor = System.Drawing.Color.LightSeaGreen;
			this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.BtnRegister.FlatAppearance.BorderSize = 0;
			this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRegister.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnRegister.ForeColor = System.Drawing.Color.White;
			this.BtnRegister.Location = new System.Drawing.Point(99, 157);
			this.BtnRegister.Name = "BtnRegister";
			this.BtnRegister.Size = new System.Drawing.Size(200, 30);
			this.BtnRegister.TabIndex = 9;
			this.BtnRegister.Text = "REGISTER";
			this.BtnRegister.UseVisualStyleBackColor = false;
			this.BtnRegister.Click += new System.EventHandler(this.Register_Click);
			// 
			// BoxUsername
			// 
			this.BoxUsername.Font = new System.Drawing.Font("Lato", 12F);
			this.BoxUsername.Location = new System.Drawing.Point(99, 77);
			this.BoxUsername.Name = "BoxUsername";
			this.BoxUsername.Size = new System.Drawing.Size(200, 27);
			this.BoxUsername.TabIndex = 8;
			// 
			// BtnLogin
			// 
			this.BtnLogin.BackColor = System.Drawing.Color.LimeGreen;
			this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.BtnLogin.FlatAppearance.BorderSize = 0;
			this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnLogin.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.ForeColor = System.Drawing.Color.White;
			this.BtnLogin.Location = new System.Drawing.Point(99, 193);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(200, 30);
			this.BtnLogin.TabIndex = 7;
			this.BtnLogin.Text = "LOGIN";
			this.BtnLogin.UseVisualStyleBackColor = false;
			this.BtnLogin.Click += new System.EventHandler(this.Login_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(156, 47);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Fill it to Regist";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// triviaDataSet11
			// 
			this.triviaDataSet11.DataSetName = "triviaDataSet1";
			this.triviaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// usersBindingSource
			// 
			this.usersBindingSource.AllowNew = true;
			this.usersBindingSource.DataMember = "Users";
			this.usersBindingSource.DataSource = this.triviaDataSet11;
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BoxPassword);
			this.Controls.Add(this.BtnRegister);
			this.Controls.Add(this.BoxUsername);
			this.Controls.Add(this.BtnLogin);
			this.Name = "Register";
			this.Text = "Register";
			((System.ComponentModel.ISupportInitialize)(this.triviaDataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox BoxPassword;
		private System.Windows.Forms.Button BtnRegister;
		private System.Windows.Forms.TextBox BoxUsername;
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.Label label4;
		private triviaDataSet1 triviaDataSet11;
		private System.Windows.Forms.BindingSource usersBindingSource;
	}
}