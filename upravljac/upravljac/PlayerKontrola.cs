using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljac
{
    class PlayerKontrola : IPlayerKontrola
    {
  

        public void Play()
        {
             
            
            MessageBox.Show("Aj spod mi Raklja selaaaa " + "\nTar na naj");
           
        }
        public void Pause()
        {
            MessageBox.Show("  Štutim   ");
        }
        public void Stop()
        {
            MessageBox.Show("Stop");
        }
        public void Forward()
        {
            MessageBox.Show("Zaspaj Pave");
        }
        public void Backward()
        {
            MessageBox.Show("Aj švikni Marko da te gora čuje");
        }
    }
}
