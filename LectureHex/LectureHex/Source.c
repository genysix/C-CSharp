#include <stdio.h>

//Jérémie Veillard - 23.09.2016

struct Article {

	int quantite;
	char descri[12];
	double prix;
};

void main(void)
{
	FILE * pf; //déclare un pointeur de fichier
	struct Article UnArticle;
	struct Article desArticles[4] =
	{
		{ 2,"table", 200.0 },
		{ 5,"Chaise",100.0 },
		{ 42344,"canape",1500.0 },
		{ 42342,"Ordinateur",20000.0 }
	};

	char c;
	int i = 0;
	//---------ecrire dans un fichier
	pf = fopen("C:\\test.tin", "wb");

	fwrite(&desArticles, sizeof(struct Article), 4, pf);
	fclose(pf);
	//---------fin ecriture

	//---------lecture d'un fichier avec 
	pf = fopen("C:\\test.tin", "rb");

	if (pf != NULL)
	{
		fseek(pf,sizeof(struct Article)*2,SEEK_SET);

		fread(&UnArticle, sizeof(struct Article), 1, pf);
		
		printf("Description :%s  quantite: %d  prix : %lf\n", UnArticle.descri, UnArticle.quantite, UnArticle.prix);
		
		fseek(pf, 0, SEEK_END);

		printf("nombre d'articles: %d\n", ftell(pf) / sizeof(struct Article));

		system("pause");
		
	}
	fclose(pf);
}