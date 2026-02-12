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

#### 1
<img width="734" height="585" alt="nuget" src="https://github.com/user-attachments/assets/765eb822-e1c1-4051-ba8b-1d14700d23a3" />

#### 2
<img width="1005" height="211" alt="nuget1" src="https://github.com/user-attachments/assets/20ada159-a497-4c9e-8673-337fecbee57e" />

#### 3
<img width="529" height="355" alt="nuget2" src="https://github.com/user-attachments/assets/7181ef2a-3f63-40e2-a079-90072be9a245" />



## Exemplo de Formulário

#### Aba 1
<img width="630" height="747" alt="template" src="https://github.com/user-attachments/assets/22453bb3-bede-4c26-bc12-962ef6026db3" />

#### Aba 2
<img width="630" height="748" alt="template1" src="https://github.com/user-attachments/assets/9c27827d-11ee-4de4-8efb-f7e434b25961" />


