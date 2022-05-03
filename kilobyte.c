#include <stdio.h>
int main (){
	float kilobyte, byte;
	printf ("Enter your kilobyte: ");
	scanf ("%f", &kilobyte);
	byte = kilobyte * 1024;
	printf ("Byte is: ");
	printf ("%f\n", byte);
	printf ("\nFinished");
	return 0;
}