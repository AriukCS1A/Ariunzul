#include <stdio.h>
int sum (int n){
	if (n==1) return 1;
	else {
		int result = sum (n-1)+n;
		return result;
	}
}
int main (){
	int a = 5;
	printf ("sum:%d", sum(a));
	
	return 0;
}
