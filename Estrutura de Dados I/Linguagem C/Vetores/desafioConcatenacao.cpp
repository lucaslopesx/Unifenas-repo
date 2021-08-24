#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>

void concatena(char *ps1, char *ps2, char *ps3){
	int i,j=0;
	for(i=0;ps1[i]!=0;i++){
		ps3[j] = ps1[i];
		j++;
	}
	for(i=0;ps2[i]!=0;i++){
		ps3[j] = ps2[i];
		j++;
	}
	ps3[j]=0;
//	for(i=0;ps3[i]!=0;i++){
//		printf("%c",ps3[i]);
//	}
	
}

int main(void){
	setlocale(LC_ALL,"");
	
	char s1[15], s2[15], s3[30];
	
	printf("Digite a primeira string: ");
	scanf("%s",&s1);
	
	printf("Digite a segunda string: ");
	scanf("%s",&s2);
	
	concatena(s1,s2,s3);
	
	printf("\nResultado da concatenação: %s",s3);
	
	
	
}
