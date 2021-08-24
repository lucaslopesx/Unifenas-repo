#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
int main(){
    int i,j,b,a,aux,aux_qn=0,indice;
    float vet[30],notas[10],provas[10];
    float mat[3][10];
    int test[3][10];
    int menor,qn[10];
    qn[0]=0;//lixo de memoria;
    qn[1]=0;
    qn[2]=0;
    for(i=0;i<10;++i){
        for(j=0;j<3;++j){
    printf("Aluno %d ,na prova [%d] :",i+1,j+1);
    scanf("%f",&vet[j]);
    mat[i][j]=vet[j];
        }
        printf("==========================\n");
    }

    for(i=0;i<10;++i){
        aux=0;
        aux_qn=0;
        for(j=0;j<3;++j){

        if(j==0){
            menor=mat[i][0];//
        }

        if (mat[i][j]<menor){
            aux++;
            aux_qn=j;
            //aux_qn=j;
            menor=mat[i][j];
        }

        }
        qn[aux]+=1;
        notas[i]=menor;
        provas[i]=aux;
        a++;
    }
    printf("\n====MATRIZ=====\n");

    for(i=0;i<10;++i){
    printf("%d° Aluno  :",i+1);
        for(j=0;j<3;++j){ //IMPRIMINDO A MATRIZ ORIGINAL
        printf(" %f ",mat[i][j]);
        }
    printf("\n\n");
    }
    printf("=============RELATORIO DE NOTAS =============== \n");
    for(i=0;i<10;++i){
        j=i;
        a=j;

        printf(" ALUNO: %i ",i+1);//notas[i]
        printf(" - Questao com a menor nota : %.2f\n",provas[i]+1);
        //printf("======\nQuantidade de alunos com menor nota na prova %d =  %d alunos  ======",i+1,qn[i]);

    }
    printf("\n\n=============== RELATORIO DE ACERTOS EM PROVAS =============\n");
    for(i=0;i<3;++i){
        printf("======Quantidade de alunos com menor nota na prova %d =  %d alunos  ====== \n",i+1,qn[i]);
    }
    system("pause");
}
