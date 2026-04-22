Proceso conversion
    Definir valor Como Real
    Definir opcion Como Entero
	
    Escribir "Ingrese valor en metros:"
    Leer valor
	
    Escribir "1. A pies"
    Escribir "2. A centímetros"
    Escribir "3. A pulgadas"
    Leer opcion
	
    Segun opcion Hacer
        1: Escribir "Resultado: ", valor * 3.28
        2: Escribir "Resultado: ", valor * 100
        3: Escribir "Resultado: ", valor * 39.37
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinProceso