# TrilhaCSharp

Minha trilha de estudos para consolidar C# / .NET, do básico até tudo o que vi no Entra21, e chegar a **fazer sozinho, sem IA**, um fluxo inteiro: API REST, SQL, migration, DTO, regras de negócio e front.

No curso usei muita IA: hoje eu leio e entendo, mas ainda não escrevo tudo do zero sem consulta. Aqui a regra é a inversa: **eu escrevo o código**, e a IA só orienta, com cada vez menos ajuda, até não precisar mais.

E os exercícios são **baseados em jogos variados**: pets, loja de itens, guilda de aventureiros, batalha por turnos. Estudo coisa séria, mas quero me divertir enquanto aprendo.

## Como funciona

Cada habilidade passa por **cerca de 4 repetições**. A cada uma, mudam o tema **e** uma regra, e a ajuda diminui:

| Repetição | Exemplo (habilidade: classe + lista + método) | Ajuda |
|---|---|---|
| 1 | cadastrar e listar pets | à vontade |
| 2 | pet cuja fome cai a cada turno | olhando a 1 |
| 3 | item da loja que não vende sem estoque | menos |
| 4 | herói que só aceita missão do nível dele | nenhuma, sem IA |

A habilidade só passa quando eu faço sem IA e explico o porquê de cada linha.

**Nenhuma repetição é apagada.** Cada uma é um projeto próprio na solução, para comparar a primeira com a última e ver a evolução, aqui e no histórico do Git.

## Fases

1. **Console C#**: POO, coleções, LINQ, exceções e, no fim, separar em camadas (Clean Architecture). ← *agora*
2. **SQL puro** no MySQL.
3. **Front** com HTML, CSS e JavaScript, consumindo json-server.
4. **Web API** com EF Core, migrations, DTO, JWT, Swagger e testes com xUnit.
5. **Fusão: o jogo.** Batalha por turnos com um herói editável e pets que lutam junto, habilidades, nível, loja e inventário. Os temas das fases anteriores (pets, loja, guilda de aventureiros) vivem no mesmo mundo, com os mesmos nomes, e aqui viram um jogo só.
6. **Desafio final**: um sistema num tema que nunca pratiquei, do zero e sem IA.

## Estrutura

```
TrilhaCSharp.slnx
Fase1\
  ClasseListaMetodo\
    ClasseListaMetodo.Rep1.Pets\
    ...
```

Uma pasta por habilidade e um projeto de console por repetição, em .NET 10.

## Para rodar

Abra `TrilhaCSharp.slnx` no Visual Studio, defina a repetição como projeto de inicialização e aperte Ctrl+F5. Pelo terminal:

```
dotnet run --project Fase1\ClasseListaMetodo\ClasseListaMetodo.Rep1.Pets
```
