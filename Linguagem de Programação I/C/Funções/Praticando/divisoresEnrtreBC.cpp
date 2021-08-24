#include <stdio.h>
#include <stdlib.h>

int divisores(int a,int b,int c)
{
    int i,soma;
    float resto;
    soma=0;
    for(i=b;i<=c;i++)
    {
        resto=i%a;
        if (resto==0)
        {
            soma=soma+i;
        }
    }
    return soma;
}

int main(void){
	int a=0,b,c,res;
	
	do{
		printf("Digite o valor de a sendo (a>0): ");
		scanf("%d",&a);
	}while(a<=0);
	printf("Digite o valor de b: ");
	scanf("%d",&b);
	printf("Digite o valor de c: ");
	scanf("%d",&c);
	
	res = divisores(a,b,c);
	printf("A soma dos divisores de a: %d",res);
}
