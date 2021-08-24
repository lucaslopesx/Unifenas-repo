#include <iostream>
using namespace std;
int fat(int N) 
{
	_asm 
	{
		mov ecx, N
		mov eax, ecx
		dec ecx
		repita:
			imul ecx
		loop repita
	}
}
//
//int tam(char *n) {
//
//}

int soma(int* v, int x)
{
	_asm
	{
		mov ebx, v
		mov eax, 0
		mov ecx, x
		inicio :
		add eax, [ebx]
			add ebx, 4
			loop inicio
	}
}

int conta(char* s, char x) {
	_asm
	{
		mov eax, 0
		mov cl, x
		mov ebx, s
		loopp :
		cmp[ebx], cl
		ja nextt
		jb nextt
		inc eax
		nextt :
		inc ebx
		cmp[ebx], 0
		jnz loopp
	}
}

int contaUPandLOW(char* s, char x)
{
	_asm
	{
		mov eax, 0
		mov cl, x
		mov ebx, s
		beginn :
		cmp[ebx], 65
			jb loww
			cmp[ebx], 90
			ja loww
			add[ebx], 32
			cmp[ebx], cl
			jnz nextt
			loww :
		cmp[ebx], 97
			jb nextt
			cmp[ebx], 122
			ja nextt
			cmp[ebx], cl
			jnz nextt
			inc eax
			nextt :
		inc ebx
			cmp[ebx], 0
			jnz beginn
	}
}

int maior(int x, int y) {
	_asm
	{
		mov eax, x
		mov ebx, y
		beginn :
		cmp eax, ebx
			jge endd //compara se sao iguais
			jb lowerr
			jmp endd
			lowerr :
		mov eax, ebx
			endd :
	}
}

int soma(int n) {
	if (n == 1) {
		return 1;
	}
	else {
		return (n + soma(n - 1));
	}
}
//void limpanum(char* E)
//{
//	_asm
//	{
//		mov ebx, E
//		inicio :
//		cmp[ebx], 48
//			jb proximo
//			cmp[ebx], 57
//			ja proximo
//			mov[ebx], 32
//			proximo :
//			inc ebx
//			cmp[ebx], 0
//			jnz inicio
//	}
//}

int main(void) 
{
	int x = 10, * y;
	y = &x;
	x = x * 3;
	int *M = new int*[4][5];
	cout <<  soma(3) << endl;


	int N = 6;
	cout << fat(N) << endl;

	char nome[30] = "Unive31rs123idade";
	char s[30] = "UnivEersiedAade";


	//cout << "Tamanho: " << tam(nome) << endl;
	//limpanum(nome);

	cout << nome << endl;
	cout << s << endl;
	cout << "Quantidade de letra a: " << conta(s,'a') << endl;
	cout << "Quantidade de letra a: " << contaUPandLOW(s, 'a') << endl;
	cout << maior(999, 9999) << endl;

	int v[4] = { 5,2,8,1 };

	cout << "Soma: " << soma(v, 4) << endl;

	return 1;
}