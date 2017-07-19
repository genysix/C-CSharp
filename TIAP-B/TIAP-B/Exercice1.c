#include <stdio.h>

//Jérémie Veillard - 1P-TIN-IT2


void main(void)
{
	char  *chaine = "ab12rz7c", c;


	printf("%s\n", chaine);

	while (*chaine != '\0')
	{
		switch (*chaine)
		{
		case '0':
			printf("+");
			break;
		case '1':
			printf("+");
			break;
		case '2':
			printf("+");
			break;
		case '3':
			printf("+");
			break;
		case '4':
			printf("+");
			break;
		case '5':
			printf("+");
			break;
		case '6':
			printf("+");
			break;
		case '7':
			printf("+");
			break;
		case '8':
			printf("+");
			break;
		case '9':
			printf("+");
			break;
		default:
			printf("%c", *chaine);
			break;
		}

		chaine++;
	}
	printf("\n");
	system("pause");
	exercice2();
	exercice3();
}