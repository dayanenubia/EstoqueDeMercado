namespace SistemaCadastro
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFecharS = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCadastrarProduto = new System.Windows.Forms.TabPage();
            this.txtsecao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnConfirmaCadastroP = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtquantEstoque = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabBuscar = new System.Windows.Forms.TabPage();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbuscas = new System.Windows.Forms.TextBox();
            this.textbuscam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBusca = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tabAlterar = new System.Windows.Forms.TabPage();
            this.textAlteraSecao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirmaAlteracao = new System.Windows.Forms.Button();
            this.textAlteraMarca = new System.Windows.Forms.TextBox();
            this.textAlteraQuant = new System.Windows.Forms.TextBox();
            this.textAlteraNome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCadastrarProduto.SuspendLayout();
            this.tabBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.tabAlterar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Controls.Add(this.btnBuscaProduto);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnCadastraProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 502);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.LightSteelBlue;
            this.marcador.Location = new System.Drawing.Point(1, 279);
            this.marcador.Margin = new System.Windows.Forms.Padding(4);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(11, 41);
            this.marcador.TabIndex = 8;
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.FlatAppearance.BorderSize = 0;
            this.btnBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscaProduto.ForeColor = System.Drawing.Color.White;
            this.btnBuscaProduto.Image = global::SistemaCadastro.Properties.Resources._003_search;
            this.btnBuscaProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaProduto.Location = new System.Drawing.Point(11, 311);
            this.btnBuscaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(162, 56);
            this.btnBuscaProduto.TabIndex = 5;
            this.btnBuscaProduto.Text = "&Buscar Produtos";
            this.btnBuscaProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscaProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscaProduto.UseVisualStyleBackColor = true;
            this.btnBuscaProduto.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 128);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTROLE DE ESTOQUE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.FlatAppearance.BorderSize = 0;
            this.btnCadastraProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastraProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastraProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastraProduto.Image = global::SistemaCadastro.Properties.Resources.add;
            this.btnCadastraProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastraProduto.Location = new System.Drawing.Point(8, 267);
            this.btnCadastraProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(184, 56);
            this.btnCadastraProduto.TabIndex = 3;
            this.btnCadastraProduto.Text = "&Cadastrar Produtos";
            this.btnCadastraProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastraProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnFecharS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(181, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 41);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(52, 44);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(146, 151);
            this.panel3.TabIndex = 2;
            // 
            // btnFecharS
            // 
            this.btnFecharS.FlatAppearance.BorderSize = 0;
            this.btnFecharS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharS.ForeColor = System.Drawing.Color.White;
            this.btnFecharS.Image = global::SistemaCadastro.Properties.Resources.close;
            this.btnFecharS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharS.Location = new System.Drawing.Point(732, -5);
            this.btnFecharS.Margin = new System.Windows.Forms.Padding(4);
            this.btnFecharS.Name = "btnFecharS";
            this.btnFecharS.Size = new System.Drawing.Size(52, 49);
            this.btnFecharS.TabIndex = 8;
            this.btnFecharS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFecharS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFecharS.UseVisualStyleBackColor = true;
            this.btnFecharS.Click += new System.EventHandler(this.btnFecharS_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastrarProduto);
            this.tabControl1.Controls.Add(this.tabBuscar);
            this.tabControl1.Controls.Add(this.tabAlterar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(181, 124);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 378);
            this.tabControl1.TabIndex = 9;
            // 
            // tabCadastrarProduto
            // 
            this.tabCadastrarProduto.BackColor = System.Drawing.Color.AliceBlue;
            this.tabCadastrarProduto.Controls.Add(this.txtsecao);
            this.tabCadastrarProduto.Controls.Add(this.label6);
            this.tabCadastrarProduto.Controls.Add(this.BtnConfirmaCadastroP);
            this.tabCadastrarProduto.Controls.Add(this.txtmarca);
            this.tabCadastrarProduto.Controls.Add(this.txtquantEstoque);
            this.tabCadastrarProduto.Controls.Add(this.txtnome);
            this.tabCadastrarProduto.Controls.Add(this.label3);
            this.tabCadastrarProduto.Controls.Add(this.label2);
            this.tabCadastrarProduto.Controls.Add(this.label4);
            this.tabCadastrarProduto.Location = new System.Drawing.Point(4, 25);
            this.tabCadastrarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastrarProduto.Name = "tabCadastrarProduto";
            this.tabCadastrarProduto.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastrarProduto.Size = new System.Drawing.Size(776, 349);
            this.tabCadastrarProduto.TabIndex = 0;
            this.tabCadastrarProduto.Text = "Cadastrar";
            // 
            // txtsecao
            // 
            this.txtsecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtsecao.Location = new System.Drawing.Point(154, 151);
            this.txtsecao.Name = "txtsecao";
            this.txtsecao.Size = new System.Drawing.Size(620, 26);
            this.txtsecao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seção:";
            // 
            // BtnConfirmaCadastroP
            // 
            this.BtnConfirmaCadastroP.FlatAppearance.BorderSize = 0;
            this.BtnConfirmaCadastroP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmaCadastroP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConfirmaCadastroP.ForeColor = System.Drawing.Color.DimGray;
            this.BtnConfirmaCadastroP.Image = global::SistemaCadastro.Properties.Resources.add;
            this.BtnConfirmaCadastroP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastroP.Location = new System.Drawing.Point(332, 200);
            this.BtnConfirmaCadastroP.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfirmaCadastroP.Name = "BtnConfirmaCadastroP";
            this.BtnConfirmaCadastroP.Size = new System.Drawing.Size(153, 56);
            this.BtnConfirmaCadastroP.TabIndex = 13;
            this.BtnConfirmaCadastroP.Text = "Confirmar";
            this.BtnConfirmaCadastroP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirmaCadastroP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirmaCadastroP.UseVisualStyleBackColor = true;
            this.BtnConfirmaCadastroP.Click += new System.EventHandler(this.BtnConfirmaCadastro_Click_1);
            // 
            // txtmarca
            // 
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtmarca.Location = new System.Drawing.Point(154, 105);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(620, 26);
            this.txtmarca.TabIndex = 11;
            // 
            // txtquantEstoque
            // 
            this.txtquantEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtquantEstoque.Location = new System.Drawing.Point(154, 58);
            this.txtquantEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantEstoque.Name = "txtquantEstoque";
            this.txtquantEstoque.Size = new System.Drawing.Size(620, 26);
            this.txtquantEstoque.TabIndex = 10;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtnome.Location = new System.Drawing.Point(154, 10);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(620, 29);
            this.txtnome.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quant Estoque:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // tabBuscar
            // 
            this.tabBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.tabBuscar.Controls.Add(this.btnAlterar);
            this.tabBuscar.Controls.Add(this.label8);
            this.tabBuscar.Controls.Add(this.label7);
            this.tabBuscar.Controls.Add(this.textbuscas);
            this.tabBuscar.Controls.Add(this.textbuscam);
            this.tabBuscar.Controls.Add(this.label5);
            this.tabBuscar.Controls.Add(this.textBusca);
            this.tabBuscar.Controls.Add(this.lblMensagem);
            this.tabBuscar.Controls.Add(this.dgProdutos);
            this.tabBuscar.Controls.Add(this.btnRemove);
            this.tabBuscar.Location = new System.Drawing.Point(4, 25);
            this.tabBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Name = "tabBuscar";
            this.tabBuscar.Padding = new System.Windows.Forms.Padding(4);
            this.tabBuscar.Size = new System.Drawing.Size(776, 349);
            this.tabBuscar.TabIndex = 1;
            this.tabBuscar.Text = "Buscar";
            this.tabBuscar.Click += new System.EventHandler(this.tabBuscar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterar.ForeColor = System.Drawing.Color.DimGray;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(8, 300);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(110, 40);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = " Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(7, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Seção:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marca:";
            // 
            // textbuscas
            // 
            this.textbuscas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbuscas.Location = new System.Drawing.Point(71, 132);
            this.textbuscas.Name = "textbuscas";
            this.textbuscas.Size = new System.Drawing.Size(124, 24);
            this.textbuscas.TabIndex = 5;
            this.textbuscas.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textbuscam
            // 
            this.textbuscam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textbuscam.Location = new System.Drawing.Point(71, 81);
            this.textbuscam.Name = "textbuscam";
            this.textbuscam.Size = new System.Drawing.Size(124, 24);
            this.textbuscam.TabIndex = 4;
            this.textbuscam.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Produto:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBusca
            // 
            this.textBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBusca.Location = new System.Drawing.Point(71, 28);
            this.textBusca.Name = "textBusca";
            this.textBusca.Size = new System.Drawing.Size(124, 24);
            this.textBusca.TabIndex = 2;
            this.textBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.ForeColor = System.Drawing.Color.Red;
            this.lblMensagem.Location = new System.Drawing.Point(91, 259);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 16);
            this.lblMensagem.TabIndex = 1;
            // 
            // dgProdutos
            // 
            this.dgProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Location = new System.Drawing.Point(208, 16);
            this.dgProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.RowHeadersWidth = 51;
            this.dgProdutos.RowTemplate.Height = 29;
            this.dgProdutos.Size = new System.Drawing.Size(550, 287);
            this.dgProdutos.TabIndex = 0;
            this.dgProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBandas_CellContentClick);
            // 
            // btnRemove
            // 
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRemove.ForeColor = System.Drawing.Color.DimGray;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(126, 300);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(140, 40);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "  Remover";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tabAlterar
            // 
            this.tabAlterar.BackColor = System.Drawing.Color.AliceBlue;
            this.tabAlterar.Controls.Add(this.textAlteraSecao);
            this.tabAlterar.Controls.Add(this.label9);
            this.tabAlterar.Controls.Add(this.btnConfirmaAlteracao);
            this.tabAlterar.Controls.Add(this.textAlteraMarca);
            this.tabAlterar.Controls.Add(this.textAlteraQuant);
            this.tabAlterar.Controls.Add(this.textAlteraNome);
            this.tabAlterar.Controls.Add(this.label10);
            this.tabAlterar.Controls.Add(this.label11);
            this.tabAlterar.Controls.Add(this.label12);
            this.tabAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tabAlterar.Location = new System.Drawing.Point(4, 25);
            this.tabAlterar.Name = "tabAlterar";
            this.tabAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlterar.Size = new System.Drawing.Size(776, 349);
            this.tabAlterar.TabIndex = 2;
            this.tabAlterar.Text = "Alterar";
            this.tabAlterar.Click += new System.EventHandler(this.tabAterar_Click);
            // 
            // textAlteraSecao
            // 
            this.textAlteraSecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAlteraSecao.Location = new System.Drawing.Point(148, 164);
            this.textAlteraSecao.Name = "textAlteraSecao";
            this.textAlteraSecao.Size = new System.Drawing.Size(620, 26);
            this.textAlteraSecao.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Seção:";
            // 
            // btnConfirmaAlteracao
            // 
            this.btnConfirmaAlteracao.FlatAppearance.BorderSize = 0;
            this.btnConfirmaAlteracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmaAlteracao.ForeColor = System.Drawing.Color.DimGray;
            this.btnConfirmaAlteracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmaAlteracao.Image")));
            this.btnConfirmaAlteracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.Location = new System.Drawing.Point(326, 213);
            this.btnConfirmaAlteracao.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmaAlteracao.Name = "btnConfirmaAlteracao";
            this.btnConfirmaAlteracao.Size = new System.Drawing.Size(223, 56);
            this.btnConfirmaAlteracao.TabIndex = 22;
            this.btnConfirmaAlteracao.Text = "Confirmar Alteração";
            this.btnConfirmaAlteracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmaAlteracao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmaAlteracao.UseVisualStyleBackColor = true;
            this.btnConfirmaAlteracao.Click += new System.EventHandler(this.btnConfirmaAlteracao_Click);
            // 
            // textAlteraMarca
            // 
            this.textAlteraMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAlteraMarca.Location = new System.Drawing.Point(148, 118);
            this.textAlteraMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textAlteraMarca.Name = "textAlteraMarca";
            this.textAlteraMarca.Size = new System.Drawing.Size(620, 26);
            this.textAlteraMarca.TabIndex = 19;
            // 
            // textAlteraQuant
            // 
            this.textAlteraQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAlteraQuant.Location = new System.Drawing.Point(148, 71);
            this.textAlteraQuant.Margin = new System.Windows.Forms.Padding(4);
            this.textAlteraQuant.Name = "textAlteraQuant";
            this.textAlteraQuant.Size = new System.Drawing.Size(620, 26);
            this.textAlteraQuant.TabIndex = 18;
            // 
            // textAlteraNome
            // 
            this.textAlteraNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textAlteraNome.Location = new System.Drawing.Point(148, 23);
            this.textAlteraNome.Margin = new System.Windows.Forms.Padding(4);
            this.textAlteraNome.Name = "textAlteraNome";
            this.textAlteraNome.Size = new System.Drawing.Size(620, 29);
            this.textAlteraNome.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(8, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Marca:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(8, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Quant Estoque:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Nome:";
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(965, 502);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastrarProduto.ResumeLayout(false);
            this.tabCadastrarProduto.PerformLayout();
            this.tabBuscar.ResumeLayout(false);
            this.tabBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.tabAlterar.ResumeLayout(false);
            this.tabAlterar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharS;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastrarProduto;
        private System.Windows.Forms.TabPage tabBuscar;
        private System.Windows.Forms.Button BtnConfirmaCadastroP;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtquantEstoque;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel marcador;
        private System.Windows.Forms.TextBox txtsecao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox textBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbuscas;
        private System.Windows.Forms.TextBox textbuscam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabPage tabAlterar;
        private System.Windows.Forms.TextBox textAlteraSecao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirmaAlteracao;
        private System.Windows.Forms.TextBox textAlteraMarca;
        private System.Windows.Forms.TextBox textAlteraQuant;
        private System.Windows.Forms.TextBox textAlteraNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAlterar;
    }
}