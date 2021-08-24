#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int v[4];
int i;

for(i=0;i<4;i++){
	printf("Entre com o %d° valor: ",i);
	scanf("%d",&v[i]);
}

printf("\nValores lidos: \n");

for(i=0;i<4;i++){
	printf("%d\n",v[i]);
}

return 1;

}
