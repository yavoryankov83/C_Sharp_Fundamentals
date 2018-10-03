using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Messages
{
    class Messages
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, User>();

            var input = Console.ReadLine();

            string sender;
            string recipient;

            while (input != "exit")
            {
                var tokens = input
                    .Split(' ');
                if (tokens[0] == "register")
                {
                    var username = tokens[1];
                    users.Add(username, new User(username));
                }
                else
                {
                    var senderUsername = tokens[0];
                    var recipientUsername = tokens[2];
                    var content = tokens[3];

                    if (users.ContainsKey(senderUsername)
                    && users.ContainsKey(recipientUsername))
                    {
                        User senderUser = users[senderUsername];
                        users[recipientUsername].ReceivedMessages.Add(new Message(content, senderUser));
                    }
                }

                input = Console.ReadLine();
            }

            var chatTokens = Console.ReadLine().Split(' ');
            sender = chatTokens[0];
            recipient = chatTokens[1];

            var senderMassages = users[recipient].ReceivedMessages
                .Where(m => m.Sender.Username == sender)
                .ToList();

            var recipientMassages = users[sender].ReceivedMessages
                .Where(m => m.Sender.Username == recipient)
                .ToList();

            if (senderMassages.Count == 0 && recipientMassages.Count == 0)
            {
                Console.WriteLine("No messages");
            }
            var index = 0;

            while (index < senderMassages.Count
                && index < recipientMassages.Count)
            {
                Console.WriteLine($"{sender}: {senderMassages[index].Content}");
                Console.WriteLine($"{recipientMassages[index].Content} :{recipient}");

                index++;    
            }

            while (index < senderMassages.Count)
            {
                Console.WriteLine($"{sender}: {senderMassages[index].Content}");

                index++;
            }
            while (index < recipientMassages.Count)
            {
                Console.WriteLine($"{recipientMassages[index].Content} :{recipient}");

                index++;
            }
        }
    }
    class User
    {
        public string Username { get; set; }
        public List<Message> ReceivedMessages { get; set; }

        public User(string username)
        {
            this.Username = username;
            this.ReceivedMessages = new List <Message>();
        }
    }
    class Message
    {
        public string Content { get; set; }
        public User Sender { get; set; }

        public Message(string content, User sender)
        {
            this.Content = content;
            this.Sender = sender;
        }
    }
}
