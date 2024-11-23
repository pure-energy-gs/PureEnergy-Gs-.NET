# Pure Energy
## Descrição

Integrantes:
José Ribeiro dos Santos Neto RM 553844

Keven Ike Pereira da Silva RM 553215

Vitor Cruz dos Santos RM 553621

Para subir o docker acessando a maquina pronta:

# Instalar a extensão de Remote SSH no VS Code
```
Host vmdotnet
    HostName 191.232.244.226
    User pureenergy
```

# Inserir a senha da vm

```
 Pureenergy12!
```

# Garantir que o container esta desligado

```
sudo docker stop d3664b4782d6
```

# Ligar o container com a imagem do docker

```
sudo docker start d3664b4782d6
```

# Montar uma vm para subir a aplicação

1- Acessar via ssh a vm 
```nome_usuario@ip_publico```

2- inserir a senha no terminal
```sua_senha```


## instalando o projeto na VM

1- instalar o gerenciador de pacotes yum
```sudo yum install -y yum-utils -y```

2- instalar o docker
```sudo yum-config-manager --add-repo https://download.docker.com/linux/rhel/docker-ce.repo```

3- verificar a versao do docker
``` docker --version```

4- clonar nosso repositório
```git clone https://github.com/pure-energy-gs/PureEnergy-Gs-.NET.git```

5- start no docker
``` sudo systemctl start docker```

6- enable  no docker
```sudo systemctl enable docker```

7- cria uma build do docker a partir do dockerfile do projeto
```sudo docker build -t pureenergy-dotnet .```

8- cria um container com a imagem criada e roda na porta 8081
```sudo docker run -d -p 8081:8080 --name pureenergy-app pureenergy-dotnet```

O **Energia Verde** é um aplicativo inovador que visa promover a conscientização sobre o consumo energético e a sustentabilidade. Ele permite que os usuários monitorem seu consumo de energia residencial e adotem práticas mais conscientes, contribuindo para um futuro mais sustentável.

## Funcionalidades

- **Cadastro de Clientes**: Os usuários podem se cadastrar de forma simples e prática.
- **Monitoramento de Consumo**: Acompanhe o consumo de energia em tempo real.
- **Educação sobre Sustentabilidade**: Acesse conteúdos educativos sobre energia verde e práticas sustentáveis.
- **Comunicação**: Interaja com outros usuários para trocar dicas e experiências.
- **Interface Amigável**: Design responsivo e intuitivo, facilitando a navegação.

## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento web.
- **ASP.NET MVC**: Arquitetura para construção de aplicações web.
- **Entity Framework**: ORM para acesso a dados.
- **Entity Framework Tools**: Ferramentas para gerenciamento de migrações e interações com o banco de dados.
- **Entity Framework Design**: Design de modelos e mapeamento de entidades.
- **Oracle Entity Framework**: Integração com bancos de dados Oracle.
- **Bootstrap**: Framework CSS para design responsivo.

## Pré-requisitos

Antes de executar o projeto, verifique se você possui as seguintes ferramentas instaladas:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (ou outro banco de dados de sua escolha)

## Instalação

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/energia-verde.git
   cd energia-verde

2. ## Tecnologias Utilizadas
   ```
   {
     "ConnectionStrings": {
         "DefaultConnection": "Server=seuservidor;Database=energiasustentavel;Trusted_Connection=True;"
      }
   }
   ```
4. Depois de conectar com o banco rode esses comandos no terminal para criar as tabelas e subir
   ```
   Add-migrations initdb
   ```
   ```
   Update-Database
   ```

Obrigado por usar o Energia Verde! Juntos, podemos fazer a diferença e promover um futuro mais sustentável.


Sinta-se à vontade para substituir os placeholders (como `seuusuario` e `seuemail@example.com`) com suas informações reais. Se precisar de mais alguma coisa, é só avisar!
