using System.Diagnostics;
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

// https://github.com/GarryLed/Winter-Exam-2025  

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // Lists to store event objects 
        private List<Event> events = new List<Event>();
        //private List<Ticket> tickets = new List<Ticket>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // create event objects and add to event list 
            Event event1 = new Event() {Name = "Oasis Croke Park", EventDate = new DateTime(2025, 06, 20) };
            Event event2 = new Event() { Name = "Electric Picnic", EventDate = new DateTime(2025, 08, 20) };
            events.Add(event1);
            events.Add(event2);

            lbxEvents.ItemsSource = events;

            // create ticket objects and add to tickets list 
            Ticket ticket1 = new Ticket("Early Bird",100m,100);
            Ticket ticket2 = new Ticket("Platinium", 150m, 100);
            
            

            
            

   
            // create vip tickets and add to vip tickets list 

            //VIPTicket vipticket1 = new VIPTicket("Ticket and Hotel Package", 150m, 100m, "4 * hotel", 100);
            //VIPTicket vipticket2 = new VIPTicket("Weekend Ticket", 200m, 100m, "with camping", 100);

        }

        private void lbxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // when an event is selected display in the tickets list box  
            if (lbxEvents.SelectedItem is Event selectecdEvent)
            {
                //lbxTickets.ItemsSource = selectecdEvent.Name;

                // display ticket info here 
            }
        }
    }
}