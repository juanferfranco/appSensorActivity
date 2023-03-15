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

Primero tendrás que instalar la aplicacióin en tu celular. La siguiente imagen te muestra como construir y descargar la aplicación:

![image](https://user-images.githubusercontent.com/2473101/225316717-1a651530-5dee-4471-b7ff-531f054df171.png)

Selecciona Android App (apk). Ten presente que deberás configurar los permisos necesarios en tu celular Android que te permitan instalar aplicaciones de fuentes desconocidas. Si no haces esto no podrás instalar la aplicación.

Para probar la aplicación no te recomendaré que construyas otra aplicación en Unity. ¿Qué pasa si tu aplicación no funciona? ¿Es problema de la aplicación móvil o de la aplicación que construiste en Unity para probar? ¿Ves el punto? Entonces para probar la aplicación móvil necesitarás algo como ScriptCommunicator para probar. 

Para realizar las pruebas debes:

1. Crear una red inalámbrica privada. No lo hagas con la red pública de la U. Para crear la red puedes usar el celular o un computador con tarjeta de red inalámbrica.    con ambos dispositivos puedes crear un punto de acceso.
2. Una vez creado el punto de acceso debes conectar a este el celular y el computador.
3. En tu computador abre una terminal o símbolo del sistema y lanza el comando ipconfig. Toma nota de la Dirección IPv4 de tu adapatador inalámbrico conectado al punto    de acceso. Vas a necesitar esta dirección en la aplicación móvil.

![image](https://user-images.githubusercontent.com/2473101/225361555-beda1dda-6648-44a7-a5d1-1c85cf266eac.png)

![image](https://user-images.githubusercontent.com/2473101/225361477-60d8654d-7293-4ca0-8077-ec2700939815.png)

4. Abre ScriptCommunicator y crea un socket UDP. El puerto puede ser 6666.

![image](https://user-images.githubusercontent.com/2473101/225361314-2f125e3a-29e5-487f-b11a-85c3deaa746e.png)

Selecciona current interface como socket y dale click en connect:

![image](https://user-images.githubusercontent.com/2473101/225362034-5e08c6dc-5027-4f43-936d-3c7b6eca01c5.png)

Deberás ver en la parte inferior izquierda de la interfaz principal de ScriptCommunicator:

![image](https://user-images.githubusercontent.com/2473101/225362235-e1776ac2-6f78-4dbb-b6ff-ed7423f39d3c.png)

Tu computador estará esperando datos. Ten presente que si luego quieres otra aplicación escuchando en el mismo puerto, primero tendrás que desconectar ScriptCommunicator y al contrario. ¿Vale?

5. Abre la aplicación móvil y configura la dirección IP del computador y el puerto en el cual ScriptCommunicator estará escuchando los mensajes enviados por UDP. 
   Escribe un Message y dale click en Send to Unity. Deberías ver tu mensaje en ScriptCommunicator. ¿Y si no funciona? Verifica que el firewall esté desactivado. PERO    no olvides activarlo de nuevo una vez termines de trabajar.

## ¿Cómo construir la aplicación en Unity?

Ahora que ya sabes que tu aplicación móvil funciona, vas a construir la aplicación en Unity. Crea un proyecto y adiciona a la escena un GameObject vacío. A ese GameObject le puedes colocar el siguiente Script:

```csharp

using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class comm : MonoBehaviour
{

    private static comm instance;
    private Thread receiveThread;
    private UdpClient receiveClient;
    private IPEndPoint receiveEndPoint;
    private string ip = "127.0.0.1";
    private int receivePort = 6666;
    private bool isInitialized;
    private Queue receiveQueue;
    private GameObject sphere;
    private Material m_Material;

    private void Awake()
    {
        Initialize();
    }

    private void Start()
    {
       
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);        
        m_Material = sphere.GetComponent<Renderer>().material;
    }

    private void Initialize()
    {
        instance = this;
        receiveEndPoint = new IPEndPoint(IPAddress.Parse(ip), receivePort);
        receiveClient = new UdpClient(receivePort);
        receiveQueue = Queue.Synchronized(new Queue());
        receiveThread = new Thread(new ThreadStart(ReceiveDataListener));
        receiveThread.IsBackground = true;
        receiveThread.Start();
        isInitialized = true;
    }

    private void ReceiveDataListener()
    {
        while (true)
        {
            try
            {
                byte[] data = receiveClient.Receive(ref receiveEndPoint);
                string text = Encoding.UTF8.GetString(data);
                SerializeMessage(text);
            }
            catch (System.Exception ex)
            {
                Debug.Log(ex.ToString());
            }
        }
    }

    private void SerializeMessage(string message)
    {
        try
        {
         receiveQueue.Enqueue(message);
        }
        catch (System.Exception e)
        {
            Debug.Log(e.ToString());
        }
    }

    private void OnDestroy()
    {
        TryKillThread();
    }

    private void OnApplicationQuit()
    {
        TryKillThread();
    }

    private void TryKillThread()
    {
        if (isInitialized)
        {
            receiveThread.Abort();
            receiveThread = null;
            receiveClient.Close();
            receiveClient = null;
            Debug.Log("Thread killed");
            isInitialized = false;
        }
    }

    void Update()
    {
        if (receiveQueue.Count != 0)
        {
            string message = (string)receiveQueue.Dequeue();
            if(message == "off") m_Material.color = Color.black;
            if(message == "on") m_Material.color = Color.red;
            else m_Material.color = Color.yellow;
        }
    }
}

```

## ¿Cómo probar la aplicación?

Ahora para probar la aplicación en Unity usarás ScriptCommunicator, pero esta vez lo usarás para enviar información a Unity.


## ¿Cómo integrar las aplicaciones y probar que todo esté bien?
