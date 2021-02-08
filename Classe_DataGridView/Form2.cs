using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_DataGridView
{
	public partial class frmCliente2<T> : Form where T: class
	{
		private string _id;
		private string _nome;
		public IEnumerable<T> _clientes;
	
		public string Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public string Nome
		{
			get { return _nome; }
			set { _nome = value; }
		}

		public IEnumerable<T> Clientes
		{
			get { return _clientes; }
			set { _clientes = value; }
		}


		public frmCliente2()
		{
			InitializeComponent();
		}

		public void Listar()
		{
			dgvCliente2.Columns.Clear();

			Type tipo = _clientes.GetType().GetProperties().Where(x => x.Name == "Item").Select(x => x.PropertyType).FirstOrDefault();

			List<PropertyInfo> propriedade = tipo.GetProperties()
												 .Where(x => x.Name == _id || x.Name == _nome)
												 .Select(x => x)
												 .OrderByDescending(x => x.Name == _id).ToList();

			dgvCliente2.Columns.Add(_id, _id);
			dgvCliente2.Columns.Add(_nome, _nome);

			/*
			var teste = _clientes.Select(x =>
			{
				List<string> lista = new List<string>();

				foreach (var p in propriedade)
				{
					lista.Add(p.GetValue(x).ToString());
				}
				return lista;
			});
			*/
			//dgvCliente2.DataSource = teste;

			
			var Lista = _clientes.Select(x =>
			{
				IDictionary<string, object> expando = new ExpandoObject();
				foreach (var prop in propriedade)
					expando.Add(prop.Name, prop.GetValue(x));
				return expando;
			});
			
			foreach (var l in Lista)
			{
				dgvCliente2.Rows.Add(((IDictionary<string, object>)l).Values.ToArray());
			}
		}

		private void frmCliente2_Load(object sender, EventArgs e)
		{
			Listar();
		}
	}
}
