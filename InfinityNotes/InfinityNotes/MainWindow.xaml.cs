using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace InfinityNotes
{
    public partial class MainWindow : Window
    {
        private static ObservableCollection<TabItem> tabItemsOpened = new ObservableCollection<TabItem>();
        private static int IndexOfLastTabSelected = -1;
        public MainWindow()
        {
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
        private void closeTab(object sender, RoutedEventArgs e)
        {
            SolidColorBrush b = ((TextBlock)((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]).Foreground as SolidColorBrush;
            if (b != null)
                if ((((TextBlock)((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]).Text.ToString() == "untitled"
                    && (((TabItem)tabControl.SelectedItem).Content as TextBox).Text.ToString().Length > 0)
                    || (b.Color != null && b.Color == Colors.Red && (((TabItem)tabControl.SelectedItem).Content as TextBox).Text.ToString().Length > 0))
                {
                    Console.WriteLine("Not saved");
                    SaveAsContext(sender, e);
                }
                else
                {
                    tabControl.Items.Remove(((TabItem)tabControl.SelectedItem));
                    tabItemsOpened.Remove((TabItem)tabControl.SelectedItem);
                }

        }
        private void AddTabFromTreeView(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(((TreeViewItem)sender).Header.ToString());
            //MessageBox.Show((((TreeViewItem)sender).Tag as FileInfo).FullName);
            TabItem newTab = new TabItem();
            //newTab.((((TreeViewItem)sender).Tag as FileInfo).FullName);
            newTab.Header = ((TreeViewItem)sender).Header.ToString();
            TextBox textBox = new TextBox();
            textBox.AcceptsReturn = true;

            textBox.AcceptsTab = true;
            newTab.Content = textBox;
            newTab.IsSelected = true;
            tabControl.Items.Add(newTab);
            tabItemsOpened.Add(newTab);
            //e.CanExecute = true;
        }
        static public ObservableCollection<TabItem> GetOpenedTabs()
        {
            return MainWindow.tabItemsOpened;
        }
        private void NewTabTreeItem(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(new TextBlock()
            {
                Padding = new Thickness(0, 0, 4, 0),
                Text = ((TreeViewItem)sender).Header.ToString(),
                Foreground = new SolidColorBrush(Colors.Green),
                Tag = File.ReadAllText((((TreeViewItem)sender).Tag as FileInfo).FullName)
            }) ;

            Image newImage = new Image()
            {
                Width = 12,
                Height = 12,
                Source = new BitmapImage(new Uri(@"C:\Users\razva\OneDrive - Universitatea Transilvania din Brasov\Desktop\MVP\Tema 1 - InfinityNotes\InfinityNotes\InfinityNotes\Images\close.png")),
            };

            newImage.MouseUp += closeTab;
            stackPanel.Children.Add(newImage);

            TextBox newTextBox = new TextBox()
            {
                Text = File.ReadAllText((((TreeViewItem)sender).Tag as FileInfo).FullName),
                Padding = new Thickness(4),
                AcceptsReturn = true,
                AcceptsTab = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
            };
            newTextBox.TextChanged += TextBox_TextChanged;
            TabItem newTabItem = new TabItem()
            {
                Header = stackPanel,
                IsSelected = true,
            };
            newTabItem.Content = newTextBox; 

            tabControl.Items.Add(newTabItem);
            tabItemsOpened.Add(newTabItem);

        }
        private void NewTabDefault(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(new TextBlock()
            {
                Padding = new Thickness(0, 0, 4, 0),
                Text = "untitled",
                Foreground = new SolidColorBrush(Colors.Red),
                Tag=""
            });

            Image newImage = new Image()
            {
                Width = 12,
                Height = 12,
                Source = new BitmapImage(new Uri(@"C:\Users\razva\OneDrive - Universitatea Transilvania din Brasov\Desktop\MVP\Tema 1 - InfinityNotes\InfinityNotes\InfinityNotes\Images\close.png")),
            };

            newImage.MouseUp += closeTab;
            stackPanel.Children.Add(newImage);

            TextBox newTextBox = new TextBox()
            {
                Padding = new Thickness(4),
                AcceptsReturn = true,
                AcceptsTab = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                Tag = ""
            };

            newTextBox.TextChanged += TextBox_TextChanged;
            TabItem newTabItem = new TabItem()
            {
                Header = stackPanel,
                IsSelected = true,
            };
            
            newTabItem.Content = newTextBox;

            tabControl.Items.Add(newTabItem);
            tabItemsOpened.Add(newTabItem);
        }
        private string TextBox_TextChangedUtil()
        {
            string oldTextBoxString = (((TabItem)tabControl.SelectedItem).Content as TextBox).Text.ToString();
            return oldTextBoxString;
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if((TabItem)tabControl.SelectedItem != null && ((TextBlock)((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]).Tag.ToString() != "")
            if(((TextBlock)((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]).Tag.ToString() != ((TextBox)(((TabItem)tabControl.SelectedItem).Content)).Text.ToString())
                ((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]) as TextBlock).Foreground = new SolidColorBrush(Colors.Red);
            else
                ((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]) as TextBlock).Foreground = new SolidColorBrush(Colors.Green);
        }
        static public int GetLastTabItemIndex()
        {
            for (int i = 0; i < tabItemsOpened.Count; i++)
            {
                if (tabItemsOpened[i].IsSelected)
                {
                    IndexOfLastTabSelected = i;
                    break;
                }
            }
            return IndexOfLastTabSelected;
        }
        private void FindReplaceContext(object sender, RoutedEventArgs e)
        {
            DeselectAllFiles();
            FindReplace findReplaceWindow = new FindReplace();
            findReplaceWindow.Show();
            if (FindReplace.replaceAllChecked)
            {
                if (FindReplace.GetResponseReplaceThroughTabs() != null)
                    tabItemsOpened = FindReplace.GetResponseReplaceThroughTabs();
            }
            else
            {
                if (FindReplace.GetResponseReplaceSpecificTab() != null)
                    tabItemsOpened[IndexOfLastTabSelected] = FindReplace.GetResponseReplaceSpecificTab();
            }

            if (FindReplace.findAllChecked)
            {
                if (FindReplace.GetResponseFindThroughTabs() != null)
                    tabItemsOpened = FindReplace.GetResponseFindThroughTabs();
            }
            else
            {
                if(FindReplace.GetResponseFindSpecificTab() != null)
                    tabItemsOpened[IndexOfLastTabSelected] = FindReplace.GetResponseFindSpecificTab();
            }

        }
        private void DeselectAllFiles()
        {
            for(int i = 0; i < tabItemsOpened.Count; i++)
            {
                (tabItemsOpened[i].Content as TextBox).Select(0, 0);
            }
        }
        private void NewTabCustom(string fileName, string text, string path)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Orientation = Orientation.Horizontal;
            stackPanel.Children.Add(new TextBlock()
            {
                Padding = new Thickness(0, 0, 4, 0),
                Text = fileName,
                Foreground = new SolidColorBrush(Colors.Green),
                Tag = text //this is for red/green
            });
            Image newImage = new Image()
            {
                Width = 12,
                Height = 12,
                Source = new BitmapImage(new Uri(@"C:\Users\razva\OneDrive - Universitatea Transilvania din Brasov\Desktop\MVP\Tema 1 - InfinityNotes\InfinityNotes\InfinityNotes\Images\close.png")),
            };

            newImage.MouseUp += closeTab;
            stackPanel.Children.Add(newImage);


            TextBox newTextBox = new TextBox()
            {
                Text = text,
                Padding = new Thickness(4),
                AcceptsReturn = true,
                AcceptsTab = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto,
                Tag = path
            };

            newTextBox.TextChanged += TextBox_TextChanged;

            TabItem newTabItem = new TabItem()
            {
                Header = stackPanel,
                IsSelected = true,
            };
            newTabItem.Content = newTextBox;

            tabControl.Items.Add(newTabItem);
            tabItemsOpened.Add(newTabItem);
        }
        private TreeViewItem CreateTreeItem(object obj)
        {
            TreeViewItem item = new TreeViewItem();
            if (obj is FileInfo)
            {
                item.Header = obj.ToString();
                item.Tag = obj;
                item.MouseDoubleClick += new MouseButtonEventHandler(NewTabTreeItem);
            }
            else
            {
                item.Header = obj.ToString();
                item.Tag = obj;
                item.Items.Add("--Nothing here--");
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
                catch
                {
                    //momentan nimic
                }
            }
        }
        private void SaveContext(object sender, RoutedEventArgs e)
        {
            if ((TabItem)tabControl.SelectedItem != null)
                if ((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0] as TextBlock).Text == "untitled"
                    && (((TabItem)tabControl.SelectedItem).Content as TextBox).Text.ToString().Length > 0)
                {
                    SaveAsContext(sender, e);
                }
                else
                {
                    if((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0] as TextBlock).Text.ToString() != "untitled")
                    {
                        var path = ((((TabItem)tabControl.SelectedItem).Content) as TextBox).Tag;
                        File.WriteAllText((string)path, ((TextBox)((TabItem)tabControl.SelectedItem).Content).Text);
                        ((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]) as TextBlock).Foreground = new SolidColorBrush(Colors.Green);
                    }
                    
                }
        }
        private void SaveAsContext(object sender, RoutedEventArgs e)
        {
            if ((TabItem)tabControl.SelectedItem != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "txt files (*.txt)|*.txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, ((TextBox)((TabItem)tabControl.SelectedItem).Content).Text);
                    ((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]) as TextBlock).Text = Path.GetFileName(saveFileDialog.FileName);
                    ((((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]) as TextBlock).Foreground = new SolidColorBrush(Colors.Green);
                    ((TextBlock)((StackPanel)((TabItem)tabControl.SelectedItem).Header).Children[0]).Tag = ((TextBox)((TabItem)tabControl.SelectedItem).Content).Text.ToString();
                }
            }
        }
        private void OpenContext(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Multiselect = true;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == true)
            {
                File.ReadAllText(openFileDialog.FileName);
                NewTabCustom(Path.GetFileName(openFileDialog.FileName), File.ReadAllText(openFileDialog.FileName).ToString(), openFileDialog.FileName);
            }
        }
        private void AboutMe(object sender, RoutedEventArgs e)
        {
            About aboutWindow = new About();
            aboutWindow.Show();
        }
    }
};
