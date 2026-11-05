# Rep4: Herói e missões

**Projeto:** `Fase1\ClasseListaMetodo\ClasseListaMetodo.Rep4.Missoes`

## Parte 1: as classes

- [x] Crie uma classe para o herói, com nome, nível e XP. O herói nasce com o nome informado, nível 1 e XP 0.
- [x] Ninguém de fora altera o nível nem o XP direto.
- [x] Crie uma classe para a missão, com nome, nível mínimo, XP de recompensa e se já foi concluída. Ela nasce não concluída.
- [x] O herói sabe fazer uma missão:
  - se o nível dele é menor que o nível mínimo da missão, nada muda, e quem pediu fica sabendo por quê;
  - se a missão já foi concluída, nada muda, e quem pediu fica sabendo por quê;
  - senão, o herói ganha o XP da recompensa e a missão fica concluída.
- [x] A cada 100 XP o herói sobe 1 nível, e o que passou de 100 continua como XP (com 90 XP, ganhar 30 deixa o herói 1 nível acima com 20 XP).
- [x] O herói e a missão sabem montar a própria ficha.

## Parte 2: o programa

- [x] Ao abrir, existem o herói "Arin" e 4 missões cadastradas no código:
  - Caçar slimes: nível 1, 60 XP
  - Escoltar o mercador: nível 1, 50 XP
  - Limpar a caverna: nível 2, 80 XP
  - Enfrentar o golem: nível 3, 150 XP
- [x] Menu em loop até sair: `1` Ver herói / `2` Ver missões / `3` Fazer missão / `0` Sair.
- [x] **Ver missões:** lista numerada a partir de 1, com nível mínimo, XP e se já foi concluída.
- [x] **Fazer missão:** mostra a lista e pede o número. Entrada inválida mostra o motivo e volta para o menu. Na recusa, mostra o motivo. No sucesso, mostra o XP ganho e, se subiu de nível, avisa.

## Partida de exemplo

O texto pode variar.

```
> 1
Arin | nível 1 | XP 0

> 3
Missão: 3
Recusada: Limpar a caverna pede nível 2, Arin está no nível 1.

> 3
Missão: 1
Arin ganhou 60 XP.

> 3
Missão: 1
Recusada: Caçar slimes já foi concluída.

> 3
Missão: 2
Arin ganhou 50 XP. Subiu para o nível 2!

> 1
Arin | nível 2 | XP 10

> 3
Missão: 0
A escolha deve ser entre 1 e 4.

> 3
Missão: 3
Arin ganhou 80 XP.

> 3
Missão: 4
Recusada: Enfrentar o golem pede nível 3, Arin está no nível 2.

> 0
```

## Pronto

- [x] A partida acima sai igual.
- [x] Nenhuma classe usa `Console`.
- [x] Os números digitados foram testados com 0, 1, o último e o último + 1.

**Fora do pronto:** criar herói pelo menu, cadastrar missão, nível máximo, equipamento, falhar missão.
