#include <stdio.h>

void Inverse(char *);

void main(void)
{
	int i;
	char Tab[] = "salut";

	Inverse(Tab);
	printf("%s", Tab);

	system("pause");
}

void Inverse(char* p)
{
	char *p2 = p, a;
	while (*p != '\0')
	{
		p++;
	}
	p--;


	

	while (p2<p)
	{
		a = *p2;
		*p2= *p;
		*p = a;
		p--;
		p2++;
	} 
}