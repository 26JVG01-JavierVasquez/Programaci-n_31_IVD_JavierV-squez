Proceso trigonometria
    Definir angulo, rad Como Real
    Definir opcion Como Entero
	
    Escribir "Ingrese ángulo en grados:"
    Leer angulo
	
    rad <- angulo * 3.1416 / 180
	
    Escribir "1. Seno"
    Escribir "2. Coseno"
    Escribir "3. Tangente"
    Leer opcion
	
    Segun opcion Hacer
        1: Escribir "Seno: ", sen(rad)
        2: Escribir "Coseno: ", cos(rad)
        3: Escribir "Tangente: ", tan(rad)
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
FinProceso