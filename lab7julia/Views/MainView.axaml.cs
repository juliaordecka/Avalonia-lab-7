using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab7julia.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }
    public void ButtonClicked(object source, RoutedEventArgs args)
    {

        List<string> parts = new List<string>();
        List<int> amount = new List<int>();
        string result = "Wynik: \n";

        for (int i = 0; i <= sekwencja.Text.Length - 4; i++)
        {
            parts.Add(sekwencja.Text.Substring(i, 4));
            amount.Add(1);
        }
        for (int i = 0; i < parts.Count; i++)
        {
            for (int j = i + 1; j < parts.Count; j++)
            {
                if (parts[i] == parts[j])
                {
                    amount[i]++;
                    parts.RemoveAt(j);
                    amount.RemoveAt(j);
                    j--;
                }
            }
        }

        for (int i = 0; i < parts.Count; i++)
        {
            result += parts[i];
            result += " - ";
            result += amount[i].ToString();
            result += "\n";
        }
        wynik.Text = result;
    }
}