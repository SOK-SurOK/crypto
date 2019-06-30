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
    class ServerProverka
    {
        int ID = 2;
        long keyC = 7;
        long keyD = 5;
        int port = 8005; // порт для приема входящих запросов
        int port3 = 8006; // порт сервера
        string address = "127.0.0.1"; // адрес сервера
        //long heh = Utility.getZahifr(7);
        Thread myThread;
        bool GoJhony;

        public void ServerDo()
        {
            GoJhony = true;
            // создаем новый поток
            myThread = new Thread(new ThreadStart(ServerDo0));
            myThread.Start(); // запускаем поток

        }
        public void ServerStop()
        {
            GoJhony = false;
            myThread.Abort();
        }
        private void ServerDo0()
        {
            // получаем адреса для запуска сокета
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

            // создаем сокет
            Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // связываем сокет с локальной точкой, по которой будем принимать данные
            listenSocket.Bind(ipPoint);

            // начинаем прослушивание
            listenSocket.Listen(10);//максимальное кол-во подключений

            //Console.WriteLine("Сервер запущен. Ожидание подключений...");

            while (GoJhony)//постоянно слушаем
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
                //long pas = Convert.ToInt64(str);
                string message;
                long pasw;
                if (isGoodClient(str))
                {
                    pasw = getPassword();
                    message = Utility.getZahifr(pasw+3, keyC).ToString();
                    if(!isSetServer(pasw))
                    {
                        throw new Exception("Что-то не так с сервером даты");
                    }

                }
                else
                {
                    message = "-1";
                }


                


                // отправляем ответ
                data = Encoding.Unicode.GetBytes(message);
                handler.Send(data);
                // закрываем сокет
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }

        }

        private bool isSetServer(long pas)
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port3);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // подключаемся к удаленному хосту
            socket.Connect(ipPoint);

            string message = Utility.getZahifr(pas + 1, keyD).ToString();

            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);//отправляем информацию


            //******************************\\


            // получаем ответ
            data = new byte[256]; // буфер для ответа
            StringBuilder builder = new StringBuilder();
            int bytes = 0; // количество полученных байт

            do
            {
                bytes = socket.Receive(data, data.Length, 0);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (socket.Available > 0);
            string otvet = builder.ToString();
            // закрываем сокет
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();

            bool otv = Convert.ToBoolean(otvet);
            return otv;
        }
        private long getPassword()
        {
            return 13;
        }

        private bool isGoodClient(string log)
        {
            //if(pas == heh)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            if(log == "1\r\n3")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
