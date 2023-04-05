#include <stdio.h>
int factorial (int n){
	if (n == 1) return 1;
	else {
		int result = factorial (n-1) * n;
		return result;
	}
}
int main (){
	int a = 5;
	printf ("factorial:%d", factorial(a));
	
	return 0;
}
