//pide 2 num 1 opccion
//
Algoritmo Ejercicio2
	Definir num1,num2,opc,Resultado Como Real
	Escribir Sin Saltar "Digite 2 valores numericos"
	leer num1
	leer num2
	
	//Menu de operaciones
	Escribir "____________________________________________"
	Escribir "MENÜ PRENCIPAL"
	Escribir "____________________________________________"
	Escribir "msj 1 - suma"
	Escribir "msj 2 - resta"
	Escribir "msj 3 - multiplicación"
	Escribir "msj 4 - Divición"
	Escribir "msj 5 - salir"
	Escribir sin saltar "Digite el numero segun su operación"
	leer opc
	Segun opc Hacer
		1:
			msj="El resultado de la suma es: "
			Resultado=num1+num2
		2:
			msj="El resultado de la resta es: "
			Resultado=num1-num2
		3:
			msj="El resultado de la multiplicación es: "
			Resultado=num1*num2
		4:
			msj="El resultado de la divición es: "
			Resultado=num1/num2
		De Otro Modo:
		msj= "diguite un numero correcto"
			
	Fin Segun
	escribir msj
	escribir Resultado
	FinAlgoritmo
