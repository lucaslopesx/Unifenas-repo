#define _CRT_SECURE_NO_WARNINGS
#include <iostream>

using namespace std;

float mdc(int x, int y)
{
	if (x == y)
	{
		return x;
	}
	else if (x < y)
	{
		return mdc(y, x);
	}
	else if (x > y)
	{
		return mdc(x - y, y);
	}


}

int main(void) 
{
	cout << mdc(8, 4) << endl;
}