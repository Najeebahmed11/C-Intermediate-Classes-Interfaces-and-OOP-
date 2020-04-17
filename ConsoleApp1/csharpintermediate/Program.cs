using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Channels;

namespace ClassLibrary1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //upcasting:from derived to base class
            //downcasting:from base to drive class
            private void Button_Click(object sender, RoutedEventArgs e)
            {
                var downc = sender as Button;
                if (downc != null)
                {
                    MessageBox.Show(downc.ActualHeight.ToString());


                }

                MessageBox.Show("najeeb");
            }
            Shape shape = new Text();
            Text text = (Text)shape;
            

        }

    }       
}

