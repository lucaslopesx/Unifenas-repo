#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#define TAM 15
#include <string.h>
typedef struct{
	char nome[30];
	int nr;
}Elem;

typedef struct{
 	Elem M[TAM];
 	int Fim;
}Lista;
 
void Linity(Lista *PL){
	PL->Fim=0;
}

void Lins(Lista *PL,Elem X){ // X é o caracter
	int i=PL->Fim;
	if(PL->Fim<TAM){ // A lista nao esta cheia
		//PL->M[i]=X;
		//++i;
		while( i > 0  &&  strcmp(X.nome,PL->M[i-1].nome) < 0){
			strcpy(PL->M[i].nome,PL->M[i-1].nome);
			PL->M[i].nr=PL->M[i-1].nr;
			i--;
		}
		strcpy(PL->M[i].nome,X.nome);
		PL->M[i].nr=X.nr;
		PL->Fim++;
	}
	
}

//void Lmostra (Lista *L)
//{
//    printf ("[");
//    int i;
//
//    for (i=0;i<L->Fim;i++)
//    {
//        printf("%s",L->M[i]);
//        if (i+1 < L->Fim)
//            printf(",");
//    }
//    printf ("]");
//}

//int Lconta(Lista *pl,Elem X){
//	int i=0,cont=0;
//
//	while( i<pl->Fim && strcmp(X , pl->M[i])>0)
//		i++;
//	while((i<pl->Fim) && strcmp(X , pl->M[i])==0){
//		cont++;
//		i++;
//	}
//    return cont;
//}

//void intervalo(Lista *pl,Elem X,Elem F){
//	
//	int i=0,a=0;
//	
//	while(i<pl->Fim && strcmp( X ,pl->M[i]) > 0)
//		++i;
//		
//	printf("[")	;
//	while(i < pl->Fim && strcmp(pl->M[i],F)>=0){
//		printf("%s ",pl->M[i]);
//		++i;
//	}
//	printf("]");
//
//}
char l_rem(Lista *pl,Elem X){
	int i=0;
	
		while(i < pl->Fim  &&  strcmp(X,pl->M[i])>0)
			++i;
		
		if(i < pl->Fim && strcmp(X,pl->M[i])==0){
			while(i < (pl->Fim - 1)){
				strcpy(pl->M[i] , pl -> M[i+1]);
				++i;
			}
			pl->Fim--;
			return 1;
		}
		
		else
			return 0;
}
