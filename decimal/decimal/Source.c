#include <stdio.h>

int Decimal(char *);

void main(void)
{
	int i;
	char Tab[] = "12345678938";

	i = Decimal(Tab);
	printf("%d", i);

	system("pause");
}

int Decimal(char* p)
{
	int e =0;
	//return *p-'0';
	while (*p != '\0')
	{
		e *= 10;
		e += *p - '0';
		p++;
	}
	return e;
}