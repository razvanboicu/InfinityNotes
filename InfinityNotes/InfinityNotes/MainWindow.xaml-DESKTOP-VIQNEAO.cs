using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InfinityNotes
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

        private void CommonCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tabControl.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = tabControl.Items.Count - 1;
            tabControl.SelectedIndex = newIndex;
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tabControl.SelectedIndex + 1;
            if (newIndex >= tabControl.Items.Count)
                newIndex = 0;
            tabControl.SelectedIndex = newIndex;
        }

        private void btnSelectedTab_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Selected tab: " + (TabControl.SelectedItem as TabItem).Header);
        }

        private void NewTabContext(object sender, RoutedEventArgs e)
        {
            tabControl.Items.Add(new TabItem()
            {
                Header = "new tab",
                IsSelected = true,
                Content = new TextBox()
                {
                    AcceptsReturn = true,
                    AcceptsTab = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                }
            }); ;
        }

        private void NewTabContext(object sender, RoutedEventArgs e, string fileName, string text)
        {
            tabControl.Items.Add(new TabItem()
            {
                Header = fileName,
                IsSelected = true,
                Content = new TextBox()
                {
                    Text = text,
                    AcceptsReturn = true,
                    AcceptsTab = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                }
            }) ;
        }

        private void SaveContext(object sender, RoutedEventArgs e)
        {
            if ((TabItem)tabControl.SelectedItem != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, ((TextBox)((TabItem)tabControl.SelectedItem).Content).Text);
                ((TabItem)tabControl.SelectedItem).Header = saveFileDialog.FileName.ToString();
            }
        }
        private string findFileName(string source)
        {
            string result;
            int lastIndexOfSlesh = source.LastIndexOf("'\'");
            result = source.Substring(lastIndexOfSlesh, source.Length - lastIndexOfSlesh);
            return result;
        }

        private void OpenContext(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                File.ReadAllText(openFileDialog.FileName);
            NewTabContext(sender, e, findFileName(openFileDialog.FileName.ToString()), File.ReadAllText(openFileDialog.FileName).ToString());
        }
    }
}
