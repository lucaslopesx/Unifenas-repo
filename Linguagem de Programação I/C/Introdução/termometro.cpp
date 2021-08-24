#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

float temp;

printf("Digite a temperatura: ");
scanf("%f",&temp);

if(temp > 40.00){
	printf("Esta com febre!\n");
}else{
	printf("Sem febre!\n");
}
system("pause");
}
