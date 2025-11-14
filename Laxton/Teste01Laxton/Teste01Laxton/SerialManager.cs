using System;
using System.IO.Ports;

namespace Teste01Laxton
{
    public class SerialManager
    {
        private SerialPort _serialPort;

        public event Action<string> OnDataReceived; // evento para repassar resposta

        public SerialManager(string portName = "COM4", int baudRate = 115200)
        {
            _serialPort = new SerialPort(portName, baudRate);
            _serialPort.DataReceived += SerialPort_DataReceived;
            _serialPort.Open();
        }

        public void SendCommand(string command)
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Write(command);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _serialPort.ReadExisting(); 
                OnDataReceived?.Invoke(data); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro na leitura: " + ex.Message);
            }
        }

        public void Close()
        {
            if (_serialPort != null && _serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }
    }
}