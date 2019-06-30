using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Crypto_Net
{
    class Client1
    {
        // адрес и порт сервера, к которому будем подключаться
        int ID = 1;
        long KEY = 17;
        long keyS = 7;
        long Pas;
        int port = 8005; // порт сервера
        int port2 = 8007; // порт сервера
        string address = "127.0.0.1"; // адрес сервера
        public long ClientDo()
        {
            //.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // подключаемся к удаленному хосту
            socket.Connect(ipPoint);
            //Console.Write("Введите сообщение:");
            //string message = Console.ReadLine();

            //string message = Utility.getZahifr(pas).ToString();
            string message = ID+"\r\n"+3;

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
            //Console.WriteLine("ответ сервера: " + builder.ToString());

            // закрываем сокет
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();

            long otv = Convert.ToInt64(otvet);
            if(otv == -1)
            {
                throw new Exception("неправильная аутентификация");
            }
            else
            {
                return M2(Utility.getRashifr(otv, keyS)-3);
            }

           // Console.Read();
        }


        private long M2(long pas)
        {
            Pas = pas;
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port2);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // подключаемся к удаленному хосту
            socket.Connect(ipPoint);

            string message = Utility.simHifr(pas, KEY).ToString() + "\r\n"+ Utility.simHifr(pas*2, KEY).ToString();

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

            //long otv = Convert.ToInt64(otvet);
            if (otvet == "-1")
            {
                throw new Exception("Что то пошло не так на последнем этапе");
            }
            else
            {
                string[] str_mas = otvet.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (Utility.simHifr(Convert.ToInt64(str_mas[1]), KEY) % Pas ==0)
                {
                    long otv = Convert.ToInt64(str_mas[0]);
                    return Utility.simHifr(otv, KEY);
                }
                else
                {
                    throw new Exception("Сигнатуры сервера не совподают");
                }
            }
        }

       

    }
}
