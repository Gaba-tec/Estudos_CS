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
			this.textoN = new System.Windows.Forms.TextBox();
			this.textoTit = new System.Windows.Forms.TextBox();
			this.botaoCadastro = new System.Windows.Forms.Button();
			this.comboTContas = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textoNumero
			// 
			this.textoNumero.AutoSize = true;
			this.textoNumero.Location = new System.Drawing.Point(22, 89);
			this.textoNumero.Name = "textoNumero";
			this.textoNumero.Size = new System.Drawing.Size(44, 13);
			this.textoNumero.TabIndex = 0;
			this.textoNumero.Text = "Numero";
			// 
			// textoTitular
			// 
			this.textoTitular.AutoSize = true;
			this.textoTitular.Location = new System.Drawing.Point(22, 139);
			this.textoTitular.Name = "textoTitular";
			this.textoTitular.Size = new System.Drawing.Size(36, 13);
			this.textoTitular.TabIndex = 1;
			this.textoTitular.Text = "Titular";
			// 
			// textoN
			// 
			this.textoN.Location = new System.Drawing.Point(101, 82);
			this.textoN.Name = "textoN";
			this.textoN.Size = new System.Drawing.Size(120, 20);
			this.textoN.TabIndex = 2;
			// 
			// textoTit
			// 
			this.textoTit.Location = new System.Drawing.Point(101, 132);
			this.textoTit.Name = "textoTit";
			this.textoTit.Size = new System.Drawing.Size(120, 20);
			this.textoTit.TabIndex = 3;
			// 
			// botaoCadastro
			// 
			this.botaoCadastro.Location = new System.Drawing.Point(87, 190);
			this.botaoCadastro.Name = "botaoCadastro";
			this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
			this.botaoCadastro.TabIndex = 4;
			this.botaoCadastro.Text = "Cadastrar";
			this.botaoCadastro.UseVisualStyleBackColor = true;
			this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
			// 
			// comboTContas
			// 
			this.comboTContas.FormattingEnabled = true;
			this.comboTContas.Location = new System.Drawing.Point(101, 32);
			this.comboTContas.Name = "comboTContas";
			this.comboTContas.Size = new System.Drawing.Size(125, 21);
			this.comboTContas.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Conta";
			// 
			// FormCadastroConta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 225);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboTContas);
			this.Controls.Add(this.botaoCadastro);
			this.Controls.Add(this.textoTit);
			this.Controls.Add(this.textoN);
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
		private System.Windows.Forms.TextBox textoN;
		private System.Windows.Forms.TextBox textoTit;
		private System.Windows.Forms.Button botaoCadastro;
		private System.Windows.Forms.ComboBox comboTContas;
		private System.Windows.Forms.Label label1;
	}
}