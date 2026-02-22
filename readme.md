# 🏆 Projeto Final: Cadastro de Atletas com Banco de Dados
**Unidade Curricular 12 (UC 12) - Desenvolvimento Desktop**

Chegamos à nossa última missão! Até agora, nossos dados sumiam quando fechávamos o programa. Neste projeto, vamos dar um salto profissional: vamos conectar nossa aplicação a um **Banco de Dados Real (MySQL)**.

Além disso, vamos aprender sobre **Arquitetura de Software**. Em vez de colocar todo o código misturado nos botões da tela, vamos separar as responsabilidades:
1. **Entidades:** Classes que apenas guardam os dados (ex: `Atleta` e `MedicalInfo`).
2. **Interface (UI):** O formulário visual (`Form1`).
3. **Acesso a Dados:** Uma classe dedicada apenas para conversar com o banco (`BancoDeDados`).

---

## 💾 1. Preparando o Banco de Dados (MySQL)
Antes do C#, precisamos criar as tabelas onde os dados vão morar. Execute o script abaixo no seu MySQL Workbench. Note que temos duas tabelas que se conectam através de uma Chave Estrangeira (`MedicalInfoId`).

```sql
CREATE DATABASE uc12;
use uc12;

CREATE TABLE MedicalInfo (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    TipoSanguineo VARCHAR(5) NOT NULL,
    Alergia VARCHAR(255),
    Altura DOUBLE NOT NULL,
    Peso DOUBLE NOT NULL,
    IMC DOUBLE NOT NULL
) ENGINE=InnoDB;

CREATE TABLE Atleta (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(150) NOT NULL,
    Idade INT NOT NULL,
    DataNascimento DATE NOT NULL,
    Genero CHAR(1) NOT NULL, -- M ou F
    Nacionalidade VARCHAR(100) NOT NULL,
    Modalidade VARCHAR(100) NOT NULL,
    MedicalInfoId INT NOT NULL,

    CONSTRAINT FK_Atleta_MedicalInfo
        FOREIGN KEY (MedicalInfoId)
        REFERENCES MedicalInfo(Id)
        ON DELETE CASCADE
) ENGINE=InnoDB;
```
## 🔌 2. Instalando o MySql.Data (NuGet)
O C# não "fala" **MySQL** nativamente. Precisamos de um tradutor! O NuGet é a **"loja de aplicativos"** do **Visual Studio** onde baixamos pacotes de código de terceiros.

Vá em **Ferramentas** -> **Gerenciador de Pacotes do NuGet** -> **Gerenciar Pacotes do NuGet para a Solução.**

Procure por **`MySql.Data`** e instale.

### Passo a Passo visual:
<img width="734" height="585" alt="nuget" src="https://github.com/user-attachments/assets/765eb822-e1c1-4051-ba8b-1d14700d23a3" />
<img width="1005" height="211" alt="nuget1" src="https://github.com/user-attachments/assets/20ada159-a497-4c9e-8673-337fecbee57e" />
<img width="529" height="355" alt="nuget2" src="https://github.com/user-attachments/assets/7181ef2a-3f63-40e2-a079-90072be9a245" />

## 🧬 3. Nossas Entidades (Classes)
No C#, precisamos de "moldes" que representem as tabelas do banco.

Atenção aqui: Note que dentro da classe Atleta, nós temos uma propriedade chamada InformacoesMedicas que é do tipo MedicalInfo. Isso significa que um Atleta "tem um" Prontuário Médico acoplado a ele!

```C#
public class MedicalInfo
{
    public int Id { get; set; }
    public string TipoSanguineo { get; set; }
    public string Alergia { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double IMC { get; set; }
}

public class Atleta
{
    public int Id { get; set; }
    public string Nome {  get; set; }
    public int Idade { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Genero { get; set; } // M ou F
    public string Nacionalidade { get; set; }
    public string Modalidade { get; set; }
    
    // O Atleta carrega suas informações médicas com ele!
    public MedicalInfo InformacoesMedicas { get; set; }

    public Atleta() 
    {
        // Sempre que um Atleta nasce no sistema, o prontuário nasce junto.
        InformacoesMedicas = new MedicalInfo();
    }
}
```
## 🎨 4. A Interface Visual
Utilize um componente chamado `TabControl` para criar "abas" no seu sistema (uma para cadastrar, outra para listar).

