# SistemaEncomiendas - PROTOTIPO. 
Se detallan a continuación las opciones válidas para reproducir el "camino feliz".


### INICIO DE SESIÓN

**- Numero de Cuit:** 20306578636768

**- Usuario:** NicolasMartinez

**- Contraseña:** usuario1

(Los datos corresponden al unico usuario habilitado para operar en el sistema)


### MENU PRINCIPAL

**- 1. Solicitar servicio	

	*-TIPO ENVIO
	1- Correspondencia
	2- Encomienda (aún no desarrollado. Siempre que sea encomienda se le pedirá 
	al usuario el peso de la misma para poder, de acuerdo al resto de las
	opciones, calcular la tarifa del servicio).
	
	*-PRIORIDAD ENVIO
	1- Normal
	2- Urgente (aún no desarrollado. Afectará al incremento de la tarifa por ser 
	un servicio adicional) 

	DATOS ORIGEN:
	
	*-ORIGEN ENVIO
	1- Sucursal (se da por supuesto que existe una sucursal por localidad con su
	identificador, direccion y altura almacenados en archivo de texto)
	2- Domicilio (aún no desarrollado. Siempre que el usuario seleccione domicilio
	tanto para origen como para destino, el sistema pedirá el ingreso de la 
	dirección y altura)

	*-SELECCION PROVINCIA (listado de provincias argentinas)
	1- Buenos Aires
	...

	*-LOCALIDAD (abrá 10 localidad asignadas a cada una de las provincias)
	1- Martinez
	...
	
	DATOS DESTINO:
	
	*-TIPO ENVIO
	1- Nacional
	2- Internacional (aún no desarrollado. Siempre que el usuario seleccione destino
	internacional el sistema le solicita ingresar pais, validando el ingreso contra
	archivo de texto con paises y determinando la región a la cual aplica para
	poder calcular la tarifa del servicio. El sistema siempre adiciona un costo fijo
	equivalente a un envio a CABA por regla de negocio.
	Paso siguiente, el usuario ingresa los datos de localidad y domicilio)

	*-DESTINO ENVIO
	1- Sucursal (se da por supuesto que existe una sucursal por localidad con su
	identificador, direccion y altura almacenados en archivo de texto)
	2- Domicilio (aún no desarrollado. Siempre que el usuario seleccione domicilio
	tanto para origen como para destino, el sistema pedirá el ingreso de la 
	dirección y altura)

	*-SELECCION PROVINCIA (listado de provincias argentinas)
	1- Buenos Aires
	...

	*-SELECCION LOCALIDAD
	1- Bahia Blanca


	DATOS DESTINATARIO:

	*-NOMBRE DESTINATARIO: campo libre alfabetico
	*-APELLIDO DESTINATARIO: campo libre alfabetico
	*-DNI: admite 8 dígitos 


		

	
	*- DATOS DE ORIGEN	
	"Ingrese peso del paquete (KG)": validado >= 0 & <=30 (decimal separado con ",")
	"Seleccione la prioridad del envío": 1-Normal
	"Seleccione el tipo de envío": 1-Nacional
	"Seleccione si el origen del envío es una sucursal o domicilio particular": 1-Domicilio 
	"Seleccione region de origen": 2-Metropolitana
	"Seleccione provincia de origen": 1-Buenos Aires
	"Seleccione sucursal de origen": 1-Martinez
	"Ingrese domicilio de origen": NO debe ser vacío

	*- DATOS DE DESTINO
	"Seleccione el tipo de envío": 1-Nacional
	"Seleccione si el destino del envío es una sucursal o domicilio particular": 1-Domicilio
	"Seleccione region de destino": 2-Metropolitana
	"Seleccione provincia de destino": 2-Cordoba
	"Seleccione localidad destino": 1-Cosquin

	*- DATOS DEL DESTINATARIO
	"Ingrese domicilio del destino": falta subdividir al docmicilio en "Dirección" (alfabetico) y "Altura" (numerico).
	"Ingrese nombre del destinatario": se valida campo alfabetico ok.
	"Ingrese apellido del destinatario": se valida campo alfabetico ok.
	"Ingrese DNI": se valida que sea numerico y de 8 digitos ok.

**- 2. Consultar estado de servicio
	
	"Ingrese el número de orden de servicio que desea consultar": 30541
	"¿Desea consultar otra orden de servicio?": esta opción no fue desarrollada ya que carece de sentido la funcionalidad tratandose unicamente de una orden de servicio en este prototipo.
	
**- 3. Consultar estado de cuenta

	Se visualiza resumen de cuenta con los siguientes datos:
	*- "Resumen a la fecha" (fecha actual de la consulta)
	*- "Monto total" (definido por 1 solicitud a realizar o ya realizada)
	*- "Estado" (A PAGAR solo definida para el prototipo)

**- 4. Cerrar sesion
	
	Se notifica el cierre de sesión y se pide presionar una tecla para continuar. El sistema vuelve al inicio de sesión.
	

**- 5. Salir del programa

	Se notifica la salida al usuario y se pide presionar una tecla para cerrar la consola.

	
-----------------------------------------------------

