using Microsoft.AspNetCore.SignalR.Client;

namespace ChatMaui
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;
        private string myChatMessage;
        private string chatMessages;

        public MainPage()
        {
            InitializeComponent();
            _connection = new HubConnectionBuilder()
               .WithUrl("http://localhost:5176/chat")
               .Build();

            _connection.On<string>("MessageReceived", (message) =>
            {
                chatMessages += $"{Environment.NewLine}{message}";
            });

            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                await _connection.StartAsync());
            });
        }

        public async void OnClick(object sender, EventArgs e)
        {
            await _connection.InvokeCoreAsync("SendMessage", args: new[] { myChatMessage });

            myChatMessage = String.Empty;
        }

    }
}