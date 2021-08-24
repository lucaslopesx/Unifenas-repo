#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(void){
int x;
setlocale(LC_ALL,"");
printf("Digite um número: ");
scanf("%d",&x);

if(x>0){
	printf("\nPositivo!");
}else if(x=0){
	printf("\nZero!");
}else{
	printf("\nNegativo!");
}

return 1;

}

