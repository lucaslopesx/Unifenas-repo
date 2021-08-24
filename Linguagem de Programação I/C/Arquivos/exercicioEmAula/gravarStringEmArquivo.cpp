#include <stdio.h>
#include <stdlib.h>
int main(void){
  FILE *arq;
  char palavra[20]; 
  

  arq = fopen("texto.txt", "w");
  

  if(arq == NULL){
	  printf("Erro na abertura do arquivo!");
	  return 1;
  }
  
  printf("Escreva uma palavra para gravar no arquivo: ");
  scanf("%s", palavra);
  
  fprintf(arq, "%s", palavra);
  
  fclose(arq);
  
  printf("Dados gravados com sucesso!");
  
  getchar();
  return(0);
}
