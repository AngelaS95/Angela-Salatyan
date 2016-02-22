using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntershipMessengerClient;

namespace IntershipMessengerServer
{
    public class Messages
    {
        long _messageId;
        String _message;
        DateTime _timestamp;
        int _clientId;

        public Messages()
        {
            _message = string.Empty;
        }

        public byte[] GetBytes()
        {
            var messageBytes = Encoding.UTF8.GetBytes(_message);

            var result = new byte[sizeof(long) + sizeof(long) + sizeof(int) + messageBytes.Length];

            _timestamp.ToBinary();

            var messageIdBytes = BitConverter.GetBytes(_messageId);
            var timestampBytes = BitConverter.GetBytes(_timestamp.ToBinary());
            var messageBytes = BitConverter.GetBytes(_message);
            var clientIdBytes= BitConverter.GetBytes(_clientId);

            var result = new byte[
                messageIdBytes.Length +
                timestampBytes.Length +
                messageBytes.Length +
                clientIdBytes.Length];

            Array.Copy(messageIdBytes, 0, result, 0, messageIdBytes.Length);
            Array.Copy(timestampBytes, 0, result, messageIdBytes.Length, timestampBytes.Length);
            Array.Copy(clientIdBytes, 0, result, messageIdBytes.Length+timestampBytes.Length, clientIdBytes.Length);
            Array.Copy(messageBytes, 0, result, messageIdBytes.Length + timestampBytes.Length+clientIdBytes.Length, messageBytes.Length);

            return result;

        }
        public long ByteToLong()
        {

        }

        /*
        byte[] LongToByte(long t)
        {
            byte[] result = new byte[8];
            result[7] = Convert.ToByte(t & 255);
            result[6] = Convert.ToByte((t>>8)&255);
        }
        */
        /*
        User sender { get; set; }
        string messageText { get; set; }
        DateTime timeStump { get; set; }
        */
    }
}
