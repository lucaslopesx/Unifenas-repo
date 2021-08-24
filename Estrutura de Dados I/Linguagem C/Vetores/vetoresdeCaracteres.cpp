#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

//void escreva(char *ps, int size){
//	int i;
//	for(i=0;i<size;i++){
//		printf("%c",ps[i]);
//	}
//}

void escreva(char *ps){
	int i;
	for(i=0;ps[i]!=0;i++){
		printf("%c",ps[i]);
	}
}

int main(void){
	setlocale(LC_ALL,"");
	
//	char s[5]={'L','u','c','a','s'};
	char n[8];
	
	printf("Entre com o seu nome: ");
	scanf("%s",&n);
	
//	printf("%s",n);
	
	escreva(n);
	
	return 1;
}
