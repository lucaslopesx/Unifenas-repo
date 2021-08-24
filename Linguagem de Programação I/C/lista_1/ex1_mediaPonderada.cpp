#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	int n1,n2,n3,p1,p2,p3;
	int soma1,soma2,soma3,total,media;
	printf("Media Ponderada!!\n");
	
	printf("Digite a nota 1: ");
	scanf("%d",&n1);
	printf("Digite a nota 2: ");
	scanf("%d",&n2);
	printf("Digite a nota 3: ");
	scanf("%d",&n3);
	printf("Digite o peso 1: ");
	scanf("%d",&p1);
	printf("Digite o peso 2: ");
	scanf("%d",&p2);
	printf("Digite o peso 3: ");
	scanf("%d",&p3);
	
	soma1 = n1 * p1;
	soma2 = n2 * p2;
	soma3 = n3 * p3;
	total = p1 + p2 + p3;
	media = (soma1 + soma2 + soma3)/total;
	
	printf("\n\nMedia: %d",media);
	
	return 1;
}
