﻿namespace Banco
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.textoTitular = new System.Windows.Forms.TextBox();
			this.textoNumero = new System.Windows.Forms.TextBox();
			this.textoSaldo = new System.Windows.Forms.TextBox();
			this.textoValor = new System.Windows.Forms.TextBox();
			this.botaoDeposito = new System.Windows.Forms.Button();
			this.botaoSaque = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboContas = new System.Windows.Forms.ComboBox();
			this.botaoNovaConta = new System.Windows.Forms.Button();
			this.botaoImpostos = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textoTitular
			// 
			this.textoTitular.Location = new System.Drawing.Point(140, 124);
			this.textoTitular.Name = "textoTitular";
			this.textoTitular.Size = new System.Drawing.Size(206, 20);
			this.textoTitular.TabIndex = 0;
			// 
			// textoNumero
			// 
			this.textoNumero.Location = new System.Drawing.Point(140, 171);
			this.textoNumero.Name = "textoNumero";
			this.textoNumero.Size = new System.Drawing.Size(206, 20);
			this.textoNumero.TabIndex = 1;
			// 
			// textoSaldo
			// 
			this.textoSaldo.Location = new System.Drawing.Point(140, 218);
			this.textoSaldo.Name = "textoSaldo";
			this.textoSaldo.Size = new System.Drawing.Size(206, 20);
			this.textoSaldo.TabIndex = 2;
			// 
			// textoValor
			// 
			this.textoValor.Location = new System.Drawing.Point(140, 266);
			this.textoValor.Name = "textoValor";
			this.textoValor.Size = new System.Drawing.Size(206, 20);
			this.textoValor.TabIndex = 3;
			// 
			// botaoDeposito
			// 
			this.botaoDeposito.Location = new System.Drawing.Point(255, 328);
			this.botaoDeposito.Name = "botaoDeposito";
			this.botaoDeposito.Size = new System.Drawing.Size(76, 32);
			this.botaoDeposito.TabIndex = 4;
			this.botaoDeposito.Text = "Depositar";
			this.botaoDeposito.UseVisualStyleBackColor = true;
			this.botaoDeposito.Click += new System.EventHandler(this.Deposito);
			// 
			// botaoSaque
			// 
			this.botaoSaque.Location = new System.Drawing.Point(173, 328);
			this.botaoSaque.Name = "botaoSaque";
			this.botaoSaque.Size = new System.Drawing.Size(76, 32);
			this.botaoSaque.TabIndex = 5;
			this.botaoSaque.Text = "Sacar";
			this.botaoSaque.UseVisualStyleBackColor = true;
			this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Titular";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Número";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Saldo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 273);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Valor";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Busca de Conta";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(29, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(85, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Escolha a Conta";
			// 
			// comboContas
			// 
			this.comboContas.FormattingEnabled = true;
			this.comboContas.Location = new System.Drawing.Point(131, 44);
			this.comboContas.Name = "comboContas";
			this.comboContas.Size = new System.Drawing.Size(215, 21);
			this.comboContas.TabIndex = 15;
			this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
			// 
			// botaoNovaConta
			// 
			this.botaoNovaConta.Location = new System.Drawing.Point(91, 328);
			this.botaoNovaConta.Name = "botaoNovaConta";
			this.botaoNovaConta.Size = new System.Drawing.Size(76, 32);
			this.botaoNovaConta.TabIndex = 16;
			this.botaoNovaConta.Text = "Nova Conta";
			this.botaoNovaConta.UseVisualStyleBackColor = true;
			this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click);
			// 
			// botaoImpostos
			// 
			this.botaoImpostos.Location = new System.Drawing.Point(10, 328);
			this.botaoImpostos.Name = "botaoImpostos";
			this.botaoImpostos.Size = new System.Drawing.Size(75, 32);
			this.botaoImpostos.TabIndex = 17;
			this.botaoImpostos.Text = "Impostos";
			this.botaoImpostos.UseVisualStyleBackColor = true;
			this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 372);
			this.Controls.Add(this.botaoImpostos);
			this.Controls.Add(this.botaoNovaConta);
			this.Controls.Add(this.comboContas);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.botaoSaque);
			this.Controls.Add(this.botaoDeposito);
			this.Controls.Add(this.textoValor);
			this.Controls.Add(this.textoSaldo);
			this.Controls.Add(this.textoNumero);
			this.Controls.Add(this.textoTitular);
			this.Name = "Form1";
			this.Text = " ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textoTitular;
		private System.Windows.Forms.TextBox textoNumero;
		private System.Windows.Forms.TextBox textoSaldo;
		private System.Windows.Forms.TextBox textoValor;
		private System.Windows.Forms.Button botaoDeposito;
		private System.Windows.Forms.Button botaoSaque;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboContas;
		private System.Windows.Forms.Button botaoNovaConta;
		private System.Windows.Forms.Button botaoImpostos;
	}
}

