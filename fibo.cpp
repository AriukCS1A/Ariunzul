#include <stdio.h>
int fibo_dp(int n){
	int fib[n+1];
	
	fib[2]=2;
	fib[1]=1;
	fib[0]=0;
	
	for (int i=2; i<=n; i++){
		fib[i]=fib[i-1] + fib[i-2] + fib[i-3];
	}
	return fib[n];
}
int main(){
	printf ("%d", fibo_dp(35));
	return 0;
}
