using MySql.Data.MySqlClient;

namespace Cadastro_de_Atletas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //gênero
            cbxGenero.Items.Add("M");
            cbxGenero.Items.Add("F");
            //tipo sanguíneo
            cbxTipoSanguineo.Items.Add("A-");
            cbxTipoSanguineo.Items.Add("A+");
            cbxTipoSanguineo.Items.Add("B-");
            cbxTipoSanguineo.Items.Add("B+");
            cbxTipoSanguineo.Items.Add("AB-");
            cbxTipoSanguineo.Items.Add("AB+");
            cbxTipoSanguineo.Items.Add("O+");
            cbxTipoSanguineo.Items.Add("O-");

           
        }
        private double CalculaImc(Atleta atleta)
        {
            return (atleta.InformacoesMedicas.Peso / (atleta.InformacoesMedicas.Altura * atleta.InformacoesMedicas.Altura));
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Atleta atleta = new Atleta();
            atleta.Nome = txtNome.Text;
            atleta.Nacionalidade = txtNacionalidade.Text;
            atleta.Modalidade = txtModalidade.Text;
            atleta.Genero = cbxGenero.SelectedItem.ToString();
            atleta.DataNascimento = dtpNascimento.Value.Date;
            atleta.Idade = DateTime.Now.Year - atleta.DataNascimento.Year;
            atleta.InformacoesMedicas.Altura = Convert.ToDouble(txtAltura.Text);
            atleta.InformacoesMedicas.Peso = Convert.ToDouble(txtPeso.Text);
            atleta.InformacoesMedicas.TipoSanguineo = cbxTipoSanguineo.SelectedItem.ToString();
            atleta.InformacoesMedicas.Alergia = txtAlergia.Text;
            atleta.InformacoesMedicas.IMC = CalculaImc(atleta);

            /*
            //Query
            // insert into aaytatta values uaugauga
            string textoAtleta = "\nAtleta Cadastrado:\n" + "Nome: " + atleta.Nome + ";\n"
            + "Nacionalidade: " + atleta.Nacionalidade + ";\n"
            + "Modalidade: " + atleta.Modalidade + ";\n"
            + "Numero de Identificacao: " + atleta.Id + ";\n"
            + "Gênero: " + atleta.Genero + ";\n"
            + "Data de Nascimento: " + atleta.DataNascimento + ";\n"
            + "Altura: " + atleta.InformacoesMedicas.Altura + ";\n"
            + "Peso: " + atleta.InformacoesMedicas.Peso + ";\n"
            + "Tipo Sanguínero: " + atleta.InformacoesMedicas.TipoSanguineo + ";\n"
            + "Alergias: " + atleta.InformacoesMedicas.Alergia + ";\n";

            
            //sql.execute
            if (!File.Exists("C:\\Users\\jonatas.jsilva4\\Documents\\atletas.txt"))
            {
                using (FileStream fileStream = File.Create("C:\\Users\\jonatas.jsilva4\\Documents\\atletas.txt")) ;
                
            }
            File.AppendAllText("C:\\Users\\jonatas.jsilva4\\Documents\\atletas.txt", textoAtleta);

            */
            BancoDeDados.InserirAtleta(atleta);

            MessageBox.Show("Atleta Cadastrado!");

            txtAlergia.Text = txtAltura.Text = txtModalidade.Text = txtNacionalidade.Text = txtNome.Text
                = txtPeso.Text = string.Empty;
            cbxGenero.SelectedIndex = cbxTipoSanguineo.SelectedIndex = -1;
            dtpNascimento.Value = DateTime.Now;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           dgvAtletas.DataSource = BancoDeDados.BuscaAtletas();
           dgvAtletas.Update();
        }
    }
}
