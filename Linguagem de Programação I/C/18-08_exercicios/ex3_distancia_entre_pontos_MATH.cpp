#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void){
	int x1,y1,x2,y2,dist;
	
	printf("Distancia entre pontos\n\n");
	
	printf("PONTO A\n");
	printf("Digite o x: ");
	scanf("%d",&x1);
	printf("Digite o y: ");
	scanf("%d",&y1);
	
	printf("PONTO B\n");
	printf("Digite o x: ");
	scanf("%d",&x2);
	printf("Digite o y: ");
	scanf("%d",&y2);
	
	dist = sqrt(pow((x2-x1),2)+pow((y2-y1),2));
	
	printf("Distancia: %d",dist);
	
}
