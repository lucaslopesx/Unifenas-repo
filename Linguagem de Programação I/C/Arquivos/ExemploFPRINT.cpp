#include <stdio.h>
#include <conio.h>
int main(void)
{
  FILE *arq;
  int i;
  int result;
  arq = fopen("ArqGrav.txt", "wt");  // Cria um arquivo texto para grava��o
  if (arq == NULL) // Se n�o conseguiu criar
  {
     printf("Problemas na CRIACAO do arquivo\n");
     return 1;
  }
  for (i = 0; i<10;i++)
  {
// A funcao 'fprintf' devolve o n�mero de bytes gravados 
// ou EOF se houve erro na grava��o
      result = fprintf(arq,"Linha %d\n",i);  					  
      if (result == EOF)		    
	  printf("Erro na Gravacao\n");
  }
  fclose(arq);
}
