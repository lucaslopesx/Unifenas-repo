#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int x,y;

printf("Digite um numero: ");
scanf("%d",&x);
printf("Digite outro numero: ");
scanf("%d",&y);

if(x>y){
	printf("O número %d é maior que %d",x,y);
}else if(x==y){
	printf("Os números %d e %d são iguais!",x,y);
}else{
	printf("O número %d é maior que %d",y,x);
}
return 1;

}
