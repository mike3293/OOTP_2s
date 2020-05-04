using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfCustomControlLibrary1
{
    /// <summary>
    /// Логика взаимодействия для ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl, INotifyPropertyChanged
    {
        public ColorPicker()
        {
            InitializeComponent();
        }

        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;
        public static readonly RoutedEvent ColorChangedEvent;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        static ColorPicker()
        {

            // Регистрация свойств зависимости
            ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(ColorPicker),
                new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));

            RedProperty = DependencyProperty.Register("Red", typeof(byte), typeof(ColorPicker),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            GreenProperty = DependencyProperty.Register("Green", typeof(byte), typeof(ColorPicker),
                new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged)));
            FrameworkPropertyMetadata meta = new FrameworkPropertyMetadata(new PropertyChangedCallback(OnColorRGBChanged))
            {
                CoerceValueCallback = new CoerceValueCallback(CorrectValue)
            };
            BlueProperty = DependencyProperty.Register("Blue", typeof(byte), typeof(ColorPicker),
                meta, new ValidateValueCallback(ValidateValue));
            ColorChangedEvent = EventManager.RegisterRoutedEvent("ColorChanged", RoutingStrategy.Bubble,
typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorPicker));

        }

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set { SetValue(ColorProperty, value); CodeColor = Color.ToString(); }
        }
        public byte Red
        {
            get => (byte)GetValue(RedProperty);
            set => SetValue(RedProperty, value);
        }
        public byte Green
        {
            get => (byte)GetValue(GreenProperty);
            set => SetValue(GreenProperty, value);
        }
        public byte Blue
        {
            get => (byte)GetValue(BlueProperty);
            set => SetValue(BlueProperty, value);
        }

        private string _code = "CODE";
        public string CodeColor
        {
            get => _code;
            set { _code = value; NotifyPropertyChanged(""); }
        }

        public static void OnColorRGBChanged(DependencyObject sender,
            DependencyPropertyChangedEventArgs e)
        {
            ColorPicker ColorPicker = (ColorPicker)sender;
            Color color = ColorPicker.Color;
            if (e.Property == RedProperty)
            {
                color.R = (byte)e.NewValue;
            }
            else if (e.Property == GreenProperty)
            {
                color.G = (byte)e.NewValue;
            }
            else if (e.Property == BlueProperty)
            {
                color.B = (byte)e.NewValue;
            }

            ColorPicker.Color = color;
        }
        private static void OnColorChanged(DependencyObject sender,
      DependencyPropertyChangedEventArgs e)
        {
            Color newColor = (Color)e.NewValue;
            ColorPicker ColorPicker = (ColorPicker)sender;
            ColorPicker.Red = newColor.R;
            ColorPicker.Green = newColor.G;
            ColorPicker.Blue = newColor.B;
        }

        public event RoutedPropertyChangedEventHandler<Color> ColorChanged
        {
            add { this.AddHandler(routedEvent: ColorChangedEvent, value); }
            remove { this.RemoveHandler(ColorChangedEvent, value); }
        }

        private static bool ValidateValue(object value)
        {
            byte currentValue = (byte)value;
            if (currentValue >= 0 && currentValue <= 255)
            {
                return true;
            }

            return false;
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            byte currentValue = (byte)baseValue;
            if (currentValue > 255)
            {
                return 255;
            }

            return currentValue;
        }
    }
}
