﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Translator_app.Migrations
{
    public partial class PopulateWordsTableWithPortugueseWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
         table: "Word",
         columns: new[] { "TextId", "Text", "LanguageId" },
         values: new object[,] {
             {"1","Nome do responsável da conta", "PT"},
             {"2","Contabilidade e financeiro", "PT"},
             {"3","Ativo", "PT"},
             {"4","Adicionar nova fee", "PT"},
             {"5","Adicionar novo comentário", "PT"},
             {"6","Adicionar novo lançamento", "PT"},
             {"7","Adicionar novo fornecedor", "PT"},
             {"8","Relatórios adicionais de editores/Gerenciamento", "PT"},
             {"9","Administração", "PT"},
             {"10","Manuseio de pagamento de anúncio", "PT"},
             {"11","Agência", "PT"},
             {"12","Contas Alipay", "PT"},
             {"13","Análises", "PT"},
             {"14","Anúncios", "PT"},
             {"15","Fechamento anaual, retorno de imposto e auditoria", "PT"},
             {"16","Revisão Anual (feedback)", "PT"},
             {"17","ID do Responsável no Apollo - Controle de Qualidade", "PT"},
             {"18","ID do Responsável no Apollo - Agendamento", "PT"},
             {"19","Aplicar pagamentos no Caspian", "PT"},
             {"20","Acompanhamento de AR", "PT"},
             {"21","Relatório automático", "PT"},
             {"22","Bamboo", "PT"},
             {"23","Número da conta bancária", "PT"},
             {"24","Endereço do banco", "PT"},
             {"25","Nome do banco", "PT"},
             {"26","BI - Assistir outro departamento", "PT"},
             {"27","BI - Assistência para outros escritórios", "PT"},
             {"28","BI - Design, Ilustrações, Layout Gráficos, CSS", "PT"},
             {"29","BI - Arquivos de desenvolvimento de soluções", "PT"},
             {"30","BI - Análises específicas (Tier, rotas, custo, etc.)", "PT"},
             {"31","Cobrança", "PT"},
             {"32","Suporte BR", "PT"},
             {"33","Nome da Filial / ID", "PT"},
             {"34","Cargos Bravo", "PT"},
             {"35","Usuário Bravo", "PT"},
             {"36","Preparação de orçamento", "PT"},
             {"37","Gerenciamento de negócios", "PT"},
             {"38","Ligação para novos avaliadores", "PT"},
             {"39","Ligações - Avaliadores", "PT"},
             {"40","Ligações / Reuniões - Cliente, SM", "PT"},
             {"41","Ligações / Reuniões - Interno", "PT"},
             {"42","Ligações com provedores de anúncios", "PT"},
             {"43","Ligações Emails", "PT"},
             {"44","Cancelar", "PT"},
             {"45","Projeção de Caixa", "PT"},
             {"46","Caspian", "PT"},
             {"47","Caspian (entrando, gerenciando leads)", "PT"},
             {"48","Usuários do escritório no Caspian", "PT"},
             {"49","Uruário primário no Caspian", "PT"},
             {"50","Cargo no Caspian", "PT"},
             {"51","Pedido de revisão", "PT"},
             {"52","Escolha um...", "PT"},
             {"53","Suporte CL", "PT"},
             {"54","Cliente", "PT"},
             {"55","Criação de acordo com cliente e follow-up", "PT"},
             {"56","Comunicação com cliente", "PT"},
             {"57","Relatório de cliente em Excel", "PT"},
             {"58","Comunicação relacionada a cliente", "PT"},
             {"59","Relatório de cliente", "PT"},
             {"60","Cliente/Proposta - follow up", "PT"},
             {"61","Cliente/Proposta - reunião", "PT"},
             {"62","Suporte CN", "PT"},
             {"63","Ligação fria", "PT"},
             {"64","Comentário", "PT"},
             {"65","Comentário:", "PT"},
             {"66","Comentários", "PT"},
             {"67","Nome da empresa", "PT"},
             {"68","Contrato expira", "PT"},
             {"69","Data da expiração do contrato", "PT"},
             {"70","Copiar", "PT"},
             {"71","Cost-Out, RFP", "PT"},
             {"72","Código de países...", "PT"},
             {"73","Criar novo fornecedor", "PT"},
             {"74","Criado", "PT"},
             {"75","Criando proposta para cliente", "PT"},
             {"76","Criando processos/procedimentos", "PT"},
             {"77","Aprovando/Inserindo credit memos", "PT"},
             {"78","Suporte entre departamentos - BI", "PT"},
             {"79","Suporte entre departamentos - DQ", "PT"},
             {"80","Suporte entre departamentos - Financeiro", "PT"},
             {"81","Suporte entre departamentos - RH", "PT"},
             {"82","Suporte entre departamentos - TI", "PT"},
             {"83","Suporte entre departamentos - KAM", "PT"},
             {"84","Suporte entre departamentos - MKTG", "PT"},
             {"85","Suporte entre departamentos - RM", "PT"},
             {"86","Suporte entre departamentos - Vendas", "PT"},
             {"87","Moeda", "PT"},
             {"88","Checagem de dados no Excel", "PT"},
             {"89","Limpeza de dados, checagem e matching", "PT"},
             {"90","Data", "PT"},
             {"91","Deletar", "PT"},
             {"92","Departamento", "PT"},
             {"93","Supervisor DQ", "PT"},
             {"94","Editar", "PT"},
             {"95","Editar entrada na TimeSheet", "PT"},
             {"96","Editando relatórios (Primeira linha de edição)", "PT"},
             {"97","Alocação de relatórios", "PT"},
             {"98","Pagamento de editores", "PT"},
             {"99","E-mail", "PT"},
             {"100","E-mail", "PT"},
             {"101","Controle de assiduidade do funcionário", "PT"},
             {"102","Pagamento de benefício de funcionário", "PT"},
             {"103","Feedback do funcionário", "PT"},
             {"104","Fim", "PT"},
             {"105","Data final:", "PT"},
             {"106","Horário de término:", "PT"},
             {"107","Inserindo dados no sistema de contabilidade", "PT"},
             {"108","O horário inserido corresponde à outra atividade já inserida", "PT"},
             {"109","Suporte EU", "PT"},
             {"110","Export", "PT"},
             {"111","Fee", "PT"},
             {"112","Tipo de fee", "PT"},
             {"113","Fees", "PT"},
             {"114","Parceiro de campo", "PT"},
             {"115","Primeiro nome", "PT"},
             {"116","Primeiro nome", "PT"},
             {"117","Follow up", "PT"},
             {"118","Sexta-feira", "PT"},
             {"119","Full Tier", "PT"},
             {"120","Atividade do grupo global Anti-Fraude", "PT"},
             {"121","Suporte Global", "PT"},
             {"122","Assistência de Saúde", "PT"},
             {"123","Esconder novo comentário", "PT"},
             {"124","Contratando / Entrevista", "PT"},
             {"125","Contratando / Processo de Integração", "PT"},
             {"126","Solução de Hold-A", "PT"},
             {"127","Solução de Hold-B", "PT"},
             {"128","Início", "PT"},
             {"129","Código IBAN / Número da conta bancária", "PT"},
             {"130","Id", "PT"},
             {"131","Suporte IN", "PT"},
             {"132","Usuário indepentende", "PT"},
             {"133","Comunicação interna", "PT"},
             {"134","Pedidos internos", "PT"},
             {"135","Relatórios internos", "PT"},
             {"136","Comunicação entre escritórios", "PT"},
             {"137","Faturando", "PT"},
             {"138","Comunicação IO", "PT"},
             {"139","É parceiro de campo", "PT"},
             {"140","É agência?", "PT"},
             {"141","Tarefas de TI_Admin", "PT"},
             {"142","Supervisor KAM", "PT"},
             {"143","Cálculo KPI", "PT"},
             {"144","Último login", "PT"},
             {"145","Sobrenome", "PT"},
             {"146","Sobrenome", "PT"},
             {"147","Pesquisa de lead", "PT"},
             {"148","Lista de horários da TimeSheet", "PT"},
             {"149","Visualizar lista", "PT"},
             {"150","Sair", "PT"},
             {"151","Gerenciando parceiros", "PT"},
             {"152","Criação de material", "PT"},
             {"153","Modificado", "PT"},
             {"154","Segunda-feira", "PT"},
             {"155","Mais", "PT"},
             {"156","Nome", "PT"},
             {"157","Eventos de networking", "PT"},
             {"158","Contratação - Treinamento", "PT"},
             {"159","Novo horário na TimeSheet", "PT"},
             {"160","Próximo", "PT"},
             {"161","Não", "PT"},
             {"162","Escritório", "PT"},
             {"163","Gerenciamento de escritório", "PT"},
             {"164","Título de cargo oficial", "PT"},
             {"165","Cálculo de OH e atribuições", "PT"},
             {"166","Fee opcional é apenas aplicada se o status primário é Reviewed.", "PT"},
             {"167","Fee opcional", "PT"},
             {"168","Organizando dados, templade de marketing", "PT"},
             {"169","Outros projetos / Geral", "PT"},
             {"170","Preparação de P&L", "PT"},
             {"171","Comunicação com parceiro", "PT"},
             {"172","Problemas de pagamentos", "PT"},
             {"173","Método de pagamento", "PT"},
             {"174","Desenvolvimento de pessoas", "PT"},
             {"175","Gerenciamento de pessoas", "PT"},
             {"176","Acompanhamento de performance", "PT"},
             {"177","Suporte PH", "PT"},
             {"178","Número de telefone", "PT"},
             {"179","Número de telefone", "PT"},
             {"180","Número de telefone incorreto.", "PT"},
             {"181","Pitching", "PT"},
             {"182","Planejamento de volume de trabalho", "PT"},
             {"183","Por favor, selecione", "PT"},
             {"184","Postagem de anúncio", "PT"},
             {"185","Idioma de preferência", "PT"},
             {"186","Preparação para reuniões", "PT"},
             {"187","Preparação de relatórios mensais", "PT"},
             {"188","Preparação de relatórios semanais", "PT"},
             {"189","Anterior", "PT"},
             {"190","Requisição de preço", "PT"},
             {"191","Controle/Revisão de processo", "PT"},
             {"192","Melhoria de processo", "PT"},
             {"193","Perfil", "PT"},
             {"194","Desenho de projeto", "PT"},
             {"195","Revisão de projeto com OPS/PM", "PT"},
             {"196","Setup de projeto / Preparação de manuais / Briefing", "PT"},
             {"197","Ministrando treinamento", "PT"},
             {"198","Férias/Day Off/ Ausência Justificada", "PT"},
             {"199","Checagem de qualidade (Segunda linha de edição)", "PT"},
             {"200","Recebendo treinamento", "PT"},
             {"201","Recrutamento", "PT"},
             {"202","Automatização de relatório", "PT"},
             {"203","Relatórios / Status / Follow up", "PT"},
             {"204","Resetar senha do Caspian", "PT"},
             {"205","Confirmação de receita", "PT"},
             {"206","Revisão de questionário / Manual de avaliador", "PT"},
             {"207","Retrabalho - Analista", "PT"},
             {"208","Retrabalho - Cliente", "PT"},
             {"209","Retrabalho - KAM", "PT"},
             {"210","Supervisor de Campo", "PT"},
             {"211","Cargos", "PT"},
             {"212","Rulez", "PT"},
             {"213","Transição de Sales to Ops", "PT"},
             {"214","Sábado", "PT"},
             {"215","Salvar", "PT"},
             {"216","Salvar comentário", "PT"},
             {"217","Salvar fee", "PT"},
             {"218","Agendamento", "PT"},
             {"219","Buscar", "PT"},
             {"220","Selecionar", "PT"},
             {"221","Selecionar agência", "PT"},
             {"222","Selecionar tarefa", "PT"},
             {"223","Auto Agendado", "PT"},
             {"224","Suporte SG", "PT"},
             {"225","Mídia Social", "PT"},
             {"226","Horas gastas", "PT"},
             {"227","Início", "PT"},
             {"228","Início - Final", "PT"},
             {"229","Data de início:", "PT"},
             {"230","Horário de início:", "PT"},
             {"231","Domingo", "PT"},
             {"232","Nome do supervisor", "PT"},
             {"233","Suporte", "PT"},
             {"234","Surfmerchants", "PT"},
             {"235","Survey", "PT"},
             {"236","Trocar para", "PT"},
             {"237","Tarefa", "PT"},
             {"238","Tarefa:", "PT"},
             {"239","O formato correto é: 'hh:mm'", "PT"},
             {"240","Esse campo não pode estar vazio", "PT"},
             {"241","Quinta-feira", "PT"},
             {"242","Tier", "PT"},
             {"243","Tier 1", "PT"},
             {"244","Tier 2 ", "PT"},
             {"245","TimeSheet", "PT"},
             {"246","Nome do usuário da TimeSheet", "PT"},
             {"247","Hoje", "PT"},
             {"248","Gerenciamento de Acompanhamento", "PT"},
             {"249","Treinamento - próprio", "PT"},
             {"250","Treinamento - próprio / membro do time / externo", "PT"},
             {"251","Treinamento / Manual com avaliador", "PT"},
             {"252","Treinamento / membro do time / externo", "PT"},
             {"253","Tradução", "PT"},
             {"254","Tradução de manuais, outros documentos, etc.", "PT"},
             {"255","Terça-feira", "PT"},
             {"256","Digite seu comentário aqui...", "PT"},
             {"257","Digite para pesquisar...", "PT"},
             {"258","Suporte US", "PT"},
             {"259","Use a setas em seu teclado (cima e baixo) para mudar a seleção. O tamanho das colunas e linhas podem ser ajustadas na primeira célula.", "PT"},
             {"260","ID de usuário", "PT"},
             {"261","Nome de usuário", "PT"},
             {"262","Tipo de usuário", "PT"},
             {"263","Usuário com agência", "PT"},
             {"264","Preparação e arquivamento de imposto VAT/GST ", "PT"},
             {"265","Fornecedor", "PT"},
             {"266","Fee de fornecedor", "PT"},
             {"267","ID de fornecedor", "PT"},
             {"268","Nota fiscal de fornecedor", "PT"},
             {"269","Nome de fornecedor", "PT"},
             {"270","Pagamentos de fornecedor", "PT"},
             {"271","Onda", "PT"},
             {"272","Quarta-feira", "PT"},
             {"273","Dias úteis", "PT"},
             {"274","Endereço Western Union", "PT"},
             {"275","Semana completa", "PT"},
             {"276","Sim", "PT"}

         });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}