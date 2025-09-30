namespace SistemaProtoGuiA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == "")
            {
                lblAviso.Visible = true;
                txtNome.Focus();
                txtNome.SelectAll();
                return;
            }

            Usuario usuario = new Usuario()
            {
                Nome = txtNome.Text,
                Ativo = chkAtivo.Checked
            };

            UsuarioRepository.SaveOrUpdate(usuario);

            MessageBox.Show("Nome: " + usuario.Nome + "\nAtivo: " + usuario.Ativo);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblAviso.Visible = false;

            if (txtNome.Text.Trim() == "")
            {
                lblAviso.Visible = true;
            }

        }
    }
}
