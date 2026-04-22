Proceso caracter
    Definir c Como Caracter
    Escribir "Ingrese un carácter:"
    Leer c
	
    Si c >= "0" Y c <= "9" Entonces
        Escribir "Es dígito"
    Sino
        Segun c Hacer
            "a","e","i","o","u":
                Escribir "Es vocal"
            De Otro Modo:
                Escribir "Otro carácter"
        FinSegun
    FinSi
FinProceso