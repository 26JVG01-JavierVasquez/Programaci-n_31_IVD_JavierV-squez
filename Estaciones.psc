Algoritmo Estación_del_año
	Definir dia, mes Como Entero
    
    Escribir "Ingrese dia y mes:"
    Leer dia, mes
    
    Si (mes=12 Y dia>=21) O (mes=1) O (mes=2) O (mes=3 Y dia<=20) Entonces
        Escribir "Invierno"
	Sino
		Si (mes=3 Y dia>=21) O (mes=4) O (mes=5) O (mes=6 Y dia<=20) Entonces
		Escribir "Primavera"
	Sino
		
		Si (mes=6 Y dia>=21) O (mes=7) O (mes=8) O (mes=9 Y dia<=22) Entonces
        Escribir "Verano"
    Sino
        Escribir "Otoño"
    FinSi
	FinSi
	FinSi
FinAlgoritmo
