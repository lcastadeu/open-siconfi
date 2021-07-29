![Badge](https://dotnet.microsoft.com/static/images/redesign/downloads-dotnet.svg?v=uLixlb9S-A5Qlb2r4ONUKPIBIrr2ABPgOfgTSqfDRwY)
# Open SICONFI

# Sobre
## O SICONFI
SICONFI é o Sistema de Informações Contábeis e Fiscais do Setor Público Brasileiro destinado a receber os dados contábeis, orçamentários e fiscais dos entes da federação. Entrou em operação no ano de 2014 e é mantido pela Secretaria do Tesouro Nacional (STN).

## O Serviço
Este serviço tem como finalidade fornecer a planilha disponibilizada anualmente pelo SICONFI, em forma de API Rest. Tendo como finalidade ajudar a comunidade a padronizar as informações.

# O que será disponibilizado
- [x] Informações Complementáres
- [ ] Conjunto de Informações Complementáres
- [x] Fontes de Recursos
- [x] Natureza de Receita
- [ ] Natureza de Despesa
- [ ] Poder e Orgão
- [ ] Função e Subfunção
- [x] Complemento de Fonte de Recurso
- [ ] PCASP Estendido

# Pré requisitos
- [x] Terminal
- [x] Docker
- [x] .Net 5.0

# Iniciando serviço (Uma das opções abaixo) 
Para iniciar o projeto possuem duas opções, na qual fica optativo. Basta abrir o terminal e executar um dos comando abaixo.
## Terminal
```bash
dotnet run
```
## Docker
```bash
docker-compose up --b
```
- Basta acessar: http://127.0.0.1:5000/swagger/index.html