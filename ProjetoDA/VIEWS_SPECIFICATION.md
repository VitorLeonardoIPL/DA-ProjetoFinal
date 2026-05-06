# 📋 Especificação das Views - iShopping

## 9 Formulários Obrigatórios

---

## **a. Formulário de Login** 🔐

**Objectivo:** Primeira janela a aparecer para identificar o utilizador através das suas credenciais de login.

**Requisitos Funcionais:**
- Inserir Username
- Inserir Password
- Botão "Login" - validar credenciais existentes
- Botão "Registar" - criar novo utilizador
- **Id do utilizador deve ser guardado durante a execução da aplicação**
- Validação de campos obrigatórios
- Verificação de unicidade de Username

**Dados a Guardar:**
- `CurrentUserId` em variável global/sesão durante execução

**Fluxo:**
1. Utilizador insere Username/Password
2. Se "Login" → valida e abre MainForm
3. Se "Registar" → cria novo utilizador com Username único
4. Guardar ID do utilizador logado

---

## **b. Formulário Principal** 🏠

**Objectivo:** Janela principal de trabalho com menu de acesso às restantes janelas.

**Requisitos Funcionais:**
- Apresentar lista das **compras em aberto**
- Menu de acesso aos outros formulários:
  - Gestão de Tipos de Artigo
  - Gestão de Artigos
  - Gestão de Orçamentos
  - Planeamento de Compras
  - Estatísticas
- Permitir acesso ao **Formulário do Modo Compra** a partir da lista
- Botão "Logout"

**Componentes:**
- DataGridView/ListView com compras abertas
- Colunas: ID, Nome, DataCriação, DataFechada(?), Estado
- Botões de menu (Navigation)
- Botão "Modo Compra" (só se compra selecionada)

**Fluxo:**
1. Ao abrir, carrega lista de compras abertas
2. Utilizador seleciona compra e clica "Modo Compra"
3. Ou acessa outros formulários pelo menu

---

## **c. Formulário de Gestão de Tipos de Artigo** 📂

**Objectivo:** Visualizar todos os tipos de artigo e efetuar CRUD dos mesmos.

**Requisitos Funcionais:**
- Listar todos os tipos de artigo
- **CREATE:** Adicionar novo tipo (Nome, Descrição?)
- **READ:** Visualizar dados do tipo
- **UPDATE:** Editar tipo existente
- **DELETE:** Eliminar tipo (se não tiver artigos associados?)
- Validação de campos

**Componentes:**
- DataGridView com tipos
- Colunas: ID, Nome, Descrição
- Botões: Novo, Editar, Eliminar, Guardar, Cancelar
- Form de edição inline ou separado

**Regras de Negócio:**
- Nome obrigatório e único?
- Não permitir eliminação se tiver artigos associados

---

## **d. Formulário de Gestão de Artigos** 🛒

**Objectivo:** Visualizar todos os artigos filtrados por Tipo ou Todos, e efetuar CRUD dos mesmos.

**Requisitos Funcionais:**
- Listar todos os artigos
- **Filtro por Tipo de Artigo** (dropdown com "Todos")
- **CREATE:** Adicionar novo artigo
- **READ:** Visualizar dados do artigo
- **UPDATE:** Editar artigo existente
- **DELETE:** Eliminar artigo
- Validação de campos

**Componentes:**
- ComboBox para filtro de TipoArtigo
- DataGridView com artigos
- Colunas: ID, Nome, Descrição, TipoArtigo
- Botões: Novo, Editar, Eliminar, Guardar, Cancelar

**Fluxo:**
1. Ao abrir, carrega todos os artigos
2. Utilizador seleciona filtro de Tipo
3. Lista atualiza com artigos desse tipo
4. CRUD disponível em cada operação

---

## **e. Formulário de Gestão de Orçamentos** 💰

**Objectivo:** Visualizar todos os orçamentos e efetuar CRUD dos mesmos.

**Requisitos Funcionais:**
- Listar todos os orçamentos
- **Um orçamento mensal único** por utilizador?
- **CREATE:** Adicionar novo orçamento
- **READ:** Visualizar dados do orçamento
- **UPDATE:** Editar orçamento existente
- **DELETE:** Eliminar orçamento
- Campos: Valor, Mês, Ano

**Componentes:**
- DataGridView com orçamentos
- Colunas: ID, Valor, Mês, Ano, UtilizadorId, DataCriacao
- Botões: Novo, Editar, Eliminar, Guardar, Cancelar

**Regras de Negócio:**
- Um orçamento por mês/ano/utilizador?
- Rastreamento de criação/alteração (quem criou, quando)

---

## **f. Formulário de Planeamento de Compras** 📋

**Objectivo:** Visualizar todas as compras ou filtrar pelo seu estado. Aceder ao formulário de Criação/Alteração.

**Requisitos Funcionais:**
- Listar todas as compras
- **Filtro por estado** (Aberta, Fechada, Todas)
- Permitir acesso ao **Formulário de Criação/Alteração**:
  - Botão "Nova Compra" → abre form vazio
  - Duplo clique ou botão "Editar" → abre form com dados (só se não fechada)
- Visualizar compras em aberto com destaque visual

**Componentes:**
- ComboBox para filtro de estado
- DataGridView com compras
- Colunas: ID, Nome, DataCriacao, DataFechada, Estado, UtilizadorCriador
- Botões: Nova, Editar, Eliminar(?), Fechar

**Fluxo:**
1. Ao abrir, carrega todas as compras
2. Utilizador seleciona filtro de estado
3. Lista atualiza com compras desse estado
4. "Nova" ou "Editar" abre EdicaoCompraForm

---

## **g. Formulário de Criação/Alteração de uma Compra Planeada** ✏️

