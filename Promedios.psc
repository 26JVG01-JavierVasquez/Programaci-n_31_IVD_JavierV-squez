Algoritmo Promedio
    Definir n1,n2,n3,n4,n5,prom Como Real
    
    Escribir "Ingrese 5 notas:"
    Leer n1,n2,n3,n4,n5
    
    prom <- (n1+n2+n3+n4+n5)/5
    
    Si prom >= 61 Entonces
        Escribir "Aprueba con promedio: ", prom
    Sino
        Escribir "Reprueba con promedio: ", prom
    FinSi
FinAlgoritmo