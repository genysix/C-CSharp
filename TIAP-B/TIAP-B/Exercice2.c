#include <stdio.h>

//Jérémie Veillard - 1P-TIN-IT2
char plusgrand(char*);

void exercice2(void)
{
	char * info = "ABCBAE", c=NULL;

	c = plusgrand(info);

	printf("%c\n", c);
	system("pause");

}

char plusgrand(char *p)
{
	char e = NULL;
	while (*p != '\0')
	{
		if (*p > e)
		{
			e = *p;
		}
		*p++;
	}
	return e;
}