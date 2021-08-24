#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

int fib(int x)
{
	if (x == 0)
	{
		return 0;
	}
	else if (x == 1)
	{
		return 1;
	}
	else
	{
		return fib(x - 1) + fib(x - 2);
	}
}

int main(void)
{
	cout << fib(2) << endl;
}