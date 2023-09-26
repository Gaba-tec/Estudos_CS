namespace Banco
{
	partial class FormCadastroConta
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
			this.textoNumero = new System.Windows.Forms.Label();
			this.textoTitular = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.botaoCadastro = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textoNumero
			// 
			this.textoNumero.AutoSize = true;
			this.textoNumero.Location = new System.Drawing.Point(32, 21);
			this.textoNumero.Name = "textoNumero";
			this.textoNumero.Size = new System.Drawing.Size(44, 13);
			this.textoNumero.TabIndex = 0;
			this.textoNumero.Text = "Numero";
			// 
			// textoTitular
			// 
			this.textoTitular.AutoSize = true;
			this.textoTitular.Location = new System.Drawing.Point(32, 66);
			this.textoTitular.Name = "textoTitular";
			this.textoTitular.Size = new System.Drawing.Size(36, 13);
			this.textoTitular.TabIndex = 1;
			this.textoTitular.Text = "Titular";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(101, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(101, 59);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// botaoCadastro
			// 
			this.botaoCadastro.Location = new System.Drawing.Point(78, 103);
			this.botaoCadastro.Name = "botaoCadastro";
			this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
			this.botaoCadastro.TabIndex = 4;
			this.botaoCadastro.Text = "Cadastrar";
			this.botaoCadastro.UseVisualStyleBackColor = true;
			this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
			// 
			// FormCadastroConta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 138);
			this.Controls.Add(this.botaoCadastro);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textoTitular);
			this.Controls.Add(this.textoNumero);
			this.Name = "FormCadastroConta";
			this.Text = " ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label textoNumero;
		private System.Windows.Forms.Label textoTitular;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button botaoCadastro;
	}
}