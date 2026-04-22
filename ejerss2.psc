Algoritmo ejercicio2
	Definir num1, num2, opc, result Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar"Digite dos valores; "
	Leer num1
	Leer num2
	
	Escribir "**************"
	Escribir "MENU PRINCIPAL"
	Escribir "1-Suma"
	Escribir "2-Resta"
	Escribir "3-Multiplicacion"
	Escribir "4-Divicion"
	Escribir "5-Salir"
	Escribir Sin Saltar "Digite el numero segun su operacion: "
	Leer opc
	
	Segun opc Hacer
		1:
			msj="El resultado de la suma es: "
			result=num1+num2
		2:
			msj="El resultado de la Resta es: "
			result=num1-num2
		3:
			msj="El resultado de la Multi es: "
			result=num1*num2
		4:
			msj="El resultado de la Divi es: "
			result=num1/num2
		5:
			msj="Saliendo del sistema"
		De Otro Modo:
			msj="Seleccione una opcion valida"
	Fin Segun
	
	Escribir msj
	Escribir result
FinAlgoritmo
