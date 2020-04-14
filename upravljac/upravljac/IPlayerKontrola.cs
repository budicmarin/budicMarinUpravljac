using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljac
{
    public interface IPlayerKontrola
    {
        void Play();
        void Pause();
        void Stop();
        void Forward();
        void Backward();
        
    }
}
