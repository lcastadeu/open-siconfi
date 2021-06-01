using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace OpenSiconfi.Core.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "complemento_fonte_recurso",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    nomenclatura = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    especificacao = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    exercicio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_complemento_fonte_recurso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fonte_recurso",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_principal = table.Column<string>(type: "character varying(4)", maxLength: 4, nullable: false),
                    detalhamento = table.Column<string>(type: "text", nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    especificacao = table.Column<string>(type: "text", nullable: true),
                    exercicio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fonte_recurso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "informacao_complementar",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigo_ic = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    nome = table.Column<string>(type: "text", nullable: true),
                    digito = table.Column<int>(type: "integer", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: true),
                    finalidade = table.Column<string>(type: "text", nullable: true),
                    exercicio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_informacao_complementar", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "natureza_receita",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    o = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    E = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    d1 = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    dd2 = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    d3 = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    t = table.Column<string>(type: "character varying(1)", maxLength: 1, nullable: true),
                    nr = table.Column<string>(type: "character varying(9)", maxLength: 9, nullable: true),
                    detalhamento = table.Column<string>(type: "text", nullable: false),
                    norma_correspondente = table.Column<string>(type: "text", nullable: true),
                    valorizavel = table.Column<string>(type: "text", nullable: true),
                    exercicio = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_natureza_receita", x => x.id);
                });

            migrationBuilder.InsertData(
                schema: "public",
                table: "fonte_recurso",
                columns: new[] { "id", "codigo_principal", "detalhamento", "especificacao", "exercicio", "nome" },
                values: new object[,]
                {
                    { 1, "001", "0000", "Recursos da entidade de livre aplicação", 2021, "Recursos Ordinários" },
                    { 51, "510", "0000", "Recursos originários de transferências federais em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada aos seus objetos. Não serão controlados por esta fonte os recursos de convênios vinculados a programas da educação, da saúde e da assistência social, cujo controle será realizado através das fontes 125, 220 e 312, respectivamente. ", 2021, "Outras Transferências de Convênios ou Contratos de Repasse da União" },
                    { 50, "460", "0000", "Controle dos recursos vinculados aos benefícios previdenciários concedidos aos militares e pensionistas militares.", 2021, "Recursos vinculados às pensões e aos inativos militares" },
                    { 49, "450", "0000", "Controle dos recursos vinculados ao RGPS (uso exclusivo da União).", 2021, "Recursos vinculados ao RGPS" },
                    { 48, "430", "0000", "Constrole dos recursos destinados ao custeio das despesas necessárias à organização e ao funcionamento da unidade gestora do R", 2021, "Recursos vinculados ao RPPS - Taxa de Administração" },
                    { 47, "420", "0000", "Controle dos recursos vinculados ao fundo em repartiçãoo do RPPS. Esse plano existe somente nos entes que segregaram a massa d", 2021, "Recursos vinculados ao RPPS - Fundo em Repartição (Plano Financeiro)" },
                    { 46, "410", "0000", "Controle dos recursos vinculados ao fundo em capitalização do RPPS. Esse plano existe tanto nos entes que segregaram quanto no", 2021, "Recursos vinculados ao RPPS - Fundo em Capitalização (Plano Previdenciário)" },
                    { 52, "520", "0000", "Recursos originários de transferências estaduais em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada aos seus objetos. Não serão controlados por esta fonte os recursos de convênios ou contratos de repasse vinculados a programas da educação, da saúde e da assistência social, cujo controle será realizado através das fontes 125, 220 e 312, respectivamente. ", 2021, "Outras Transferências de Convênios ou Contratos de Repasse dos Estados" },
                    { 45, "390", "0000", "Controle dos recursos não enquadrados em especificações próprias, cuja destinação encontra-se vinculada a programas da assistência social.", 2021, "Outros Recursos Vinculados à Assistência Social" },
                    { 43, "311", "0000", "Controle os recursos originários de transferências do Fundo Nacional de Assistência Social - Lei Federal nº 8.742, 07/12/1993.", 2021, "Transferência de Recursos do Fundo Nacional de Assistência Social - FNAS" },
                    { 42, "290", "0000", "Controle dos recursos não enquadrados em especificações próprias, cuja destinação encontra-se vinculada a programas da saúde.", 2021, "Outros Recursos Vinculados à Saúde" },
                    { 41, "250", "0000", "Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 211 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Receita de Impostos e de Transferência de Impostos - Saúde - Remuneração de Depósitos Bancários" },
                    { 40, "240", "0000", "Controle dos recursos vinculados à Saúde, originários de transferências recebidas pelo Município, relativos  a Royalties e Participação Especial – Art. 2º da Lei nº 12.858/2013.", 2021, "Royalties do Petróleo vinculados à Saúde" },
                    { 39, "230", "0000", "Controlar dos recursos originários de operações de crédito, cuja destinação encontra-se vinculada a programas da saúde.", 2021, "Operações de Crédito vinculadas à Saúde" },
                    { 38, "220", "0000", "Controle dos recursos originários de transferências em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada a programas da saúde.", 2021, "Transferências de Convênios ou de Contratos de Repasse vinculados à Saúde" },
                    { 44, "312", "0000", "Controle dos recursos originários de transferências em virtude de assinatura de convênios ou legislações específicas, cuja destinação encontra-se vinculada a programas da assistência social.", 2021, "Transferências de Convênios - Assistência Social" },
                    { 37, "215", "2100", "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS), relacionados ao Bloco de Estruturação na Rede de Serviços Públicos de Saúde e destinados ao enfrentamento da COVID-19 no bojo da ação 21C0 do orçamento da União.", 2021, "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Estruturação da Rede de Serviços Públicos de Saúde – Recursos destinados ao enfrentamento da COVID-19 no bojo da ação." },
                    { 53, "530", "0000", "Controle dos recursos originários da arrecadação da cota-parte royalties.", 2021, "Transferência da União Referente a Royalties do Petróleo" },
                    { 55, "550", "0000", "Controle dos recursos provenientes de emendas individuais impositivas ao orçamento da União nos termos do art. 166-A, inciso I, da Constitui", 2021, "Transferência Especial da União" },
                    { 69, "979", "0000", "Controle dos recursos financeiros que não transitam pelo orçamento, como dep", 2021, "Outros recursos extraorçamentários" },
                    { 68, "972", "0000", "Controle dos recursos financeiros junto aos tribunais de justiça vinculados ", 2021, "Recursos extraorçamentários vinculados a depósitos judiciais" },
                    { 67, "971", "0000", "Controle dos recursos financeiros junto aos tribunais de justiça vinculados ", 2021, "Recursos extraorçamentários vinculados a precatórios" },
                    { 66, "962", "0000", "Controle dos recursos de depósitos judiciais apropriados pelo ente de lides das quais o ente não faz parte.", 2021, "Recursos de depósitos judiciais – Lides das quais o ente não faz parte" },
                    { 65, "961", "0000", "Controle dos recursos de depósitos judiciais apropriados pelo ente de lides das quais o ente faz parte.", 2021, "Recursos de depósitos judiciais – Lides das quais o ente faz parte" },
                    { 64, "950", "0000", "Controle dos recursos de outras taxas e contribuições vinculadas", 2021, "Outras vinculações de taxas e contribuições" },
                    { 54, "540", "0000", "Controle dos recursos originários das transferências de royalties pelos Estados.", 2021, "Transferência dos Estados Referente a Royalties do Petróleo" },
                    { 63, "940", "0000", "Controle dos recursos de outras transferências vinculadas.", 2021, "Outras vinculações de transferências" },
                    { 61, "920", "0000", "Controle dos recursos originários de operações de crédito, exceto as operações cuja aplicação estejam destinadas a programas de educação e saúde.", 2021, "Recursos de Operações de Crédito" },
                    { 60, "910", "0000", "Controle dos recursos próprios dos Consórcios Públicos", 2021, "Recursos próprios dos consórcios" },
                    { 59, "630", "0000", "Controle dos recursos com a cobrança das multas de trânsito nos termos do artigo nº. 320 da Lei nº 9.503/1997 - Código de Trânsito Brasileiro.", 2021, "Recursos Vinculados ao Trânsito" },
                    { 58, "620", "0000", "Controle dos recursos da COSIP, nos termos do artigo 149-A da Constituição Federal da República.", 2021, "Contribuição para o Custeio do Serviço de Iluminação Pública - COSIP" },
                    { 57, "610", "0000", "Controle dos recursos da CIDE.", 2021, "Contribuição de Intervenção no Domínio Econômico - CIDE" },
                    { 56, "560", "0000", "Controle dos recursos provenientes de transferência da União com base no disposto no inciso I do art. 5º da lei complementar 173/2020.", 2021, "Transferências da União – inciso I do art. 5º da Lei Complementar 173/2020 " },
                    { 62, "930", "0000", "Controle dos recursos advindos da alienação de bens nos termos do art. 44 da LRF.", 2021, "Recursos de Alienação de Bens/Ativos" },
                    { 70, "980", "0000", "Classificação temporária enquanto não se identifica a correta vinculação.", 2021, "Recursos não classificados – a classificar" },
                    { 36, "215", "0000", "Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 211 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Estruturação da Rede de Serviços Públicos de Saúde." },
                    { 34, "214", "0000", "Controlar dos recursos originários de operações de crédito, cuja destinação encontra-se vinculada a programas da saúde.", 2021, "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Manutenção das Ações e Serviços Públicos de Saúde" },
                    { 15, "119", "0000", "Controle dos recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE, destinados ao Programa Dinheiro Direto na Escola (PDDE).Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências do FUNDEB 30% – Complementação da União - VAAT" },
                    { 14, "118", "0000", "Controle dos recursos originários de transferências recebidas do Fundo Nacional do Desenvolvimento da Educação – FNDE, relativos aos repasses referentes ao salário-educação.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências do FUNDEB 70% – Complementação da União - VAAT" },
                    { 13, "117", "0040", "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa às fontes 114 e 115.", 2021, "Transferências do FUNDEB – Complementação da União - VAAF - Destinação 30%" },
                    { 12, "117", "0060", "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa às fontes 114 e 115.", 2021, "Transferências do FUNDEB – Complementação da União - VAAF - Destinação 70%" },
                    { 11, "117", "0000", "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa às fontes 114 e 115.", 2021, "Transferências do FUNDEB - Complementação da União - VAAF - Entrada de Recursos" },
                    { 10, "116", "0040", "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa às fontes 112 e 113.", 2021, "Transferências do FUNDEB - Impostos - Destinação 30%" },
                    { 16, "129", "0000", "Controle dos recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE, destinados ao Programa Nacional de Alimentação Escolar (PNAE).Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências do FUNDEB - Complementação da União - VAAT - Entrada de Recursos " },
                    { 9, "116", "0060", "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa às fontes 112 e 113.", 2021, "Transferências do FUNDEB - Impostos - Destinação 70%" },
                    { 7, "115", "0000", "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa à fonte 117.", 2021, "Transferências do FUNDEB 30% – Complementação da União - VAAF" },
                    { 6, "114", "0000", "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa à fonte 117.", 2021, "Transferências do FUNDEB 70% – Complementação da União - VAAF" },
                    { 5, "113", "0000", "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa à fonte 116.", 2021, "Transferências do FUNDEB - Impostos 30%" },
                    { 4, "112", "0000", "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa à fonte 116.", 2021, "Transferências do FUNDEB - Impostos 70%" },
                    { 3, "111", "0000", "Controle das despesas custeadas com recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que vinculam os recursos de impostos à educação no momento da arrecadação da receita. Nas situações em que os entes não efetuam a vinculação do recurso na origem, a aplicação das receitas de impostos e transferências na educação será identificada a partir da Fonte 001 - Recursos Ordinários, por exemplo.", 2021, "Receitas de Impostos e de Transferência de Impostos - Educação" },
                    { 2, "090", "0000", "Outros recursos não vinculados que não se enquadrem nas especificações acima", 2021, "Outros Recursos Não Vinculados" },
                    { 8, "116", "0000", "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa às fontes 112 e 113.", 2021, "Transferências do FUNDEB - Impostos - Entrada de Recursos" },
                    { 35, "214", "2100", "Controle dos recursos vinculados à Saúde, originários de transferências recebidas pelo Município, relativos  a Royalties e Participação Especial – Art. 2º da Lei nº 12.858/2013.", 2021, "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Manutenção das Ações e Serviços Públicos de Saúde – Recursos destinados ao enfrentamento da COVID-19 no bojo da ação." },
                    { 17, "129", "0060", "Controle dos recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE, destinados ao Programa Nacional de Apoio ao Transporte Escolar (PNATE).Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências do FUNDEB – Complementação da União - VAAT - Destinação 70%" },
                    { 19, "120", "0000", "Controle dos recursos originários de transferências em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada a programas da educação.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferência do Salário-Educação" },
                    { 33, "213", "0000", "Controle dos recursos originários de transferências em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada a programas da saúde.", 2021, "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Estadual" },
                    { 32, "212", "0000", "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS), relacionados ao Bloco de Estruturação na Rede de Serviços Públicos de Saúde e destinados ao enfrentamento da COVID-19 no bojo da ação 21C0 do orçamento da União.", 2021, "Transferências Fundo a Fundo de Recursos do SUS provenientes dos Governos Municipais" },
                    { 31, "211", "0000", "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS) e relacionados ao Bloco de Estruturação na Rede de Serviços Públicos de Saúde.", 2021, "Receitas de Impostos e de Transferência de Impostos - Saúde" },
                    { 30, "190", "0000", "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS), relacionados ao Bloco de Manutneção das Ações e Serviços Públicos de Saúde, e destinados ao enfrentamento da COVID-19 no bojo da ação 21C0 do orçamento da União.", 2021, "Outros Recursos Vinculados à Educação" },
                    { 29, "152", "0000", "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS) e relacionados ao Bloco de Manutenção das Ações e Serviços Públicos de Saúde.", 2021, "Transferências do FUNDEB - Complementação da União - Remuneração de Depósitos Bancários" },
                    { 28, "151", "0000", "Controle dos recursos originários de transferências do Fundo Estadual de Saúde, referentes ao Sistema Único de Saúde (SUS).", 2021, "Transferências do FUNDEB - Remuneração de Depósitos Bancários" },
                    { 18, "129", "0040", "Controle dos demais recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências do FUNDEB – Complementação da União - VAAT - Destinação 30%" },
                    { 27, "150", "0000", "Controle dos recursos originários de transferências dos Fundos de saúde de outros municípios, referentes ao Sistema Único de Saúde (SUS).", 2021, "Receitas de Impostos e de Transferência de Impostos - Educação - Remuneração de Depósitos Bancários" },
                    { 25, "130", "0000", "Controle dos demais recursos vinculados à Educação.", 2021, "Operações de Crédito Vinculadas à Educação" },
                    { 24, "125", "0000", "Controle das despesas custeadas com os rendimentos dos recursos do FUNDEB quando houver necessidade. Essescódigos serão utilizados pelos entes da federação que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências de Convênios ou de Contratos de Repasse vinculados à Educação" },
                    { 23, "124", "0000", "Controle das despesas custeadas com os rendimentos dos recursos do FUNDEB quando houver necessidade. Essescódigos serão utilizados pelos entes da federação que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Outras Transferências de Recursos do FNDE" },
                    { 22, "123", "0000", "Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências de Recursos do FNDE Referentes ao Programa Nacional de Apoio ao Transporte Escolar (PNATE)" },
                    { 21, "122", "0000", "Controle dos recursos vinculados à Educação, originários de transferências recebidas pelo Município, relativos  a Royalties e Participação Especial – Art. 2º da Lei nº 12.858/2013.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências de Recursos do FNDE Referentes ao Programa Nacional de Alimentação Escolar (PNAE)" },
                    { 20, "121", "0000", "Controle dos recursos originários de operações de crédito, cuja destinação encontra-se vinculada a programas da educação.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica.", 2021, "Transferências de Recursos do FNDE Referentes ao Programa Dinheiro Direto na Escola (PDDE)" },
                    { 26, "140", "0000", "Controle das despesas custeadas com recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que vinculam os recursos de impostos à saúde no momento da arrecadação da receita. Nas situações em que os entes não efetuam a vinculação do recurso na origem, a aplicação das receitas de impostos e transferências na saúde será identificada a partir da Fonte 001 - Recursos Ordinários, por exemplo.", 2021, "Royalties do Petróleo Vinculados à Educação" },
                    { 71, "990", "0000", "Controle dos recursos cuja aplicação seja vinculada e não tenha sido enquadrado em outras especificações.", 2021, "Outros Recursos Vinculados" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "complemento_fonte_recurso",
                schema: "public");

            migrationBuilder.DropTable(
                name: "fonte_recurso",
                schema: "public");

            migrationBuilder.DropTable(
                name: "informacao_complementar",
                schema: "public");

            migrationBuilder.DropTable(
                name: "natureza_receita",
                schema: "public");
        }
    }
}
