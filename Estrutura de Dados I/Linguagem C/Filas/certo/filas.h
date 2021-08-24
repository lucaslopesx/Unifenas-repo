#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

#define TAM 8
 
 typedef struct{
 	char M[TAM];
 	int Com,Fim,Total;
 }	Fila;
 
 void Qinity(Fila *pf1){
 	pf1->Com	=	0;
 	pf1->Fim	=	0;
 	pf1->Total	=	0;
 }
void Enqueue(Fila *pfila,char x){
	if (pfila->Total < TAM){
		pfila->M[pfila->Fim] = x;
		pfila->Fim++;
			if (pfila->Fim == TAM){
				pfila->Fim=0;
			}
		pfila->Total++;
	}
} 

char Dequeue(Fila *pfila){
	if (pfila->Total>0){
		char x = pfila->M[pfila->Com];
		pfila->Com++;
		if(pfila->Com == TAM){
			pfila->Com=0;
		}
		pfila->Total--;
		return x;
	}
}

void Mostra(Fila *ppop){
	
		printf("[");
		int i=ppop->Com;
		int c;
		for (c=0;c<ppop->Total;++c){
			printf("%d",ppop->M[i]);//ppop->M[ppop->Com]
			++i;
			
			if(c < ppop->Total-1){
				printf(",");
			}
			if (i==TAM){
				i=0;
			}
		}
		printf("]");
	
	
}
char Qisempty(Fila *pfila){ //empty em ingles é vazio
	if(pfila->Total==0){
		return 1;
	}
	else 
		return 0;
}

char Qisfull(Fila *pfila){
	if (pfila->Total==TAM)
		return 1;
	else 
		return 0;
}
int Conta(Fila *pfilas,int X){
	int i=pfilas->Com,cont=0;
	int c;
	for(c=0;c<pfilas->Total;++c){
		if( pfilas->M[i]== X){
			++cont;
	}
		
	++i;
		if(i==TAM)
			i=0;
	}		
	
	return cont;
	
}
 
