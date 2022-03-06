masculino(lucas).
masculino(marcel).
masculino(francinir).
masculino(isaias).
masculino(joao).
masculino(santiago).

feminino(flavia).
feminino(maria).
feminino(maryene).
feminino(gabriela).
feminino(romilda).

progenitor(marcel,lucas).
progenitor(francinir,marcel).
progenitor(maria,marcel).
progenitor(flavia,lucas).
progenitor(maryene,flavia).
progenitor(isaias,flavia).
progenitor(joao,maryene).
progenitor(gabriela,maryene).
progenitor(santiago,isaias).
progenitor(romilda,isaias).

filho(Y,X):-progenitor(X,Y),masculino(Y).
filha(Y,X):-progenitor(X,Y),feminino(Y).

pai(Y,Filho):-progenitor(Y,Filho),masculino(Y).
mae(Y,Filho):-progenitor(Y,Filho),feminino(Y).

av�(X,Z):-progenitor(X,Y),progenitor(Y,Z),masculino(X).
av�(X,Z):-progenitor(X,Y),progenitor(Y,Z),feminino(X).

bisav�(X,Z):-progenitor(X,Y),progenitor(Y,W),progenitor(W,Z),masculino(X).
bisav�(X,Z):-progenitor(X,Y),progenitor(Y,W),progenitor(W,Z),feminino(X).

