#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>
#include <locale.h>

typedef struct{
	float notas[4];
	char nome[30];
	struct{
		int nro;
		char dv;
	}codigo;
}aluno;

int main(void){
	setlocale(LC_ALL,"");
	
	aluno reg;
	
	reg.notas[0] = 6.8;
	reg.codigo.nro = 1001;
	reg.codigo.dv = 5;
	
}

