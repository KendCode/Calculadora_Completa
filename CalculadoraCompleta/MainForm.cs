/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 08/08/2024
 * Hora: 21:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraCompleta
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//atributos
		double n1,n2,resultado;
		string operador;
		bool nuevoNum;
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		public void verificar(){
			if(nuevoNum){
				txtPantalla.Clear();
				nuevoNum = false;
			}
		}
		
		void BtnN1Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text=txtPantalla.Text+"1";
		}
		void BtnN2Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="2";
		}
		void BtnN3Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="3";
		}
		void BtnN4Click(object sender, EventArgs e)
		{
			txtPantalla.Text+="4";
		}
		void BtnN5Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="5";
		}
		void BtnN6Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="6";
		}
		void BtnN7Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="7";
		}
		void BtnN8Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="8";
		}
		void BtnN9Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="9";
		}
		void BtnN0Click(object sender, EventArgs e)
		{
			verificar();
			txtPantalla.Text+="0";
		}
		void BtnPuntoClick(object sender, EventArgs e)
		{
			verificar();
			if(txtPantalla.Text.Equals(""))
				txtPantalla.Text+="0,";
			else
				txtPantalla.Text+=",";
		}
		void BtnCClick(object sender, EventArgs e)
		{
			txtPantalla.Clear();
		}
		void BtnCaClick(object sender, EventArgs e)
		{
			if(txtPantalla.Text.Length==1 || txtPantalla.Text=="")
				txtPantalla.Clear();
			else
				txtPantalla.Text=txtPantalla.Text.Substring(0,txtPantalla.Text.Length-1);
		}
		void BtnSumaClick(object sender, EventArgs e)
		{
			n1= double.Parse(txtPantalla.Text);
			operador="+";
			txtPantalla.Clear();
		}
		void BtnCalcularClick(object sender, EventArgs e)
		{
			n2 = Convert.ToDouble(txtPantalla.Text);
			switch(operador){
				case"+":
					resultado=n1+n2;
					txtPantalla.Text=resultado.ToString();
					break;
				case"-":
					resultado = n1-n2;
					txtPantalla.Text=resultado.ToString();
					break;
				case"*":
					resultado = n1*n2;
					txtPantalla.Text=resultado.ToString();
					break;
				case"/":
					resultado = n1/n2;
					txtPantalla.Text=resultado.ToString();
					break;
				case"^":
					resultado = Math.Pow(n1,n2);
					txtPantalla.Text=resultado.ToString();
					break;
				
			}
			nuevoNum = true;
		}
		void BtnRestaClick(object sender, EventArgs e)
		{
			n1= double.Parse(txtPantalla.Text);
			operador="-";
			txtPantalla.Clear();
		}
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			n1= double.Parse(txtPantalla.Text);
			operador="*";
			txtPantalla.Clear();
		}
		void BtnDividirClick(object sender, EventArgs e)
		{
			n1= double.Parse(txtPantalla.Text);
			operador="/";
			txtPantalla.Clear();
		}
		void BtnPotenciaClick(object sender, EventArgs e)
		{
			verificar();
			n1= double.Parse(txtPantalla.Text);
			operador = "^";
			txtPantalla.Clear();
			nuevoNum = true;
		}
		void BtnRaizClick(object sender, EventArgs e)
		{
			verificar();
			n1 = double.Parse(txtPantalla.Text);
			resultado = Math.Sqrt(n1);
			txtPantalla.Text=resultado.ToString();
			nuevoNum = true;
		}
		void BtnFactClick(object sender, EventArgs e)
		{
			verificar();
			n1 = double.Parse(txtPantalla.Text);
			double fac =1;
			for(double i=1; i<=n1; i++)
				fac*=i;
			txtPantalla.Text=fac.ToString();
			nuevoNum= true;
		}
		void BtnModClick(object sender, EventArgs e)
		{
			verificar();
			n1 = double.Parse(txtPantalla.Text);
			resultado = n1 / 100;
			txtPantalla.Text=resultado.ToString();
			nuevoNum = true;
		}
		
	}
}
