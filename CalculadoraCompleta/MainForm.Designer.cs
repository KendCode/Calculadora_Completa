/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 08/08/2024
 * Hora: 21:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CalculadoraCompleta
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPantalla;
		private System.Windows.Forms.Button btnN1;
		private System.Windows.Forms.Button btnN6;
		private System.Windows.Forms.Button btnN9;
		private System.Windows.Forms.Button btnResta;
		private System.Windows.Forms.Button btnPunto;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnCa;
		private System.Windows.Forms.Button btnN8;
		private System.Windows.Forms.Button btnN5;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnSuma;
		private System.Windows.Forms.Button btnN3;
		private System.Windows.Forms.Button btnN2;
		private System.Windows.Forms.Button btnN0;
		private System.Windows.Forms.Button btnN7;
		private System.Windows.Forms.Button btnN4;
		private System.Windows.Forms.Button btnFact;
		private System.Windows.Forms.Button btnPotencia;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnRaiz;
		private System.Windows.Forms.Button btnMod;
		
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
			this.txtPantalla = new System.Windows.Forms.TextBox();
			this.btnN1 = new System.Windows.Forms.Button();
			this.btnN6 = new System.Windows.Forms.Button();
			this.btnN9 = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.btnPunto = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnCa = new System.Windows.Forms.Button();
			this.btnN8 = new System.Windows.Forms.Button();
			this.btnN5 = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnSuma = new System.Windows.Forms.Button();
			this.btnN3 = new System.Windows.Forms.Button();
			this.btnN2 = new System.Windows.Forms.Button();
			this.btnN0 = new System.Windows.Forms.Button();
			this.btnN7 = new System.Windows.Forms.Button();
			this.btnN4 = new System.Windows.Forms.Button();
			this.btnFact = new System.Windows.Forms.Button();
			this.btnPotencia = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnRaiz = new System.Windows.Forms.Button();
			this.btnMod = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPantalla
			// 
			this.txtPantalla.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPantalla.Location = new System.Drawing.Point(33, 31);
			this.txtPantalla.Multiline = true;
			this.txtPantalla.Name = "txtPantalla";
			this.txtPantalla.Size = new System.Drawing.Size(444, 82);
			this.txtPantalla.TabIndex = 0;
			this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnN1
			// 
			this.btnN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN1.Location = new System.Drawing.Point(33, 146);
			this.btnN1.Name = "btnN1";
			this.btnN1.Size = new System.Drawing.Size(71, 60);
			this.btnN1.TabIndex = 1;
			this.btnN1.Text = "1";
			this.btnN1.UseVisualStyleBackColor = true;
			this.btnN1.Click += new System.EventHandler(this.BtnN1Click);
			// 
			// btnN6
			// 
			this.btnN6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN6.Location = new System.Drawing.Point(218, 212);
			this.btnN6.Name = "btnN6";
			this.btnN6.Size = new System.Drawing.Size(71, 60);
			this.btnN6.TabIndex = 2;
			this.btnN6.Text = "6";
			this.btnN6.UseVisualStyleBackColor = true;
			this.btnN6.Click += new System.EventHandler(this.BtnN6Click);
			// 
			// btnN9
			// 
			this.btnN9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN9.Location = new System.Drawing.Point(218, 282);
			this.btnN9.Name = "btnN9";
			this.btnN9.Size = new System.Drawing.Size(71, 60);
			this.btnN9.TabIndex = 3;
			this.btnN9.Text = "9";
			this.btnN9.UseVisualStyleBackColor = true;
			this.btnN9.Click += new System.EventHandler(this.BtnN9Click);
			// 
			// btnResta
			// 
			this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnResta.Location = new System.Drawing.Point(396, 148);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(67, 60);
			this.btnResta.TabIndex = 4;
			this.btnResta.Text = "-";
			this.btnResta.UseVisualStyleBackColor = true;
			this.btnResta.Click += new System.EventHandler(this.BtnRestaClick);
			// 
			// btnPunto
			// 
			this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPunto.Location = new System.Drawing.Point(122, 362);
			this.btnPunto.Name = "btnPunto";
			this.btnPunto.Size = new System.Drawing.Size(71, 60);
			this.btnPunto.TabIndex = 5;
			this.btnPunto.Text = ".";
			this.btnPunto.UseVisualStyleBackColor = true;
			this.btnPunto.Click += new System.EventHandler(this.BtnPuntoClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(33, 428);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(256, 60);
			this.btnCalcular.TabIndex = 6;
			this.btnCalcular.Text = "=";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDividir.Location = new System.Drawing.Point(396, 212);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(71, 60);
			this.btnDividir.TabIndex = 7;
			this.btnDividir.Text = "/";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMultiplicar.Location = new System.Drawing.Point(319, 212);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(63, 60);
			this.btnMultiplicar.TabIndex = 8;
			this.btnMultiplicar.Text = "x";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnCa
			// 
			this.btnCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCa.Location = new System.Drawing.Point(319, 435);
			this.btnCa.Name = "btnCa";
			this.btnCa.Size = new System.Drawing.Size(80, 46);
			this.btnCa.TabIndex = 9;
			this.btnCa.Text = "CA";
			this.btnCa.UseVisualStyleBackColor = true;
			this.btnCa.Click += new System.EventHandler(this.BtnCaClick);
			// 
			// btnN8
			// 
			this.btnN8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN8.Location = new System.Drawing.Point(122, 282);
			this.btnN8.Name = "btnN8";
			this.btnN8.Size = new System.Drawing.Size(71, 60);
			this.btnN8.TabIndex = 10;
			this.btnN8.Text = "8";
			this.btnN8.UseVisualStyleBackColor = true;
			this.btnN8.Click += new System.EventHandler(this.BtnN8Click);
			// 
			// btnN5
			// 
			this.btnN5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN5.Location = new System.Drawing.Point(122, 212);
			this.btnN5.Name = "btnN5";
			this.btnN5.Size = new System.Drawing.Size(71, 60);
			this.btnN5.TabIndex = 11;
			this.btnN5.Text = "5";
			this.btnN5.UseVisualStyleBackColor = true;
			this.btnN5.Click += new System.EventHandler(this.BtnN5Click);
			// 
			// btnC
			// 
			this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnC.Location = new System.Drawing.Point(405, 433);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(62, 48);
			this.btnC.TabIndex = 12;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.BtnCClick);
			// 
			// btnSuma
			// 
			this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSuma.Location = new System.Drawing.Point(319, 146);
			this.btnSuma.Name = "btnSuma";
			this.btnSuma.Size = new System.Drawing.Size(63, 60);
			this.btnSuma.TabIndex = 13;
			this.btnSuma.Text = "+";
			this.btnSuma.UseVisualStyleBackColor = true;
			this.btnSuma.Click += new System.EventHandler(this.BtnSumaClick);
			// 
			// btnN3
			// 
			this.btnN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN3.Location = new System.Drawing.Point(218, 146);
			this.btnN3.Name = "btnN3";
			this.btnN3.Size = new System.Drawing.Size(71, 60);
			this.btnN3.TabIndex = 14;
			this.btnN3.Text = "3";
			this.btnN3.UseVisualStyleBackColor = true;
			this.btnN3.Click += new System.EventHandler(this.BtnN3Click);
			// 
			// btnN2
			// 
			this.btnN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN2.Location = new System.Drawing.Point(122, 146);
			this.btnN2.Name = "btnN2";
			this.btnN2.Size = new System.Drawing.Size(71, 60);
			this.btnN2.TabIndex = 15;
			this.btnN2.Text = "2";
			this.btnN2.UseVisualStyleBackColor = true;
			this.btnN2.Click += new System.EventHandler(this.BtnN2Click);
			// 
			// btnN0
			// 
			this.btnN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN0.Location = new System.Drawing.Point(33, 362);
			this.btnN0.Name = "btnN0";
			this.btnN0.Size = new System.Drawing.Size(71, 60);
			this.btnN0.TabIndex = 16;
			this.btnN0.Text = "0";
			this.btnN0.UseVisualStyleBackColor = true;
			this.btnN0.Click += new System.EventHandler(this.BtnN0Click);
			// 
			// btnN7
			// 
			this.btnN7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN7.Location = new System.Drawing.Point(33, 282);
			this.btnN7.Name = "btnN7";
			this.btnN7.Size = new System.Drawing.Size(71, 60);
			this.btnN7.TabIndex = 17;
			this.btnN7.Text = "7";
			this.btnN7.UseVisualStyleBackColor = true;
			this.btnN7.Click += new System.EventHandler(this.BtnN7Click);
			// 
			// btnN4
			// 
			this.btnN4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnN4.Location = new System.Drawing.Point(33, 212);
			this.btnN4.Name = "btnN4";
			this.btnN4.Size = new System.Drawing.Size(71, 60);
			this.btnN4.TabIndex = 18;
			this.btnN4.Text = "4";
			this.btnN4.UseVisualStyleBackColor = true;
			this.btnN4.Click += new System.EventHandler(this.BtnN4Click);
			// 
			// btnFact
			// 
			this.btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFact.Location = new System.Drawing.Point(319, 282);
			this.btnFact.Name = "btnFact";
			this.btnFact.Size = new System.Drawing.Size(63, 60);
			this.btnFact.TabIndex = 19;
			this.btnFact.Text = "!";
			this.btnFact.UseVisualStyleBackColor = true;
			this.btnFact.Click += new System.EventHandler(this.BtnFactClick);
			// 
			// btnPotencia
			// 
			this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPotencia.Location = new System.Drawing.Point(396, 282);
			this.btnPotencia.Name = "btnPotencia";
			this.btnPotencia.Size = new System.Drawing.Size(71, 60);
			this.btnPotencia.TabIndex = 20;
			this.btnPotencia.Text = "^";
			this.btnPotencia.UseVisualStyleBackColor = true;
			this.btnPotencia.Click += new System.EventHandler(this.BtnPotenciaClick);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(396, 362);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(71, 60);
			this.button3.TabIndex = 21;
			this.button3.Text = "-";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// btnRaiz
			// 
			this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRaiz.Location = new System.Drawing.Point(319, 362);
			this.btnRaiz.Name = "btnRaiz";
			this.btnRaiz.Size = new System.Drawing.Size(62, 60);
			this.btnRaiz.TabIndex = 22;
			this.btnRaiz.Text = "R";
			this.btnRaiz.UseVisualStyleBackColor = true;
			this.btnRaiz.Click += new System.EventHandler(this.BtnRaizClick);
			// 
			// btnMod
			// 
			this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMod.Location = new System.Drawing.Point(218, 362);
			this.btnMod.Name = "btnMod";
			this.btnMod.Size = new System.Drawing.Size(71, 60);
			this.btnMod.TabIndex = 23;
			this.btnMod.Text = "%";
			this.btnMod.UseVisualStyleBackColor = true;
			this.btnMod.Click += new System.EventHandler(this.BtnModClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BurlyWood;
			this.ClientSize = new System.Drawing.Size(506, 545);
			this.Controls.Add(this.btnMod);
			this.Controls.Add(this.btnRaiz);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnPotencia);
			this.Controls.Add(this.btnFact);
			this.Controls.Add(this.btnN4);
			this.Controls.Add(this.btnN7);
			this.Controls.Add(this.btnN0);
			this.Controls.Add(this.btnN2);
			this.Controls.Add(this.btnN3);
			this.Controls.Add(this.btnSuma);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnN5);
			this.Controls.Add(this.btnN8);
			this.Controls.Add(this.btnCa);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.btnPunto);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnN9);
			this.Controls.Add(this.btnN6);
			this.Controls.Add(this.btnN1);
			this.Controls.Add(this.txtPantalla);
			this.Name = "MainForm";
			this.Text = "CalculadoraCompleta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
