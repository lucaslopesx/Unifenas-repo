#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

int Pot(int x, int y)
{
	if (y == 0)
	{
		return 1;
	}
	else if (y == 1)
	{
		return x;
	}
	else if (x == 0)
	{
		return 0;
	}
	else
	{
		return (x * Pot(x, y - 1));
	}
}



int main(void)
{
	int base = 2;
	int exp = 3;
	cout << "base: " << base << " || expoente: " << exp << endl;
	cout << Pot(base, exp) << endl;
}