using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO.Packaging;
using System.IO;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Media;

namespace InfinityNotes
{
    internal class Replace
    {
        static public TabItem ReplaceSpecificTab(TabItem source, string oldText, string newText)
        {
            TextBox newTextBox = new TextBox()
            {
                Text = (((TextBox)(source.Content)).Text.Replace(oldText, newText)),
                Padding = new Thickness(4),
                AcceptsReturn = true,
                AcceptsTab = true,
                VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                HorizontalScrollBarVisibility = ScrollBarVisibility.Auto
            };

           // newTextBox.TextChanged += MainWindow.TextBox_TextChanged;
            source.Content = newTextBox;
            newTextBox.TextChanged += TextBox_TextChanged;
            (source.Content as TextBox).TextChanged += TextBox_TextChanged;
            //Console.WriteLine(source.Content.ToString());
            return source;
        }

        private static void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        static private TabItem TextBox_TextChanged(TabItem source)
        {
                if (((TextBlock)((StackPanel)(source.Header)).Children[0]).Tag.ToString() != (source.Content as TextBox).Text.ToString())
                    ((((StackPanel)(source.Header)).Children[0]) as TextBlock).Foreground = new SolidColorBrush(Colors.Red);
                else
                ((((StackPanel)(source.Header)).Children[0]) as TextBlock).Foreground = new SolidColorBrush(Colors.Green);
            return source;
        }
        static public List<TabItem> ReplaceThroughTabs(List<TabItem> source, string oldText, string newText)
        {
            for (int i = 0; i < source.Count; i++)
            {
                TextBox newTextBox = new TextBox()
                {
                    Text = (((TextBox)(source[i].Content)).Text.Replace(oldText, newText)),
                    Padding = new Thickness(4),
                    AcceptsReturn = true,
                    AcceptsTab = true,
                    VerticalScrollBarVisibility = ScrollBarVisibility.Auto,
                    HorizontalScrollBarVisibility = ScrollBarVisibility.Auto
                };
                source[i].Content = newTextBox;
            }
            return source;
        }
    }
}
