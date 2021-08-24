#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int x;

printf("Digite sua idade: ");
scanf("%d",&x);

if((x >= 18)&&(x <= 67)){
	printf("\nPode doar!");
}else{
	printf("\nNão pode doar!");
}
return 1;
}

