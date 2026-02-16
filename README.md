# AgendaPersonale
Esercizio sulla scrittura di un programma complesso basato su menu utente e con l'uso di array anche multipli.

## Funzionalità da implementare
Il progetto implementerà un menu utente
- permette all'utente di inserire un comando, lo esegue, e torna in attesa del prossimo comando
- resta in esecuzione fino a che l'utente non inserisce un comando per uscire

Le funzionalità implementate tramite il menu saranno:
- inserimento di un'attività con data e ora, titolo e descrizione
- visualizzazione delle attività in ordine cronologico
- modifica di un'attività inserita
- eliminazione di un'attività inserita

## Problematiche da affrontare
- gestione dei *buchi* nell'array (l'eliminazione di un elemento crea *buchi*)
- ordinamento del vettore (la visualizzazione degli appuntamenti in ordine cronologico richiede un ordinamento per data e ora)
- gestione di data e ora
- formattazione interna (ogni elemento richiede una struttura interna con diversi dati da usare in maniera diversa) --> utilizzo di API (per le stringhe)
