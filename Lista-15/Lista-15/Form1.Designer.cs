namespace Lista_15
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblSetor = new Label();
            label2 = new Label();
            label3 = new Label();
            dtgSetores = new DataGridView();
            txtPesquisar = new TextBox();
            txtId = new TextBox();
            txtNome = new TextBox();
            btnGravar = new Button();
            button2 = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgSetores).BeginInit();
            SuspendLayout();
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSetor.Location = new Point(12, 22);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(175, 20);
            lblSetor.TabIndex = 0;
            lblSetor.Text = "Digite o nome do setor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 336);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 382);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // dtgSetores
            // 
            dtgSetores.AllowUserToAddRows = false;
            dtgSetores.AllowUserToDeleteRows = false;
            dtgSetores.AllowUserToResizeColumns = false;
            dtgSetores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSetores.Location = new Point(22, 68);
            dtgSetores.Name = "dtgSetores";
            dtgSetores.ReadOnly = true;
            dtgSetores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSetores.Size = new Size(432, 222);
            dtgSetores.TabIndex = 3;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(193, 22);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(251, 23);
            txtPesquisar.TabIndex = 4;
            txtPesquisar.TextChanged += txtPesquisar_TextChanged;
            // 
            // txtId
            // 
            txtId.Location = new Point(71, 333);
            txtId.MaxLength = 3;
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(71, 379);
            txtNome.MaxLength = 100;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(215, 23);
            txtNome.TabIndex = 6;
            // 
            // btnGravar
            // 
            btnGravar.BackColor = Color.ForestGreen;
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.ForeColor = SystemColors.ButtonHighlight;
            btnGravar.Location = new Point(22, 445);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(83, 29);
            btnGravar.TabIndex = 7;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = false;
            btnGravar.Click += btnGravar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Orange;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(203, 445);
            button2.Name = "button2";
            button2.Size = new Size(83, 29);
            button2.TabIndex = 8;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Firebrick;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(371, 445);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(83, 29);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 498);
            Controls.Add(btnExcluir);
            Controls.Add(button2);
            Controls.Add(btnGravar);
            Controls.Add(txtNome);
            Controls.Add(txtId);
            Controls.Add(txtPesquisar);
            Controls.Add(dtgSetores);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblSetor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSetores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSetor;
        private Label label2;
        private Label label3;
        private DataGridView dtgSetores;
        private TextBox txtPesquisar;
        private TextBox txtId;
        private TextBox txtNome;
        private Button btnGravar;
        private Button button2;
        private Button btnExcluir;
    }
}
