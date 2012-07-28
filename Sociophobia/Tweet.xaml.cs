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

namespace Sociophobia
{
    /// <summary>
    /// Interaction logic for Tweet.xaml
    /// </summary>
    public partial class Tweet : UserControl
    {
        private string m_username;
        private string m_tweet;

        public Tweet(String username, String tweet)
        {
            m_username = username;
            m_tweet = tweet;
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            uxUsernameText.Content = m_username;
            uxTweetText.Content = m_tweet;
        }
    }
}
