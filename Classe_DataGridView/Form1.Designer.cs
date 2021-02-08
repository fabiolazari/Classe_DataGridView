namespace Classe_DataGridView
{
	public partial class frmCliente
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
			this.dgvCliente = new System.Windows.Forms.DataGridView();
			this.btnPopular = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCliente
			// 
			this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCliente.Location = new System.Drawing.Point(14, 41);
			this.dgvCliente.Name = "dgvCliente";
			this.dgvCliente.Size = new System.Drawing.Size(558, 283);
			this.dgvCliente.TabIndex = 0;
			// 
			// btnPopular
			// 
			this.btnPopular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnPopular.Location = new System.Drawing.Point(497, 12);
			this.btnPopular.Name = "btnPopular";
			this.btnPopular.Size = new System.Drawing.Size(75, 23);
			this.btnPopular.TabIndex = 1;
			this.btnPopular.Text = "&Popular";
			this.btnPopular.UseVisualStyleBackColor = true;
			this.btnPopular.Click += new System.EventHandler(this.btnPopular_Click);
			// 
			// frmCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 334);
			this.Controls.Add(this.btnPopular);
			this.Controls.Add(this.dgvCliente);
			this.Name = "frmCliente";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCliente;
		private System.Windows.Forms.Button btnPopular;
	}
}

