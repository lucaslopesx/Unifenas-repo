#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

void hanoi(int n, char a, char b, char c)
{
	if (n == 1)
	{
		cout << "Transfira o disco da torre " << a << " para a torre " << c << endl;
	}
	else
	{
		hanoi(n - 1, a, c, b);
		cout << "Transferir o disco da torre " << a << " para a torre " << c << endl;
		hanoi(n - 1, b, a, c);
	}
}


int main()
{
	hanoi(64, 'A', 'B', 'C');
	return 0; 
}