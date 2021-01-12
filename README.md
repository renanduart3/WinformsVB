# WinformsVB
![Processo-CI](https://github.com/renanduart3/WinformsVB/workflows/Processo-CI/badge.svg)
Projeto em windows forms utilizando .net full framework

As caracteristicas desse projetos sao baseadas no dotnet 4.5.2 usando windows forms em VB.

O pipeline realiza o build e se houver algum erro de build o projeto não realiza o deploy.
Os testes estou verificando ainda a utilização do mstest para rodar os testes no pipeline.

- [x] Build e deploy da app em winforms VB .net (4.5.2) em maquina windows local
- [ ] Adicionar regra de rodar o pipeline somente após pull_request aprovado na main
- [ ] Deploy em container
