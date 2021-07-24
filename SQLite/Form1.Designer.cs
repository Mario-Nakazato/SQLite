
namespace SQLite
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
            this.dataGridViewSQLite = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelmsg = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonTabela = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonProcurar = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLite)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSQLite
            // 
            this.dataGridViewSQLite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSQLite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSQLite.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSQLite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSQLite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.sobrenome});
            this.dataGridViewSQLite.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewSQLite.Name = "dataGridViewSQLite";
            this.dataGridViewSQLite.ReadOnly = true;
            this.dataGridViewSQLite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSQLite.Size = new System.Drawing.Size(600, 196);
            this.dataGridViewSQLite.TabIndex = 8;
            // 
            // id
            // 
            this.id.FillWeight = 21.31979F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // nome
            // 
            this.nome.FillWeight = 139.3401F;
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            // 
            // sobrenome
            // 
            this.sobrenome.FillWeight = 139.3401F;
            this.sobrenome.HeaderText = "SOBRENOME";
            this.sobrenome.Name = "sobrenome";
            // 
            // labelmsg
            // 
            this.labelmsg.AutoSize = true;
            this.labelmsg.Location = new System.Drawing.Point(12, 66);
            this.labelmsg.Name = "labelmsg";
            this.labelmsg.Size = new System.Drawing.Size(10, 13);
            this.labelmsg.TabIndex = 11;
            this.labelmsg.Text = ":";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "Nome";
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(12, 40);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(61, 13);
            this.labelSobrenome.TabIndex = 10;
            this.labelSobrenome.Text = "Sobrenome";
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(355, 9);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 23);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonTabela
            // 
            this.buttonTabela.Location = new System.Drawing.Point(355, 35);
            this.buttonTabela.Name = "buttonTabela";
            this.buttonTabela.Size = new System.Drawing.Size(75, 23);
            this.buttonTabela.TabIndex = 1;
            this.buttonTabela.Text = "Tabela";
            this.buttonTabela.UseVisualStyleBackColor = true;
            this.buttonTabela.Click += new System.EventHandler(this.buttonTabela_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(436, 9);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.Location = new System.Drawing.Point(436, 35);
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(75, 23);
            this.buttonProcurar.TabIndex = 3;
            this.buttonProcurar.Text = "Procurar";
            this.buttonProcurar.UseVisualStyleBackColor = true;
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(53, 11);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(268, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(79, 37);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(242, 20);
            this.textBoxSobrenome.TabIndex = 7;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(517, 9);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(517, 35);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 5;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonProcurar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonTabela);
            this.Controls.Add(this.buttonConectar);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelmsg);
            this.Controls.Add(this.dataGridViewSQLite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSQLite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSQLite;
        private System.Windows.Forms.Label labelmsg;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonTabela;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonProcurar;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome;
    }
}

