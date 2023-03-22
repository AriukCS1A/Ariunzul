#include<stdio.h>
int stack [10];
int top_index;
int top(){
	if (top_index == -1){
		return -1;
	}
	else {
		return stack[top_index];
	}
}
void push (int val){
	if (top_index<10){
		top_index++;
		stack[top_index] = val;
		printf("%d is pushed in a stack\n", val);
	} 
	else {
		printf("Stack is full");
	}
}
int pop (){
	int top_value = stack [top_index];
	top_index--;
	return top_value;
	
	if (top_index == -1){
		printf ("Stack is empty");
		return -1;
	}
	else{
		int top_value = stack [top_index];
		printf("%d is popped from the stack", top_value);
		return top_value;
	}
}
int main (){
	top_index = -1;
	int i;
	push (5);
	push (4);
	printf("%d\n", pop());
	printf("%d\n", pop());
	printf("%d\n", pop());
	push (7);
	push(8);
	push (9);
	push (10);
	printf ("%d\n", top());

	for(i=0;i<top_index;i++){
		printf("%d ",stack[i]);
	}
	return 0;
}

