#define TAM 20

typedef struct{
	int M[TAM];
	int com, fim, total;
}fila;

void qInit(fila *f){
	f->com = 0;
	f->fim = 0;
	f->total = 0;
}

void enQueue(fila *f, int x){
	if (f->total<TAM)
	{
		f->M[f->fim]=x;
		f->fim++;
		if (f->fim==TAM)
		{
			f->fim=0;
		}
		f->total++;
	}
}

void mostra(fila *f1){
	
		printf("[");
		int i=f1->com;
		int c;
		for (c=0;c<f1->total;++c){
			printf("%d",f1->M[i]);
			++i;
			
			if(c < f1->total-1){
				printf(",");
			}
			if (i==TAM){
				i=0;
			}
		}
		printf("]");
	
}

int deQueue(fila *f){
	if(f->total>0){
		int X=f->M[f->com];
		f->com++;
		if (f->com==TAM){
			f->com=0;
		}
		f->total--;
		return X;
	}
}
int deQueueFim(fila *f){
	if(f->total>0){
		int X=f->M[f->fim-1];
		f->fim--;
		if (f->fim==TAM){
			f->fim=0;
		}
		f->total--;
		return X;
	}
}
char queueIsEmpty(fila *f){
	if(f->total == 0){
		return 1;
	}else{
		return 0;
	}
}
char queueIsFull(fila *f){
	if(f->total == TAM){
		return 1;
	}else{
		return 0;
	}
}

int conta(fila *f1,int X){
	int i=f1->com,cont=0;
	int c;
	for(c=0;c<f1->total;c++){
		if( f1->M[i] == X){
			cont++;
	}
		
	i++;
		if(i==TAM)
			i=0;
	}		
	
	return cont;
}

void enQueueInicio(fila *f1, int x){
	f1->com--;
	if(f1->com < 0){
		f1->com = TAM-1;
	}
	f1->M[f1->com]=x;
	f1->total++;
}


