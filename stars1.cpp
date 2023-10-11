#include <stdio.h>
void printStar(int n) {
	if(n==1) printf("*\n");
	else {
	for(int i=0;i<n;i++) printf("*");
		printf("\n");
		printStar(n-1);
}
}
int main(){
	printStar(3);
	return 0;
}
