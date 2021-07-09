using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Domain.Seed
{
  public class SeedFonteRecurso
  {
    public static void Data(ModelBuilder modelBuilder)
    {
      var fontesRecursos = new List<FonteRecurso> {
          new FonteRecurso() { Id = 1, Exercicio = 2021, CodigoPrincipal = "001", Detalhamento = "0000", Nome = "Recursos Ordinários", Especificacao = "Recursos da entidade de livre aplicação" },
          new FonteRecurso() { Id = 2, Exercicio = 2021, CodigoPrincipal = "090", Detalhamento = "0000", Nome = "Outros Recursos Não Vinculados", Especificacao = "Outros recursos não vinculados que não se enquadrem nas especificações acima" },
          new FonteRecurso() { Id = 3, Exercicio = 2021, CodigoPrincipal = "111", Detalhamento = "0000", Nome = "Receitas de Impostos e de Transferência de Impostos - Educação", Especificacao = "Controle das despesas custeadas com recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que vinculam os recursos de impostos à educação no momento da arrecadação da receita. Nas situações em que os entes não efetuam a vinculação do recurso na origem, a aplicação das receitas de impostos e transferências na educação será identificada a partir da Fonte 001 - Recursos Ordinários, por exemplo." },
          new FonteRecurso() { Id = 4, Exercicio = 2021, CodigoPrincipal = "112", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Impostos 70%", Especificacao = "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa à fonte 116." },
          new FonteRecurso() { Id = 5, Exercicio = 2021, CodigoPrincipal = "113", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Impostos 30%", Especificacao = "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa à fonte 116." },
          new FonteRecurso() { Id = 6, Exercicio = 2021, CodigoPrincipal = "114", Detalhamento = "0000", Nome = "Transferências do FUNDEB 70% – Complementação da União - VAAF", Especificacao = "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa à fonte 117." },
          new FonteRecurso() { Id = 7, Exercicio = 2021, CodigoPrincipal = "115", Detalhamento = "0000", Nome = "Transferências do FUNDEB 30% – Complementação da União - VAAF", Especificacao = "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa à fonte 117." },
          new FonteRecurso() { Id = 8, Exercicio = 2021, CodigoPrincipal = "116", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Impostos - Entrada de Recursos", Especificacao = "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa às fontes 112 e 113." },
          new FonteRecurso() { Id = 9, Exercicio = 2021, CodigoPrincipal = "116", Detalhamento = "0060", Nome = "Transferências do FUNDEB - Impostos - Destinação 70%", Especificacao = "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa às fontes 112 e 113." },
          new FonteRecurso() { Id = 10, Exercicio = 2021, CodigoPrincipal = "116", Detalhamento = "0040", Nome = "Transferências do FUNDEB - Impostos - Destinação 30%", Especificacao = "Controle das despesas custeadas com recursos recebidos do FUNDEB - Impostos, com base no art. 212-A, inciso I, da Constituição Federal. Esse código é de utilização alternativa às fontes 112 e 113." },
          new FonteRecurso() { Id = 11, Exercicio = 2021, CodigoPrincipal = "117", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Complementação da União - VAAF - Entrada de Recursos", Especificacao = "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa às fontes 114 e 115." },
          new FonteRecurso() { Id = 12, Exercicio = 2021, CodigoPrincipal = "117", Detalhamento = "0060", Nome = "Transferências do FUNDEB – Complementação da União - VAAF - Destinação 70%", Especificacao = "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa às fontes 114 e 115." },
          new FonteRecurso() { Id = 13, Exercicio = 2021, CodigoPrincipal = "117", Detalhamento = "0040", Nome = "Transferências do FUNDEB – Complementação da União - VAAF - Destinação 30%", Especificacao = "Controle das despesas custeadas com recursos de Complementação da União ao FUNDEB - VAAF, com base no art. 212-A, inciso V, \"a\" da Constituição Federal. Esse código é de utilização alternativa às fontes 114 e 115." },
          new FonteRecurso() { Id = 14, Exercicio = 2021, CodigoPrincipal = "118", Detalhamento = "0000", Nome = "Transferências do FUNDEB 70% – Complementação da União - VAAT", Especificacao = "Controle dos recursos originários de transferências recebidas do Fundo Nacional do Desenvolvimento da Educação – FNDE, relativos aos repasses referentes ao salário-educação.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 15, Exercicio = 2021, CodigoPrincipal = "119", Detalhamento = "0000", Nome = "Transferências do FUNDEB 30% – Complementação da União - VAAT", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE, destinados ao Programa Dinheiro Direto na Escola (PDDE).Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 16, Exercicio = 2021, CodigoPrincipal = "129", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Complementação da União - VAAT - Entrada de Recursos ", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE, destinados ao Programa Nacional de Alimentação Escolar (PNAE).Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 17, Exercicio = 2021, CodigoPrincipal = "129", Detalhamento = "0060", Nome = "Transferências do FUNDEB – Complementação da União - VAAT - Destinação 70%", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE, destinados ao Programa Nacional de Apoio ao Transporte Escolar (PNATE).Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 18, Exercicio = 2021, CodigoPrincipal = "129", Detalhamento = "0040", Nome = "Transferências do FUNDEB – Complementação da União - VAAT - Destinação 30%", Especificacao = "Controle dos demais recursos originários de transferências do Fundo Nacional do Desenvolvimento da Educação – FNDE.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 19, Exercicio = 2021, CodigoPrincipal = "120", Detalhamento = "0000", Nome = "Transferência do Salário-Educação", Especificacao = "Controle dos recursos originários de transferências em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada a programas da educação.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 20, Exercicio = 2021, CodigoPrincipal = "121", Detalhamento = "0000", Nome = "Transferências de Recursos do FNDE Referentes ao Programa Dinheiro Direto na Escola (PDDE)", Especificacao = "Controle dos recursos originários de operações de crédito, cuja destinação encontra-se vinculada a programas da educação.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 21, Exercicio = 2021, CodigoPrincipal = "122", Detalhamento = "0000", Nome = "Transferências de Recursos do FNDE Referentes ao Programa Nacional de Alimentação Escolar (PNAE)", Especificacao = "Controle dos recursos vinculados à Educação, originários de transferências recebidas pelo Município, relativos  a Royalties e Participação Especial – Art. 2º da Lei nº 12.858/2013.Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 22, Exercicio = 2021, CodigoPrincipal = "123", Detalhamento = "0000", Nome = "Transferências de Recursos do FNDE Referentes ao Programa Nacional de Apoio ao Transporte Escolar (PNATE)", Especificacao = "Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 111 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 23, Exercicio = 2021, CodigoPrincipal = "124", Detalhamento = "0000", Nome = "Outras Transferências de Recursos do FNDE", Especificacao = "Controle das despesas custeadas com os rendimentos dos recursos do FUNDEB quando houver necessidade. Essescódigos serão utilizados pelos entes da federação que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 24, Exercicio = 2021, CodigoPrincipal = "125", Detalhamento = "0000", Nome = "Transferências de Convênios ou de Contratos de Repasse vinculados à Educação", Especificacao = "Controle das despesas custeadas com os rendimentos dos recursos do FUNDEB quando houver necessidade. Essescódigos serão utilizados pelos entes da federação que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 25, Exercicio = 2021, CodigoPrincipal = "130", Detalhamento = "0000", Nome = "Operações de Crédito Vinculadas à Educação", Especificacao = "Controle dos demais recursos vinculados à Educação." },
          new FonteRecurso() { Id = 26, Exercicio = 2021, CodigoPrincipal = "140", Detalhamento = "0000", Nome = "Royalties do Petróleo Vinculados à Educação", Especificacao = "Controle das despesas custeadas com recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que vinculam os recursos de impostos à saúde no momento da arrecadação da receita. Nas situações em que os entes não efetuam a vinculação do recurso na origem, a aplicação das receitas de impostos e transferências na saúde será identificada a partir da Fonte 001 - Recursos Ordinários, por exemplo." },
          new FonteRecurso() { Id = 27, Exercicio = 2021, CodigoPrincipal = "150", Detalhamento = "0000", Nome = "Receitas de Impostos e de Transferência de Impostos - Educação - Remuneração de Depósitos Bancários", Especificacao = "Controle dos recursos originários de transferências dos Fundos de saúde de outros municípios, referentes ao Sistema Único de Saúde (SUS)." },
          new FonteRecurso() { Id = 28, Exercicio = 2021, CodigoPrincipal = "151", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Remuneração de Depósitos Bancários", Especificacao = "Controle dos recursos originários de transferências do Fundo Estadual de Saúde, referentes ao Sistema Único de Saúde (SUS)." },
          new FonteRecurso() { Id = 29, Exercicio = 2021, CodigoPrincipal = "152", Detalhamento = "0000", Nome = "Transferências do FUNDEB - Complementação da União - Remuneração de Depósitos Bancários", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS) e relacionados ao Bloco de Manutenção das Ações e Serviços Públicos de Saúde." },
          new FonteRecurso() { Id = 30, Exercicio = 2021, CodigoPrincipal = "190", Detalhamento = "0000", Nome = "Outros Recursos Vinculados à Educação", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS), relacionados ao Bloco de Manutneção das Ações e Serviços Públicos de Saúde, e destinados ao enfrentamento da COVID-19 no bojo da ação 21C0 do orçamento da União." },
          new FonteRecurso() { Id = 31, Exercicio = 2021, CodigoPrincipal = "211", Detalhamento = "0000", Nome = "Receitas de Impostos e de Transferência de Impostos - Saúde", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS) e relacionados ao Bloco de Estruturação na Rede de Serviços Públicos de Saúde." },
          new FonteRecurso() { Id = 32, Exercicio = 2021, CodigoPrincipal = "212", Detalhamento = "0000", Nome = "Transferências Fundo a Fundo de Recursos do SUS provenientes dos Governos Municipais", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS), relacionados ao Bloco de Estruturação na Rede de Serviços Públicos de Saúde e destinados ao enfrentamento da COVID-19 no bojo da ação 21C0 do orçamento da União." },
          new FonteRecurso() { Id = 33, Exercicio = 2021, CodigoPrincipal = "213", Detalhamento = "0000", Nome = "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Estadual", Especificacao = "Controle dos recursos originários de transferências em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada a programas da saúde." },
          new FonteRecurso() { Id = 34, Exercicio = 2021, CodigoPrincipal = "214", Detalhamento = "0000", Nome = "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Manutenção das Ações e Serviços Públicos de Saúde", Especificacao = "Controlar dos recursos originários de operações de crédito, cuja destinação encontra-se vinculada a programas da saúde." },
          new FonteRecurso() { Id = 35, Exercicio = 2021, CodigoPrincipal = "214", Detalhamento = "2100", Nome = "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Manutenção das Ações e Serviços Públicos de Saúde – Recursos destinados ao enfrentamento da COVID-19 no bojo da ação.", Especificacao = "Controle dos recursos vinculados à Saúde, originários de transferências recebidas pelo Município, relativos  a Royalties e Participação Especial – Art. 2º da Lei nº 12.858/2013." },
          new FonteRecurso() { Id = 36, Exercicio = 2021, CodigoPrincipal = "215", Detalhamento = "0000", Nome = "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Estruturação da Rede de Serviços Públicos de Saúde.", Especificacao = "Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 211 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 37, Exercicio = 2021, CodigoPrincipal = "215", Detalhamento = "2100", Nome = "Transferências Fundo a Fundo de Recursos do SUS provenientes do Governo Federal - Bloco de Estruturação da Rede de Serviços Públicos de Saúde – Recursos destinados ao enfrentamento da COVID-19 no bojo da ação.", Especificacao = "Controle dos recursos originários de transferências do Fundo Nacional de Saúde, referentes ao Sistema Único de Saúde (SUS), relacionados ao Bloco de Estruturação na Rede de Serviços Públicos de Saúde e destinados ao enfrentamento da COVID-19 no bojo da ação 21C0 do orçamento da União." },
          new FonteRecurso() { Id = 38, Exercicio = 2021, CodigoPrincipal = "220", Detalhamento = "0000", Nome = "Transferências de Convênios ou de Contratos de Repasse vinculados à Saúde", Especificacao = "Controle dos recursos originários de transferências em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada a programas da saúde." },
          new FonteRecurso() { Id = 39, Exercicio = 2021, CodigoPrincipal = "230", Detalhamento = "0000", Nome = "Operações de Crédito vinculadas à Saúde", Especificacao = "Controlar dos recursos originários de operações de crédito, cuja destinação encontra-se vinculada a programas da saúde." },
          new FonteRecurso() { Id = 40, Exercicio = 2021, CodigoPrincipal = "240", Detalhamento = "0000", Nome = "Royalties do Petróleo vinculados à Saúde", Especificacao = "Controle dos recursos vinculados à Saúde, originários de transferências recebidas pelo Município, relativos  a Royalties e Participação Especial – Art. 2º da Lei nº 12.858/2013." },
          new FonteRecurso() { Id = 41, Exercicio = 2021, CodigoPrincipal = "250", Detalhamento = "0000", Nome = "Receita de Impostos e de Transferência de Impostos - Saúde - Remuneração de Depósitos Bancários", Especificacao = "Controle das despesas custeadas com os rendimentos do recursos de impostos e transferências de impostos consideradas para cumprimento do limite constitucional e será utilizado pelos entes da federação que utilizam a fonte de recuros 211 e que, em razão da forma de verificação do cumprimento do limite mínimo, necessitam identificar esses recursos por meio de uma fonte específica." },
          new FonteRecurso() { Id = 42, Exercicio = 2021, CodigoPrincipal = "290", Detalhamento = "0000", Nome = "Outros Recursos Vinculados à Saúde", Especificacao = "Controle dos recursos não enquadrados em especificações próprias, cuja destinação encontra-se vinculada a programas da saúde." },
          new FonteRecurso() { Id = 43, Exercicio = 2021, CodigoPrincipal = "311", Detalhamento = "0000", Nome = "Transferência de Recursos do Fundo Nacional de Assistência Social - FNAS", Especificacao = "Controle os recursos originários de transferências do Fundo Nacional de Assistência Social - Lei Federal nº 8.742, 07/12/1993." },
          new FonteRecurso() { Id = 44, Exercicio = 2021, CodigoPrincipal = "312", Detalhamento = "0000", Nome = "Transferências de Convênios - Assistência Social", Especificacao = "Controle dos recursos originários de transferências em virtude de assinatura de convênios ou legislações específicas, cuja destinação encontra-se vinculada a programas da assistência social." },
          new FonteRecurso() { Id = 45, Exercicio = 2021, CodigoPrincipal = "390", Detalhamento = "0000", Nome = "Outros Recursos Vinculados à Assistência Social", Especificacao = "Controle dos recursos não enquadrados em especificações próprias, cuja destinação encontra-se vinculada a programas da assistência social." },
          new FonteRecurso() { Id = 46, Exercicio = 2021, CodigoPrincipal = "410", Detalhamento = "0000", Nome = "Recursos vinculados ao RPPS - Fundo em Capitalização (Plano Previdenciário)", Especificacao = "Controle dos recursos vinculados ao fundo em capitalização do RPPS. Esse plano existe tanto nos entes que segregaram quanto no" },
          new FonteRecurso() { Id = 47, Exercicio = 2021, CodigoPrincipal = "420", Detalhamento = "0000", Nome = "Recursos vinculados ao RPPS - Fundo em Repartição (Plano Financeiro)", Especificacao = "Controle dos recursos vinculados ao fundo em repartiçãoo do RPPS. Esse plano existe somente nos entes que segregaram a massa d" },
          new FonteRecurso() { Id = 48, Exercicio = 2021, CodigoPrincipal = "430", Detalhamento = "0000", Nome = "Recursos vinculados ao RPPS - Taxa de Administração", Especificacao = "Constrole dos recursos destinados ao custeio das despesas necessárias à organização e ao funcionamento da unidade gestora do R" },
          new FonteRecurso() { Id = 49, Exercicio = 2021, CodigoPrincipal = "450", Detalhamento = "0000", Nome = "Recursos vinculados ao RGPS", Especificacao = "Controle dos recursos vinculados ao RGPS (uso exclusivo da União)." },
          new FonteRecurso() { Id = 50, Exercicio = 2021, CodigoPrincipal = "460", Detalhamento = "0000", Nome = "Recursos vinculados às pensões e aos inativos militares", Especificacao = "Controle dos recursos vinculados aos benefícios previdenciários concedidos aos militares e pensionistas militares." },
          new FonteRecurso() { Id = 51, Exercicio = 2021, CodigoPrincipal = "510", Detalhamento = "0000", Nome = "Outras Transferências de Convênios ou Contratos de Repasse da União", Especificacao = "Recursos originários de transferências federais em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada aos seus objetos. Não serão controlados por esta fonte os recursos de convênios vinculados a programas da educação, da saúde e da assistência social, cujo controle será realizado através das fontes 125, 220 e 312, respectivamente. " },
          new FonteRecurso() { Id = 52, Exercicio = 2021, CodigoPrincipal = "520", Detalhamento = "0000", Nome = "Outras Transferências de Convênios ou Contratos de Repasse dos Estados", Especificacao = "Recursos originários de transferências estaduais em virtude de assinatura de convênios, contratos de repasse ou legislações específicas, cuja destinação encontra-se vinculada aos seus objetos. Não serão controlados por esta fonte os recursos de convênios ou contratos de repasse vinculados a programas da educação, da saúde e da assistência social, cujo controle será realizado através das fontes 125, 220 e 312, respectivamente. " },
          new FonteRecurso() { Id = 53, Exercicio = 2021, CodigoPrincipal = "530", Detalhamento = "0000", Nome = "Transferência da União Referente a Royalties do Petróleo", Especificacao = "Controle dos recursos originários da arrecadação da cota-parte royalties." },
          new FonteRecurso() { Id = 54, Exercicio = 2021, CodigoPrincipal = "540", Detalhamento = "0000", Nome = "Transferência dos Estados Referente a Royalties do Petróleo", Especificacao = "Controle dos recursos originários das transferências de royalties pelos Estados." },
          new FonteRecurso() { Id = 55, Exercicio = 2021, CodigoPrincipal = "550", Detalhamento = "0000", Nome = "Transferência Especial da União", Especificacao = "Controle dos recursos provenientes de emendas individuais impositivas ao orçamento da União nos termos do art. 166-A, inciso I, da Constitui" },
          new FonteRecurso() { Id = 56, Exercicio = 2021, CodigoPrincipal = "560", Detalhamento = "0000", Nome = "Transferências da União – inciso I do art. 5º da Lei Complementar 173/2020 ", Especificacao = "Controle dos recursos provenientes de transferência da União com base no disposto no inciso I do art. 5º da lei complementar 173/2020." },
          new FonteRecurso() { Id = 57, Exercicio = 2021, CodigoPrincipal = "610", Detalhamento = "0000", Nome = "Contribuição de Intervenção no Domínio Econômico - CIDE", Especificacao = "Controle dos recursos da CIDE." },
          new FonteRecurso() { Id = 58, Exercicio = 2021, CodigoPrincipal = "620", Detalhamento = "0000", Nome = "Contribuição para o Custeio do Serviço de Iluminação Pública - COSIP", Especificacao = "Controle dos recursos da COSIP, nos termos do artigo 149-A da Constituição Federal da República." },
          new FonteRecurso() { Id = 59, Exercicio = 2021, CodigoPrincipal = "630", Detalhamento = "0000", Nome = "Recursos Vinculados ao Trânsito", Especificacao = "Controle dos recursos com a cobrança das multas de trânsito nos termos do artigo nº. 320 da Lei nº 9.503/1997 - Código de Trânsito Brasileiro." },
          new FonteRecurso() { Id = 60, Exercicio = 2021, CodigoPrincipal = "910", Detalhamento = "0000", Nome = "Recursos próprios dos consórcios", Especificacao = "Controle dos recursos próprios dos Consórcios Públicos" },
          new FonteRecurso() { Id = 61, Exercicio = 2021, CodigoPrincipal = "920", Detalhamento = "0000", Nome = "Recursos de Operações de Crédito", Especificacao = "Controle dos recursos originários de operações de crédito, exceto as operações cuja aplicação estejam destinadas a programas de educação e saúde." },
          new FonteRecurso() { Id = 62, Exercicio = 2021, CodigoPrincipal = "930", Detalhamento = "0000", Nome = "Recursos de Alienação de Bens/Ativos", Especificacao = "Controle dos recursos advindos da alienação de bens nos termos do art. 44 da LRF." },
          new FonteRecurso() { Id = 63, Exercicio = 2021, CodigoPrincipal = "940", Detalhamento = "0000", Nome = "Outras vinculações de transferências", Especificacao = "Controle dos recursos de outras transferências vinculadas." },
          new FonteRecurso() { Id = 64, Exercicio = 2021, CodigoPrincipal = "950", Detalhamento = "0000", Nome = "Outras vinculações de taxas e contribuições", Especificacao = "Controle dos recursos de outras taxas e contribuições vinculadas" },
          new FonteRecurso() { Id = 65, Exercicio = 2021, CodigoPrincipal = "961", Detalhamento = "0000", Nome = "Recursos de depósitos judiciais – Lides das quais o ente faz parte", Especificacao = "Controle dos recursos de depósitos judiciais apropriados pelo ente de lides das quais o ente faz parte." },
          new FonteRecurso() { Id = 66, Exercicio = 2021, CodigoPrincipal = "962", Detalhamento = "0000", Nome = "Recursos de depósitos judiciais – Lides das quais o ente não faz parte", Especificacao = "Controle dos recursos de depósitos judiciais apropriados pelo ente de lides das quais o ente não faz parte." },
          new FonteRecurso() { Id = 67, Exercicio = 2021, CodigoPrincipal = "971", Detalhamento = "0000", Nome = "Recursos extraorçamentários vinculados a precatórios", Especificacao = "Controle dos recursos financeiros junto aos tribunais de justiça vinculados " },
          new FonteRecurso() { Id = 68, Exercicio = 2021, CodigoPrincipal = "972", Detalhamento = "0000", Nome = "Recursos extraorçamentários vinculados a depósitos judiciais", Especificacao = "Controle dos recursos financeiros junto aos tribunais de justiça vinculados " },
          new FonteRecurso() { Id = 69, Exercicio = 2021, CodigoPrincipal = "979", Detalhamento = "0000", Nome = "Outros recursos extraorçamentários", Especificacao = "Controle dos recursos financeiros que não transitam pelo orçamento, como dep" },
          new FonteRecurso() { Id = 70, Exercicio = 2021, CodigoPrincipal = "980", Detalhamento = "0000", Nome = "Recursos não classificados – a classificar", Especificacao = "Classificação temporária enquanto não se identifica a correta vinculação." },
          new FonteRecurso() { Id = 71, Exercicio = 2021, CodigoPrincipal = "990", Detalhamento = "0000", Nome = "Outros Recursos Vinculados", Especificacao = "Controle dos recursos cuja aplicação seja vinculada e não tenha sido enquadrado em outras especificações." }
        };

      modelBuilder.Entity<FonteRecurso>().HasData(fontesRecursos);
    }
  }
}