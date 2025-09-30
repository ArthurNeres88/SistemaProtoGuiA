namespace SistemaProtoGuiA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlPrincipal = new Panel();
            lblAviso = new Label();
            btnSalvar = new Button();
            chkAtivo = new CheckBox();
            txtNome = new TextBox();
            lblNome = new Label();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lblAviso);
            pnlPrincipal.Controls.Add(btnSalvar);
            pnlPrincipal.Controls.Add(chkAtivo);
            pnlPrincipal.Controls.Add(txtNome);
            pnlPrincipal.Controls.Add(lblNome);
            pnlPrincipal.Location = new Point(15, 17);
            pnlPrincipal.Margin = new Padding(4);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(538, 231);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.BackColor = Color.FromArgb(255, 255, 192);
            lblAviso.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.FromArgb(192, 0, 0);
            lblAviso.Location = new Point(94, 198);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(169, 21);
            lblAviso.TabIndex = 4;
            lblAviso.Text = "Digite um nome válido";
            lblAviso.Visible = false;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalvar.Font = new Font("Segoe UI", 14F);
            btnSalvar.Location = new Point(419, 143);
            btnSalvar.Margin = new Padding(4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 51);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkAtivo
            // 
            chkAtivo.AutoSize = true;
            chkAtivo.Font = new Font("Segoe UI", 14F);
            chkAtivo.Location = new Point(94, 154);
            chkAtivo.Margin = new Padding(4);
            chkAtivo.Name = "chkAtivo";
            chkAtivo.Size = new Size(74, 29);
            chkAtivo.TabIndex = 2;
            chkAtivo.Text = "Ativo";
            chkAtivo.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(94, 90);
            txtNome.Margin = new Padding(4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(434, 32);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(0, 94);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 265);
            Controls.Add(pnlPrincipal);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Cadastro de Pessoa";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Label lblNome;
        private Button btnSalvar;
        private CheckBox chkAtivo;
        private TextBox txtNome;
        private Label lblAviso;
    }
}
