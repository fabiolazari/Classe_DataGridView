using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Classe_DataGridView
{
	public partial class frmCliente : Form
	{
		List<Cliente> cli = new List<Cliente>();

		public frmCliente()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cli.Add(new Cliente { Id = 1, Nome = "Fulano", Telefone = "2524-5784" });
			cli.Add(new Cliente { Id = 2, Nome = "Ciclano", Telefone = "3245-2567" });
			cli.Add(new Cliente { Id = 3, Nome = "Beltrano", Telefone = "3234-3657" });
			cli.Add(new Cliente { Id = 4, Nome = "Dunha", Telefone = "2524-1258" });
			cli.Add(new Cliente { Id = 5, Nome = "Locha", Telefone = "3233-3185" });

			dgvCliente.Columns.Clear();
			dgvCliente.DataSource = cli;

		}

		private void btnPopular_Click(object sender, EventArgs e)
		{
			//var t = (List<Cliente>)cli.Select(x => new { x.Id, x.Nome });
			frmCliente2<Cliente> frm2 = new frmCliente2<Cliente>();
			frm2.Id = "Id";
			frm2.Nome = "Nome";
			frm2.Clientes = cli; //(List<Cliente>)cli.Select(x => new { x.Id, x.Nome });
			frm2.ShowDialog();
		}
	}
}
