using System.Collections;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using UnityEngine;
using System.Text;

public class UDPSensorApp : MonoBehaviour
{

    private GameObject sphere;
    private Material m_Material;


    private Thread receiveThread;
    private bool isInitialized;
    private Queue receiveQueue;


    private UdpClient receiveClient;
    private int receivePort = 6666;
    

    void Start()
    {
        sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3 (5f, 5f, 5f);
        m_Material = sphere.GetComponent<Renderer>().material;



        receiveClient = new UdpClient(receivePort);
        receiveQueue = Queue.Synchronized(new Queue());
        receiveThread = new Thread(new ThreadStart(ReceiveDataListener));
        receiveThread.IsBackground = true;
        receiveThread.Start();
        isInitialized = true;

    }

    private void ReceiveDataListener()
    {
        IPEndPoint receiveEndPoint = new IPEndPoint(0, 0);

        while (true)
        {
            try
            {
                byte[] data = receiveClient.Receive(ref receiveEndPoint);
                string text = Encoding.UTF8.GetString(data);
                

                Debug.Log("Data received from " + receiveEndPoint + ": " + text);
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
            if (message == "off") m_Material.color = Color.black;
            else if (message == "on") m_Material.color = Color.red;
            else m_Material.color = Color.yellow;
        }
    }
}
