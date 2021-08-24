#define TAM 8

typedef struct{
	char m[TAM];
	int fim;
}lista;

void lInit(lista *l){
	l->fim=0;
}
	
void lIns(lista *l,char x){
	int i = l->fim;
	if(l->fim<TAM){
		
		while((i>0) and (x<l->m[i-1])){
			l->m[i] = l->m[i-1];
			i--;
		} 
		l->m[i]=x;
		l->fim++;	
	}
}

char lRem(lista *l, char x){
	int i = 0;
	
	while((i<l->fim) && (x>l->m[i])){
		i++;
	}
	if((i<l->fim) && (x==l->m[i])){
		while(i<(l->fim-1)){
			l->m[i] = l->m[i+1];
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
        printf("%c",l->m[i]);
        if (i+1 < l->fim){
        	printf(",");
		}
    }
    printf ("]");
}

void lMostra_intervalo(lista *l, char xi, char xf){
	printf("[");
	int i;
	
	while((i<l->fim)&&(xi>l->m[i])){
		i++;
	}
	while((i<l->fim)&&(xf>=l->m[i])){
		printf(" %c",l->m[i]);
		i++;
	}
	
	printf(" ] ");
}

int lConta (lista *l, char x){
	int rep=0, i=0;
	if(l->fim>0){
		while((i<l->fim)&&(x>l->m[i])){
			i++;
		}
		while((i<l->fim)&&(x==l->m[i])){
			rep++;
			i++;
		}
		printf("O elemento |%c| se repetiu %d vezes! \n",x,rep);
	}else{
		printf("Lista vazia, Operação inválida\n");
	}
	return rep;
}



