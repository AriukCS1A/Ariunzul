#include<stdio.h>
int power (int base, int n){
	if (n == 1) return base;
	else {
		int result = power (base, n-1) * base;
		return result;
	}
}
int main (){
	int base = 10;
	int n = 5;
	printf ("%d", power (base, n));
	return 0;
}
