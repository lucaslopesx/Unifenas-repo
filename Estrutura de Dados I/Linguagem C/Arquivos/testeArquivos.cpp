#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef char Elem[30];

int main(void){
	Elem N,X;
	
	
	strcpy(N,"joao");
	strcpy(X,"jose");
	
	if(!strcmp(X,N)){
		printf("Sao iguais!\n");
	}else{
		printf("Sao diferentes!\n");
	}
	
	printf("%d\n",strcmp(X,N));
	
	return 1;
}
