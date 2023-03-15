# Conectar un teléfono Android a Unity usando UDP

La idea de esta actividad es que construyas dos aplicaciones, una aplicación móvil para un teléfono Android y otra para Unity. La idea es enviar desde el celular información de manera inalámbrica usando [JSON](https://en.wikipedia.org/wiki/JSON) y el protocolo [UDP](https://en.wikipedia.org/wiki/User_Datagram_Protocol). 

La actividad estará dividida en fases que responderán a las siguiente preguntas:

1. ¿Cómo construir la aplicación móvil?
2. ¿Cómo probar la aplicación?
3. ¿Cómo construir la aplicación en Unity?
4. ¿Cómo probar la aplicación?
5. ¿Cómo integrar las aplicaciones y probar que todo esté bien?

## ¿Cómo construir la aplicación móvil?

Para construir la aplicación móvil vás a utilizar una herramienta llamada [appinventor](https://appinventor.mit.edu/). Esta herramienta es simple y permite realizar prototipos rápidos usando un lenguaje de programación gráfico basado en eventos.

1. Ingresa a la interfaz de construcción de aplicaciones [aquí](http://ai2.appinventor.mit.edu/). Debes ingresar con una cuenta de google.
2. Una vez ingreses vas a crear un proyecto. Yo voy a llamarlo UDPSensorJson

![image](https://user-images.githubusercontent.com/2473101/225294152-8cde6c15-74cd-4bc8-8d60-bbd4e9646663.png)

Verás que aparece una vista que te permitirá diseñar la interfaz gráfica de tu aplicación:

![image](https://user-images.githubusercontent.com/2473101/225294571-ef982bca-d191-401f-a243-a8ad1d516f8e.png)

En esta parte podrás seleccionar entre la vista de diseño y la vista de programación (Blocks):

![image](https://user-images.githubusercontent.com/2473101/225294720-8b985e60-ed59-4eba-9fe1-16d81bdfea60.png)

Ahora observa lo que te ofrece la vista de diseño para que te familiarices con la herramienta.

En la zona Palette verás todos los componentes disponibles y además si notas también podrás agregar extensiones o componentes hechos por otras personas:

![image](https://user-images.githubusercontent.com/2473101/225295260-3dcbd255-faed-4bd6-9d33-06e7edfd2358.png)

Ahora observa al otro lado. Verás los componentes que tiene en este momento la aplicación y si seleccionas cada componente podrás ver y configurar sus propiedades:

![image](https://user-images.githubusercontent.com/2473101/225295633-1bba1019-1269-458e-a2dd-09baf9e5dcb9.png)

Prueba personalizando la propiedad AboutScreen del componente Screen1

![image](https://user-images.githubusercontent.com/2473101/225295883-baff7914-64d9-48b5-822c-19497356ff5d.png)

Ahora te pediré que hagas la interfaz de usuario que verás en las siguiente imágenes:

![image](https://user-images.githubusercontent.com/2473101/225300241-14b0b7a9-67a8-4ec5-ae9b-2074342a5483.png)

![image](https://user-images.githubusercontent.com/2473101/225300548-c5f7612b-7de8-41dc-931f-ad178d1fec4d.png)

Solo nos falta agregar un componente que viene como una extensión. Este componente es que el que permite enviar información por UDP. La extesión la puedes descargar en [este](http://ullisroboterseite.de/android-AI2-UDP-en.html) sitio. Verás el enlace de descarga en la sección Downloads.

Una vez descargues la extensión, que será un archivo con extensión .zip, lo debes descomprimir e importar a appinventor:

![image](https://user-images.githubusercontent.com/2473101/225302598-d7b56caf-c6b4-487d-8821-09f46b2e29e2.png)

Para completar la interfaz de usuario solo debe agregar el componente UDPXmitter:

![image](https://user-images.githubusercontent.com/2473101/225302743-7b7d179d-3479-4d98-8ca0-5524da4e5551.png)

Ahora vas a seleccionar la vista de programación (Blocks) para añadir el comportamiento que tendrá la aplicación. El programa debe quedarte así:

![image](https://user-images.githubusercontent.com/2473101/225316163-dedc2071-456b-45c8-8be9-62fc5585dcc8.png)


## ¿Cómo probar la aplicación?

Para probar la aplicación necesitarás instalarla en el celular y usar un software de prueba como ScriptCommunicator. La siguiente imagen te muestra como construir y descargar la aplicación:

![image](https://user-images.githubusercontent.com/2473101/225316717-1a651530-5dee-4471-b7ff-531f054df171.png)

Selecciona Android App (apk). Ten presente que deberás configurar los permisos necesarios en tu celular Android que te permitan instalar aplicaciones de fuentes desconocidas. Si no haces esto no podrás instalar la aplicación.

![image](https://user-images.githubusercontent.com/2473101/225317010-f33a70b2-058e-4586-b339-1c13320e9cac.png)



## ¿Cómo construir la aplicación en Unity?

## ¿Cómo probar la aplicación?

## ¿Cómo integrar las aplicaciones y probar que todo esté bien?
