#include <stdio.h>

int stack [10];
int top_index;

void push (int val){
	if (top_index<10){
		stack[top_index] = val;
		printf("%d is pushed in a stack\n", val);
	} else printf("Stack is full");
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
	push(5);
	push(6);
	
	printf ("%d", pop());
	printf ("%d", pop());
	
	return 0;
}
