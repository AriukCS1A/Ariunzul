#include <stdio.h>
void printStar(int n) {
	if(n==1) printf("*\n");
	else {
		printStar(n-1);
	for(int i=0;i<n;i++) printf("*");
		printf("\n");
}
}
int main(){
	printStar(3);
	return 0;
}
