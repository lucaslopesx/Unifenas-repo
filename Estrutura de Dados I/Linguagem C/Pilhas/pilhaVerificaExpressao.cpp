#include<stdio.h>
#include<stdlib.h>
#include<locale.h>
#include"pilha.h"

int main(void){
	setlocale(LC_ALL,"");
	char e[40];
	int i;
	char flag;
	pilha p;
	
	init(&p);
	
	printf("Entre com uma express�o: ");
	scanf("%s",&e);
	//analise da express�o
	
	flag = 1;
	for(i=0;e[i];i++){
		
		if(e[i]=='('){
			push(&p,1);
		}else 
			if(e[i]==')'){
				if(!empty(&p)){
					pop(&p);	
				}else{
					flag = 0;
					break;
				}	
		}
	}
	
	if(empty(&p) and flag != 0){
		printf("Express�o correta");
	}else{
		printf("Express�o Incorreta");
	}
	return 1;
}







