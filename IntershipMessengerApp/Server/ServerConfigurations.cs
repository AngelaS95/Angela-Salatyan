namespace Server
{
    public class ServerConfigurations
    {

        public int Port { get; set; }
        public int MaxClients { get; set; }

        public ServerConfigurations()
        {
            this.Port = 1300;
            this.MaxClients = 10;
        }
    }
}