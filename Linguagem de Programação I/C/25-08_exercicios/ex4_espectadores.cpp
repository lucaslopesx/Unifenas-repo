#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int x;

printf("Digite a quantidade de pessoas: ");
scanf("%d",&x);

if(x<=1000){
	printf("P�blico baixo");
}else if((x>1000)&&(x<10000)){
	printf("P�blico m�dio");
}else{
	printf("P�blico bom");
}
}

