#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <locale.h>
#include <time.h>

int main(void){
setlocale(LC_ALL,"");
int dia,mes,ano,hora,min;

struct tm *data_hora;
time_t t;
t = time(NULL);
data_hora = localtime(&t);
	// as principais variáveis são:
    // tm_sec - segundos da hora do sistema (0 a 59)
    // tm_min - minutos da hora do sistema (0 a 59)
    // tm_hour - horas da hora do sistema (0 a 23)
    // tm_mday - dia da data do sistema (1 a 31) 
    // tm_mon - mês da data do sistema (0 a 11) 
    // tm_year - ano da data do sistema (desde 1900)
    // tm_wday - dia da semana da data do sistema (0 a 6, sendo o 0 o domingo)

dia = data_hora->tm_mday;
mes = data_hora->tm_mon+1;
ano = data_hora->tm_year+1900;
hora = data_hora->tm_hour;
min = data_hora->tm_min;


printf("\n %d/%d/%d \n", dia,mes,ano);
printf("\n %d:%d",hora,min);
}
