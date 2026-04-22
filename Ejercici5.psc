Proceso empresa
    Definir cantidad, opcion Como Entero
    Definir precio, iva, total, descuento, totalFinal Como Real
	
    precio <- 650
    iva <- 1.12
	
    Escribir "Cantidad de impresoras:"
    Leer cantidad
	
    Escribir "1. Efectivo"
    Escribir "2. Tarjeta"
    Escribir "3. Vale"
    Leer opcion
	
    total <- cantidad * precio * iva
	
    Segun opcion Hacer
        1: descuento <- 0.10
        2: descuento <- 0.05
        3: descuento <- 0.15
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun
	
    totalFinal <- total - (total * descuento)
	
    Escribir "Total sin descuento: ", total
    Escribir "Descuento: ", descuento * 100, "%"
    Escribir "Total a pagar: ", totalFinal
FinProceso