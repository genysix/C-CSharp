// Calcul2emeDegre.cpp�: d�finit le point d'entr�e pour l'application console.
//

#include <stdio.h>
#include <math.h>


void main(void)
{
	double a, b, c, x, y1, y2;

	printf("Entrez la donn�e pour a : \n");
	scanf("%d", &a);
	printf("Entrez la donn�e pour a : \n");
	scanf("%d", &b);
	printf("Entrez la donn�e pour a : \n");
	scanf("%d", &c);

	x = b*b - 4 * a*c;

	if (x < 0)
	{
		//aucune solution, car x est plus petit que z�ro
		printf("Aucune valeur n'est retourn�, car le d�terminant est n�gatif");
	}
	else {
		if (x == 0) {
			// 1 solution, car x est �gal � z�ro
			y1 = (-b) / (2 * a);
			printf("le d�terminant vaut z�ro. Il n'y a qu'une seule r�ponse  x=%d", y1);
		}
		else {
			// 2 solutions, car x est plus grand que z�ro
			y1 = ((-b) - sqrtf(x)) / (2 * a);
			y2 = ((-b) + sqrtf(x)) / (2 * a);
			printf("le d�terminant est plus grand que z�ro. Il n'y a donc 2 r�ponses  x1=%d  et x2=%d", y1, y2);
		}
	}
}

