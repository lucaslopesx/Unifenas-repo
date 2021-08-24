#include <stdio.h>
#include <stdlib.h>
int main(void){

	FILE *arq;
	char texto_string[20];
	
	arq = fopen("texto.txt", "r");
	
	while(fgets(texto_string, 20, arq) != NULL){
		printf("%s", texto_string);
	}
	
	fclose(arq);
	
	return 1;
}
