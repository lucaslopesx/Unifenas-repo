#include <stdio.h>
#include <stdlib.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");

int a,b,c;
a = 12;
b = 14;
c = 16;

if((a > b) && (c > a)){
	printf("Primeira Mensagem!\n");
}else if((a < b)||(b < c)){
	printf("Segunda Mensagem!\n");
}else if(c == a){
	printf("Terceira Mensagem!\n");
}else{
	printf("Quarta Mensagem!\n");
}
printf("Quinta Mensagem!\n");
system("pause");

}