**Objectivo:** Visualizar e editar dados de uma compra, inserir/editar itens. Leitura-apenas se fechada.

**Requisitos Funcionais:**
- Editar dados da compra: **Nome, Descrição**
- Sub-grid para editar **itens da compra** (lista de itens):
  - Adicionar artigo (select artigo)
  - Quantidade prevista
  - Remover item
- **Se compra fechada:**
  - Modo visualização-apenas (ReadOnly)
  - Não permitir edição

**Componentes:**
- TextBox: Nome da Compra
- TextBox: Descrição (opcional)
- DataGridView para itens:
  - Colunas: ID, ArtigoNome, QuantidadePrevista, Ações (Editar, Eliminar)
- Botões: Novo Item, Guardar, Cancelar

**Regras de Negócio:**
- Compra fechada = modo leitura-apenas
- Artigos duplicados permitidos?
- Validar quantidade > 0

---

## **h. Formulário do Modo Compra** 🛍️

**Objectivo:** Registar itens adquiridos, quantidade e preço. Controlo de orçamento em tempo real. Fechar compra.

**Requisitos Funcionais:**
- Visualizar **compra em aberto** (só se não fechada)
- Registar para cada item:
  - **Quantidade adquirida**
  - **Preço unitário**
- Adicionar **artigos não previstos**:
  - Selecionar artigo ou criar "ad-hoc"
  - Quantidade
  - Preço unitário
- **Visualização de orçamento em tempo real:**
  - Saldo disponível
  - Total gasto
  - Alerta visual se ultrapassar orçamento
- **Botão "Fechar Compra"** - registar data/hora e utilizador
- Impedir edição de compra já fechada

**Componentes:**
- Panel de resumo do orçamento (em destaque):
  - "Orçamento: X€"
  - "Total Gasto: Y€"
  - "Saldo: Z€" (com cor de aviso se negativo)
- DataGridView para itens previstos:
  - Colunas: ArtigoNome, QuantidadePrevista, QuantidadeAdquirida, PrecoUnitario, Subtotal
- DataGridView para itens não previstos:
  - Adicionar novos ad-hoc
- Botões: Adicionar Item Não Previsto, Fechar Compra, Cancelar

**Fluxo:**
1. Utilizador abre compra em modo compra
2. Para cada item previsto, insere Qtd Adquirida e Preço Unit
3. Total atualiza em tempo real
4. Se ultrapassar orçamento → aviso visual
5. Pode adicionar itens não previstos
6. "Fechar Compra" registra data/hora/utilizador e fecha

---

## **i. Formulário de Estatísticas** 📊

**Objectivo:** Apresentar listagens e sugestões conforme requisitos.

**Requisitos Funcionais:**

### **Separador 1: Listagens**
- Tabela mensal com:
  - Mês/Ano
  - Orçamento (valor do orçamento definido)
  - Total de Compras (soma de todos os itens desse mês)
  - Diferença (Orçamento - Total)
- Análise de Compras:
  - % de artigos previstos vs não previstos
  - Gráfico opcional

### **Separador 2: Sugestões**
- **Sugestões de Orçamento:**
  - Recomendação baseada em histórico dos últimos meses
  - Média, máximo, mínimo
- **Sugestões de Lista de Compras:**
  - Recomendação por semana do mês
  - Baseada em histórico

**Componentes:**
- TabControl com 2 separadores
- **Tab 1:**
  - DataGridView: Mês, Orçamento, Total, Diferença
  - DataGridView: Artigos Previstos %, Não Previstos %
- **Tab 2:**
  - Label com sugestões de orçamento
  - Label com sugestões de compras por semana

**Fluxo:**
1. Ao abrir, calcula dados dos últimos N meses
2. Exibe listagens no separador 1
3. Gera sugestões no separador 2 baseado em histórico

---

## 📊 Resumo das Funcionalidades por Form

| Form | Create | Read | Update | Delete | Filter | SubForm |
|------|--------|------|--------|--------|--------|---------|
| Login | ✅ | - | - | - | - | - |
| Main | - | ✅ | - | - | ✅ | ModoCompra |
| Tipos | ✅ | ✅ | ✅ | ✅ | - | - |
| Artigos | ✅ | ✅ | ✅ | ✅ | ✅ Tipo | - |
| Orçamentos | ✅ | ✅ | ✅ | ✅ | - | - |
| Planeamento | - | ✅ | ✅ | ✅ | ✅ Estado | EdicaoCompra |
| EdicaoCompra | ✅ Item | ✅ | ✅ | ✅ Item | - | - |
| ModoCompra | ✅ ItemNão | ✅ | ✅ Qtd/Preço | - | - | - |
| Estatísticas | - | ✅ | - | - | ✅ Mês | - |

---

## 🎯 Ordem Recomendada de Implementação

1. **LoginForm** - Base da aplicação
2. **MainForm** - Navegação central
3. **GestaoTiposArtigoForm** - Simples CRUD
4. **GestaoArtigosForm** - CRUD com filtro
5. **GestaoOrcamentosForm** - CRUD simples
6. **PlaneamentoComprasForm** - CRUD com navegação
7. **EdicaoCompraForm** - Edição de itens
8. **ModoCompraForm** - Lógica complexa de orçamento
9. **EstatisticasForm** - Análise de dados

---

## ⚙️ Padrões a Implementar

- **MVC:** Model (Entidades), View (Forms), Controller (Lógica)
- **Validação:** Em cada form antes de guardar
- **Rastreamento:** Quem criou, quando, quem editou, quando
- **Segurança:** Verificar permissões do utilizador logado
- **UX:** Feedback visual (mensagens de sucesso/erro)

