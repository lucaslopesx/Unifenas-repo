#include <stdio.h>
#include <stdlib.h>

int main(void){
	FILE *pont_arq;
	int i, res;
	pont_arq = fopen("arquivo.txt", "w");
	
	
	if (pont_arq == NULL){
    	printf("ERRO! O arquivo não foi aberto!\n");
    	return 1;
	}
		
	for(i=0;i<10;i++){
		fprintf(pont_arq, "%d\n", i);
	}
	
	fclose(pont_arq);
	
	printf("Dados gravados com sucesso!\n");
	
	
	system("pause");
	return 1;
}

