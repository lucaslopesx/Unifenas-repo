#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
	setlocale(LC_ALL,"");
	
	int i;
		
	for(i=1000;i<=1999;i++){
		if(i%11 == 5){
			printf("%d\n",i);
		}
	}
	printf("\n N�meros de 1000 a 1999 que d�o resto 5");
}
