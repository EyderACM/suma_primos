#include <stdio.h>
#include <stdlib.h>

int main()
{
    int n;
    int x = 2;
    int sum = 0;
    printf("Ingrese n");
    scanf("%d" ,&n);

        while(n > 1){

        if(n%x == 0){
            n = n/x;
            sum = sum + x;
            }
                else
                x = x + 1;
        }
        sum = sum  + 1;
        printf("%d", sum);
        return 0;
    }

/*
QA: Eyder A. Concha Moreno
Entradas: OK
Salidas: OK

Extra: Las variables no siguen el estándar definido para la codificación (el nombrado de variables debería representar
lo que es cada una)
*/
