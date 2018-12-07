namespace TriviaVS
{
	partial class Gameplay
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
			this.LblQuestion = new System.Windows.Forms.Label();
			this.LblLife = new System.Windows.Forms.Label();
			this.LblPoint = new System.Windows.Forms.Label();
			this.BtnAnswer = new System.Windows.Forms.Button();
			this.BoxAnswer = new System.Windows.Forms.TextBox();
			this.LblAnswer = new System.Windows.Forms.Label();
			this.BtnGuest = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.boxReport = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LblQuestion
			// 
			this.LblQuestion.AutoSize = true;
			this.LblQuestion.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblQuestion.Location = new System.Drawing.Point(263, 96);
			this.LblQuestion.Name = "LblQuestion";
			this.LblQuestion.Size = new System.Drawing.Size(273, 21);
			this.LblQuestion.TabIndex = 0;
			this.LblQuestion.Text = "You can put your question here";
			this.LblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LblLife
			// 
			this.LblLife.AutoSize = true;
			this.LblLife.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblLife.Location = new System.Drawing.Point(12, 9);
			this.LblLife.Name = "LblLife";
			this.LblLife.Size = new System.Drawing.Size(129, 21);
			this.LblLife.TabIndex = 1;
			this.LblLife.Text = "Your Life : 3/3";
			// 
			// LblPoint
			// 
			this.LblPoint.AutoSize = true;
			this.LblPoint.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblPoint.Location = new System.Drawing.Point(711, 9);
			this.LblPoint.Name = "LblPoint";
			this.LblPoint.Size = new System.Drawing.Size(77, 21);
			this.LblPoint.TabIndex = 2;
			this.LblPoint.Text = "Point : 0";
			// 
			// BtnAnswer
			// 
			this.BtnAnswer.BackColor = System.Drawing.Color.LightSeaGreen;
			this.BtnAnswer.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.BtnAnswer.FlatAppearance.BorderSize = 0;
			this.BtnAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAnswer.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAnswer.ForeColor = System.Drawing.Color.White;
			this.BtnAnswer.Location = new System.Drawing.Point(466, 202);
			this.BtnAnswer.Name = "BtnAnswer";
			this.BtnAnswer.Size = new System.Drawing.Size(46, 28);
			this.BtnAnswer.TabIndex = 10;
			this.BtnAnswer.Text = ">";
			this.BtnAnswer.UseVisualStyleBackColor = false;
			this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
			// 
			// BoxAnswer
			// 
			this.BoxAnswer.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BoxAnswer.Location = new System.Drawing.Point(279, 202);
			this.BoxAnswer.Margin = new System.Windows.Forms.Padding(0);
			this.BoxAnswer.Name = "BoxAnswer";
			this.BoxAnswer.Size = new System.Drawing.Size(184, 28);
			this.BoxAnswer.TabIndex = 11;
			// 
			// LblAnswer
			// 
			this.LblAnswer.AutoSize = true;
			this.LblAnswer.Font = new System.Drawing.Font("Raleway", 13F);
			this.LblAnswer.Location = new System.Drawing.Point(350, 155);
			this.LblAnswer.Name = "LblAnswer";
			this.LblAnswer.Size = new System.Drawing.Size(113, 21);
			this.LblAnswer.TabIndex = 12;
			this.LblAnswer.Text = "_ _ _   _ N _ O";
			this.LblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// BtnGuest
			// 
			this.BtnGuest.BackColor = System.Drawing.Color.LimeGreen;
			this.BtnGuest.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.BtnGuest.FlatAppearance.BorderSize = 0;
			this.BtnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnGuest.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGuest.ForeColor = System.Drawing.Color.White;
			this.BtnGuest.Location = new System.Drawing.Point(279, 236);
			this.BtnGuest.Name = "BtnGuest";
			this.BtnGuest.Size = new System.Drawing.Size(233, 30);
			this.BtnGuest.TabIndex = 13;
			this.BtnGuest.Text = "GUEST FULL ANSWER";
			this.BtnGuest.UseVisualStyleBackColor = false;
			this.BtnGuest.Click += new System.EventHandler(this.BtnSkip_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Crimson;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(16, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 30);
			this.button1.TabIndex = 14;
			this.button1.Text = "SURENDER";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnReport
			// 
			this.btnReport.BackColor = System.Drawing.Color.Crimson;
			this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
			this.btnReport.FlatAppearance.BorderSize = 0;
			this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReport.Font = new System.Drawing.Font("Lato Heavy", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport.ForeColor = System.Drawing.Color.White;
			this.btnReport.Location = new System.Drawing.Point(279, 300);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(233, 30);
			this.btnReport.TabIndex = 15;
			this.btnReport.Text = "REPORT";
			this.btnReport.UseVisualStyleBackColor = false;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// boxReport
			// 
			this.boxReport.Font = new System.Drawing.Font("Raleway", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.boxReport.Location = new System.Drawing.Point(279, 269);
			this.boxReport.Margin = new System.Windows.Forms.Padding(0);
			this.boxReport.Name = "boxReport";
			this.boxReport.Size = new System.Drawing.Size(233, 28);
			this.boxReport.TabIndex = 16;
			// 
			// Gameplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 337);
			this.Controls.Add(this.boxReport);
			this.Controls.Add(this.btnReport);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnGuest);
			this.Controls.Add(this.LblAnswer);
			this.Controls.Add(this.BoxAnswer);
			this.Controls.Add(this.BtnAnswer);
			this.Controls.Add(this.LblPoint);
			this.Controls.Add(this.LblLife);
			this.Controls.Add(this.LblQuestion);
			this.Name = "Gameplay";
			this.Text = "Gameplay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblQuestion;
		private System.Windows.Forms.Label LblLife;
		private System.Windows.Forms.Label LblPoint;
		private System.Windows.Forms.Button BtnAnswer;
		private System.Windows.Forms.TextBox BoxAnswer;
		private System.Windows.Forms.Label LblAnswer;
		private System.Windows.Forms.Button BtnGuest;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.TextBox boxReport;
	}
}