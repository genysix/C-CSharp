// Calcul2emeDegre.cpp : définit le point d'entrée pour l'application console.
//

#include <stdio.h>
#include <math.h>


void main(void)
{
	double a, b, c, x, y1, y2;

	printf("Entrez la donnée pour a : \n");
	scanf("%d", &a);
	printf("Entrez la donnée pour a : \n");
	scanf("%d", &b);
	printf("Entrez la donnée pour a : \n");
	scanf("%d", &c);

	x = b*b - 4 * a*c;

	if (x < 0)
	{
		//aucune solution, car x est plus petit que zéro
		printf("Aucune valeur n'est retourné, car le déterminant est négatif");
	}
	else {
		if (x == 0) {
			// 1 solution, car x est égal à zéro
			y1 = (-b) / (2 * a);
			printf("le déterminant vaut zéro. Il n'y a qu'une seule réponse  x=%d", y1);
		}
		else {
			// 2 solutions, car x est plus grand que zéro
			y1 = ((-b) - sqrtf(x)) / (2 * a);
			y2 = ((-b) + sqrtf(x)) / (2 * a);
			printf("le déterminant est plus grand que zéro. Il n'y a donc 2 réponses  x1=%d  et x2=%d", y1, y2);
		}
	}
}

