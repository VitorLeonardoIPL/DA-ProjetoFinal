# 🛒 iShopping - Sistema de Gestão de Compras Domésticas

## Descrição do Projeto

**iShopping** é um protótipo de aplicação em C# (WinForms) desenvolvido para validar o conceito de uma solução de gestão de compras domésticas. A aplicação permite aos utilizadores gerir o orçamento familiar, planear compras e acompanhar gastos de forma organizada e controlada.

**Instituição:** Politécnico de Leiria - ESTG  
**Curso:** Técnico Superior Profissional de Programação de Sistemas de Informação  
**Unidade Curricular:** Desenvolvimento de Aplicações  
**Ano:** 2025/2026  

---

## 🎯 Objetivos Principais

1. **Gestão de Orçamento:** Definir e controlar o orçamento mensal máximo para compras
2. **Planeamento de Compras:** Criar e planear listas de compras com artigos categorizados
3. **Registo de Compras:** Registar artigos comprados, quantidades e preços durante a compra
4. **Controlo de Gastos:** Monitorizar gastos em tempo real e alertar quando o orçamento é ultrapassado
5. **Análise de Dados:** Gerar estatísticas e sugestões de orçamento baseadas em histórico
6. **Exportação de Dados:** Exportar compras para formato CSV para análise posterior
7. **Gestão Multi-utilizador:** Permitir acesso a diferentes membros do agregado familiar com rastreamento de ações

---

## ✨ Funcionalidades Principais

### 🔐 Autenticação
- **Login/Registo de Utilizadores** - Acesso seguro com Username e Password únicos
- **Rastreamento de Utilizador** - Cada ação fica associada ao utilizador logado

### 📊 Gestão de Base de Dados
- **Gestão de Utilizadores** - CRUD completo com permissões iguais para todos
- **Gestão de Tipos de Artigo** - Categorização de artigos (CRUD)
- **Gestão de Artigos** - Artigos organizados por tipo (CRUD)
- **Gestão de Orçamentos** - Um orçamento mensal único com rastreamento de criação/alteração

### 🛍️ Planeamento e Compra
- **Criar Lista de Compras** - Novo registo com utilizador criador
- **Itens Previstos** - Adicionar artigos planeados com quantidade
- **Itens Não Previstos** - Adicionar artigos adicionais durante a compra com observações
- **Modo Compra** - Interface para registar artigos adquiridos, quantidades e preços unitários
- **Fecho de Compra** - Registar data/hora do fecho e utilizador responsável

### 💰 Controlo Financeiro
- **Visualização de Orçamento** - Saldo disponível em tempo real durante a compra
- **Alerta de Ultrapassagem** - Mensagem visível quando ultrapassar o orçamento
- **Cálculo Automático** - Atualização dinâmica do saldo conforme se adquirem itens

### 📈 Estatísticas e Análises
- **Listagem Mensal** - Orçamento, Total de Compras e Diferença por mês
- **Análise de Compras** - Percentagem de artigos previstos e não previstos
- **Sugestões de Orçamento** - Recomendação baseada em histórico dos meses anteriores
- **Sugestões de Compras** - Recomendação por semana do mês baseada no histórico

### 📄 Exportação de Dados
- **Exportar para CSV** - Formato separado por ponto e vírgula
- **Campos Incluídos:** NomeCompra, DataCriacao, DataFechada, NomeArtigo, ArtigoPrevisto, ArtigoNaoPrevisto, QuantidadePrevista, QuantidadeAdquirida, PrecoUnitario

---

## 🏗️ Arquitetura e Tecnologias

### Stack Tecnológico
- **Linguagem:** C# (.NET Framework)
- **Interface Gráfica:** Windows Forms (WinForms)
- **Base de Dados:** SQL Server
- **ORM:** Entity Framework
- **Arquitetura:** MVC (Model-View-Controller)

### Padrão Arquitetural
O projeto segue o padrão **MVC**:
- **Model:** Entidades de negócio e lógica de dados
- **View:** Formulários WinForms
- **Controller:** Lógica de aplicação e orquestração

---

## 📋 Formulários Obrigatórios

