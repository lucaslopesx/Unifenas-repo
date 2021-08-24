#include <iostream>
#include <cstring>
#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int main(void){
	
	int i, j, size, sizeAux;
	char frase[50],space = ' ',aux[30];
	
	printf("Digite uma frase: ");
	gets(frase);
	
	char add[] = "ou mouse";
	
	size = strlen(frase);
	
//	for(i=0;i<space;i++){
//		
//	}
	
	for(i=0;i<size;i++){
		if((frase[i+1]=='t')&&(frase[i+2]=='e')&&(frase[i+3]=='c')&&(frase[i+4]=='l')&&(frase[i+5]=='a')&&(frase[i+6]=='d')&&(frase[i+7]=='o')){
			strcat(frase,add);
		}
	}
	
	printf("%s",frase);


	return 1;
}
