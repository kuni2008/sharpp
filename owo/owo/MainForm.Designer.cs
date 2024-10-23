/*
 * Created by SharpDevelop.
 * User: CC2_PC27
 * Date: 23/10/2024
 * Time: 08:00 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace owo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(120, 225);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "SIGUIENTE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido 1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(158, 20);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(95, 20);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(158, 46);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(95, 20);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(158, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(95, 20);
			this.textBox3.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Apellido 2";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(158, 98);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(95, 20);
			this.textBox4.TabIndex = 7;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(158, 124);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(95, 20);
			this.textBox5.TabIndex = 8;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1er semestre",
									"3er semestre",
									"5to semestre"});
			this.comboBox1.Location = new System.Drawing.Point(158, 150);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(94, 21);
			this.comboBox1.TabIndex = 10;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(158, 178);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
			this.dateTimePicker1.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(49, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 15);
			this.label4.TabIndex = 12;
			this.label4.Text = "Telefono";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(49, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 15);
			this.label5.TabIndex = 13;
			this.label5.Text = "Direccion";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(49, 153);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 15);
			this.label6.TabIndex = 14;
			this.label6.Text = "Semestre";
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(49, 183);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Fecha de nacimiento";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 342);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "owo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}
