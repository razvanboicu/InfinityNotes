using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Font = System.Windows.Media.FontFamily;

namespace InfinityNotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //this.FontFamily = new Font("Arial Rounded MT Bold");
            //this.FontSize = 10;
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
                trvStructure.Items.Add(CreateTreeItem(driveInfo));
        }
        public ObservableCollection<TabItem> tabItemsModel = new ObservableCollection<TabItem>();
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

        private void withButtonNewTab(object sender, RoutedEventArgs e)
        {

            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(new TextBlock()
            {
                Text = "bravo frate"
            });
            stackPanel.Children.Add(new Button()
            {
                Content = new TextBlock()
                {
                    Text = "X"
                }
            });
            tabControl.Items.Add(new TabItem()
            {
                Header = stackPanel,
                IsSelected = true,

                Content = new TextBox()
                {
                    Padding = new Thickness(4),
                    AcceptsReturn = true,
                    AcceptsTab = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto
                }
            });

        }
        private void closeTab(object sender, RoutedEventArgs e)
        {
            tabControl.Items.Remove(((TabItem)tabControl.SelectedItem));
        }
        private void NewTabDefault(object sender, RoutedEventArgs e)
        {
            (this.DataContext as TabItemCollection).Tabs.Add(new TabItemObject() { FilePath = "nimic", FileName = "untitled", ContentFile = "" });
            //StackPanel stackPanel = new StackPanel();
            //stackPanel.Orientation = Orientation.Horizontal;
            //stackPanel.Children.Add(new TextBlock()
            //{
            //    Padding = new Thickness(0, 0, 4, 0),
            //    Text = "untitled"
            //});

            //Image newImage = new Image()
            //{
            //    Width = 12,
            //    Height = 12,
            //    Source = new BitmapImage(new Uri(@"C:\Users\razva\OneDrive - Universitatea Transilvania din Brasov\Desktop\MVP\Tema 1 - InfinityNotes\InfinityNotes\InfinityNotes\Images\close.png")),
            //};

            //newImage.MouseUp += closeTab;
            //stackPanel.Children.Add(newImage);
            
            //tabControl.Items.Add(new TabItem()
            //{
            //    Header = stackPanel,
            //    IsSelected = true,

            //    Content = new TextBox()
            //    {
            //        Padding = new Thickness(4),
            //        AcceptsReturn = true,
            //        AcceptsTab = true,
            //        VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
            //        HorizontalScrollBarVisibility = ScrollBarVisibility.Auto
            //    }
            //});
        }
        private void NewTabTreeView(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(new TextBlock()
            {
                Padding = new Thickness(0, 0, 4, 0),
                Text = ((TreeViewItem)sender).Header.ToString()
            }) ;
            Image newImage = new Image()
            {
                Width = 12,
                Height = 12,
                Source = new BitmapImage(new Uri(@"C:\Users\razva\OneDrive - Universitatea Transilvania din Brasov\Desktop\MVP\Tema 1 - InfinityNotes\InfinityNotes\InfinityNotes\Images\close.png")),
            };

            newImage.MouseUp += closeTab;
            stackPanel.Children.Add(newImage);
            String text = (((TreeViewItem)sender).Tag as FileInfo).FullName;
            tabControl.Items.Add(new TabItem()
            {
                Header = stackPanel,
                IsSelected = true,
                
                Content = new TextBox()
                {
                    //File.ReadAllText(openFileDialog.FileName).ToString(),
                    Text = File.ReadAllText(text),
                    Padding = new Thickness(4),
                    AcceptsReturn = true,
                    AcceptsTab = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                }
            });
        }
        private void NewTabCustom(string fileName, string text)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(new TextBlock()
            {
                Padding = new Thickness(0, 0, 4, 0),
                Text = fileName
            });
            Image newImage = new Image()
            {
                Width = 12,
                Height = 12,
                Source = new BitmapImage(new Uri(@"C:\Users\razva\OneDrive - Universitatea Transilvania din Brasov\Desktop\MVP\Tema 1 - InfinityNotes\InfinityNotes\InfinityNotes\Images\close.png")),
            };

            newImage.MouseUp += closeTab;
            stackPanel.Children.Add(newImage);

            tabControl.Items.Add(new TabItem()
            {
                Header = stackPanel,
                IsSelected = true,

                Content = new TextBox()
                {
                    Text = text,
                    Padding = new Thickness(4),
                    AcceptsReturn = true,
                    AcceptsTab = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                }
            }) ;
        }
        private TreeViewItem CreateTreeItem(object obj)
        {
            TreeViewItem item = new TreeViewItem();
            if (obj is FileInfo)
            {
                item.Header = obj.ToString();
                item.Tag = obj;
                item.MouseDoubleClick += new MouseButtonEventHandler(NewTabTreeView);
            }
            else
            {
                item.Header = obj.ToString();
                item.Tag = obj;
                item.Items.Add("Nothing here...");
            }

            return item;
        }
        public void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            if ((item.Items.Count == 1) && (item.Items[0] is string) && !(item.Tag is FileInfo))
            {
                item.Items.Clear();
                DirectoryInfo expandedDir = null;
                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;
                if (item.Tag is DirectoryInfo)
                    expandedDir = (item.Tag as DirectoryInfo);
                try
                {
                    foreach (DirectoryInfo subDir in expandedDir.GetDirectories())
                    {
                        item.Items.Add(CreateTreeItem(subDir));
                    }
                    foreach (FileInfo file in expandedDir.GetFiles())
                    {
                        item.Items.Add(CreateTreeItem(file));
                    }
                }
                catch { }
            }
        }

        private void SaveAsContext(object sender, RoutedEventArgs e)
        {
            if ((TabItem)tabControl.SelectedItem != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, ((TextBox)((TabItem)tabControl.SelectedItem).Content).Text);
                    ((TabItem)tabControl.SelectedItem).Header = Path.GetFileName(saveFileDialog.FileName);
                }
            }
        }

        private void OpenContext(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                File.ReadAllText(openFileDialog.FileName);
                NewTabCustom(Path.GetFileName(openFileDialog.FileName), File.ReadAllText(openFileDialog.FileName).ToString());
            }

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ((TabItemCollection)DataContext).Tabs.Remove(((TabItem)tabControl.SelectedItem).DataContext as TabItemObject);
           // tabControl.Items.Remove(((TabItem)tabControl.SelectedItem));
        }
    }
}
