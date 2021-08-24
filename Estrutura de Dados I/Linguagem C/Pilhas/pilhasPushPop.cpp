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

int main(){
	pilha p;
	int n,r;
	
	printf("Digite um numero inteiro:");
	scanf("%d",&n);
	init(&p); //inicializar a pilha p
	
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
	
	printf("Correspondente em binario: ");
	while(!empty(&p)){
		printf("%d",pop(&p));
	}
return 1;
}









