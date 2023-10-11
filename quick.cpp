#include<stdio.h>
void partition (int a[], int f, int l){
	int pivot = arr[l];
	
}
void quicksort(int a[], int f, int l){
	if (f>=l) return;
	
	int pivot_index=partition(a,f,l);
	
	quicksort(a,f,pivot_index-1);
	quicksort (a,pivote_index+1,l);
}
int main (){
	int a[]={38,27,43,3,9,82,10};
	int n=7;
	
	quicksort(a,0, n-1);
	for (int i=0; i<n; i++){
		printf ("%d ", a[i]);
	}
	return 0;
}
