#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	char letra;
	
	printf("Digite uma letra de A a E: ");
	scanf("%c",&letra);
	printf("\n");
	
	switch(letra){
		
		case 'A':
			printf("Arara");
			printf("\n");
			break;
		case 'B':
			printf("Bola");
			printf("\n");
			break;
		case 'C':
			printf("Casa");
			printf("\n");
			break;
		case 'D':
			printf("Domingo");
			printf("\n");
			break;
		case 'E':
			printf("Escola");
			printf("\n");
			break;
	}

}
