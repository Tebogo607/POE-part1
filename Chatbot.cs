using System;
using System.Media;
using System.IO;
using System.Threading;

namespace CybersecurityChatbot
{


    class Chatbot
    {

        public string Name;
        public string UserName;
        public Random RandomGenerator;

        public Chatbot()
        {
            Name = "Generic Chatbot";
            RandomGenerator = new Random();
            Console.Title = "Cybersecurity Chatbot";
        }
        public virtual void Start()
        {

            Console.WriteLine("Chatbot is starting...");
            Console.ResetColor();

            //method for the sound
            PlayGreeting();
           // ShowLogo();
           // AskForName();
        }
        public void PlayGreeting()
        {
            try
            {
                if (File.Exists("greeting.wav"))
                {
                    SoundPlayer player = new SoundPlayer("greeting.wav");
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("(Welcome greeting would play here)");
                    Console.Beep(440, 500);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("(Voice greeting not available)");
            }
        }
    }

}

