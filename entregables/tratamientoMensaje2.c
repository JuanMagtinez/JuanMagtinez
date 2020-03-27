#include <stdio.h>
#include <string.h>
#include <stdlib.h>
int main(int argc, char *argv[]) {
	
	char peticion[100];
	char resultados[100];
	
	strcpy(peticion, "Miguel/47/Juan/12/anna/22/Marcos/19");
	char nombre[20];
	int edad;
	char *p= strtok(peticion, "/");
	int i,j;
	
	while (p!=NULL)
	{
		
		strcpy (nombre,p);
		p= strtok(NULL, "/");
		edad= atoi (p);
		j=strlen(nombre)-1;
		i=0;
		int encontrado=1;
		while (i<j && encontrado==1)
		{
			while (nombre[i]==nombre[j])
			{
				if (i==j && edad>18)
				{
					encontrado==0;
				}
				else
					encontrado==1;
			
			}
			i++;
			j=j-1;
		}
		if (encontrado==0)
			sprintf(resultados, "%s%s*%d-",resultados,nombre,edad);
		p= strtok(NULL, "/");
		
		
	}
	
	resultados[strlen(resultados)-1]='\0';
	printf ("Resultado: %s",resultados);
	
	
}

