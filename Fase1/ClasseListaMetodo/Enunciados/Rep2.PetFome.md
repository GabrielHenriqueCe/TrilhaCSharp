# Rep2: A fome dos pets

**Projeto:** `Fase1\ClasseListaMetodo\ClasseListaMetodo.Rep2.PetFome`

## A classe

- [x] O `Pet` tem nome e fome, de 0 a 100. Ninguém de fora altera a fome.
- [x] A fome começa em 100, com a barra cheia.
- [x] Passar o turno tira 10 da fome, sem ficar abaixo de 0.
- [x] Alimentar soma 30 à fome, sem passar de 100.
- [x] A ficha mostra `Fome: X/100`.

## O programa

- [x] Menu em loop até sair: `1` Cadastrar / `2` Listar / `3` Passar turno / `4` Alimentar / `0` Sair.
- [x] **Listar:** lista numerada a partir de 1, com aviso se estiver vazia.
- [x] **Passar turno:** vale para todos os pets.
- [x] **Alimentar:** você escolhe o pet pelo número na lista. Texto pede de novo, e número fora da lista avisa e volta para o menu.
- [x] Opção inválida no menu: avisa e volta para o menu.

## Partida de exemplo

O texto pode variar.

```
> 1
Nome: A

> 1
Nome: B

> 3
> 3

> 2
1 - A  Fome: 80/100
2 - B  Fome: 80/100

> 4
Pet: 1
A  Fome: 100/100

> 4
Pet: 3
Valor inválido

> 0
```

## Pronto

- [x] A fome dá 80 e 80 depois de dois turnos, e 100 e 80 depois de alimentar o primeiro pet.
- [x] O 10 e o 30 moram no `Pet`.

**Fora do pronto:** o pet morrer quando a fome chega a 0.