1. **Formulário de Login** - Autenticação inicial e registo de novos utilizadores
2. **Formulário Principal** - Menu principal com lista de compras em aberto
3. **Gestão de Tipos de Artigo** - CRUD de categorias de artigos
4. **Gestão de Artigos** - CRUD de artigos com filtro por tipo
5. **Gestão de Orçamentos** - CRUD com visualização de todos os orçamentos
6. **Planeamento de Compras** - Listagem com filtros de estado
7. **Criação/Alteração de Compra Planeada** - Editor de itens previstos
8. **Modo Compra** - Interface de compra com registo de itens e controlo de orçamento
9. **Estatísticas** - Dois separadores com listagens e sugestões

---

## 🔧 Requisitos do Sistema

### Requisitos Mínimos
- Windows 7 ou superior
- .NET Framework 4.5+
- SQL Server 2012 ou superior

### Dependências
- Entity Framework 6.0+
- Windows Forms

---

## 💾 Instalação e Configuração

### 1. Pré-requisitos
- Visual Studio 2019 ou superior
- SQL Server instalado e em funcionamento
- .NET Framework 4.5+

### 2. Passos de Instalação

```bash
# 1. Extrair o ficheiro ZIP do projeto
unzip AnaFelix8216658_ClaudioMiguel56476784_DianaCosta8675434.zip

# 2. Abrir a solução em Visual Studio
# Abrir ficheiro: iShopping.sln

# 3. Configurar a base de dados
# Editar a string de conexão no arquivo de configuração

# 4. Executar as migrações Entity Framework
Update-Database

# 5. Compilar a solução
# Build → Build Solution (Ctrl+Shift+B)

# 6. Executar a aplicação
# Debug → Start Debugging (F5)
```

### 3. Configuração da Base de Dados

Editar o ficheiro de configuração e atualizar a string de conexão:

