#include<stdio.h>
#define SIZE 5

void enQueue (int);
int deQueue();
int peek ();
void display();
int isFull();
int isEmpty ();

int queue [SIZE], front = -1, rear = -1;

int isEmpty(){
	if (front == -1 && rear == -1){
		return 1;
	}
	else {
		return 0;
	}
}

int isFull (){
	if (rear == SIZE - 1){
		return 1;
	}
	else {
		return 0;
	}
}
void enQueue (int value){
	if (isFull()){
		printf ("\nQueue is full");
	}
	else {
		if (front==-1) front = 0;
		rear++;
		queue [rear] = value;
		printf ("\nEnqueued -> %d", value);
	}
}
int deQueue (){
	if (isEmpty()){
		printf ("\nQueue is empty");
		return -1;
	}
	else {
		int value = queue [front];
		front++;
		if (front == SIZE){
			front = -1;
			rear = -1;
		}
		return value;
	}
}
int peek (){
	if (isEmpty()){
		printf ("\nQueue is empty");
		return -1;
	}
	else{
		int value = queue [front];
		printf ("\nPeeked -> %d", value);
		return value;
	}
}
int main(){
	enQueue (1);
	enQueue (2);
	enQueue (3);
	enQueue (4);
	enQueue (5);
}
