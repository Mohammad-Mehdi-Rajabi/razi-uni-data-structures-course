namespace prime_fibo
{
	partial class Form1
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
			this.isPrimBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.fiboBtn = new System.Windows.Forms.Button();
			this.numberTxt = new System.Windows.Forms.TextBox();
			this.resultTxt = new System.Windows.Forms.TextBox();
			this.clearBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// isPrimBtn
			// 
			this.isPrimBtn.Location = new System.Drawing.Point(159, 89);
			this.isPrimBtn.Name = "isPrimBtn";
			this.isPrimBtn.Size = new System.Drawing.Size(75, 23);
			this.isPrimBtn.TabIndex = 2;
			this.isPrimBtn.Text = "Is Prime?";
			this.isPrimBtn.UseVisualStyleBackColor = true;
			this.isPrimBtn.Click += new System.EventHandler(this.isPrimBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "enter your number here";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(266, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "result";
			// 
			// fiboBtn
			// 
			this.fiboBtn.Location = new System.Drawing.Point(159, 134);
			this.fiboBtn.Name = "fiboBtn";
			this.fiboBtn.Size = new System.Drawing.Size(75, 23);
			this.fiboBtn.TabIndex = 5;
			this.fiboBtn.Text = "Fibonacci";
			this.fiboBtn.UseVisualStyleBackColor = true;
			this.fiboBtn.Click += new System.EventHandler(this.fiboBtn_Click);
			// 
			// numberTxt
			// 
			this.numberTxt.Location = new System.Drawing.Point(145, 45);
			this.numberTxt.Name = "numberTxt";
			this.numberTxt.Size = new System.Drawing.Size(100, 20);
			this.numberTxt.TabIndex = 6;
			// 
			// resultTxt
			// 
			this.resultTxt.Location = new System.Drawing.Point(304, 45);
			this.resultTxt.Name = "resultTxt";
			this.resultTxt.Size = new System.Drawing.Size(100, 20);
			this.resultTxt.TabIndex = 7;
			// 
			// clearBtn
			// 
			this.clearBtn.Location = new System.Drawing.Point(313, 89);
			this.clearBtn.Name = "clearBtn";
			this.clearBtn.Size = new System.Drawing.Size(75, 23);
			this.clearBtn.TabIndex = 8;
			this.clearBtn.Text = "Clear";
			this.clearBtn.UseVisualStyleBackColor = true;
			this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 197);
			this.Controls.Add(this.clearBtn);
			this.Controls.Add(this.resultTxt);
			this.Controls.Add(this.numberTxt);
			this.Controls.Add(this.fiboBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.isPrimBtn);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button isPrimBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button fiboBtn;
		private System.Windows.Forms.TextBox numberTxt;
		private System.Windows.Forms.TextBox resultTxt;
		private System.Windows.Forms.Button clearBtn;
	}
}

