using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectrOcher.Models
{
    public static class TalonQueue
    {
        public static Queue<Talon> talonsList = new Queue<Talon>();
        
        public static void EnqueueTalon(Talon talon) {
            talonsList.Enqueue(talon);
        }

        public static Talon  DequeueTalon() {
            return talonsList.Dequeue();
        }

        public static Talon PeekTalon() {
            return talonsList.Peek();
        }

        public static int GetTalonLength() {
            return talonsList.Count();
        }
    }
}
