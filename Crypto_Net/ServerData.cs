using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Crypto_Net
{
    class ServerData
    {
        int ID = 3;
        long KEY = 17;
        long keyS = 5;
        int port2 = 8006; // порт для приема входящих запросов
        int port3 = 8007; // порт сервера
        string address = "127.0.0.1"; // адрес сервера
        long secret = 54;
        bool GoJhony;
        //bool state;
        long Pas;
        Thread myThread1, myThread2;

        public void ServerDo()
        {
            GoJhony = true;
            // создаем новый поток
            myThread1 = new Thread(new ThreadStart(ServerDo1));
            myThread2 = new Thread(new ThreadStart(ServerDo2));

            myThread1.Start(); // запускаем поток
            myThread2.Start(); // запускаем поток
        }
        public void ServerStop()
        {
            GoJhony = false;
            myThread1.Abort();
            myThread2.Abort();
        }
        //public void ServerDo0()
        //{
        //    while (GoJhony)//постоянно попеременно слушаем
        //    {
        //        //state = false;
        //        ServerDo1();
        //        ServerDo2();
        //    }
        //}
        private void ServerDo1()
        {
            // получаем адреса для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port2);

            // создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // связываем сокет с локальной точкой, по которой будем принимать данные
            listenSocket.Bind(ipPoint);

            // начинаем прослушивание
            listenSocket.Listen(10);//максимальное кол-во подключений

            //Console.WriteLine("Сервер запущен. Ожидание подключений...");
            //bool firstuse = false;
            while (GoJhony)
            {
                Socket handler = listenSocket.Accept();
                // получаем сообщение
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байтов
                byte[] data = new byte[256]; // буфер для получаемых данных

                do
                {
                    bytes = handler.Receive(data);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (handler.Available > 0);

                //Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());
                string str = builder.ToString();

                //******************************\\
                long a = Convert.ToInt64(str);
                Pas = Utility.getRashifr(a, keyS)-1;
                bool state = true;
                string message = state.ToString();


                // отправляем ответ
                data = Encoding.Unicode.GetBytes(message);
                handler.Send(data);
                // закрываем сокет
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

                //state = true;
                
                //listenSocket.Close();
            }
        }

        private void ServerDo2()
        {
            // получаем адреса для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port3);

            // создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // связываем сокет с локальной точкой, по которой будем принимать данные
            listenSocket.Bind(ipPoint);

            // начинаем прослушивание
            listenSocket.Listen(10);//максимальное кол-во подключений

            //Console.WriteLine("Сервер запущен. Ожидание подключений...");
            //bool firstuse = false;
            while (GoJhony)
            {
                Socket handler = listenSocket.Accept();
                // получаем сообщение
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байтов
                byte[] data = new byte[256]; // буфер для получаемых данных

                do
                {
                    bytes = handler.Receive(data);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (handler.Available > 0);

                //Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());
                string str = builder.ToString();

                string[] str_mas = str.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                //******************************\\
                long pas = Convert.ToInt64(str_mas[1]);

                string message;
                if (Utility.simHifr(pas, KEY) % Pas == 0)
                {
                    message = Utility.simHifr(secret, KEY).ToString() +"\r\n"+ Utility.simHifr(Pas*3, KEY).ToString();
                }
                else
                {
                    message = "-1";
                }

                //string message = state.ToString();


                // отправляем ответ
                data = Encoding.Unicode.GetBytes(message);
                handler.Send(data);
                // закрываем сокет
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

                //state = true;
                //firstuse = true;
                //listenSocket.Close();
            }
        }

    }
}
