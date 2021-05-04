using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExperimentWithControls
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

        private void numberTextBox1_TextChanged(object sender, TextChangedEventArgs e)          // Event handler method for TextBox.
        {
            number.Text = numberTextBox1.Text;                  // This line of code sets the text in the TextBlock so it's the same as the text in the TextBox. And it gets called any time the user changes the text in the TextBox. 
        }

        private void numberTextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)         // Event handler method for TextBox.
        {
            e.Handled = !int.TryParse(e.Text, out int result);      // This event handler method is called when the user enters text into the TextBox, but before the TextBox is updated. If the user entered a number, it sets e.Handeled to true, which tells WPF to ignore the input.
        }

        private void smallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)      // Event handler method for SmallSlider.
        {
            number.Text = smallSlider.Value.ToString("0");          // The method sets the text in the TextBlock so it's the same as the text on the SmallSlider. (The value of the Slider control is a fractional number with a decimal point. This "0" converts it to a whole number).
        }

        private void bigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)        // Event handler method for BigSlider.
        {
            number.Text = bigSlider.Value.ToString("000-000-0000");         // The method sets the text in the TextBlock so it's the same as the text on the BigSlider. (The zeros and hyphens cause the method to format any IO-digit number as a US phone number).
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)      // Event handler method for all the RadioButtons.
        {
            if (sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();       // This line of code sets the text in the TextBlock so it's the same as the text in the RadioButtons. The method gets called whenever the user changes the text in the RadioButtons. 
            }
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)         // Event handler method for the ListBox.
        {
            if (myListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();       // This line of code sets the text in the TextBlock so it's the same as the text in the ListBox. The method gets called whenever the user changes the text in the ListBox. 
            }
        }

        private void readOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)          // Event handler method for the ReadOnly ComboBox. 
        {
            if (readOnlyComboBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();           // This line of code sets the text in the TextBlock so it's the same as the text in the readOnly ComboBox. The method gets called whenever the user changes the text in the readOnly ComboBox. 
            }
        }

        private void editableComboBox_TextChanged(object sender, TextChangedEventArgs e)        // Event handler method for the Editable ComboBox.
        {
            if (sender is ComboBox comboBox)
            {
                number.Text = comboBox.Text;                            // This line of code sets the text in the TextBlock so it's the same as the text in the editable ComboBox. The method gets called whenever the user changes the text in the editable ComboBox. 
            }
        }
    }
}
