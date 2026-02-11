# Componentes
- TabControl
- Panel
- TextBox
- Label
- Button
- ComboBox
- DataGridView ou DataGrid
- MaskedTextBox - Opcional
- DatePicker - Opcional
- Calendar - Opcional

### Atleta
```c#
public class Atleta
{
    public int Id { get; set; }
     public string Nome {  get; set; }
     public int Idade { get; set; }
     public DateTime DataNascimento { get; set; }
     public string Genero { get; set; } // M ou F
     public string Nacionalidade { get; set; }
     public string Modalidade { get; set; }
     public MedicalInfo InformacoesMedicas { get; set; }

     public Atleta() //Quando eu crio um novo objeto do tipo Atleta
     {
         InformacoesMedicas = new MedicalInfo();//Eu crio um novo objeto do tipo MedicalInfo
     }
}
```

### MedicalInfo

```c#
public class MedicalInfo
{
    public int Id { get; set; }
    public string TipoSanguineo { get; set; }
    public string Alergia { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double IMC { get; set; }
}
```

## Tabelas do Banco de Dados

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

## Nuget
Nuget é o gerenciador de pacotes do Visual Studio para os projetos em C#
para acessar a loja de plugins, o caminho é Ferramentas-> Gerenciar de Pacotes do Nuget -> Gerenciar Pacotes do Nuget para a solução.

Dentro disso, você deve procurar o MySqlData e instalar
