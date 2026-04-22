Algoritmo Tipo_de_triángulo
	Definir a,b,c Como Entero
    
    Leer a,b,c
    
    Si a=60 Y b=60 Y c=60 Entonces
        Escribir "Equilatero"
	Sino
		Si a=b O a=c O b=c Entonces
        Escribir "Isosceles"
    Sino
        Escribir "Escaleno"
    FinSi
	FinSi
FinAlgoritmo