```xml
<connectionStrings>
    <add name="iShoppingContext" 
         connectionString="Server=YOUR_SERVER;Database=iShopping;Trusted_Connection=true;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 4. Primeira Execução

- A aplicação apresentará o formulário de Login
- Criar um novo utilizador ou fazer login com credenciais existentes
- Navegar pelo menu principal para aceder às diferentes funcionalidades

---

## 📁 Estrutura do Projeto

```
iShopping/
│
├── Models/                    # Entidades de domínio
│   ├── User.cs
│   ├── Budget.cs
│   ├── ShoppingList.cs
│   ├── ShoppingItem.cs
│   ├── Article.cs
│   └── ArticleType.cs
│
├── Views/                     # Formulários WinForms
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   ├── ArticleTypeForm.cs
│   ├── ArticleForm.cs
│   ├── BudgetForm.cs
│   ├── ShoppingPlanForm.cs
│   ├── ShoppingEditForm.cs
│   ├── ShoppingMode.cs
│   └── StatisticsForm.cs
│
├── Controllers/               # Lógica de aplicação
│   ├── UserController.cs
│   ├── ArticleController.cs
│   ├── BudgetController.cs
│   ├── ShoppingController.cs
│   └── StatisticsController.cs
│
├── Data/                      # Acesso a dados
│   ├── iShoppingContext.cs
│   └── Repository.cs
│
├── Utils/                     # Utilidades
│   ├── CsvExporter.cs
│   ├── ValidationHelper.cs
│   └── DateHelper.cs
│
├── README.md                  # Este ficheiro
├── readme.txt                 # Instruções adicionais
└── iShopping.sln              # Solução Visual Studio
```

---

## 🚀 Como Usar

### 1. Fazer Login
```
1. Executar a aplicação
2. Inserir Username e Password
3. Clicar em "Login" ou "Registar" para novo utilizador
```

### 2. Criar uma Compra
```
1. No formulário principal, clicar em "Nova Compra"
2. Atribuir nome e descrição
3. Selecionar o Tipo de Artigo para filtrar artigos
4. Adicionar artigos planeados com quantidades
5. Guardar
```

### 3. Realizar uma Compra
```
1. Clicar em "Modo Compra" na lista de compras abertas
2. Para cada item previsto, inserir quantidade adquirida e preço
3. Se necessário, adicionar artigos não previstos
4. Verificar o saldo de orçamento em tempo real
5. Clicar em "Fechar Compra" após terminar
```

### 4. Visualizar Estatísticas
```
1. Aceder ao formulário de Estatísticas
2. Separador 1: Visualizar orçamentos e totais mensais
3. Separador 2: Gerar sugestões de orçamento e lista de compras
```

### 5. Exportar Dados
```
1. Selecionar as compras a exportar
2. Clicar em "Exportar para CSV"
3. Escolher localização e guardar ficheiro
```

---

## 📊 Critérios de Avaliação

| Avaliação | Peso |
|-----------|------|
| Relatório e Manual | 10% |
| Aspeto Geral e Usabilidade | 5% |
| Utilização de arquitetura e qualidade do código | 10% |
| Configuração e utilização do EntityFramework | 5% |
| Formulário de Login | 5% |
| Formulário de Gestão de Tipos de Artigos | 5% |
| Formulário de Gestão Artigos | 5% |
| Gestão de Utilizadores | 5% |
| Gestão de Orçamentos | 5% |
| Planeamento de Compras | 5% |
| Formulário de edição de compras planeadas | 10% |
| Formulário do modo Compra | 10% |
| Estatísticas | 15% |
| Exportação dos dados para CSV | 5% |

---

## 📅 Datas Importantes

- **11/04/2026** - Publicação do enunciado do projeto
- **09/06/2026** - Entrega do projeto (até às 23:59)
- **18/06/2026** - Defesa individual de projeto

---

## 👥 Membros do Grupo

| Nome | Número de Estudante |
|------|-------------------|
| [Nome Aluno 1] | [Número] |
| [Nome Aluno 2] | [Número] |
| [Nome Aluno 3] | [Número] |

---

## ⚠️ Notas Importantes

### Integridade de Dados
- Todos os dados são persistidos em SQL Server via Entity Framework
- Cada registo é associado ao utilizador que o criou/alterou com timestamp
- A base de dados garante a integridade referencial

### Proteções e Validações
- Validação de campos obrigatórios
- Verificação de unicidade de Username
- Controlo de acesso a compras (apenas fechadas não podem ser alteradas)
- Proteções contra erros inesperados
- Alerta visual quando orçamento é ultrapassado

### Funcionalidades Extra (até 5% bónus)
Qualquer funcionalidade adicional não especificada no enunciado deve ser documentada no relatório para ser considerada na avaliação.

---

## 🔍 Troubleshooting

### Erro de Conexão à Base de Dados
- Verificar se SQL Server está em funcionamento
- Verificar string de conexão em App.config
- Verificar permissões de utilizador SQL Server

### Entity Framework Migrations
```bash
# Se houver problemas com migrações:
Add-Migration InitialCreate
Update-Database
```

### Erro ao Exportar CSV
- Verificar permissões na pasta de destino
- Garantir que nenhum ficheiro com o mesmo nome está aberto

---

## 📚 Recursos Adicionais

- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [Entity Framework Documentation](https://docs.microsoft.com/en-us/ef/)
- [WinForms Best Practices](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)

---

## 📝 Licença

Este projeto é desenvolvido para fins educacionais no contexto da disciplina de Desenvolvimento de Aplicações.

---

## ✅ Lista de Verificação Final

- [ ] Todos os 9 formulários obrigatórios implementados
- [ ] CRUD completo para todas as entidades
- [ ] Login funcional com rastreamento de utilizador
- [ ] Gestão de orçamento mensal único
- [ ] Modo compra com controlo de orçamento
- [ ] Alertas quando ultrapassar orçamento
- [ ] Estatísticas com dois separadores
- [ ] Exportação para CSV com campos corretos
- [ ] Base de dados SQL Server com Entity Framework
- [ ] Arquitetura MVC implementada
- [ ] Proteções contra erros inesperados
- [ ] Relatório com manual de utilização
- [ ] Ficheiro readme.txt com instruções
- [ ] Código documentado e bem estruturado
- [ ] Testes funcionais realizados

---

**Bom trabalho!** 🚀

---

*Última atualização: Abril de 2026*
