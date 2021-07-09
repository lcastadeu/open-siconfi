using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OpenSiconfi.Domain.Entities;

namespace OpenSiconfi.Domain.Seed
{
  public class SeedInformacaoComplementar
  {
    public static void Data(ModelBuilder modelBuilder)
    {
      List<InformacaoComplementar> dados = new()
      {
        new InformacaoComplementar() { Id = 1, Exercicio = 2021, CodigoIC = "PO", Nome = "Poder ou Órgão ", Digito = 5, Descricao = "Poderes e Órgãos relacionados no artigo 20 da LRF.", Finalidade = "Permite a elaboração do Anexo 7 do RREO – Demonstrativo dos Restos a Pagar por Poder ou Órgão, do RGF de todos os poderes e órgãos, a partir do MSC enviada pelo Poder Executivo, e a extração das informações referentes ao RPPS." },
        new InformacaoComplementar() { Id = 2, Exercicio = 2021, CodigoIC = "FP", Nome = "Atributo do Superávit Financeiro (Financeiro/Permanente)", Digito = 1, Descricao = "1 - Financeiro / 2 - Permanente.", Finalidade = "Permite a apuração do superávit financeiro no Balanço Patrimonial." },
        new InformacaoComplementar() { Id = 3, Exercicio = 2021, CodigoIC = "DC", Nome = "Dívida Consolidada", Digito = 1, Descricao = "1 – não compõem a DC.", Finalidade = "Tem como objetivo a identificação de parte do passivo originário de financiamento ou operação de crédito equiparada, contratada com prazo de amortização inferior a 12 meses, que, conforme definido na Lei de Responsabilidade Fiscal – LRF, não integra a dívida consolidada. Esse marcador não identificará o total da dívida consolidada, mas sim o conjunto de contas em que parte do saldo poderá não integrar a DC. " },
        new InformacaoComplementar() { Id = 4, Exercicio = 2021, CodigoIC = "FR", Nome = "Fonte ou Destinação de Recursos", Digito = 8, Descricao = "1º dígito: Exerc. Atual = 1, Exerc. Anterior = 2 / 2º ao 4º dígito = classificação por fonte ou destinação de recursos 5º ao 8º dígito = Detalhamento da fonte ou destinação de recursos.", Finalidade = "Permite o acompanhamento da origem e destinação dos recursos legalmente vinculados a órgão, fundo ou despesa, possibilitando a identificação, pelo Siconfi, das informações necessárias à elaboração de demonstrativos fiscais integrantes do RREO e do RGF." },
        new InformacaoComplementar() { Id = 5, Exercicio = 2021, CodigoIC = "CF", Nome = "Complemento da Fonte de Recursos ou Destinação de Recursos", Digito = 4, Descricao = "Classificação definida conforme necessidade de complementação da classificação por fonte de Recursos.", Finalidade = "Essa informação complementar tem como objetivo a identificação de informações que complementam a classificação por Fonte de Recursos e que podem estar associadas às várias classificações de Fontes existentes. Trata-se, portanto, de um detalhamento flexível da Fonte de Recursos. Deverá ser utilizada pelos entes no momento da execução da receita e da despesa orçamentária, quando se aplicar, e, opcionalmente, na fase de previsão da receita e dotação da despesa." },
        new InformacaoComplementar() { Id = 6, Exercicio = 2021, CodigoIC = "NR", Nome = "Natureza da Receita", Digito = 8, Descricao = "Classificação por Natureza da Receita (8 dígitos) Portaria 163 STN/SOF.", Finalidade = null },
        new InformacaoComplementar() { Id = 7, Exercicio = 2021, CodigoIC = "ND", Nome = "Natureza da Despesa", Digito = 8, Descricao = "Classificação por Natureza da Despesa (8 dígitos) Portaria 163 STN/SOF.", Finalidade = null },
        new InformacaoComplementar() { Id = 8, Exercicio = 2021, CodigoIC = "FS", Nome = "Classificação Funcional (Função e Subfunção)", Digito = 5, Descricao = "Função (2 dígitos) +subfunção (03 dígitos), Portaria MOG nº 42/99.", Finalidade = "Classificação de aplicação comum e obrigatória, no âmbito da União, dos Estados, do Distrito Federal e dos Municípios, o que permite a consolidação nacional dos gastos do setor público." },
        new InformacaoComplementar() { Id = 9, Exercicio = 2021, CodigoIC = "AI", Nome = "Ano de Inscrição de Restos a Pagar", Digito = 4, Descricao = "Identificação do ano de inscrição de restos a pagar.", Finalidade = "Tem como objetivo a identificação dos valores referentes a restos a pagar para a elaboração de demonstrativos fiscais, como o quadro de controle de restos a pagar do Demonstrativo da  Saúde, que integra o RREO." },
        new InformacaoComplementar() { Id = 10, Exercicio = 2021, CodigoIC = "ES", Nome = "Despesas com MDE e ASPS", Digito = 1, Descricao = "1 – compõe MDE / 2 – compõe ASPS.", Finalidade = "Essa informação complementar tem como objetivo a identificação das despesas consideradas para cômputo do limite da educação e da saúde. Deverá ser utilizada pelos entes que não identificam os recursos aplicados para cumprimento dos limites por meio da fonte de recursos de receita de impostos para educação e para a saúde." }
      };

      modelBuilder.Entity<InformacaoComplementar>().HasData(dados);
    }
  }
}