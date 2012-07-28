using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Twitterizer;
using Twitterizer.Core;
using Twitterizer.Entities;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Sociophobia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var mentionCollection = new MentionCollection();
            Stream stream = File.Open("Tweets.sociophobia", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            Type[] mentionTypes = { typeof(Mention) };
            
            for (int i = 0; i < 5; i++)
            {
                Mention mention = new Mention("K0HAX", "This is a test! " + i.ToString());
                Tweet tweet = new Tweet(mention);
                uxStackPanel.Children.Insert(0, tweet);
                tweet.Visibility = Visibility.Visible;
                mentionCollection.Mentions.Add(mention);
            }
            var xformatter = new XmlSerializer(typeof(MentionCollection));
            xformatter.Serialize(stream, mentionCollection);
            //bformatter.Serialize(stream, mentionCollection);
            stream.Close();
        }
    }
}
