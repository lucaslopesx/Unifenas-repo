#include <stdio.h>
#include <stdlib.h>

#define max 10

typedef struct {
	int topo,m[max];
}pilha;

void init(pilha *p){
	p->topo = 0;
}

void push(pilha *p, int r){
	if(p->topo < max){
		p->m[p->topo] = r;
		p->topo++;	
	}
}

int pop(pilha *p){
	if(p->topo > 0){
		p->topo--;
		return p->m[p->topo];
	}
}

char empty(pilha *p){
	if(p->topo == 0){
		return 1;
	}else{
		return 0;
	}
}

char isFull(pilha *p){
	if(p->topo==max){
		return 1;
	}else{
		return 0;
	}
}

int main(void){

	pilha p, po;
	int n,n2,r;
	
	printf("Digite um numero inteiro:");
	scanf("%d",&n);
	n2 = n;
	init(&p); //inicializar a pilha p
	init(&po);
	
	while (n>0){
		r = n % 2;
		if(!isFull(&p)){
			push(&p,r);
		}else{
			printf("Pilha cheia!!");
			return 1;
		}
		
		n = n / 2;
	}
	
	while (n2>0){
		r = n2 % 8;
		if(!isFull(&po)){
			push(&po,r);
		}else{
			printf("Pilha cheia!!");
			return 1;
		}
		
		n2 = n2 / 8;
	}
	
	printf("Correspondente em binario: ");
	while(!empty(&p)){
		printf("%d",pop(&p));
	}
	printf("\n\nCorrespondente em octal: ");
	while(!empty(&po)){
		printf("%d",pop(&po));
	}
return 1;
}
