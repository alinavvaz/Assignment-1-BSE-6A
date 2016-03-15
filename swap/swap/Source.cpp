#include <iostream>
#include <conio.h>
using namespace std;

void main()

{
	int a, b;
	cout << "enter two numbers that are to be swapped" << endl;
	cout << "enter a" << endl;
	cin >> a;
	cout << "enter b" << endl;
	cin>>b;
	a = a + b;
	b = a - b;
	a = a - b;


	cout << "swapped numbers are" << "\na="<<a<<"\nb=" << b << endl;
	_getch();
}