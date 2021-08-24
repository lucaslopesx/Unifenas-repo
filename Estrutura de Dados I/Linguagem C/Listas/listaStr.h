#define TAM 8
#include <string.h>

typedef char Elem[30];

typedef struct{
	Elem m[TAM];
	int fim;
} lista;

void lInit(lista *l){
	l->fim=0;
}
	
void lIns(lista *l,Elem x){	
	if(l->fim<TAM){
		int i = l->fim;
		
		while(i>0 and strcmp(x,l->m[i-1])<0){
			strcpy(l->m[i],l->m[i-1]);
			i--;
		} 
		strcpy(l->m[i],x);
		l->fim++;	
	}
}

char lRem(lista *l, Elem x){
	int i = 0;
	
	while((i<l->fim) && strcmp(x,l->m[i])>0){
		i++;
	}
	if((i<l->fim) && !strcmp(x,l->m[i])){
		while(i<(l->fim-1)){
			strcpy(l->m[i],l->m[i+1]);
			i++;
		}
		l->fim--;
		return 1;
	}else{
		return 0;
	}
	
}

void lMostra (lista *l){
    printf ("[");
    int i;

    for (i=0;i<l->fim;i++){
        printf("%s",l->m[i]);
        if (i+1 < l->fim){
        	printf(",");
		}
    }
    printf ("]");
}

void lMostra_intervalo(lista *l, Elem xi, Elem xf){
	printf("[");
	int i;
	
	while((i<l->fim) && (strcmp(xi,l->m[i])>0)){
		i++;
	}
	while((i<l->fim) && (strcmp(xf,l->m[i])>=0)){
		printf(" %s",l->m[i]);
		i++;
	}
	
	printf(" ] ");
}

int lConta (lista *l, Elem x){
	int rep=0, i=0;
	if(l->fim>0){
		while((i<l->fim) && strcmp(x,l->m[i])>0){
			i++;
		}
		while((i<l->fim) && !strcmp(x,l->m[i])){
			rep++;
			i++;
		}
		printf("O elemento |%s| se repetiu %d vezes! \n",x,rep);
	}else{
		printf("Lista vazia, Operação inválida\n");
	}
	return rep;
}



