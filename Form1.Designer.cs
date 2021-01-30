
namespace FX2Writer
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonProgram = new System.Windows.Forms.Button();
			this.radioButtonEEPROM = new System.Windows.Forms.RadioButton();
			this.radioButtonRAM = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(93, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(328, 19);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(427, 12);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(28, 19);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "...";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "Firmware File";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Firmware Image File (*.iic)|*.iic";
			// 
			// buttonProgram
			// 
			this.buttonProgram.Enabled = false;
			this.buttonProgram.Location = new System.Drawing.Point(366, 49);
			this.buttonProgram.Name = "buttonProgram";
			this.buttonProgram.Size = new System.Drawing.Size(89, 28);
			this.buttonProgram.TabIndex = 8;
			this.buttonProgram.Text = "Program";
			this.buttonProgram.UseVisualStyleBackColor = true;
			this.buttonProgram.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// radioButtonEEPROM
			// 
			this.radioButtonEEPROM.AutoSize = true;
			this.radioButtonEEPROM.Checked = true;
			this.radioButtonEEPROM.Location = new System.Drawing.Point(93, 55);
			this.radioButtonEEPROM.Name = "radioButtonEEPROM";
			this.radioButtonEEPROM.Size = new System.Drawing.Size(69, 16);
			this.radioButtonEEPROM.TabIndex = 9;
			this.radioButtonEEPROM.TabStop = true;
			this.radioButtonEEPROM.Text = "EEPROM";
			this.radioButtonEEPROM.UseVisualStyleBackColor = true;
			// 
			// radioButtonRAM
			// 
			this.radioButtonRAM.AutoSize = true;
			this.radioButtonRAM.Location = new System.Drawing.Point(187, 55);
			this.radioButtonRAM.Name = "radioButtonRAM";
			this.radioButtonRAM.Size = new System.Drawing.Size(48, 16);
			this.radioButtonRAM.TabIndex = 10;
			this.radioButtonRAM.Text = "RAM";
			this.radioButtonRAM.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 111);
			this.Controls.Add(this.radioButtonRAM);
			this.Controls.Add(this.radioButtonEEPROM);
			this.Controls.Add(this.buttonProgram);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EZ-USB FX2 EEPROM Writer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonProgram;
		private System.Windows.Forms.RadioButton radioButtonEEPROM;
		private System.Windows.Forms.RadioButton radioButtonRAM;
	}
}

