#include <stdio.h>
int total_weight=0;
int total_value=0;
int current_solution = 0;
void knapsack(int W, int wt[], int val[], int k, int n, int hiisen_val){
	if (total_weight>50) return;
	if(k==n){
		printf ("%d %d", total_weight, total_value);
		printf ("\n");
		if (total_value>current_solution) current_solution=total_value;
		return;
	}
	int upper_bound_left, upper_bound_right;
	if (k+1==n){
		upper_bound_left=hiisen_val;
		upper_bound_right=val[k]+hiisen_val;
		
	}else{	
		upper_bound_right=hiisen_val+val[k]+(W-wt[k])*(val[k+1]/wt[k+1]);
		upper_bound_left=hiisen_val+W*(val[k+1]/wt[k+1]);
	}
	if (current_solution<upper_bound_left) knapsack (W, wt, val, k+1, n, hiisen_val);
	total_weight+=wt[k];
	total_value+=val[k];
	if(current_solution<upper_bound_right) knapsack(W-wt[k], wt, val, k+1, n, hiisen_val+val[k]);
	total_weight-=wt[k];
	total_value-=val[k];
}
int main(){
	int wt[]={10,20,30};
	int val[]={60,100,120};
	int W=50;
	knapsack(W,wt,val,0,3,0);
	
	printf ("Final: %d", current_solution);
}
