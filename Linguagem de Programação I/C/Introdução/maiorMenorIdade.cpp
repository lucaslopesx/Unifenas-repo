#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){

int idade;

printf("Digite a idade: ");
scanf("%d",&idade);

if(idade > 18){
	printf("Maior de idade!");
}else{
	printf("Menor de idade!");
}
}

