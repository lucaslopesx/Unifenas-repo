#include <stdio.h>
#include <stdlib.h>
int main(void){

	FILE *arq;
	int i;
	
	arq = fopen("resultado.txt", "w");
	
	if (arq == NULL){
    	printf("ERRO! O arquivo não foi aberto!\n");
    	return 1;
	}
	
	for(i=0;i<10;i++){
		fprintf(arq, "%d\n", i);
	}
	
	fclose(arq);
	
	printf("DADOS gravados com sucesso!!\n");
	
	system("pause");
	return 1;
}
