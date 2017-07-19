#include <stdio.h>

//Jérémie Veillard - 1P-TIN-IT2
int ConvOctDec(char*);

void main(void)
{
	char *Octal = "123";

	printf("%d", ConvOctDec(Octal));
	system("pause");
}

int ConvOctDec(char* dec)
{
	int e = 0,u=0, f=0, n=0;

	while (*dec != '\0')
	{
		e *= 10;
		e += *dec - '0';
		dec++;
	}

	//conversion de l'octal en décimal

	while (e != 0)
	{
		while (e > (8 ^ n))
		{
			n++;
		}
	}
	u = e / 8;
	f = e % 8;
	printf("%d\n", u);
	printf("%d\n", f);
	printf("%d\n", e);
	system("pause");
}