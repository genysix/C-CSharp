#include <stdio.h>

//Jérémie Veillard - 23.09.2016

//#define MAX 16;

struct Form {
	long Hexadec;
};

void main(void)
{
	FILE * pf;
	char Nom;

	struct Form Test;

	int i = 0, j = 0, q=0;
	int c = 0;
	

	//printf("entrez un nom de fichier : ");
	//scanf("%s", Nom);


	pf = fopen("C:\\test.tin", "rb");

	if (pf != NULL) {

		printf("Offset   |  0  1  2  3  4  5  6  7    8  9  A  B  C  D  E  F   |   Affichage des caracteres \n");


		while (!feof(pf)) {
			if (!feof(pf)) {
				
				
				printf("%07x0 | ", i);

				
				while (j < 16 && !feof(pf)) {
					
					c = fgetc(pf);

					if (j == 8)
					{
						printf("  ");
					}
					printf("%02X ", c);
					j++;
				} 
				
				if (feof(pf)) {
					for(q=0;q < (16 - j);q++)
					{
						
						printf("  ");
					}
				}

				printf("  |  ");
				
				if (!feof(pf)) {
					fseek(pf, -15, SEEK_CUR);
				}
				else {
					fseek(pf, -j+2, SEEK_CUR);
				}
				j = 0;
				while (j < 16 && !feof(pf)) {
					
					c = fgetc(pf);
					if (j == 8)
					{
						printf("  ");
					}
					if (c>32)
					{
						printf("%c ", c);
					}
					else {
						printf(". ");
					}

					j++;
				}
								
				j = 0;
				printf("\n");
				i++;
				if (!feof(pf)) {
					fseek(pf, -1, SEEK_CUR);
				}
			}
			
		}
		system("pause");
	}
	fclose(pf);
}