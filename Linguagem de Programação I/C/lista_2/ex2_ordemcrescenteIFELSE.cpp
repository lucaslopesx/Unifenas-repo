#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

int main(void){
setlocale(LC_ALL,"");
int x,y,z;

printf("Número 1: ");
scanf("%d",&x);
printf("Número 2: ");
scanf("%d",&y);
printf("Número 3: ");
scanf("%d",&z);

if((x>y)&&(y>z)){
	printf("%d %d %d",z,y,x);
}else if((x>z)&&(z>y)){
	printf("%d %d %d",y,z,x);
}else if((y>x)&&(x>z)){
	printf("%d %d %d",z,x,y);
}else if((y>z)&&(z>x)){
	printf("%d %d %d",x,z,y);
}else if((z>x)&&(x>y)){
	printf("%d %d %d",y,x,z);
}else{
	printf("%d %d %d",x,y,z);
}

return 1;
}
