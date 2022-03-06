masculino(joao).
masculino(jose).
masculino(jorge).

feminino(maria).
feminino(julia).
feminino(ana).
feminino(iris).

progenitor(maria,jose).
progenitor(joao,jose).
progenitor(joao,ana).
progenitor(jose,julia).
progenitor(jose,iris).
progenitor(iris,jorge).

filho(Y,X):-progenitor(X,Y),masculino(Y).
filha(Y,X):-progenitor(X,Y),feminino(Y).

pai(Y,Filho):-progenitor(Y,Filho),masculino(Y).
mae(Y,Filho):-progenitor(Y,Filho),feminino(Y).

avô(X,Z):-progenitor(X,Y),progenitor(Y,Z),masculino(X).
avó(X,Z):-progenitor(X,Y),progenitor(Y,Z),feminino(X).

bisavô(X,Z):-progenitor(X,Y),progenitor(Y,W),progenitor(W,Z),masculino(X).
bisavó(X,Z):-progenitor(X,Y),progenitor(Y,W),progenitor(W,Z),feminino(X).