### Componentes utilizados:

* **`TabControl`** e **`Panel`** (para organização)

* **`TextBox`** (textos gerais), **`MaskedTextBox`** (textos com formato fixo, opcional)

* **`ComboBox`** (caixa de seleção, ótimo para Gênero e Tipo Sanguíneo)

* **`DateTimePicker`** (para a data de nascimento)

* **`DataGridView`** (a tabela interativa que mostrará nossos dados na Aba 2)

* **`Label`** e **`Button`**

### Aba 1 (Cadastro)
<img width="630" height="747" alt="template" src="https://github.com/user-attachments/assets/22453bb3-bede-4c26-bc12-962ef6026db3" />

### Aba 2 (Listagem)
<img width="630" height="748" alt="template1" src="https://github.com/user-attachments/assets/9c27827d-11ee-4de4-8efb-f7e434b25961" />

## 🛡️ 5. Tratando Erros e Salvando: A Classe BancoDeDados
Esta classe é estática (`static`), o que significa que é uma "caixa de ferramentas" pronta para uso. O grande segredo aqui é o bloco `try/catch`.

O Caminho Infeliz: O que acontece se a internet cair na hora de salvar? Se não usarmos o `try/catch`, o programa fecha na cara do usuário! Com o `try` nós tentamos fazer a ação; se der erro, o `catch` captura a falha de forma elegante e mostra uma mensagem. 

```C#
public static class BancoDeDados
{
    // Caminho + Autenticação do nosso banco de dados
    const string connectionString = "Server=localhost;Database=uc12;Uid=root;";

    public static bool InserirAtleta(Atleta atleta)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            MySqlTransaction transaction = null;
            try // TENTA EXECUTAR O CAMINHO FELIZ
            {
                connection.Open(); // Abre a porta do banco
                transaction = connection.BeginTransaction(); // Inicia uma "transação" segura

                // 1. Salva a Info Médica primeiro e pega o ID gerado...
                // (O código completo está no arquivo BancoDeDados.cs)

                // 2. Salva o Atleta usando o ID médico que pegamos acima...
                
                transaction.Commit(); // Confirma as salvações!
                return true;
            }
            catch (Exception ex) // SE ALGO DER ERRADO (CAMINHO INFELIZ)
            {
                MessageBox.Show("Erro ao conectar no banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(transaction != null)
                    transaction.Rollback(); // Desfaz tudo para não deixar dados pela metade
                return false;
            }
        }
    }
}
```
No método `BuscaAtletas()`, usamos um `INNER JOIN` para juntar as duas tabelas novamente e mostrar no **DataGridView**!

## 🚀 6. Conectando tudo no Botão "Cadastrar"
Olhe como o código do botão fica limpo! A tela não precisa saber como salvar no banco, ela apenas recolhe os dados digitados, monta o objeto Atleta e entrega para a classe **BancoDeDados** fazer o trabalho pesado.

```C#
private void btnCadastrar_Click(object sender, EventArgs e)
{
    // 1. Cria o objeto
    Atleta atleta = new Atleta();
    
    // 2. Preenche com os dados da tela
    atleta.Nome = txtNome.Text;
    atleta.Genero = cbxGenero.SelectedItem.ToString();
    atleta.DataNascimento = dtpNascimento.Value.Date;
    // ... preenche o resto ...
    atleta.InformacoesMedicas.IMC = CalculaImc(atleta); // Calcula o IMC

    // 3. Manda salvar!
    BancoDeDados.InserirAtleta(atleta);

    // 4. Avisa o usuário e limpa a tela
    MessageBox.Show("Atleta Cadastrado!");
    // (Lógica de limpar os campos...)
}
```
