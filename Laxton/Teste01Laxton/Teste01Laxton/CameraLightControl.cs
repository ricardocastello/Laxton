using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste01Laxton
{
    internal class CameraLightControl
    {
        public class SerialManager
        {
            private SerialPort _serialPort;

            public SerialManager(string portName = "COM3", int baudRate = 9600)
            {
                _serialPort = new SerialPort(portName, baudRate);
                _serialPort.Open();
            }

            public void SendCommand(string command)
            {
                if (_serialPort != null && _serialPort.IsOpen)
                {
                    _serialPort.Write(command);
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
}
